using RestaurantAPI.Models;
using RestaurantAPI.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Repos
{
    public class TimeBookingRepo : ITimeBookingRepo
    {
        public Task<TimeBooking> CreateNew(TimeBooking data)
        {
            throw new NotImplementedException();
        }

        public Task<TimeBooking> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TimeBooking>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TimeBooking> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public Task<TimeBooking> Update(TimeBooking data)
        {
            throw new NotImplementedException();
        }
    }
}
