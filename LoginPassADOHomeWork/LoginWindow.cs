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
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM [User] AS U WHERE U.Username = @username AND U.Password = [Password]";
                    SqlCommand insertQuery = new SqlCommand(query, connection);

                    insertQuery.Parameters.AddWithValue("@username", username);
                    insertQuery.Parameters.AddWithValue("@password", password);

                    insertQuery.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }

        }
    }
}
