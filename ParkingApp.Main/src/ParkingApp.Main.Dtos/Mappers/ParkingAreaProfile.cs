using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.Dtos.Mappers
{
    internal class ParkingAreaProfile : BaseProfile
    {
        public ParkingAreaProfile()
        {
            CreateMap<ParkingArea, ParkingAreaDto>().ReverseMap();
        }
    }
}
