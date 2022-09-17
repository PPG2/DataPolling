using BettingAPI.Repository.IRepository;
using Newtonsoft.Json.Linq;

namespace BettingAPI.Repository
{
    internal class SportsRepo : IRepository<Sport>
    {
        public List<Sport> GetData(string JsonFilePath)
        {
            List<Sport> Sports = new List<Sport>();

            using (StreamReader r = new StreamReader(JsonFilePath))
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

            return Sports;
        }
    }
}
