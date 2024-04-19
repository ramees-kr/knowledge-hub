using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories;
using knowledge_hub.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.ViewModel
{
    internal class AddUserViewModel
    {
        private readonly IUserRepository _userRepository;

        public AddUserViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUser(string username, string password, string password2, string name, string contactDetails, string userType)
        {
            // Check if the passwords match
            if (password != password2)
            {
                throw new Exception("Passwords do not match");
            }

            // Check if the username is already taken using GetAllUserIdsAsync method from UserRepository
            var userIds = await _userRepository.GetAllUserNamesAsync();
            if (userIds.Contains(username))
            {
                throw new Exception("Username is already taken");
            }



            // Create a new user object
            var user = new User
            {
                Username = username,
                Password = password,
                Name = name,
                ContactDetails = contactDetails,
                UserType = userType
            };

            // Add the user to the database
            await _userRepository.AddUserAsync(user);
        }
    }
}
