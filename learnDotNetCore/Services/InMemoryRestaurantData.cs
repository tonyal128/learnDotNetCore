using learnDotNetCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace learnDotNetCore.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id = 1, Name = "Pizza Place"},
                new Restaurant{Id = 2, Name = "Huhot"},
                new Restaurant{Id = 3, Name = "Pub"},
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);

            return restaurant;
        }

        List<Restaurant> _restaurants;
    }
}
