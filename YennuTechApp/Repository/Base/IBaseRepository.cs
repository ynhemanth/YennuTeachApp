using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Base
{
    public interface IBaseRepository<T> 
    {
        Task<T> AddAsync(T domain);
        Task<bool> DeleteAsync(T domain);
        //Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllByFilterAsync(Expression<Func<T, bool>> filter, bool useNoTracking = false);
        Task<T> GetAsync(Expression<Func<T, bool>> filter, bool useNoTracking = false);
        Task<IEnumerable<T>> GetAllAsync();        
        Task<T> Update(T domain);
    }
}
