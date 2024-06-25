using ECommerceApi.Application.Interfaces.Repositories;
using ECommerceApi.Domain.Common;
using ECommerceApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ECommerceApi.Persistence.Repositories
{
    public class WriteRepository<T>: IWriteRepository<T> where T : class, IEntityBase, new()
    {
        private readonly ApplicationDbContext dbContext;

        public WriteRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> table=> dbContext.Set<T>();
        public async Task AddAsync(T entity)
        {
            await table.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<T> entities)
        {
            await table.AddRangeAsync(entities);
        }
        public async Task<T> UpdateAsync(int id, T entity)
        {
            await Task.Run(() =>table.Update(entity) );
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            await Task.Run(()=>table.Remove(entity));
        }

        public async Task DeleteRangeAsync(IList<T> Entities)
        {
            await Task.Run(() => table.RemoveRange(Entities));
        }
    }
}
