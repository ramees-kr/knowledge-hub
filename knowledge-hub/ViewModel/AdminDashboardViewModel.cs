using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.ViewModel
{
    internal class AdminDashboardViewModel
    {
        public IBookRepository BookRepository { get; }
        public IUserRepository UserRepository { get; }
        public ITransactionRepository TransactionRepository { get; }
        public IFineRepository FineRepository { get; }
        public Book selectedBook { get; internal set; }
        public User selectedUser { get; internal set; }

        public AdminDashboardViewModel(IBookRepository bookRepository, IUserRepository userRepository, IFineRepository fineRepository, ITransactionRepository transactionRepository)
        {
            BookRepository = bookRepository;
            UserRepository = userRepository;
            FineRepository = fineRepository;
            TransactionRepository = transactionRepository;
            
            selectedBook = new Book();
            selectedUser = new User();
        }

        //set selected  book to the book selected by the user using id
        public async void SetSelectedBook(string isbn)
        {
            selectedBook = await BookRepository.GetBookByISBNAsync(isbn);
            //MessageBox.Show(" Inside Dashboard Model" + selectedBook.Title);
        }

        //set selected user to the user selected by the admin using id
        public async void SetSelectedUser(int id)
        {
            selectedUser = await UserRepository.GetUserByIdAsync(id);
        }

        public void LoadBooksAsync()
        {
            var books = BookRepository.GetAllBooksAsync();
        }


        internal void DeleteBook(Book selectedBook)
        {
            //delete the selected book
            BookRepository.DeleteBookAsync(selectedBook.Isbn);
        }

        internal void ViewBookDetails()
        {
            if (selectedBook != null)
            {
                MessageBox.Show(selectedBook.ToString());
            }
            else
            {
                MessageBox.Show("No book selected");
            }
        }

        internal void DeleteUser(User selectedUser)
        {
            //delete the selected user
            UserRepository.DeleteUserAsync(selectedUser.UserId);
        }

        internal void ViewUserDetails()
        {
            if(selectedUser != null)
            {
                MessageBox.Show(selectedUser.ToString());
            }
            else
            {
                MessageBox.Show("No user selected");
            }
        }
    }
}
