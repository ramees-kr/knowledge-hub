using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knowlegde_hub
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the UserLogin form
            UserLogin userLogin = new UserLogin();

            // Show the UserLogin form
            userLogin.Show();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
           // Hide the current form
            this.Hide();

            // Create an instance of the AdminLogin form
            AdminLogin adminLogin = new AdminLogin();

            // Show the AdminLogin form
            adminLogin.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the Register form
            Register register = new Register();

            // Show the Register form
            register.Show();
        }
    }
}
