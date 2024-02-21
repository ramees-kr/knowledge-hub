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
    public partial class UserDashboard : Form
    {
        private Library library;
        private Patron currentPatron;
        public UserDashboard(Library library, Patron patron)
        {
            this.library = library;
            this.currentPatron = patron;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
        }
    }
}
