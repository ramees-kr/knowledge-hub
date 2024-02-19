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
            Login userLogin = new Login(1);

            // Show the UserLogin form
            userLogin.Show();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
           // Hide the current form
            this.Hide();

            // Create an instance of the AdminLogin form
            Login adminLogin = new Login(0);

            // Show the AdminLogin form
            adminLogin.Show();

        }
    }
}
