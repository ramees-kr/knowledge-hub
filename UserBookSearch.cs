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
    public partial class UserBookSearch : Form
    {
        private Library library;
        private Patron currentPatron;

        public UserBookSearch(Library library, Patron currentPatron)
        {
            InitializeComponent();
            this.library = library;
            this.currentPatron = currentPatron;

            //MessageBox.Show("UserBookSearch form created");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search button clicked");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
            //unhide the user dashboard
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
        }
    }
}
