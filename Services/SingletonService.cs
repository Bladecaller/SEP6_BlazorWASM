using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

public class SingletonService{
    public string searchInput {get; set;}
    public string displayName {get; set;}
    public List<MovieItem> favoritesList {get; set;}
}