namespace Business.DbAniTrakModels;

public class User
{
    public long UserId {get;set;}
    public string Username {get;set;}
    public DateTime? CreatedAt {get;set;}
    public DateTime LastSync {get;set;}
    public string? AuthZeroId {get;set;}
    public string? Pfp {get;set;}

    public User(long UserId_,string Username_,DateTime? CreatedAt_,DateTime LastSync_,string? AuthZeroId_,string? Pfp_)
    {
        this.UserId = UserId_;
        this.Username = Username_;
        this.CreatedAt = CreatedAt_;
        this.LastSync = LastSync_;
        this.AuthZeroId = AuthZeroId_;
        this.Pfp = Pfp_;
    }
}