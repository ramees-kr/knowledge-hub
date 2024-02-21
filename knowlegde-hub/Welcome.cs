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
        // Create an instance of the Library class and load data
        private static Library library;

        public Welcome()
        {
            InitializeComponent();

            // Initialize the library instance if it's null (first time)
            if (library == null)
            {
                library = loadDataIntoLibrary();
            }
        }

        public Welcome(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the UserLogin form
            UserLogin userLogin = new UserLogin(library);

            // Show the UserLogin form
            userLogin.Show();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
           // Hide the current form
            this.Hide();

            // Create an instance of the AdminLogin form
            AdminLogin adminLogin = new AdminLogin(library);

            // Show the AdminLogin form
            adminLogin.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Create an instance of the Register form
            Register register = new Register(library);

            // Show the Register form
            register.Show();
        }

        private Library loadDataIntoLibrary()
        {
            //Load data in to the library for testing
            Library library = new Library();

            library.AddBook(new Book(1, "The Catcher in the Rye", "J.D", "Fiction", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(2, "To Kill a Mocking", "Harper Lee", "Fiction", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(3, "1984", "George Orwell", "Dystopian", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(4, "The Lord of the Rings", "J.R.R. Tolkien", "Fantasy", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(5, "Pride and Prejudice", "Jane Austen", "Classic", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(6, "The Book Thief", "Markus Zusak", "Historical Fiction", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(7, "The Hobbit", "J.R.R. Tolkien", "Fantasy", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(8, "The Great Gatsby", "F. Scott Fitzgerald", "Classic", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(9, "The Diary of a Young", "Anne Frank", "Biography", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(10, "The Little Prince", "Antoine de Saint-Exupéry", "Children's Literature", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(11, "The Hunger Games", "Suzanne Collins", "Science Fiction", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(12, "The Hitchhiker's Guide to the Galaxy", "Douglas Adams", "Science Fiction", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(13, "The Fault in Our Stars", "John Green", "Young Adult", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(14, "The Giver", "Lois Lowry", "Dystopian", "Available", DateTime.Now + TimeSpan.FromDays(7)));
            library.AddBook(new Book(15, "The Alchemist", "Paulo Coelho", "Fiction", "Available", DateTime.Now + TimeSpan.FromDays(7)));

            //Create a librarian
            Librarian librarian = new Librarian { LibrarianID = 1, Name = "Dexter" };
            library.Librarians.Add(librarian);

            // Create a patron
            Patron patron = new Patron("User");
            library.Patrons.Add(patron);

            return library;
        }
    }
}
