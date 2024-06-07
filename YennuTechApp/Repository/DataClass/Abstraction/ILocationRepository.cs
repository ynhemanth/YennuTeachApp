using Repository.Base;
using Repository.Domain.Model;
using Repository.Entity.Model;

namespace Repository.DataClass.Abstraction
{
    public interface ILocationRepository :IBaseRepository<LocationEntity>
    {
        public Task<IEnumerable<LocationDomain>> GetAllLocation(); 
    }
}
