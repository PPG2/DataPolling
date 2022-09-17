using BettingAPI.Repository.IRepository;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BettingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SportsController : ControllerBase
    {
        IRepository<Sport> _sportsRepository;
        
        public SportsController(IRepository<Sport> sportRepo)
        {
            _sportsRepository = sportRepo;
        }

        [HttpGet]
        public IActionResult GetSports()
        {
            var jspnFilePath = "C:\\Users\\HP\\OneDrive\\Desktop\\JsonFiles\\sports#languageCode_en.json";
            List<Sport> Sports = new List<Sport>();

            Sports = _sportsRepository.GetData(jspnFilePath);

            return Ok(Sports);
        }
    }
}
