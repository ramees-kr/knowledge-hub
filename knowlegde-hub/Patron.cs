using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowlegde_hub
{
    public class Patron
    {
        public int PatronID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactDetails { get; set; }
        public List<Book> CheckedOutBooks { get; set; } = new List<Book>();
        public bool MembershipStatus { get; set; } // Active or inactive

        //Constructor to create a new patron
        public Patron(int patronID, string name, string email, string password, string contactDetails, bool membershipStatus)
        {
            PatronID = patronID;
            Name = name;
            ContactDetails = contactDetails;
            MembershipStatus = membershipStatus;
            Email = email;
            Password = password;
        }

        public Patron(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;

            //Set default values for other properties
            PatronID = 0;
            ContactDetails = "Not available";
            MembershipStatus = true;
            CheckedOutBooks = new List<Book>();
        }

        //Overloaded constructor to create a new patron with name only
        public Patron(string name)
        {
            Name = name;
            //Set default values for other properties
            PatronID = 0;
            ContactDetails = "Not available";
            MembershipStatus = true;
            CheckedOutBooks = new List<Book>();
            Email = "Not available";
            Password = "user";
        }
    }

    
}
