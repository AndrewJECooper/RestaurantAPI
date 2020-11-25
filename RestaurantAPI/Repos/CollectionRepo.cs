using RestaurantAPI.Models;
using RestaurantAPI.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Repos
{
    public class CollectionRepo : ICollectionRepo
    {
        public Task<Collection> CreateNew(Collection data)
        {
            throw new NotImplementedException();
        }

        public Task<Collection> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Collection>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Collection> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public Task<Collection> Update(Collection data)
        {
            throw new NotImplementedException();
        }
    }
}
