using Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace DataPolling
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private const string folder = @"C:\Temp\";

        private readonly RestClient _Client;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _Client = new RestClient("http://affiliate-feed.petfre.sgp.bet/");
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                var sportsString=PollSports();
                var sports = JsonConvert.DeserializeObject<SportsData>(sportsString);

                var countriesString = PollCountries();
                var countries = JsonConvert.DeserializeObject<CountriesData>(countriesString);
                
                var tournamentsString = PollTournaments(sports.Sports.Select(x=> x.Id).ToList());
                var tournaments = JsonConvert.DeserializeObject<List<Tournament>>(tournamentsString);

                var eventsString = PollEvents(tournaments.Select(x => x.Id).ToList());
                var events = JsonConvert.DeserializeObject<List<Event>>(eventsString);

                //var marketsString = PollMarkets(events.Select(x => x.Id).ToList());
                //var markets = JsonConvert.DeserializeObject<List<Market>>(eventsString);

                await Task.Delay(1000*30, stoppingToken);
            }
        }

        private string PollSports()
        {
            var request = new RestRequest("1/sports?languageCode=en");
            string fileName = "sports.json";
            var response = _Client.Execute(request);
            File.WriteAllText(folder+ fileName, response.Content);
            return response.Content;
        }

        private string PollCountries()
        {
            var request = new RestRequest("1/countries?languageCode=en");
            string fileName = "countries.json";
            var response = _Client.Execute(request);
            File.WriteAllText(folder + fileName, response.Content);
            return response.Content;
        }

        private string PollTournaments(List<int> sportIds)
        {
            string fileName = "tournaments.json";
            var tournamentsList= new List<Tournament>();
            var content = string.Empty;
            foreach (var sportId in sportIds)
            { 
                var request = new RestRequest($"1/sports/{sportId}/tournaments?languageCode=en");
                var response = _Client.Execute(request);
                var tournaments = JsonConvert.DeserializeObject<TournamentsData>(response.Content);
                tournamentsList.AddRange(tournaments.Tournaments);
            }
            content = JsonConvert.SerializeObject(tournamentsList);
            File.WriteAllText(folder + fileName, content);
            return content;
        }

        private string PollEvents(List<int> tournamentIds)
        {
            string fileName = "events.json";
            var eventList = new List<Event>();
            var content = string.Empty;
            foreach (var tournamentId in tournamentIds)
            {
                var request = new RestRequest($"1/tournaments/{tournamentId}/events?status=2&languageCode=en");
                var response = _Client.Execute(request);
                var events = JsonConvert.DeserializeObject<EventsData>(response.Content);
                eventList.AddRange(events.Events);
            }
            content = JsonConvert.SerializeObject(eventList);
            File.WriteAllText(folder + fileName, content);
            return content;
        }

        //private string PollMarkets(List<int> eventIds)
        //{
        //    string fileName = "events.json";
        //    var marketList = new List<Market>();
        //    var content = string.Empty;
        //    foreach (var eventId in eventIds)
        //    {
        //        var request = new RestRequest($"1/events/{eventId}/markets?languageCode=en");
        //        var response = _Client.Execute(request);
        //        if (response != null)
        //        { 
        //            var markets = JsonConvert.DeserializeObject<MarketsData>(response.Content);
        //            marketList.AddRange(markets.Markets);
        //        }
        //    }
        //    content = JsonConvert.SerializeObject(marketList);
        //    File.WriteAllText(folder + fileName, content);
        //    return content;
        //}
    }
}