using knowledge_hub;
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

namespace knowlegde_hub
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            // Access the Library instance directly through the singleton
            Library library = Library.Instance;

            // Access the current user directly from Library
            var currentUser = library.CurrentUser;

            if (currentUser == null || !(currentUser is Librarian))
            {
                // Handle the case where no user is logged in or the user is not a Librarian
                MessageBox.Show("No librarian is currently logged in.");
                // You might want to redirect to the login form or take appropriate action
                this.Hide();
                var login = new Login();
                login.Show();
                return;
            }

            // Get total number of books in the library and load in textBoxBooksCount
            textBoxBooksCount.Text = Library.Instance.GetTotalBooks().ToString();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

    }

}