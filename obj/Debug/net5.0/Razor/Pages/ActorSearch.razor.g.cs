#pragma checksum "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "937296ba9b3fd3c9c258fe8257290cc912ea919c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using BlazorWASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using BlazorWASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actorSearch")]
    public partial class ActorSearch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>ActorSearch</h1>");
#nullable restore
#line 8 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
 if (actors == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Search for an actor</em></p>");
#nullable restore
#line 11 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Name</th>\r\n                <th>Popularity</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 24 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
             foreach (ActorItem actorItem in actors)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 27 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
                         actorItem.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "        \r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 28 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
                         actorItem.popularity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
       
    private string apiKey = "72d7decec4b08474aef457cd18c51628";
    private ActorItem actor;
    private Groot groot;
    private IEnumerable<ActorItem> actors;
    protected override async Task OnInitializedAsync()
    {
        if (actorInput.GetSearchInput() != null)
        {
            groot = await client.GetFromJsonAsync<Groot>("https://api.themoviedb.org/3/search/person?api_key="+ apiKey +"&query=" + actorInput.GetSearchInput());
            actors = groot.results;
            //foreach (ActorItem actor in actors)
            //{
            //    actor.file_path = "" + actor.file_path;
            //}

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SingletonService actorInput { get; set; }
    }
}
#pragma warning restore 1591
