#pragma checksum "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f5676a55501b88acec5764b445e203a88c9865"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Current Count: ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/Pages/Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/Pages/Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "number");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "/Users/petersteinkamp/RiderProjects/BlazorServerApp2/Pages/Counter.razor"
                             currentCount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCount = __value, currentCount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
