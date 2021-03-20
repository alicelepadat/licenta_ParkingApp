using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingApp.Main.DomainModels
{
    public class DrivingLicense : BaseEntity
    {
        [Required]
        [MaxLength(12)]
        public string Number { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        public Issuer Issuer { get; set; }

        public int IssuerId { get; set; }

        public Driver Driver { get; set; }
    }
}