using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.Dtos.Mappers
{
    internal class IssuerProfile : BaseProfile
    {
        public IssuerProfile()
        {
            CreateMap<Issuer, IssuerDto>().ReverseMap();
            CreateMap<Issuer, NewIssuerDto>().ReverseMap();
        }
    }
}
