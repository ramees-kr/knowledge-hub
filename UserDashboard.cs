using knowledge_hub;
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
    public partial class UserDashboard : Form
    {
        private Patron currentPatron;
        public UserDashboard() 
        {
            InitializeComponent();

            // Access the current user directly from Library singleton
            var currentUser = Library.Instance.CurrentUser;

            if (currentUser == null || !(currentUser is Patron))
            {
                // Handle the case where no user is logged in or the user is not a Patron
                MessageBox.Show("No patron is currently logged in.");
                this.Hide();
                var login = new Login();
                login.Show();
                return;
            }
            this.currentPatron = (Patron)currentUser;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void searchBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //UserBookSearch searchBooks = new UserBookSearch(this.currentPatron);
            //searchBooks.Show();
        }
    }
}
