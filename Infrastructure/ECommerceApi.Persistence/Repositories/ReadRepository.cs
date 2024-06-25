using ECommerceApi.Application.Interfaces.Repositories;
using ECommerceApi.Domain.Common;
using ECommerceApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
 

namespace ECommerceApi.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class,IEntityBase,new()
    {
        public ApplicationDbContext DbContext { get; }

        public ReadRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        private DbSet<T> entity =>DbContext.Set<T>();


        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
                                         Func<IQueryable<T>, IIncludableQueryable<T,object>>? include = null,
                                         Func<IQueryable<T>,IOrderedQueryable<T>>? orderby = null,
                                         bool enableTracing = false)
        {
            IQueryable<T> Queryable = entity;

            if (!enableTracing)
                Queryable=Queryable.AsNoTracking();
            if (include is not null)
                Queryable = include(Queryable);
            if (predicate is not null)
                Queryable = Queryable.Where(predicate);
            if (orderby is not null)
                return await orderby(Queryable).ToListAsync();

            return await Queryable.ToListAsync();

        }


        public async Task<IList<T>> GetAllByPagningAsync(Expression<Func<T, bool>>? predicate = null,
                                                  Func<IQueryable<T>, IIncludableQueryable<T,object>>? include = null,
                                                  Func<IQueryable<T>,IOrderedQueryable<T>>? orderby = null,
                                                  int currentPage = 1, int pageSize = 3,
                                                  bool enableTracing = false)
        {
           IQueryable<T> Queryable = entity;
            if(!enableTracing)
                Queryable=Queryable.AsNoTracking();
            if(include is not null)
                Queryable = include(Queryable);
            if (predicate is not null)
                Queryable = Queryable.Where(predicate);
            if (orderby is not null)
                return await orderby(Queryable).Skip((currentPage-1)*pageSize).Take(pageSize).ToListAsync();
            return await Queryable.Skip((currentPage-1)*pageSize).Take(pageSize).ToListAsync() ;

        }


        public async Task<T> GetAsync(Expression<Func<T, bool>>? predicate = null,
                                      Func<IQueryable<T>, IIncludableQueryable<T,object>>? include = null,
                                      bool enableTracing = false)
        {
           
            IQueryable<T> Queryable= entity;
            if(!enableTracing)
                Queryable=Queryable.AsNoTracking();
            if(include is not null)
                 Queryable = include(Queryable);
            return await Queryable.FirstOrDefaultAsync(predicate);
         }



        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            entity.AsNoTracking();
            if (predicate is not null)
                entity.Where(predicate);
            return await entity.CountAsync();
        }


        public async Task<IQueryable<T>> Find(Expression<Func<T, bool>>? predicate
                                              ,bool enableTracing=false)
        {
            if (!enableTracing)
                entity.AsNoTracking();

            return entity.Where(predicate);
        }

       

       

       
    }
}
