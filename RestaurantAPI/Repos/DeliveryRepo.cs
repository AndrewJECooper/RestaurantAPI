using RestaurantAPI.Models;
using RestaurantAPI.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Repos
{
    public class DeliveryRepo : IDeliveryRepo
    {
        public Task<Delivery> CreateNew(Delivery data)
        {
            throw new NotImplementedException();
        }

        public Task<Delivery> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Delivery>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Delivery> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public Task<Delivery> Update(Delivery data)
        {
            throw new NotImplementedException();
        }
    }
}
