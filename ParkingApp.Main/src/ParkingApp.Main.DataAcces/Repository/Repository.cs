using Microsoft.EntityFrameworkCore;
using ParkingApp.Main.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ParkingMainContext _parkingMainContext;
        private readonly DbSet<T> _entities;

        public Repository(ParkingMainContext parkingMainContext)
        {
            _parkingMainContext = parkingMainContext ?? throw new ArgumentNullException(nameof(parkingMainContext));
            _entities = parkingMainContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _parkingMainContext.Set<T>().ToListAsync();
        }

        public void Remove(T entity)
        {
            _parkingMainContext.Set<T>().Remove(entity);
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _parkingMainContext.Set<T>().SingleOrDefaultAsync(expression);
        }
    }
}
