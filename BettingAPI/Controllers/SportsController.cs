using Microsoft.AspNetCore.Mvc;

namespace BettingAPI.Controllers
{
    public class SportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
