using ParkingApp.Main.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ParkingApp.Main.DataAcces.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void Remove(T entity);
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> expression);
    }
}