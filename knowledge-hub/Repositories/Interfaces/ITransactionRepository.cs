using knowledge_hub.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        Task<List<Transaction>> GetAllTransactionsAsync();
        Task<Transaction> GetTransactionByIdAsync(int id);
        Task AddTransactionAsync(Transaction transaction);
        Task UpdateTransactionAsync(Transaction transaction);
        Task DeleteTransactionAsync(int id);

        //Get count of transactions with x transaction type
        Task<int> GetTransactionsCountAsync(string transactionType);
    }
}
