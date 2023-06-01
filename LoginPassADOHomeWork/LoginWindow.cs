using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace LoginPassADOHomeWork
{
    public partial class LoginWindow : Form
    {
        string connectionString;

        public LoginWindow()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("AppConfig.json");
            var config = builder.Build();
            connectionString = config.GetConnectionString("DefaultConnection")!;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            var window = new RegisterWindow();

            window.Show();

            Hide();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM [User] AS U WHERE U.Username = @username AND U.Password = @password";
                SqlCommand insertQuery = new SqlCommand(query, connection);

                insertQuery.Parameters.AddWithValue("@username", username);
                insertQuery.Parameters.AddWithValue("@password", password);

                int count = (int)insertQuery.ExecuteScalar();

                if (count > 0)
                {
                    var window = new MainWindow(username, password);
                    window.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Username and password combination does not exist.");
                    usernameTextBox.Text = string.Empty;
                    passwordTextBox.Text = string.Empty; 
                }

            }


        }
    }
}
