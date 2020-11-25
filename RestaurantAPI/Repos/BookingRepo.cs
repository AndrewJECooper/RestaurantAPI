using RestaurantAPI.Models;
using RestaurantAPI.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Repos
{
    public class BookingRepo : IBookingRepo
    {
        public Task<Booking> CreateNew(Booking data)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Booking>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Booking> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> Update(Booking data)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
