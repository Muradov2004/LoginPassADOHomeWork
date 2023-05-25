using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LoginPassADOHomeWork
{
    public partial class RegisterWindow : Form
    {

        SqlConnection connection = null;
        string connectionString;

        public RegisterWindow()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("AppConfig.json");
            var config = builder.Build();
            connectionString = config.GetConnectionString("DefaultConnection")!;

            connection = new SqlConnection(connectionString);
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty && emailTextBox.Text != string.Empty)
            {
                using (SqlConnection connection = new(connectionString))
                {
                    string username = "";
                    SqlParameter parameter = new SqlParameter();
                    string insertQuery = @"INSERT INTO [User] (Username, [Password], EMail) VALUES(@username, @password, @email)";

                    SqlCommand insertCommand = new();
                    insertCommand.Connection = connection;
                    insertCommand.CommandText = insertQuery;

                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
