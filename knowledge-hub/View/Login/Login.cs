using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories;
using knowledge_hub.Repositories.Interfaces;
using knowledge_hub.ViewModel;

namespace knowledge_hub
{
    public partial class Login : Form
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly IBookRepository _bookRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFineRepository _fineRepository;
        private readonly ITransactionRepository _transactionRepository;

        public Login(LoginViewModel loginViewModel, IBookRepository bookRepository, IUserRepository userRepository, IFineRepository fineRepository, ITransactionRepository transactionRepository)
        {
            InitializeComponent();
            _loginViewModel = loginViewModel;
            _bookRepository = bookRepository;
            _userRepository = userRepository;
            _fineRepository = fineRepository;
            _transactionRepository = transactionRepository;
        }

        /*
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
         */

        private int loginAttempts = 0;

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = await _loginViewModel.AuthenticateAsync(username, password);

            if (user != null)
            {
                // Redirect to appropriate dashboard based on UserType
                if (user.UserType == "Librarian")
                {
                    AdminDashboard adminDashboard = new AdminDashboard(_bookRepository, _userRepository, _fineRepository, _transactionRepository);
                    adminDashboard.Show();
                }
                else if (user.UserType == "Patron")
                {
                    //UserDashboard userDashboard = new UserDashboard(/* pass required dependencies */);
                    //userDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Close the login form
                this.Hide();
            }
            else
            {
                loginAttempts++;
                if (loginAttempts >= 3)
                {
                    MessageBox.Show("Too many incorrect login attempts. Closing application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

 

            private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUserForm registerUserForm = new RegisterUserForm(_userRepository);
            registerUserForm.ShowDialog();
        }
    }
}
