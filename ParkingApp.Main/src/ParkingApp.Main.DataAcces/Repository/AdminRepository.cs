using ParkingApp.Main.DomainModels;

namespace ParkingApp.Main.DataAcces.Repository
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        public AdminRepository(ParkingMainContext parkingMainContext) : base(parkingMainContext)
        {
        }
    }
}