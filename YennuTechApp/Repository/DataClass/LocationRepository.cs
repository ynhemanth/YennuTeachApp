using Repository.Base;
using Repository.DataClass.Abstraction;
using Repository.Entity.DBContext;
using Repository.Entity.Model;
using System.Linq.Expressions;

namespace Repository.DataClass
{
    public class LocationRepository : BaseRepository<LocationEntity>, ILocationRepository
    {
        public readonly DataBaseContext _dbContext;

        public LocationRepository(DataBaseContext dbContext) : base(dbContext)        
        {        
          _dbContext = dbContext;
        }        

    }
}
