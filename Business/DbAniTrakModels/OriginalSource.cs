namespace Business.DbAniTrakModels;

public class OriginalSource
{
    public long OriginalSourceId {get;set;}
    public string? Name {get;set;}

    public OriginalSource(long OriginalSourceId_,string? Name_)
    {
        this.OriginalSourceId = OriginalSourceId_;
        this.Name = Name_;
    }
}