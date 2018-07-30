using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using learnDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learnDotNetCore.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;
        public string CurrentGreeting { get; set; }

        public GreetingModel(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public void OnGet()
        {
            CurrentGreeting = _greeter.GetMessageOfTheDay();
        }
    }
}