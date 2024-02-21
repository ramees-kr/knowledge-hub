using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowlegde_hub
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Patron> Patrons { get; set; } = new List<Patron>();
        public List<Librarian> Librarians { get; set; } = new List<Librarian>();

        public void AddPatron(Patron patron)
        {
            Patrons.Add(patron);
        }

        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
    }
}
