#pragma checksum "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\Pages\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54d5c0110d545eb16fa4f6cfb0e05618cbb76315"
// <auto-generated/>
#pragma warning disable 1591
namespace BapBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\_Imports.razor"
using BapBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\_Imports.razor"
using BapBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\Pages\Pagination.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\Pages\Pagination.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kelvi\Desktop\bapteam01\BapBlazor\Pages\Pagination.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pagination")]
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Pagination</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates pagination of the databaset.</p>\r\n\r\n");
            __builder.AddMarkupContent(2, "<p>One way to tackle this problem;</p>\r\n");
            __builder.AddMarkupContent(3, @"<ul><li>Start with pretty much the same code as FetchStoreApps.razor.</li>
    <li>Add buttons to move between pages of records e.g. 25 records.</li>
    <li>You could take inspiration from Counter.razor (increment and decrement a number).</li>
    <li>You could use this number to control which items in your list are displayed.</li>
    <li>Problems to solve are not going beyond the end of your list and decrementing less than zero.</li></ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
