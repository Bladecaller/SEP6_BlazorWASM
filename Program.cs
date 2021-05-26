using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BlazorWASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddSingleton<SingletonService>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddCors(policy =>{
                policy.AddDefaultPolicy(builder => builder.AllowAnyOrigin());
           // policy.AddPolicy("https://ptsv2.com/t/nrph0-1622069235", builder => builder.AllowAnyOrigin()
           // .AllowAnyMethod()
           // .AllowAnyHeader()
           // .AllowCredentials());
            });
            await builder.Build().RunAsync();
        }
    }
}
