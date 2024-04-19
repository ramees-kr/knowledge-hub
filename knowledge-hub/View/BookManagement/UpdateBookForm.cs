using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories.Interfaces;
using knowledge_hub.ViewModel;

namespace knowledge_hub
{
    public partial class UpdateBookForm : Form
    {
        private readonly UpdateBookViewModel _viewModel;
        private Book _selectedBook;

        // Constructor with IBookRepository dependency injection
        public UpdateBookForm(IBookRepository bookRepository, Book selectedBook)
        {
            InitializeComponent();
            _viewModel = new UpdateBookViewModel(bookRepository);
            _selectedBook = selectedBook;

            // Call a method to bind the form fields to the view model properties
            BindFormFields();
        }

        // Method to bind the form fields to the view model properties
        private void BindFormFields()
        {
            if (_selectedBook != null)
            {
                textBoxISBN.Text = _selectedBook.Isbn;
                textBoxTitle.Text = _selectedBook.Title;
                textBoxAuthor.Text = _selectedBook.Author;
                textBoxPublisher.Text = _selectedBook.Publisher;
                textBoxYearPublished.Text = _selectedBook.YearOfPublication.ToString();
            }
            else
            {
                // For example, clear the text boxes or display a message to the user
                textBoxISBN.Text = "";
                textBoxTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxPublisher.Text = "";
                textBoxYearPublished.Text = "";
            }
        }


        //Clear all textboxes
        private void ClearTextBoxes()
        {
            textBoxISBN.Text = "";
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            textBoxPublisher.Text = "";
            textBoxYearPublished.Text = "";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Form validation with proper exception handling
            try
            {
                var isbn = textBoxISBN.Text;
                var title = textBoxTitle.Text;
                var author = textBoxAuthor.Text;
                var publisher = textBoxPublisher.Text;
                var yearPublished = int.Parse(textBoxYearPublished.Text);

                //update values for selected book in view model
                _selectedBook.Isbn = isbn;
                _selectedBook.Title = title;
                _selectedBook.Author = author;
                _selectedBook.Publisher = publisher;
                _selectedBook.YearOfPublication = yearPublished;

                // Call the UpdateBookAsync method from the view model to update the book
                await _viewModel.UpdateBookAsync(_selectedBook);

                MessageBox.Show("Book added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
