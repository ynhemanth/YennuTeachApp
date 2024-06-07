using Repository.DataClass.Abstraction;
using Service.Location;
using Service.Model;

namespace Service.Abstraction
{
    public interface ILocationService 
    {
        public Task<IEnumerable<LocationCore>> GetAll();
    }
}
