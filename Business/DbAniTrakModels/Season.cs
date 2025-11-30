namespace Business.DbAniTrakModels;

public class Season
{
    public long SeasonId {get;set;}
    public string? Name {get;set;}

    public Season(long SeasonId_,string? Name_)
    {
        this.SeasonId = SeasonId_;
        this.Name = Name_;
    }
}