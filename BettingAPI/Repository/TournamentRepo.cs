using BettingAPI.Repository.IRepository;
using Core.Models;
using Newtonsoft.Json.Linq;

namespace BettingAPI.Repository
{
    public class TournamentRepo : IRepository<Tournament>
    {
        public List<Tournament> GetData(string JsonFilePath)
        {
            IList<Tournament> lstTournaments = new List<Tournament>();

            using (StreamReader r = new StreamReader(JsonFilePath))
            {
                string json = r.ReadToEnd();
                var tournamentsList = JObject.Parse(json)["tournaments"].ToList();
                

                foreach (var item in tournamentsList)
                {
                    lstTournaments.Add(item.ToObject<Tournament>());
                }
            }

            return lstTournaments.ToList();
        }
    }
}
