
using System.Collections.Generic;



    public class ActorItem
    {
    public string name { get; set; }

    public double popularity { get; set; }

    public string profile_path { get; set; }
    }

public class Groot
{
    public int page { get; set; }

    public IEnumerable<ActorItem> results { get; set; }

    public int total_pages { get; set; }
    public int total_results { get; set; }
}