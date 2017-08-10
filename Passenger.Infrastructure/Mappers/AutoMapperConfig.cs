using AutoMapper;
using Passenger.Core.Domains;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
        => new MapperConfiguration(cfg =>
            {
            cfg.CreateMap<User, UserDTO>();
            cfg.CreateMap<Driver, DriverDTO>();
            })
        .CreateMapper();

    }
}