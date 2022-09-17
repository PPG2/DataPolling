using RestSharp;
using System.Net.Http;

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
                PollSports();
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
    }
}