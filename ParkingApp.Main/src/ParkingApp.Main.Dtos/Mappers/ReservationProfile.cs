using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.Dtos.Mappers
{
    internal class ReservationProfile : BaseProfile
    {
        public ReservationProfile()
        {
            CreateMap<Reservation, ReservationDto>().ReverseMap();
            CreateMap<Reservation, NewReservationDto>().ReverseMap();
        }
    }
}
