using knowlegde_hub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub
{
    public class BorrowingTransaction
    {
        public int TransactionID { get; set; }
        public int PatronID { get; set; }
        public User Patron { get; set; } // Reference to the Patron object
        public int BookID { get; set; }
        public Book Book { get; set; } // Reference to the Book object
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal FineAmount { get; set; }
    }
}
