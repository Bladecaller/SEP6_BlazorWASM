#pragma checksum "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f4095a1ca88b8a665cffb451195cacae1b6ffe"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASM.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-sm navbar-dark bg-dark");
            __builder.AddAttribute(2, "b-69rflur3ak");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                 Rerender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "navbar-brand");
            __builder.AddAttribute(6, "href", 
#nullable restore
#line 4 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                                      IndexPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "b-69rflur3ak");
            __builder.AddMarkupContent(8, @"<svg height=""130"" width=""185"" b-69rflur3ak><defs b-69rflur3ak><linearGradient id=""grad1"" x1=""0%"" y1=""100%"" x2=""100%"" y2=""50%"" b-69rflur3ak><stop offset=""0%"" style=""stop-color:rgb(198 13 13);"" b-69rflur3ak></stop>
            <stop offset=""100%"" style=""stop-color:rgb(251 239 16);"" b-69rflur3ak></stop></linearGradient></defs>
    <ellipse cx=""100"" cy=""70"" rx=""85"" ry=""55"" fill=""url(#grad1)"" b-69rflur3ak></ellipse>
    <text fill=""#ffffff"" font-size=""25"" font-family=""Verdana"" x=""50"" y=""86"" b-69rflur3ak>Group 9</text></svg>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "navbar-toggler");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-69rflur3ak");
            __builder.AddMarkupContent(14, "<span class=\"navbar-toggler-icon\" b-69rflur3ak></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", (
#nullable restore
#line 17 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                 NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " navbar-collapse");
            __builder.AddAttribute(18, "b-69rflur3ak");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "style", "color:rebeccapurple");
            __builder.AddAttribute(21, "b-69rflur3ak");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                               Rerender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "nav-link");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 19 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                                                registerPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                                                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "<span class=\"oi oi-monitor\" style=\"color:red\" aria-hidden=\"true\" b-69rflur3ak></span> ");
                __builder2.AddMarkupContent(29, "<span style=\"color:red\" b-69rflur3ak>Register</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "style", "color:rebeccapurple");
            __builder.AddAttribute(33, "b-69rflur3ak");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                               Rerender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "href", 
#nullable restore
#line 24 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                                                moviePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 24 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(40, "<span class=\"oi oi-monitor\" style=\"color:red\" aria-hidden=\"true\" b-69rflur3ak></span> ");
                __builder2.AddMarkupContent(41, "<span style=\"color:red\" b-69rflur3ak>Movies</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "b-69rflur3ak");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                               Rerender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "class", "nav-link");
            __builder.AddAttribute(48, "href", 
#nullable restore
#line 29 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                                                randomPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(50, "<span class=\"oi oi-star\" style=\"color:red\" aria-hidden=\"true\" b-69rflur3ak></span> ");
                __builder2.AddMarkupContent(51, "<span style=\"color:red\" b-69rflur3ak>Random</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "b-69rflur3ak");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(55);
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                               Rerender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "class", "nav-link");
            __builder.AddAttribute(58, "href", 
#nullable restore
#line 34 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                                                myListPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(60, "<span class=\"oi oi-list-rich\" style=\"color:red\" aria-hidden=\"true\" b-69rflur3ak></span> ");
                __builder2.AddMarkupContent(61, "<span style=\"color:red\" b-69rflur3ak>My list</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "a");
            __builder.AddAttribute(64, "b-69rflur3ak");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(65);
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                               Rerender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "class", "nav-link");
            __builder.AddAttribute(68, "href", 
#nullable restore
#line 39 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                                                actorPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(70, "<span class=\"oi oi-star\" style=\"color:red\" aria-hidden=\"true\" b-69rflur3ak></span> ");
                __builder2.AddMarkupContent(71, "<span style=\"color:red\" b-69rflur3ak>Actors</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.AddMarkupContent(73, @"<div class=""dropdown show"" b-69rflur3ak><a class=""btn btn-secondary dropdown-toggle"" href=""#"" role=""button"" b-69rflur3ak>
                Genre
            </a>
            <div class=""dropdown-menu"" b-69rflur3ak><a class=""dropdown-item"" href=""#"" b-69rflur3ak>Action</a>
                <a class=""dropdown-item"" href=""#"" b-69rflur3ak>Drama</a>
                <a class=""dropdown-item"" href=""#"" b-69rflur3ak>Comedy</a>
                <a class=""dropdown-item"" href=""#"" b-69rflur3ak>Fuck</a></div></div>
        ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "b-69rflur3ak");
            __builder.OpenElement(76, "p");
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                          Rerender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "b-69rflur3ak");
            __builder.AddContent(79, "Display name = ");
            __builder.AddContent(80, 
#nullable restore
#line 55 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                                    searchInput.displayName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "class", "form-control mr-sm-2");
            __builder.AddAttribute(84, "type", "search");
            __builder.AddAttribute(85, "placeholder", "Is this working?");
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                          InputValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InputValue = __value, InputValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(88, "b-69rflur3ak");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                              SetValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "class", "btn btn-outline-light my-2 my-sm-3");
            __builder.AddAttribute(93, "type", "submit");
            __builder.AddAttribute(94, "b-69rflur3ak");
            __builder.AddContent(95, "Find");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
       
    public string InputValue { get; set; }

    public string IndexPath {get; set;}
    public string registerPath {get; set;}
    public string moviePath {get; set;}
    public string actorPath {get; set;}
    public string myListPath {get; set;}
    public string randomPath {get; set;}
    private bool collapseNavMenu = true;
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    private void Rerender(){
        StateHasChanged();
    }
    private void SetValue(){
        searchInput.searchInput = InputValue;
        Console.WriteLine("Value has been set to " + searchInput.searchInput);
    }
    protected override void OnInitialized(){
        Uri localHost = new Uri("https://localhost:5001/");
        if(client.BaseAddress == localHost ){
            IndexPath = "/";
            registerPath = "/register";
            moviePath = "/movieSearch";
            actorPath = "/actorSearch";
            myListPath = "/myList";
            randomPath = "/random";
        } else{
            IndexPath = "/SEP6_BlazorWASM/";
            registerPath = "/SEP6_BlazorWASM/register";
            moviePath = "/SEP6_BlazorWASM/movieSearch";
            actorPath = "/SEP6_BlazorWASM/actorSearch";
            myListPath = "/SEP6_BlazorWASM/myList";
            randomPath = "/SEP6_BlazorWASM/random";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SingletonService searchInput { get; set; }
    }
}
#pragma warning restore 1591
