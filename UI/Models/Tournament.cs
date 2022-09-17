namespace UI.Models
{
    public class Tournament
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? translation { get; set; }
        public int sportId { get; set; }
        public int countryId { get; set; }
        public int preMatch { get; set; }
        public int live { get; set; }
        public object? meetingDate { get; set; }
    }
}
