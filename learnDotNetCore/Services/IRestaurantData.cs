using learnDotNetCore.Models;
using System.Collections.Generic;

namespace learnDotNetCore.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
    }
}
