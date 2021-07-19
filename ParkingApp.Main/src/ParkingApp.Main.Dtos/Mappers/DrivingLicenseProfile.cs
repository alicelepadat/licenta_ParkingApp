using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.Dtos.Mappers
{
    internal class DrivingLicenseProfile : BaseProfile
    {
        public DrivingLicenseProfile()
        {
            CreateMap<DrivingLicense, DrivingLicenseDto>().ReverseMap();
            CreateMap<DrivingLicense, NewDrivingLicenseDto>().ReverseMap();
        }
    }
}
