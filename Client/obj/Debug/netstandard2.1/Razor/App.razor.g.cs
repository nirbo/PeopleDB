#pragma checksum "/Users/nbenor/dev/PeopleDB/Client/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dcfc62de7b3e809ca6ebe9af780ae4e343ece73"
// <auto-generated/>
#pragma warning disable 1591
namespace PeopleDB.Client
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
using PeopleDB.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using PeopleDB.Shared.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 1 "/Users/nbenor/dev/PeopleDB/Client/App.razor"
                         darkTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<MudBlazor.Dialog.MudDialogProvider>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(7);
            __builder.AddAttribute(8, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 29 "/Users/nbenor/dev/PeopleDB/Client/App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(10);
                __builder2.AddAttribute(11, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 31 "/Users/nbenor/dev/PeopleDB/Client/App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 31 "/Users/nbenor/dev/PeopleDB/Client/App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(13, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(14);
                __builder2.AddAttribute(15, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 34 "/Users/nbenor/dev/PeopleDB/Client/App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(17);
                    __builder3.AddAttribute(18, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 35 "/Users/nbenor/dev/PeopleDB/Client/App.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Class", "ma-6");
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(21, "Sorry, I couldn\'t find any content at this location.");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/Users/nbenor/dev/PeopleDB/Client/App.razor"
       
    MudTheme darkTheme = new MudTheme() {
        Palette = new Palette() {
            Black = "#27272f",
            Background = "#32333d",
            BackgroundGrey = "#27272f",
            Surface = "#373740",
            DrawerBackground = "#27272f",
            DrawerText = "rgba(255,255,255, 0.80)",
            DrawerIcon = "rgba(255,255,255, 0.80)",
            AppbarBackground = "#27272f",
            AppbarText = "rgba(255,255,255, 0.80)",
            TextPrimary = "rgba(255,255,255, 0.80)",
            TextSecondary = "rgba(255,255,255, 0.50)",
            ActionDefault = "#adadb1",
            HoverOpacity = 0.20,
            ActionDisabled = "rgba(255,255,255, 0.26)",
            ActionDisabledBackground = "rgba(255,255,255, 0.12)",
            DividerLight = "rgba(0,0,0, 0.8)",
            Divider = "#FFFF8D",
        },
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
