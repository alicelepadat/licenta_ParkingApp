using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.Dtos.Mappers
{
    internal class DriverProfile : UserProfile
    {
        public DriverProfile()
        {
            CreateMap<Driver, DriverDto>().ReverseMap();
            CreateMap<Driver, NewDriverDto>().ReverseMap();
        }
        
    }
}
