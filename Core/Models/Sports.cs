public class Sport
{
    public int id { get; set; }
    public string name { get; set; }
    public string translation { get; set; }
}

public class SportsData
{
    public List<Sport> Sports { get; set; }
}