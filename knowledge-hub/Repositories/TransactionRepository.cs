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
    public class TransactionRepository : ITransactionRepository
    {
        private readonly LibDbContext _dbContext;

        public TransactionRepository(LibDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Transaction>> GetAllTransactionsAsync()
        {
            return await _dbContext.Transactions.ToListAsync();
        }

        public async Task<Transaction> GetTransactionByIdAsync(int id)
        {
            return await _dbContext.Transactions.FirstOrDefaultAsync(t => t.TransactionId == id);
        }

        public async Task AddTransactionAsync(Transaction transaction)
        {
            _dbContext.Transactions.Add(transaction);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateTransactionAsync(Transaction transaction)
        {
            _dbContext.Entry(transaction).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteTransactionAsync(int id)
        {
            var transaction = await GetTransactionByIdAsync(id);
            if (transaction != null)
            {
                _dbContext.Transactions.Remove(transaction);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<int> GetTransactionsCountAsync(string transactionType)
        {
            return await _dbContext.Transactions.CountAsync(t => t.TransactionType == transactionType);
        }
    }
}
