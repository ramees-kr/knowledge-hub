using knowlegde_hub;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace knowledge_hub
{
    public class Library
    {
        private static readonly Library instance = new Library();

        private static int idCounter = 100;
        public User CurrentUser { get; private set; } // Property to access the current user
        public List<User> Users { get; set; } = new List<User>();
        public List<Book> Books { get; set; } = new List<Book>();

        public static Library Instance
        {
            get { return instance; }
        }

        private Library()
        {
            InitializeLibrary(); // Ensure initialization on creation
        }

        private void InitializeLibrary()
        {
            Users = new List<User>(); // Initialize the users list

            // Create a Root User
            User rootUser = new Librarian("admin", "admin", "Horton", "teamhortons@knowledge-hub.com");
            Users.Add(rootUser);
            //Print the root user
            //MessageBox.Show(rootUser.ToString());
        }

        public User RegisterUser(string username, string password, string name, string email, string phoneNumber, bool membershipStatus)
        {
            if (membershipStatus)
            {
                Patron newPatron = new Patron(username, password, name, email, phoneNumber, membershipStatus);
                Library.Instance.Users.Add(newPatron);
                return newPatron;
            }
            else
            {
                throw new ArgumentException("Membership cannot be inactive for new patrons.");
            }
        }
        public User Login(string username, string password)
        {
            //MessageBox.Show("Login method in Library class is called");
            var user = Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            //MessageBox.Show("User found: " + user);
            if (user == null)
            {
                throw new Exception("Invalid username or password.");
            }
            return user;
        }

        //return the total number of books in the library
        public int GetTotalBooks()
        {
            return Books.Count();
        }

        //return the total number of users in the library
        public int GetTotalUsers(UserType type)
        {
            return Users.Count(u => u.Type == type);
        }

        public static int GetUniqueID()
        {
            return ++idCounter; // Increment counter and return the value
        }

        public void SetCurrentUser(User user)
        {
            CurrentUser = user; // Store current user in the library itself
        }

        // Get Patron by ID
        public Patron GetPatronById(int id)
        {
            return Users.OfType<Patron>().FirstOrDefault(p => p.Id == id);
        }

        // Get Librarian by ID
        public Librarian GetLibrarianById(int id)
        {
            return Users.OfType<Librarian>().FirstOrDefault(l => l.Id == id);
        }

    }
}
