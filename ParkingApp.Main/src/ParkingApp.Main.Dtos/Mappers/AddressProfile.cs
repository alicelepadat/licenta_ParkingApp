using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.Dtos.Mappers
{
    internal class AddressProfile : BaseProfile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDto>().ReverseMap();
        }
        
    }
}
