using AutoMapper;
using Repository.Domain.Model;
using Repository.Entity.Model;

namespace Repository.Configuration
{
    public class AutoMapperConfig :Profile
    {
       public AutoMapperConfig() {
            CreateMap<LocationDomain, LocationEntity>().ReverseMap();
        }
    }
}
