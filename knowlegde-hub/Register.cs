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
    public partial class Register : Form
    {
        private Library library;
        public Register(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // validate the user input
            if (string.IsNullOrEmpty(txtEmail.Text)|| string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                // Display an error message
                MessageBox.Show("All fields are Mandatory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                // Display an error message
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Create a new patron
                Patron newPatron = new Patron(txtUsername.Text, txtEmail.Text, txtPassword.Text);

                // Add the patron to the library
                library.AddPatron(newPatron);

                // Display a success message
                MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide the current form
                this.Hide();

                // Create an instance of the Welcome form
                Welcome welcome = new Welcome();

                // Show the Welcome form
                welcome.Show();
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
