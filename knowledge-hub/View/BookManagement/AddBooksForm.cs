using knowledge_hub.Repositories.Interfaces;
using knowledge_hub.ViewModel;

namespace knowledge_hub
{
    public partial class AddBooksForm : Form
    {
        private readonly AddBookViewModel _viewModel;

        // Constructor with IBookRepository dependency injection
        public AddBooksForm(IBookRepository bookRepository)
        {
            InitializeComponent();
            _viewModel = new AddBookViewModel(bookRepository);
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


                // Call the AddBook method from the view model
                await _viewModel.AddBook(isbn, title, author, publisher, yearPublished);

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
