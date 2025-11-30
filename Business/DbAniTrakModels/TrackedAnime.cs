namespace Business.DbAniTrakModels;

public class TrackedAnime
{
    public long TrackedAnimeId {get;set;}
    public User User {get;set;}
    public Anime Anime {get;set;}
    public WatchStatus WatchStatus {get;set;}
    public DateTime? StartedWatching {get;set;}
    public DateTime? StoppedWatching {get;set;}
    public DateTime? LastWatched {get;set;}
    public int EpisodesWatched {get;set;}
    public DateTime LastModified {get;set;}
    public bool IsDeleted {get;set;}
    public decimal? Progress {get;set;}
    public int TimeWatchedMins {get;set;}

    public TrackedAnime(long TrackedAnimeId_,User User_,Anime Anime_,WatchStatus WatchStatus_,DateTime? StartedWatching_,DateTime? StoppedWatching_,DateTime? LastWatched_,int EpisodesWatched_,DateTime LastModified_,bool IsDeleted_,decimal? Progress_,int TimeWatchedMins_)
    {
        this.TrackedAnimeId = TrackedAnimeId_;
        this.User = User_;
        this.Anime = Anime_;
        this.WatchStatus = WatchStatus_;
        this.StartedWatching = StartedWatching_;
        this.StoppedWatching = StoppedWatching_;
        this.LastWatched = LastWatched_;
        this.EpisodesWatched = EpisodesWatched_;
        this.LastModified = LastModified_;
        this.IsDeleted = IsDeleted_;
        this.Progress = Progress_;
        this.TimeWatchedMins = TimeWatchedMins_;
    }
}