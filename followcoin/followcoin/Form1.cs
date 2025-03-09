using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Data.SQLite;

namespace followcoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password_box.PasswordChar = '*';
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string password = GenerateSHA256Hash(password_box.Text);
            string username = username_box.Text;

            string connectionString = @"Data Source=C:\Users\ardas\source\repos\followcoin\followcoin\coindb.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM users WHERE name = @name AND password = @password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.Parameters.AddWithValue("@password", password); // Þifrelerin hashlenmiþ olmasý önerilir.

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();
                        ApplicationForm application = new ApplicationForm();
                        application.Show();

                        // Login formunu gizle veya kapat (opsiyonel)

                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }

            }
        }
        
        static string GenerateSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Converts to hexadecimal
                }
                return sb.ToString();
            }
        }
    }
}

