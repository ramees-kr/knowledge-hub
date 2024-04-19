using knowledge_hub.Data;
using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibDbContext _dbContext;

        public BookRepository(LibDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Book> GetBookByISBNAsync(string isbn)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(b => b.Isbn == isbn);
        }

        public async Task AddBookAsync(Book book)
        {
            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(Book book)
        {
            _dbContext.Entry(book).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(string isbn)
        {
            var book = await GetBookByISBNAsync(isbn);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                await _dbContext.SaveChangesAsync();
            }
        }

        public Task<int> GetBooksCountAsync()
        {
            //return the count of books in the database as integer
            return _dbContext.Books.CountAsync();
        }

        public async Task<List<Book>> SearchBooksAsync(string attribute, string searchText)
        {
            // Query books based on the attribute and search text
            IQueryable<Book> query = _dbContext.Books.AsQueryable();

            if (attribute == "Title")
            {
                query = query.Where(b => b.Title.Contains(searchText));
            }
            else if (attribute == "Author")
            {
                query = query.Where(b => b.Author.Contains(searchText));
            }
            else if (attribute == "Publisher")
            {
                query = query.Where(b => b.Publisher.Contains(searchText));
            }
            else if (attribute == "YearOfPublication")
            {
                query = query.Where(b => b.YearOfPublication.ToString().Contains(searchText));
            }

            // Execute the query and return the result
            return await query.ToListAsync();
        }

    }

}
