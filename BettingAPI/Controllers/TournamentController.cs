using BettingAPI.Repository.IRepository;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BettingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TournamentController : Controller
    {
        IRepository<Tournament> _tournamentRepository;
        public TournamentController(IRepository<Tournament> tournamentRepo)
        {
            _tournamentRepository = tournamentRepo;
        }

        [HttpGet("{sportId:int}")]
        public IActionResult GetTournaments(int sportId)
        {
            var jspnFilePath = "C:\\Users\\HP\\OneDrive\\Desktop\\JsonFiles\\sportstournaments#countryIds_181&languageCode_en.json";
            List<Tournament> lstTournaments = new List<Tournament>();

            var obj = _tournamentRepository.GetData(jspnFilePath);

            lstTournaments = obj.Where(x => x.sportId == sportId).ToList();

            return Ok(lstTournaments);
        }
    }
}
