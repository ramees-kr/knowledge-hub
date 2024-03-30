namespace knowledge_hub
{
    public class Librarian : User
    {
        public Librarian(string username, string password, string name, string email)
            : base(username, password, UserType.Librarian)
        {
            this.Name = name;
            this.Email = email;
        }
    }

}
