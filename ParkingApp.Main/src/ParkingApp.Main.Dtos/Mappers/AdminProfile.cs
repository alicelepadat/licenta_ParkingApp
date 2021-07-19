using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.Dtos.Mappers
{
    internal class AdminProfile : UserProfile
    {
        public AdminProfile()
        {
            CreateMap<Admin, AdminDto>().ReverseMap();
            CreateMap<Admin, NewAdminDto>().ReverseMap();
        }
    }
}
