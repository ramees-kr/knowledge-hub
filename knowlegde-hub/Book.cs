using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowlegde_hub
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; } // "Available", "CheckedOut"
        public DateTime DueDate { get; set; }

        //Constructor to create a new book
        public Book(int bookID, string title, string author, string genre, string status, DateTime dueDate)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            Genre = genre;
            Status = status;
            DueDate = dueDate;
        }

        //Overloaded constructor to create a new book with ID and title only
        public Book(int ID, string title)
        {
            Title = title;
            //Set default values for other properties
            BookID = 0;
            Author = "Unknown";
            Genre = "Unknown";
            Status = "Available";
            //set the due date to 7 days from now
            DueDate = DateTime.Now + TimeSpan.FromDays(7);
        }

        public void CheckOut()
        {
            Status = "CheckedOut";
        }

        public void Return()
        {
            Status = "Available";
        }

        public void Renew()
        {
            DueDate = DateTime.Now + TimeSpan.FromDays(7);
        }


    }
}
