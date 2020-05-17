#pragma checksum "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/Shared/IndividualMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c2164becaeb977a688b82488ec193b84f0516c7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerApp2.Shared
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
    public partial class IndividualMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/Shared/IndividualMovie.razor"
 
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }
    private string MovieURL = string.Empty;

    protected override void OnInitialized()
    {
        MovieURL = $"movie/{Movie.Id}/{Movie.Title.Replace(" ","-")}";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
