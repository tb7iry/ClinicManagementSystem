using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Domain.Contracts
{
    public interface IRepository<TEntity , Tkey> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(Tkey id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(Tkey id);

    }
}
