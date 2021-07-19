using ParkingApp.Main.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Main.Dtos.Mappers
{
    internal class VehicleProfile : BaseProfile
    {
        public VehicleProfile()
        {
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
            CreateMap<Vehicle, NewVehicleDto>().ReverseMap();
        }

    }
}
