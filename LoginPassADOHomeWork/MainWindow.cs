using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPassADOHomeWork
{
    public partial class MainWindow : Form
    {
        string _username;
        string _password;
        string connectionString;

        public MainWindow()
        {
            InitializeComponent();

        }

        public MainWindow(string username, string password)
            : this()
        {
            _username = username;
            _password = password;
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("AppConfig.json");
            var config = builder.Build();
            connectionString = config.GetConnectionString("DefaultConnection")!;

            using (SqlConnection connection = new(connectionString))
            {
                SqlDataReader? reader = null;

                string query = "SELECT * FROM [User] AS U WHERE U.Username = @username AND U.Password = @password";
                SqlCommand cmd = new(query, connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usernameTextBox.Text = reader.GetString("Username");
                    passwordTextBox.Text = reader.GetString("Password");
                    emailTextBox.Text = reader.GetString("EMail");
                }
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var window = new LoginWindow();

            window.Show();

            Hide();
        }
    }
}
