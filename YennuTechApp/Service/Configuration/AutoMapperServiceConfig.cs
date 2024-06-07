using AutoMapper;
using Repository.Domain.Model;
using Service.Model;

namespace Service.Configuration
{
    public class AutoMapperServiceConfig : Profile
    {
        public AutoMapperServiceConfig()
        {
            CreateMap<LocationCore, LocationDomain>().ReverseMap();
        }
    }
}
