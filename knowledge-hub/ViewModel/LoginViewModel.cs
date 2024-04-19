using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.ViewModel
{
    public class LoginViewModel
    {
        private readonly IUserRepository _userRepository;

        public LoginViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            return await _userRepository.AuthenticateAsync(username, password);
        }
    }
}
