using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories.Interfaces;
using knowledge_hub.ViewModel;

namespace knowledge_hub
{
    public partial class AdminDashboard : Form
    {
        private readonly AdminDashboardViewModel _viewModel;

        public AdminDashboard(IBookRepository bookRepository, IUserRepository userRepository, IFineRepository fineRepository, ITransactionRepository transactionRepository)
        {
            InitializeComponent();
            _viewModel = new AdminDashboardViewModel(bookRepository, userRepository, fineRepository, transactionRepository);

            // Subscribe to the Load event of the form
            this.Load += AdminDashboard_Load;
        }

        private async void AdminDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDataAsync()
        {
            //load count of books
            var booksCount = await _viewModel.BookRepository.GetBooksCountAsync();
            textBoxBooksCount.Text = booksCount.ToString();

            //load count of patrons
            var patronsCount = await _viewModel.UserRepository.GetUsersCountAsync();
            textBoxPatronsCount.Text = patronsCount.ToString();

            //load count of checked out books
            var checkedOutCount = await _viewModel.TransactionRepository.GetTransactionsCountAsync("CheckedOut");
            textBoxCheckedOutCount.Text = checkedOutCount.ToString();


            // Load all unpaid fines
            var unpaidFines = await _viewModel.FineRepository.GetTotalUnpaidFinesAsync();
            textBoxFines.Text = unpaidFines.ToString();


            // Load all books 
            var books = await _viewModel.BookRepository.GetAllBooksAsync();
            dataGridViewBooks.DataSource = books;

            // Load all users
            var users = await _viewModel.UserRepository.GetAllUsersAsync();
            dataGridViewPatrons.DataSource = users;

            // Load all transactions
            var transactions = await _viewModel.TransactionRepository.GetAllTransactionsAsync();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the AddBooksForm
            AddBooksForm addBooksForm = new AddBooksForm(_viewModel.BookRepository);
            addBooksForm.FormClosed += FormClosed;
            addBooksForm.ShowDialog();
        }

        private void updateBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSelectedBook();
            //MessageBox.Show(_viewModel.selectedBook.Title);


            // Show the UpdateBooksForm
            UpdateBookForm updateBooksForm = new UpdateBookForm(_viewModel.BookRepository, _viewModel.selectedBook);
            updateBooksForm.FormClosed += FormClosed;
            updateBooksForm.ShowDialog();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Delete the selected book
            SetSelectedBook();

            _viewModel.DeleteBook(_viewModel.selectedBook);

            MessageBox.Show("Book deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Invoke the LoadDataAsync method to refresh the data grid view
            LoadDataAsync();
        }

        private void addPatronsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the AddUserForm
            AddUserForm addUserForm = new AddUserForm(_viewModel.UserRepository);
            addUserForm.FormClosed += FormClosed;
            addUserForm.ShowDialog();
        }
        private void editPatronsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSelectedUser();

            // Show the UpdateUserForm
            UpdateUserForm updateUserForm = new UpdateUserForm(_viewModel.UserRepository, _viewModel.selectedUser);
            updateUserForm.FormClosed += FormClosed;
            updateUserForm.ShowDialog();
        }
        private void deletePatronsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Delete the selected user
            SetSelectedUser();

            _viewModel.DeleteUser(_viewModel.selectedUser);

            MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Invoke the LoadDataAsync method to refresh the data grid view
            LoadDataAsync();

        }


        private async void FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetSelectedBook()
        {
            if (dataGridViewBooks.CurrentRow != null)
            {
                //get the id of the selected book from data grid view and return the book object
                string id = dataGridViewBooks.CurrentRow.Cells[0].Value.ToString();
                //MessageBox.Show(id);    
                _viewModel.SetSelectedBook(id);
            }
        }

        private void SetSelectedUser()
        {
            if (dataGridViewPatrons.CurrentRow != null)
            {
                //get the id of the selected user from data grid view and return the user object
                int id = (int)dataGridViewPatrons.CurrentRow.Cells[0].Value;

                _viewModel.SetSelectedUser(id);
            }
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooks.CurrentRow != null)
            {
                SetSelectedBook();
            }
            else
            {
                MessageBox.Show("No book selected");
            }
        }

        private void dataGridViewPatrons_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBooks.CurrentRow != null)
            {
                SetSelectedUser();
            }
            else
            {
                MessageBox.Show("No book selected");
            }
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set selected Book
            SetSelectedBook();

            //Display the selected book

            _viewModel.ViewBookDetails();

        }

        private void viewPatronsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set selected User
            SetSelectedUser();

            //Display the selected user
            _viewModel.ViewUserDetails();
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set selected User
            SetSelectedUser();

            //Display the selected user
            _viewModel.ViewUserDetails();
        }


        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                // Retrieve selected filter type and attribute
                string filterType = comboBoxFilterType.SelectedItem.ToString();
                string filterAttribute = comboBoxFilterAttribute.SelectedItem.ToString();
                string searchText = textBoxSearch.Text;

                // Perform search operation
                if (filterType == "Books")
                {
                    var searchResults = await _viewModel.BookRepository.SearchBooksAsync(filterAttribute, searchText);
                    dataGridViewBooks.DataSource = searchResults;
                }
                else if (filterType == "Users")
                {
                    var searchResults = await _viewModel.UserRepository.SearchUsersAsync(filterAttribute, searchText);
                    dataGridViewPatrons.DataSource = searchResults;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search operation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected filter type
            string selectedFilterType = comboBoxFilterType.SelectedItem.ToString();

            // Clear the current items in comboBoxFilterAttribute
            comboBoxFilterAttribute.Items.Clear();

            // Populate comboBoxFilterAttribute based on the selected filter type
            if (selectedFilterType == "Books")
            {
                // Add items corresponding to book attributes
                comboBoxFilterAttribute.Items.AddRange(new string[] { "Title", "Author", "Publisher", "YearOfPublication" });
            }
            else if (selectedFilterType == "Users")
            {
                // Add items corresponding to user attributes
                comboBoxFilterAttribute.Items.AddRange(new string[] { "Username", "UserType" });
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the Help Information in a MessageBox
            MessageBox.Show("This is the Admin Dashboard. You can view, add, update, and delete books and patrons from here.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}