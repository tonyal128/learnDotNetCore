using learnDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learnDotNetCore.Services
{
    interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
