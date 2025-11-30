namespace Business.DbAniTrakModels;

public class AirDay
{
    public long AirDayId {get;set;}
    public string? Name {get;set;}

    public AirDay(long AirDayId_,string? Name_)
    {
        this.AirDayId = AirDayId_;
        this.Name = Name_;
    }
}