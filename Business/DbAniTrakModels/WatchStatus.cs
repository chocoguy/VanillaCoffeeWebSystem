namespace Business.DbAniTrakModels;

public class WatchStatus
{
    public long WatchStatusId {get;set;}
    public string? Name {get;set;}

    public WatchStatus(long WatchStatusId_,string? Name_)
    {
        this.WatchStatusId = WatchStatusId_;
        this.Name = Name_;
    }
}