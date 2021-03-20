using System;

namespace ParkingApp.Main.Dtos
{
    public class NewAdminDto
    {

        public NewUserDto User { get; set; }

        public int CompanyId { get; set; }

        public int? ParkingAreaId { get; set; }
    }
}
