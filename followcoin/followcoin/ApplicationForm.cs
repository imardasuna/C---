using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static followcoin.ApplicationForm;

namespace followcoin
{
    public partial class ApplicationForm : Form
    {
        public static string API_KEY = "WRİTE-HERE YOUR API FOR COINMARKETCAP";

        public ApplicationForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Load += new EventHandler(ApplicationForm_Load);

        }
        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            // Butona otomatik tıklama (örneğin fetch_coin)
            fetch_coin.PerformClick();
        }
        private void portofolio_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm is portofolio)
                {
                    // Eğer daha önce açılmışsa, kapat
                    childForm.Close();
                    break;
                }
            }
            portofolio form = new portofolio();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(616, 130);

            form.Show();
        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuDataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen ilk satır
                DataGridViewRow selectedRow = bunifuDataGridView1.SelectedRows[0];

                // Satırdaki verileri al
                string id = selectedRow.Cells["id"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                string price = selectedRow.Cells["Price"].Value.ToString();

                AddToken addtoken = new AddToken(id, name, price);
                addtoken.Show();
                // Verileri göstermek için MessageBox
                //MessageBox.Show($"ID: {id}\nName: {name}\nPrice: {price}");
            }
            else
            {
                MessageBox.Show("Hiçbir satır seçilmedi.");
            }
        }

        private async void fetch_coin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=C:\Users\ardas\source\repos\followcoin\followcoin\coindb.db";

            try
            {
                string jsonResponse = await MakeApiCallAsync();
                List<Coin> coins = ParseCoins(jsonResponse);
                var sortedCoins = coins.OrderByDescending(coin => coin.MarketCap).ToList();


                List<int> ids = GetAllIds();

                foreach (Coin coin in coins)
                {
                    if (ids.Contains(coin.id))
                    {
                        string query = "UPDATE portfolio SET LastPrice = @LastPrice WHERE Id = @Id";
                        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                        {
                            connection.Open();
                            using (SQLiteCommand command = new SQLiteCommand(query, connection))
                            {
                                // Parametreleri bağlayın
                                command.Parameters.AddWithValue("@LastPrice", coin.Price);
                                command.Parameters.AddWithValue("@Id", coin.id);

                                // Sorguyu çalıştırın
                                command.ExecuteNonQuery();
                            }

                        }
                    }

                }
                bunifuDataGridView1.DataSource = sortedCoins;
                bunifuDataGridView1.Columns["id"].Visible = false;      // id sütununu gizle
                bunifuDataGridView1.Columns["Quote"].Visible = false; // Bunifu DataGridView'e veri bağlama
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static List<int> GetAllIds()
        {
            string connectionString = @"Data Source=C:\Users\ardas\source\repos\followcoin\followcoin\coindb.db";
            List<int> ids = new List<int>();
            string query = "SELECT Id FROM portfolio";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                try
                {

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ids.Add(reader.GetInt32(0)); // Sütun indexi 0
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }

            return ids;
        }
        private static async Task<string> MakeApiCallAsync()
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);

            queryString["start"] = "1";
            queryString["limit"] = "150";
            queryString["convert"] = "USD";


            URL.Query = queryString.ToString();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", API_KEY);
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                HttpResponseMessage response = await client.GetAsync(URL.ToString());
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
        }
        private static List<Coin> ParseCoins(string jsonResponse)
        {
            // JSON yanıtını nesnelere dönüştürme
            var response = JsonConvert.DeserializeObject<CoinMarketCapResponse>(jsonResponse);
            return response.Data;
        }
        public class CoinMarketCapResponse
        {
            [JsonProperty("data")]
            public List<Coin> Data { get; set; }
        }
        public class QuoteData
        {
            [JsonProperty("USD")]
            public UsdData USD { get; set; }
        }
        public class UsdData
        {
            [JsonProperty("price")]
            public decimal? Price { get; set; }

            [JsonProperty("market_cap")]
            public decimal? MarketCap { get; set; }
        }
        public class my_coin
        {
            public int id { get; set; }
            public QuoteData Quote { get; set; }

            public decimal? Price => Quote?.USD?.Price;
        }
        public class Coin
        {
            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("cmc_rank")]
            public int CmcRank { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("symbol")]
            public string Symbol { get; set; }

            [JsonProperty("quote")]
            public QuoteData Quote { get; set; }

            public decimal? Price => Quote?.USD?.Price;
            public decimal? MarketCap => Quote?.USD?.MarketCap;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string searchValue = searchbox.Text;
            bunifuDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && 
                            row.Cells[i].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            int rowIndex = row.Index;
                            bunifuDataGridView1.Rows[rowIndex].Selected = true;
                            bunifuDataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + searchbox.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public void portofolio_button()
        {
            portofolio_Click(this, EventArgs.Empty);
        }
        private void bunifuButton1_TextChanged(object sender, EventArgs e)
        {
            // Search butonunun click olayını tetikle
            bunifuButton1.PerformClick();
        }
    }
}
