using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace followcoin
{
    public partial class AddToken : Form
    {
        private string idvalue;
        private string namevalue;
        private string price;


        public AddToken(string idvalue, string namevalue, string price)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AddToken_Load);
            this.idvalue = idvalue;
            this.namevalue = namevalue;
             this.price = price;

            double double_price = Convert.ToDouble(price);
            price_box.Text = $"{double_price:F3}";
            token_name.Text = namevalue;

        }
        private void AddToken_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=C:\Users\ardas\source\repos\followcoin\followcoin\coindb.db";
            int id = Convert.ToInt32(idvalue);
            coin_amount.Text = "denmee";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // ID'yi kontrol et
                string checkid = "SELECT COUNT(1) FROM portfolio WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(checkid, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // ID bulunduysa, Amount değerini al
                        string getAmountQuery = "SELECT Amount FROM portfolio WHERE Id = @Id";
                        using (SQLiteCommand getAmountCommand = new SQLiteCommand(getAmountQuery, connection))
                        {
                            getAmountCommand.Parameters.AddWithValue("@Id", id);
                            object result = getAmountCommand.ExecuteScalar();

                            if (result != DBNull.Value)
                            {
                                double amount = Convert.ToDouble(result);
                                coin_amount.Text = $"{amount} {namevalue}";  // coin_amount Label'ına Amount değeri yazılıyor
                            }

                        }
                    }
                    else
                    {
                        coin_amount.Text = "0";
                    }

                }
            }
        }

        private void buy_button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=C:\Users\ardas\source\repos\followcoin\followcoin\coindb.db";
            int id = Convert.ToInt32(idvalue);
            double token_price = Convert.ToDouble(price);

            string amount_changed = amount_box.Text.Replace('.', ',');
            double amount = Convert.ToDouble(amount_changed);

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string checkid = "SELECT COUNT(1) FROM portfolio WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(checkid, connection))
                {

                    command.Parameters.AddWithValue("@Id", idvalue);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        double amount_old = 0;

                        // SQLiteCommand nesnesiyle veritabanından Amount değerini alıyoruz
                        using (SQLiteCommand takeamount = new SQLiteCommand("SELECT Amount FROM portfolio WHERE Id=@Id", connection))
                        {
                            takeamount.Parameters.AddWithValue("@Id", idvalue);

                            // ExecuteScalar() ile değeri alıyoruz
                            amount_old = Convert.ToDouble(takeamount.ExecuteScalar());
                        }

                        // Yeni miktarı hesaplıyoruz
                        double last_amount = amount + amount_old;
                        string updatetoken = "UPDATE portfolio SET Amount = @NewAmount WHERE Id = @Id";
                        using (SQLiteCommand updateCommand = new SQLiteCommand(updatetoken, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@NewAmount", last_amount);
                            updateCommand.Parameters.AddWithValue("@Id", idvalue);
                            updateCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Token Başarıyla Güncellendi");
                        ApplicationForm app = new ApplicationForm();
                        app.portofolio_button();
                    }
                    else
                    {
                        string addtokennew = "INSERT INTO portfolio (Id, Name, AveragePrice, Amount,LastPrice)" +
                            "VALUES (@id, @namevalue,@token_price,@amount,@lastprice)";
                        MessageBox.Show("id değeri bulunamadı");
                        using (SQLiteCommand insertCommand = new SQLiteCommand(addtokennew, connection))
                        {
                            // Parametrelerin atanması
                            insertCommand.Parameters.AddWithValue("@id", id);
                            insertCommand.Parameters.AddWithValue("@namevalue", namevalue);
                            insertCommand.Parameters.AddWithValue("@token_price", token_price);
                            insertCommand.Parameters.AddWithValue("@amount", amount);
                            insertCommand.Parameters.AddWithValue("@lastprice", token_price);
                            int rowsAffected = insertCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Token başarıyla eklendi.");
                                ApplicationForm app = new ApplicationForm();
                                app.portofolio_button();
                            }
                            else
                            {
                                MessageBox.Show("Token eklenirken bir hata oluştu.");
                            }
                        }
                    }

                }

            }
        }

        private void sell_button_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=C:\Users\ardas\source\repos\followcoin\followcoin\coindb.db";
            double token_price = Convert.ToDouble(price);

            string amount_changed = amount_box.Text.Replace('.', ',');
            double amount_input = Convert.ToDouble(amount_changed);

            using (SQLiteConnection connection = new SQLiteConnection(connectionstring))
            {
                connection.Open();
                string checkid = "SELECT COUNT(1) FROM portfolio WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(checkid, connection))
                {
                    command.Parameters.AddWithValue("@Id", idvalue);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        double coin_amount = 0;
                        using(SQLiteCommand take_amount = new SQLiteCommand("SELECT Amount from portfolio WHERE Id=@Id",connection))
                        {
                            take_amount.Parameters.AddWithValue("@Id", idvalue);
                            coin_amount = Convert.ToDouble(take_amount.ExecuteScalar());
                        }
                        if (coin_amount - amount_input < 0)
                            MessageBox.Show("Cüzdanınız negatif olamaz!! ");
                        else if(coin_amount - amount_input > 0)
                        {
                            double last_amount = coin_amount-amount_input;
                            string sell_coin = "UPDATE portfolio SET Amount = @last_amount WHERE Id=@Id";
                            using (SQLiteCommand sell_token = new SQLiteCommand(sell_coin, connection))
                            {
                                sell_token.Parameters.AddWithValue("@Id", idvalue);
                                sell_token.Parameters.AddWithValue("@last_amount", last_amount);
                                sell_token.ExecuteNonQuery();
                            }
                            MessageBox.Show("Token Başarıyla Güncellendi");
                        }
                        else if(coin_amount - amount_input == 0)
                        {
                            string delete_token = "DELETE from portfolio WHERE Id=@Id";
                            using (SQLiteCommand delete = new SQLiteCommand(delete_token, connection))
                            {
                                delete.Parameters.AddWithValue("@Id", idvalue);
                                delete.ExecuteNonQuery() ;
                            }
                            MessageBox.Show("Token başarıyla güncellendi ve silindi");
                        }

                    }
                }
            }
        }
    }
}
