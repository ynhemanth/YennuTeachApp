using AutoMapper;
using Repository.Base;
using Repository.DataClass.Abstraction;
using Repository.Domain.Model;
using Repository.Entity.DBContext;
using Repository.Entity.Model;

namespace Repository.DataClass
{
    public class LocationRepository : BaseRepository<LocationEntity>, ILocationRepository
    {
        public readonly DataBaseContext _dbContext;
        private readonly IMapper _mapper;


        public LocationRepository(
            IMapper mapper,
            DataBaseContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LocationDomain>> GetAllLocation()
        {
            var data = await GetAllAsync();
            var result = _mapper.Map<IEnumerable<LocationDomain>>(data);
            
            return result;

        }
    }
}
