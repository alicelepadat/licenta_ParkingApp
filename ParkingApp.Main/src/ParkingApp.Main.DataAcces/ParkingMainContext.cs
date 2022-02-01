using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.DataAcces
{
    public class ParkingMainContext : DbContext
    {
        public ParkingMainContext(DbContextOptions options) : base(options) { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ParkingArea> ParkingAreas { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.SeedDatabase();
        }
    }
}
