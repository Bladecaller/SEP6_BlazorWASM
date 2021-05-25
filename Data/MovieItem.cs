using System.Collections.Generic;
public class MovieItem
{
    public string Title { get; set; }
    public string release_Date {get; set; }
    public string original_language {get; set; }
    public double popularity {get; set;}
    public string poster_path {get; set;}
    public string fullImagePath {get; set;}
    public int PersonalRate {get; set; }

}

    public class Root
    {
        public int page { get; set; }
        public IEnumerable<MovieItem> results { get; set; }

    public IEnumerable<ActorItem> items { get; set; }

    public int total_pages { get; set; }
        public int total_results { get; set; }
    }
