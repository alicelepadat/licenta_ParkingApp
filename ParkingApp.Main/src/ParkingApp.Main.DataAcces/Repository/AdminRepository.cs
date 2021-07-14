using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        public AdminRepository(ParkingMainContext parkingMainContext) : base(parkingMainContext)
        {
        }

        public async Task<Admin> GetByUserIdAsync(int userId)
        {
            return await _parkingMainContext.Admins
                    .Include(a => a.User)
                    .Include(a=>a.ParkingArea)
                    .SingleOrDefaultAsync(x => x.User.Id == userId);
        }
    }
}