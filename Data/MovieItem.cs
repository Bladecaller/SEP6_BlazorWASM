using System.Collections.Generic;
public class MovieItem
{
    public string Title { get; set; }
    public string release_Date {get; set; }
    public string original_language {get; set; }
    public double popularity {get; set;}
    public string poster_path {get; set;}
    public string fullImagePath {get; set;}
    public bool favorite {get; set; }
    public bool notFavorite {get; set; }

}

    public class Root
    {
        public int page { get; set; }
        public List<MovieItem> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
