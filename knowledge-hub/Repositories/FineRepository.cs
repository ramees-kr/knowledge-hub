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
    internal class FineRepository : IFineRepository
    {
        private readonly LibDbContext _dbContext;

        public FineRepository(LibDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Fine>> GetAllFinesAsync()
        {
            return await _dbContext.Fines.ToListAsync();
        }

        public Task<int> GetTotalFinesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<decimal> GetTotalUnpaidFinesAsync()
        {
            return await _dbContext.Fines.Where(f => f.Paid == false)
                                           .SumAsync(f => f.Amount ?? 0);
        }
    }
}
