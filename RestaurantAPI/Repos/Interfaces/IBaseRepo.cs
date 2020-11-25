using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Repos
{
    public interface IBaseRepo<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<T> DeleteByIdAsync(int id);

        Task<T> CreateNew(T data);

        Task<T> Update(T data);

        bool Save();

    }
}
