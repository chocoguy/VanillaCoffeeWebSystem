namespace Business.Models;

public partial class MALAnime
{
    public long Id { get; set; }
    public string Title { get; set; } = "";
    public Picture? MainPicture { get; set; }
    public long NumEpisodes { get; set; }
    public string? Source { get; set; }
    public string MediaType { get; set; } = "";
    public StartSeason? StartSeason { get; set; }
    public Broadcast? Broadcast { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public string? Synopsis { get; set; }
    public long? Rank { get; set; }
    public string Status { get; set; } = "";
    public List<Studio> Studios { get; set; } = new List<Studio>();
    public double Mean { get; set; }
    public Statistics? Statistics { get; set; }
    public List<Picture> Pictures { get; set; } = new List<Picture>();
}

public partial class Broadcast
{
    public string DayOfTheWeek { get; set; } = "";
    public string? StartTime { get; set; }
}

public partial class Picture
{
    public Uri Medium { get; set; } = new Uri("");
    public Uri? Large { get; set; }
}

public partial class StartSeason
{
    public long Year { get; set; } = 1960;
    public string Season { get; set; } = "winter";
}

public partial class Statistics
{
    public Status Status { get; set; } = new Status();
    public long NumListUsers { get; set; }
}

public partial class Status
{
    public long Watching { get; set; } = 0;
    public long Completed { get; set; } = 0;
    public long OnHold { get; set; } = 0;
    public long Dropped { get; set; } = 0;
    public long PlanToWatch { get; set; } = 0;
}

public partial class Studio
{
    public long Id { get; set; }
    public string Name { get; set; } = "";
}
