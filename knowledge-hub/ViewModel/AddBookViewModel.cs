using knowledge_hub.Data;
using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.ViewModel
{
    public class AddBookViewModel
    {
        private readonly IBookRepository _bookRepository;

        public AddBookViewModel(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // Method to add a new book
        public async Task AddBook(string isbn, string title, string author, string publisher, int yearPublished)
        {
            // Create a new book object
            var book = new Book
            {
                Isbn = isbn,
                Title = title,
                Author = author,
                Publisher = publisher,
                YearOfPublication = yearPublished
            };

        // Add the book to the database
        await _bookRepository.AddBookAsync(book);
        }
    }
}
