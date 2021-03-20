using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;
using System;

namespace ParkingApp.Main.DataAcces
{
    public class ParkingMainContext : DbContext
    {
        public ParkingMainContext(DbContextOptions options) : base(options) { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<ParkingArea> ParkingAreas { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.SeedDatabase();
        }
    }
}
