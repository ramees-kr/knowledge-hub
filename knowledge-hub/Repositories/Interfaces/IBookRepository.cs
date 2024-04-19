using knowledge_hub.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.Repositories.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByISBNAsync(string isbn);
        Task AddBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(string isbn);
        Task<int> GetBooksCountAsync();
        Task<List<Book>> SearchBooksAsync(string attribute, string searchText);
    }
}
