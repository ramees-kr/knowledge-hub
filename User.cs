using knowlegde_hub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace knowledge_hub
{
    public abstract class User
    {
        public int Id { get; set; } // Unique ID for each user
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType Type { get; protected set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public static User Login(string username, string password)
        {
            //Console.WriteLine(username + " " + password);
            return Library.Instance.Login(username, password);
        }

        //override ToString method to return the username
        public override string ToString()
        {
            return Username;
        }

        public User(string username, string password, UserType type)
        {
            this.Username = username;
            this.Password = password;
            this.Type = type;
        }


    }

    public enum UserType
    {
        Patron,
        Librarian
    }
}
