using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace LoginPassADOHomeWork
{
    public partial class RegisterWindow : Form
    {

        string connectionString;

        public RegisterWindow()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("AppConfig.json");
            var config = builder.Build();
            connectionString = config.GetConnectionString("DefaultConnection")!;

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty && emailTextBox.Text != string.Empty)
            {

                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO [User] (Username, [Password], EMail) VALUES(@username, @password, @email)";
                        SqlCommand insertQuery = new SqlCommand(query, connection);

                        insertQuery.Parameters.AddWithValue("@username", username);
                        insertQuery.Parameters.AddWithValue("@password", password);
                        insertQuery.Parameters.AddWithValue("@email", email);

                        insertQuery.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    usernameTextBox.Text = string.Empty;
                    passwordTextBox.Text = string.Empty;
                    emailTextBox.Text = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Write all options");
                usernameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;
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
