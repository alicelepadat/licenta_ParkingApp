using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.DomainModels
{
    public class Company : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string CompanyName { get; set; }

        public List<ParkingArea> ParkingAreas { get; set; }

        public List<Admin> Admins { get; set; }
    }
}
