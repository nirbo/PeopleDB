#pragma checksum "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee787b1b14817b444c01c29227dd1d6a359c67d5"
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
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/nbenor/dev/PeopleDB/Client/_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudLayout>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(2);
                __builder2.AddAttribute(3, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor"
                          1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudAppBarSpacer>(5);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(7);
                __builder2.AddAttribute(8, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor"
                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor"
                                      1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDrawerHeader>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(13);
                        __builder4.AddAttribute(14, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 10 "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor"
                                           Align.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(17, "PeopleDB");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudNavMenu>(19);
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(21);
                        __builder4.AddAttribute(22, "Href", "/");
                        __builder4.AddAttribute(23, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor"
                                        Icons.Material.Home

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(25, "Home");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(26, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudNavLink>(27);
                        __builder4.AddAttribute(28, "Href", "/counter");
                        __builder4.AddAttribute(29, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor"
                                               Icons.Material.Dashboard

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(31, "Dashboard");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(33);
                __builder2.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(35, 
#nullable restore
#line 18 "/Users/nbenor/dev/PeopleDB/Client/Shared/MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
