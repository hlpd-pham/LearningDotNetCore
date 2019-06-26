using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurant;

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurant.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurant.FirstOrDefault(r => r.Id == id);
        }

        public InMemoryRestaurantData()
        {
            _restaurant = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Pho Hoa" },
                new Restaurant { Id = 2, Name = "Pho Hoa 2" },
                new Restaurant { Id = 3, Name = "Pho Hoa 3" }
            };
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurant.Max(r => r.Id) + 1;
            _restaurant.Add(restaurant);
            return restaurant;
        }
    }
}
