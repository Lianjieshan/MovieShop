using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
  

    public class EfRepository<T> : IAsyncRepository<T> where T : class
    {
        // use it subclass
        protected readonly MovieShopDbContext _dbContext;

        // set constructor 
        public EfRepository(MovieShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            // use more genral one dbset<T>, not specific one "movie"
            // using FindAsync method
            var entity = await _dbContext.Set<T>().FindAsync(id);
            return entity;
        }

        public async Task<IEnumerable<T>> ListAllAsync()
        {
            var data = await _dbContext.Set<T>().ToListAsync();
            return data;
        }

        public virtual async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter)
        {
            // pass the "filter" to the "where" method due to the expression patameter.
            return await _dbContext.Set<T>().Where(filter).ToListAsync();
        }

        public virtual async Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null)
        {
            return await _dbContext.Set<T>().Where(filter).CountAsync();
        }

        public virtual async Task<bool> GetExistsAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return false;
            }
            // !!! use a lot=>"AnyAsync" method if find the element it will return true
            return await _dbContext.Set<T>().Where(filter).AnyAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            // Movie
            // Id PK,Identity
            // Title ="ABC", Revenue =1223321
            // Add method, important, use await save method after this method.
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            // Movie
            // Id=22 PK,Identity
            // db data Title ="ABC", Revenue =1223321
            // Title = "ABC2", Revenue=5345435

            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }

}
