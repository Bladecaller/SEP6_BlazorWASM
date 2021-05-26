#pragma checksum "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caae08f22213a4e7e63267bc633673718ebebfb3"
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
            __builder.AddMarkupContent(0, "<h1>ActorSearch</h1>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
                  Refresh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "UpdateSearch");
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
 if (actors == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Search for an actor</em></p>");
#nullable restore
#line 11 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "<thead><tr style=\"color:antiquewhite\"><th>Name</th>\r\n                <th>Popularity</th></tr></thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 24 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
             foreach (ActorItem actorItem in actors)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.AddAttribute(10, "style", "color:antiquewhite");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 27 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\ActorSearch.razor"
                         actorItem.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "        \r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
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
       
    async Task Refresh()
    {
        if(actorInput.GetSearchInput() != null ){
        groot = await client.GetFromJsonAsync<Groot>("https://api.themoviedb.org/3/search/person?api_key="+ apiKey + "&query=" + actorInput.GetSearchInput());
        actors = groot.results;
        }
    StateHasChanged();
    }
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
