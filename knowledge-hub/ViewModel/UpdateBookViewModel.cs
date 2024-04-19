using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.ViewModel
{
    public class UpdateBookViewModel
    {
        private readonly IBookRepository _bookRepository;

        public UpdateBookViewModel(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task UpdateBookAsync(Book selectedBook)
        {
            // Call the UpdateBookAsync method from the repository to update the book
            await _bookRepository.UpdateBookAsync(selectedBook);
        }
    }
}
