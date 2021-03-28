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
    }
}
