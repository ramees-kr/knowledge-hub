using knowledge_hub.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knowledge_hub.Repositories.Interfaces
{
    public interface IFineRepository
    {
        Task<IEnumerable<Fine>> GetAllFinesAsync();
        Task<int> GetTotalFinesAsync();

        Task<decimal> GetTotalUnpaidFinesAsync();
    }
}
