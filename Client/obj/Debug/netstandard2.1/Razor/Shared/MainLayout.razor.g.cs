#pragma checksum "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ab2f25955f17a8bba9e55caae984f2b7381bdde"
// <auto-generated/>
#pragma warning disable 1591
namespace PeopleDB.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using PeopleDB.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using PeopleDB.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<PeopleDB.Client.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.AddMarkupContent(6, "<div class=\"top-row px-4\"><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a></div>\r\n\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "content px-4");
            __builder.AddContent(9, 
#nullable restore
#line 13 "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
