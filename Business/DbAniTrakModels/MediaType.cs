namespace Business.DbAniTrakModels;

public class MediaType
{
    public long MediaTypeId {get;set;}
    public string? Name {get;set;}

    public MediaType(long MediaTypeId_,string? Name_)
    {
        this.MediaTypeId = MediaTypeId_;
        this.Name = Name_;
    }
}