namespace Business.DbAniTrakModels;

public class Anime
{
    public long AnimeId {get;set;}
    public string Title {get;set;}
    public int Episodes {get;set;}
    public Season Season {get;set;}
    public MediaType MediaType {get;set;}
    public OriginalSource OriginalSource {get;set;}
    public AirDay? AirDay {get;set;}
    public string? Studio {get;set;}
    public DateTime? OnAir {get;set;}
    public DateTime? OffAir {get;set;}
    public string? Sypnosis {get;set;}
    public decimal? MalScore {get;set;}
    public int? MalRank {get;set;}
    public string? Genre {get;set;}
    public string Poster {get;set;}
    public int EpisodeTimeMins {get;set;}
    public int PullCount {get;set;}
    public DateTime LastSynced {get;set;}
    public DateTime LastModified {get;set;}

    public Anime(long AnimeId_,string Title_,int Episodes_,Season Season_,MediaType MediaType_,OriginalSource OriginalSource_,AirDay? AirDay_,string? Studio_,DateTime? OnAir_,DateTime? OffAir_,string? Sypnosis_,decimal? MalScore_,int? MalRank_,string? Genre_,string Poster_,int EpisodeTimeMins_,int PullCount_, DateTime LastSynced_, DateTime LastModified_)
    {
        this.AnimeId = AnimeId_;
        this.Title = Title_;
        this.Episodes = Episodes_;
        this.Season = Season_;
        this.MediaType = MediaType_;
        this.OriginalSource = OriginalSource_;
        this.AirDay = AirDay_;
        this.Studio = Studio_;
        this.OnAir = OnAir_;
        this.OffAir = OffAir_;
        this.Sypnosis = Sypnosis_;
        this.MalScore = MalScore_;
        this.MalRank = MalRank_;
        this.Genre = Genre_;
        this.Poster = Poster_;
        this.EpisodeTimeMins = EpisodeTimeMins_;
        this.PullCount = PullCount_;
        this.LastSynced = LastSynced_;
        this.LastModified = LastModified_;
    }
}