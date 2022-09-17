using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BettingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SportsController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult GetSports()
        {
            var jspnFilePath = "C:\\Users\\HP\\OneDrive\\Desktop\\JsonFiles\\sports#languageCode_en.json";
            List<Sport> Sports = new List<Sport>();

            using (StreamReader r = new StreamReader(jspnFilePath))
            {
                string json = r.ReadToEnd();
                var sportsList = JObject.Parse(json)["sports"].ToList();
                IList<Sport> lstSports = new List<Sport>();

                foreach (var item in sportsList)
                {
                    lstSports.Add(item.ToObject<Sport>());
                }
                Sports = lstSports.ToList();
            }

            return Ok(Sports);
        }

        [HttpGet("{sportId:int}")]
        public IActionResult GetTournaments(int sportId)
        {
            var jspnFilePath = "C:\\Users\\HP\\OneDrive\\Desktop\\JsonFiles\\sportstournaments#countryIds_181&languageCode_en.json";
            List<Tournament> tournaments = new List<Tournament>();

            using (StreamReader r = new StreamReader(jspnFilePath))
            {
                string json = r.ReadToEnd();
                var tournamentsList = JObject.Parse(json)["tournaments"].ToList();
                IList<Tournament> lstTournaments = new List<Tournament>();

                foreach (var item in tournamentsList)
                {
                    lstTournaments.Add(item.ToObject<Tournament>());
                }

                tournaments = lstTournaments.Where(x => x.sportId == sportId).ToList();

            }

            return Ok(tournaments);
        }
    }
}
