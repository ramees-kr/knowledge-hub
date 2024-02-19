using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knowlegde_hub
{
    public partial class Login : Form
    {
        int LoginMode;
        public Login(int mode)
        {
            LoginMode = mode;
            InitializeComponent();

        }

        //Display error message if either username or password is empty
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter username and password");
            }
            else
            {
                // Check if the username and password are correct
                if (LoginMode == 0 && Authenticate())
                {
                    // Hide the current form
                    this.Hide();

                    // Create an instance of the AdminDashboard form
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                }
                else
                {
                     MessageBox.Show("Invalid username or password");
                }

                if (LoginMode == 1 && Authenticate())
                {
                    // Hide the current form
                    this.Hide();

                    // Create an instance of the UserDashboard form
                    UserDashboard userDashboard = new UserDashboard();
                    userDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }


            }
        }

        //Check if the username and password are correct
        private bool Authenticate()
        {
            // Check if the username and password are correct
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                return true;
            }
            else if (txtUserName.Text == "user" && txtPassword.Text == "user")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
