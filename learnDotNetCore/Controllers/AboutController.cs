using Microsoft.AspNetCore.Mvc;

namespace learnDotNetCore.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "5255255252";
        }

        public string Address()
        {
            return "45th st";
        }
    }
}
