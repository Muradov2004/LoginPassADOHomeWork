using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPassADOHomeWork
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            var window = new RegisterWindow();

            window.Show();

            this.Hide();
        }
    }
}
