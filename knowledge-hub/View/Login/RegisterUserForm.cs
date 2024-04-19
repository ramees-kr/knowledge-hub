using knowledge_hub.Repositories.Interfaces;
using knowledge_hub.ViewModel;

namespace knowledge_hub
{
    public partial class RegisterUserForm : Form
    {
        private readonly AddUserViewModel _viewModel;

        // Constructor with IUserRepository dependency injection
        public RegisterUserForm(IUserRepository bookRepository)
        {
            InitializeComponent();
            _viewModel = new AddUserViewModel(bookRepository);

        }

        //Clear all textboxes
        private void ClearTextBoxes()
        {
            textBoxName.Text = "";
            textBoxPassword.Text = "";
            textBoxPassword2.Text = "";
            textBoxContactDetails.Text = "";
            textBoxUsername.Text = "";
        }

        /*
         *         
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private TextBox textBoxContactDetails;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword2;
        private ComboBox comboBoxUserType;
         */

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Form validation with proper exception handling
            try
            {
                // Get the values from the textboxes
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                string password2 = textBoxPassword2.Text;
                string name = textBoxName.Text;
                string contactDetails = textBoxContactDetails.Text;
                string userType = "Patron";

                // Call the AddUser method from the view model
                await _viewModel.AddUser(username, password, password2, name, contactDetails, userType);

                MessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();

        }
    }
}
