using ECommerceApi.Application.Interfaces.Repositories;
using ECommerceApi.Application.Interfaces.UnitOfWorks;
using ECommerceApi.Persistence.Context;
using ECommerceApi.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ECommerceApi.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

         
        public async ValueTask DisposeAsync()=>await dbContext.DisposeAsync();
        

        public int SaveChange()=>dbContext.SaveChanges();
        
        public async Task<int> SaveChangeAsync()=>await dbContext.SaveChangesAsync();


          IReadRepository<T> IUnitOfWork.readRepository<T>() => new ReadRepository<T>(dbContext);
         

          IWriteRepository<T> IUnitOfWork.writeRepository<T>()=>new WriteRepository<T>(dbContext);
         
    }
}
