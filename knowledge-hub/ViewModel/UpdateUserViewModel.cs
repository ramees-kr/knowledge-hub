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
    internal class UpdateUserViewModel
    {
        private IUserRepository _userRepository;

        public UpdateUserViewModel(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public User SelectedUser { get; internal set; }

        public async Task UpdateUserAsync(User SelectedUser)
        {
            // Call the UpdateBookAsync method from the repository to update the book
            await _userRepository.UpdateUserAsync(SelectedUser);
        }

    }
}
