using AutoMapper;
using Repository.DataClass;
using Repository.DataClass.Abstraction;
using Service.Abstraction;
using Service.Model;

namespace Service.Location
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public LocationService(ILocationRepository locationRepository,IMapper mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<LocationCore>> GetAll()
        {
            var result = await _locationRepository.GetAllLocation();            
            var data = _mapper.Map<IEnumerable<LocationCore>>(result);

            return data;
        }
    }
}
