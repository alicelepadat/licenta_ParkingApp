using ParkingApp.Main.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public interface IParkingAreaRepository
    {
        Task<IEnumerable<ParkingArea>> GetAllAreasAsync();
    }
}
