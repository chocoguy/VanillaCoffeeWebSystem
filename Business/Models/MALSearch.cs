namespace Business.Models;
//Applies to seasonal anime too
public class MALSearch
{
    public List<Datum> Data { get; set; } = new List<Datum>();
    public Paging Paging { get; set; } = new Paging();
}

public partial class Datum
{
    public Node Node { get; set; } = new Node();
}

public partial class Node
{
    public long Id { get; set; }
    public string Title { get; set; } = "";
    public MainPicture? MainPicture { get; set; }
}

public partial class MainPicture
{
    public Uri Medium { get; set; } = new Uri("");
    public Uri? Large { get; set; }
}

public partial class Paging
{
    public Uri Next { get; set; } = new Uri("");
}