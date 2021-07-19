using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingApp.Main.DomainModels
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
