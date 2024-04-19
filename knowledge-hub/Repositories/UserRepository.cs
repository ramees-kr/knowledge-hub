using knowledge_hub.Data;
using knowledge_hub.Model.Entities;
using knowledge_hub.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LibDbContext _dbContext;

        public UserRepository(LibDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddUserAsync(User user)
        {
            // Add the user to the database asynchronously using dbContext
            _dbContext.Users.Add(user);
            return _dbContext.SaveChangesAsync();
        }

        public Task<User> AuthenticateAsync(string username, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                return Task.FromResult(user);
            }
            return Task.FromResult<User>(null);
        }

        //return all usernames
        public async Task<List<string>> GetAllUserNamesAsync()
        {
            return await _dbContext.Users.Select(u => u.Username).ToListAsync();
        }

        public Task DeleteUserAsync(int userId)
        {
            // Find the user by userId
            var user = _dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                // Remove the user from the database
                _dbContext.Users.Remove(user);
                return _dbContext.SaveChangesAsync();
            }
            else
            {
                return Task.CompletedTask;
            }
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            // Return all users from the database
            return await _dbContext.Users.ToListAsync();
        }

        public Task<User> GetUserByIdAsync(int userId)
        {
            // Find the user by userId
            var user = _dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            return Task.FromResult(user);
        }

        public Task UpdateUserAsync(User user)
        {
            // Update the user in the database
            _dbContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbContext.SaveChangesAsync();
        }

        public Task<int> GetUsersCountAsync()
        {
            //return the count of users in the database as integer
            return _dbContext.Users.CountAsync();
        }

        public async Task<List<User>> SearchUsersAsync(string attribute, string searchText)
        {
            // Query users based on the attribute and search text
            IQueryable<User> query = _dbContext.Users.AsQueryable();

            if (attribute == "Username")
            {
                query = query.Where(u => u.Username.Contains(searchText));
            }
            else if (attribute == "UserType")
            {
                query = query.Where(u => u.UserType.Contains(searchText));
            }

            // Execute the query and return the result
            return await query.ToListAsync();
        }
    }
}