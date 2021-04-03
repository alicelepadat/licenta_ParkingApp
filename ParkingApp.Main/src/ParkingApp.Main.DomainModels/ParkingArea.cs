using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingApp.Main.DomainModels
{
    public class ParkingArea : BaseEntity
    {
        [Required]
        public int TotalSpots { get; set; }

        [Required]
        public int AvailableSpots { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal? PricePerHour { get; set; }

        public Address Address { get; set; }

        public int AddressId { get; set; }

        public Company Company { get; set; }

        public int CompanyId { get; set; }

        public Admin Admin { get; set; }

    }
}
