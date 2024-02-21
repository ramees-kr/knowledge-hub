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
    public partial class UserLogin : Form
    {
        private Library library;
        public UserLogin(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        // Method to authenticate the user
        private void Authenticate()
        {
            // Get the username and password from the textboxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                // Display an error message
                MessageBox.Show("Please enter a username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (username == "user" && password == "user")
            {
                // Check if the username and password are correct
 
                // Hide the current form
                this.Hide();

                Patron loggedInUser = new Patron(username);

                // Create an instance of the UserDashboard form
                UserDashboard userDashboard = new UserDashboard(library, loggedInUser);

                // Show the UserDashboard form
                userDashboard.Show();
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
        }
    }
}
