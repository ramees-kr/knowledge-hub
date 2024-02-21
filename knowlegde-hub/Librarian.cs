using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowlegde_hub
{
    public class Librarian
    {
        public int LibrarianID { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }
    
        //Constructor to create Librarian
        public Librarian(int librarianID, string name, string contactDetails)
        {
            LibrarianID = librarianID;
            Name = name;
            ContactDetails = contactDetails;
        }
    }

}
