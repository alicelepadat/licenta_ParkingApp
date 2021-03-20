using ParkingApp.Main.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class CompanyDto
    {
        public int Id { get; set; } 

        [Required]
        [MaxLength(200)]
        public string CompanyName { get; set; }

        public List<ParkingAreaDto> ParkingAreas { get; set; }

        public List<AdminDto> Admins { get; set; }
    }
}
