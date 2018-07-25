using learnDotNetCore.Models;
using System.Collections.Generic;

namespace learnDotNetCore.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}
