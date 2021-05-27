using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;


namespace BlazorWASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddSingleton<SingletonService>(new SingletonService{favoritesList = new List<MovieItem>()});
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddCors(policy =>{
                policy.AddDefaultPolicy(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            });
            builder.Services.AddCors(options => {
                options.AddDefaultPolicy(builder => 
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowCredentials());
            }); 
            await builder.Build().RunAsync();
        }
    }
}
