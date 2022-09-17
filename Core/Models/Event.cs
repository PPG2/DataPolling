namespace Core.Models
{
    public class Event
    {
        public int id { get; set; }
        public string name { get; set; }
        public int sportId { get; set; }
        public int countryId { get; set; }
        public int tournamentId { get; set; }
        public string dateStart { get; set; }
        public bool isLive { get; set; }
        public bool isRacingEvent { get; set; }
        public Teams teams { get; set; }
        public RaceInfo raceInfo { get; set; }
        public bool outright { get; set; }
        public List<ParticipantInfo> participantInfo { get; set; }
    }
    public class Teams
    {
        public string home { get; set; }
        public string homeTranslation { get; set; }
        public string away { get; set; }
        public string awayTranslation { get; set; }
    }
    public class RaceInfo
    {
        public string going { get; set; }
        public bool isAntePost { get; set; }
        public string raceLength { get; set; }
        public string raceName { get; set; }
        public int raceStatus { get; set; }
    }
    public class ParticipantInfo
    {
        public int id { get; set; }
        public int eventId { get; set; }
        public bool isReserve { get; set; }
        public bool isNonRunner { get; set; }
        public string selectionName { get; set; }
        public string reserveName { get; set; }
        public string shortName { get; set; }
        public string number { get; set; }
        public string jockeyName { get; set; }
        public string draw { get; set; }
    }
}