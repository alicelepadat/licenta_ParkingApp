using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.Dtos
{
    public class AddressDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string City { get; set; }

        [MaxLength(150)]
        public string Street { get; set; }

        public int Number { get; set; }

        [MaxLength(300)]
        public string Directions { get; set; }

        [MaxLength(15)]
        public string County { get; set; }

        public ParkingAreaDto ParkingArea { get; set; }
    }
}