using knowlegde_hub;
using System.Collections.Generic;

namespace knowledge_hub
{
    public class Patron : User
    {
        public bool MembershipStatus { get; set; } // Active or inactive

        private List<Book> checkedOutBooks;

        public Patron(string username, string password, string name, string email, string phoneNumber, bool membershipStatus)
        : base(username, password, UserType.Patron)
        {
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.MembershipStatus = membershipStatus;
            this.checkedOutBooks = new List<Book>(); // Initialize empty list
        }
    }
}
