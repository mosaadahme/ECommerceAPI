using ECommerceApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(int id, T entity);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(IList<T> Entities);


    }
}
