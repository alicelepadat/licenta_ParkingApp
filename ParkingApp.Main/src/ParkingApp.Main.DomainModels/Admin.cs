using System;

namespace ParkingApp.Main.DomainModels
{
    public class Admin : BaseEntity
    {
        public User User { get; set; }

        public int UserId { get; set; }

        public Company Company { get; set; }

        public int CompanyId { get; set; }

        public ParkingArea ParkingArea { get; set; }

        public int? ParkingAreaId { get; set; }
    }
}
