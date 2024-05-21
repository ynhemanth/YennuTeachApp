using Microsoft.EntityFrameworkCore;
using Repository.Entity.DBContext;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public readonly DataBaseContext _dbContext;
        public DbSet<T> _dbSet;
        public BaseRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task<T> AddAsync(T domain)
        {
            _dbSet.Add(domain);
            await _dbContext.SaveChangesAsync();
            return domain;
        }

        public async Task<bool> DeleteAsync(T domain)
        {
            _dbSet.Remove(domain);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                var val = await _dbSet.ToListAsync();
                return val;
            }
            catch(Exception ex)
            {
                return null;
            }

            
        }

        public async Task<IEnumerable<T>> GetAllByFilterAsync(Expression<Func<T, bool>> filter, bool useNoTracking = false)
        {
            if (useNoTracking)
                return await _dbSet.AsNoTracking().Where(filter).ToListAsync();
            else
                return await _dbSet.Where(filter).ToListAsync();
        }

        //public async Task<T> GetAsync(int id)
        //{
        //    if (useNoTracking)
        //        return await _dbSet.AsNoTracking().Where(filter).FirstOrDefaultAsync();
        //    else
        //        return await _dbSet.Where(filter).FirstOrDefaultAsync();
        //}

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter, bool useNoTracking = false)
        {
            if (useNoTracking)
                return await _dbSet.AsNoTracking().Where(filter)?.FirstOrDefaultAsync();
            else
                return await _dbSet.Where(filter)?.FirstOrDefaultAsync();
        }

        public async Task<T> Update(T domain)
        {
            _dbContext.Update(domain);
            await _dbContext.SaveChangesAsync();

            return domain;
        }
    }
}
