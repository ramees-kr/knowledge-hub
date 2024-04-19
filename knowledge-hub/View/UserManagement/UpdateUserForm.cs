using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories.Interfaces;
using knowledge_hub.ViewModel;
using System.Security.Policy;

namespace knowledge_hub
{
    public partial class UpdateUserForm : Form
    {
        private readonly UpdateUserViewModel _viewModel;
        private User _selectedUser;

        // Constructor with IUserRepository dependency injection
        public UpdateUserForm(IUserRepository bookRepository, User selectedUser)
        {
            InitializeComponent();
            _viewModel = new UpdateUserViewModel(bookRepository);
            _selectedUser = selectedUser;

            // Call a method to bind the form fields to the view model properties
            BindFormFields();
        }

        // Bind the form fields to the view model properties
        private void BindFormFields()
        {
            if (_selectedUser != null)
            {
                textBoxName.Text = _selectedUser.Name;
                textBoxPassword.Text = _selectedUser.Password;
                textBoxContactDetails.Text = _selectedUser.ContactDetails;
                textBoxUsername.Text = _selectedUser.Username;
                comboBoxUserType.Text = _selectedUser.UserType;
            }
            else
            {
                // For example, clear the text boxes or display a message to the user
                textBoxName.Text = "";
                textBoxPassword.Text = "";
                textBoxContactDetails.Text = "";
                textBoxUsername.Text = "";
                comboBoxUserType.Text = "";
            }
        }
        //Clear all textboxes
        private void ClearTextBoxes()
        {
            textBoxName.Text = "";
            textBoxPassword.Text = "";
            textBoxPassword2.Text = "";
            textBoxContactDetails.Text = "";
            textBoxUsername.Text = "";
            comboBoxUserType.Text = "";
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
                string userType = comboBoxUserType.Text;

                // Check if the passwords match
                if (password != password2)
                {
                    throw new Exception("Passwords do not match");
                }

                //update values for selected user in view model
                _selectedUser.Name = name;
                _selectedUser.Password = password;
                _selectedUser.ContactDetails = contactDetails;
                _selectedUser.Username = username;
                _selectedUser.UserType = userType;

                //Call UpdateUser method from the view model
                await _viewModel.UpdateUserAsync(_selectedUser);

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
