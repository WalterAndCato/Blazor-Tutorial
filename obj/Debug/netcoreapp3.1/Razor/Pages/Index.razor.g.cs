#pragma checksum "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5064ca90adba3a602921a1acaf15c0984728609a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using BlazorServerApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using BlazorServerApp2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using BlazorServerApp2.Shared.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/_Imports.razor"
using BlazorServerApp2.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n ");
            __builder.AddMarkupContent(2, "<h3>Movies</h3>\n ");
            __builder.OpenComponent<BlazorServerApp2.Shared.MoviesList>(3);
            __builder.AddAttribute(4, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorServerApp2.Shared.Entities.Movie>>(
#nullable restore
#line 7 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/Pages/Index.razor"
                     movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/Pages/Index.razor"
      
 
 private List<Movie> movies;
 protected override async Task OnInitializedAsync()
 {
  
  movies = Repository.GetMovies();

 }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository Repository { get; set; }
    }
}
#pragma warning restore 1591
