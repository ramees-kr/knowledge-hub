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
    public partial class AddPatronForm : Form
    {
        public AddPatronForm()
        {
            InitializeComponent();
        }

        // Check if username is available
        private bool CheckUsernameAvailability(string username)
        {
            return Library.Instance.Users.All(u => u.Username != username);
        }

        // Check if passwords match
        private bool VerifyPasswordMatch(string password1, string password2)
        {
            return password1 == password2;
        }

        // Validate email address
        private bool ValidateEmailAddress(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // Validate phone number
        private bool ValidatePhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }

        //method to clear all textboxes
        private void ClearTextBoxes()
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword1.Text = "";
            txtPassword2.Text = "";
            textEmail.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnAddPatron_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password1 = txtPassword1.Text.Trim();
            string password2 = txtPassword2.Text.Trim();
            string email = textEmail.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            // Perform validations
            // 
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            if (!CheckUsernameAvailability(username))
            {
                MessageBox.Show("Username already exists. Please choose another.");
                return;
            }

            if (!VerifyPasswordMatch(password1, password2))
            {
                MessageBox.Show("Passwords do not match. Please re-enter.");
                return;
            }

            if (!ValidateEmailAddress(email))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email.");
                return;
            }

            if (!ValidatePhoneNumber(phoneNumber))
            {
                MessageBox.Show("Invalid phone number. Please enter a valid 10-digit phone number.");
                return;
            }


            // Register user if all validations pass
            try
            {
                User newUser = Library.Instance.RegisterUser(username, password1, null, email, phoneNumber, true);


                MessageBox.Show("New Patron Saved!");
                MessageBox.Show("Your user ID is: " + newUser.Id);
                ClearTextBoxes();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
