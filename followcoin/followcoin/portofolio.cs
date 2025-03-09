using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace followcoin
{
    public partial class portofolio : Form
    {
        private System.Windows.Forms.ToolTip toolTip;

        public portofolio()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.portofolio_Load);

            toolTip = new System.Windows.Forms.ToolTip(); 
        }

        private void portofolio_chart_Click(object sender, EventArgs e)
        {

        }
        private void portofolio_Load(object sender, EventArgs e)
        {
            List<Coin> mylist = new List<Coin>();
            string connectionString = @"Data Source=C:\Users\ardas\source\repos\followcoin\followcoin\coindb.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Name, LastPrice, Amount FROM portfolio";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double myvalue = Math.Round(Convert.ToDouble(reader["Amount"]) * Convert.ToDouble(reader["LastPrice"]), 2);
                            mylist.Add(new Coin
                            {
                                Name = reader["Name"].ToString(),
                                Value = myvalue

                            });
                        }
                    }
                }


                BindToPieChart(mylist);
                
            }
        }
        private void BindToPieChart(List<Coin> mylist)
        {
            // Pasta grafik için seri oluşturma
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Coin")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut,
                IsValueShownAsLabel = true
            };
            double totalworth = 0;
            // Listeyi grafiğe ekle
            foreach (var coin in mylist)
            {
                totalworth = totalworth + coin.Value;
                series.Points.AddXY(coin.Name, coin.Value);
            }

            // Chart temizle ve seriyi ekle
            portofolio_chart.Series.Clear();
            portofolio_chart.Series.Add(series);
            total_worth.Text = $"Value: ${totalworth:F2}";

            // Başlık ekleme
            portofolio_chart.Titles.Clear();
            portofolio_chart.Titles.Add("Portföy Dağılımı");

            portofolio_chart.GetToolTipText += PortofolioChart_GetToolTipText;
            
        }

        private void PortofolioChart_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                // Veri serisini al
                var series = e.HitTestResult.Series;

                // Veri noktasını al
                var point = series.Points[e.HitTestResult.PointIndex];

                // Serideki toplam değeri hesapla
                double totalValue = series.Points.Sum(p => p.YValues[0]);

                // Dilimin yüzdesini hesapla
                double percentage = (point.YValues[0] / totalValue) * 100;

                // ToolTip metni
                e.Text = $"Coin: {point.AxisLabel}\nValue: {point.YValues[0]:F2}\nPercentage: {percentage:F2}%";
            }
        }
        

    }

    public class Coin
    {
        public string Name { get; set; }
        public double Value { get; set; }
    }

}
