using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

public class SingletonService{
    private string searchInput;
    public string GetSearchInput(){
        return searchInput;
    }
    public void SetSearchInput(string s){
        searchInput = s;
    }
}