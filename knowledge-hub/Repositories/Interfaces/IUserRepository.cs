using knowledge_hub.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int userId);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int userId);

        Task<List<string>> GetAllUserNamesAsync();

        Task<int> GetUsersCountAsync();
        Task<User> AuthenticateAsync(string username, string password);

        Task<List<User>> SearchUsersAsync(string attribute, string searchText);
    }
}
