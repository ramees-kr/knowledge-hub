using knowlegde_hub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knowledge_hub
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //validate user input
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    throw new Exception("Username and password are required.");
                }
                else
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;


                    var user = User.Login(username, password);

                    if (user is Patron)
                    {
                        Library.Instance.SetCurrentUser(user);
                        Hide();
                        var userDashboard = new UserDashboard();
                        userDashboard.Show();
                    }
                    else if (user is Librarian)
                    {
                        Library.Instance.SetCurrentUser(user);
                        Hide();
                        var adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                    }
                    else
                    {
                        throw new Exception("Invalid user type.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var registration = new Register();
            registration.Show();
        }
    }
}
