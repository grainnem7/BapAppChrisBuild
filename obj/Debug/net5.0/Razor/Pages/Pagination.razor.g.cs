<<<<<<< HEAD
#pragma checksum "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15784948454616a185c1954b89575595b79a3971"
=======
#pragma checksum "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ddeb0ae8bff7a5dee06e9d5d1e37a74f77c9f8b"
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5
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
#line 2 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using BapBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using BapBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
=======
#line 2 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
=======
#line 6 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 7 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
=======
#line 7 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5
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
<<<<<<< HEAD
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "<div class=\"row justify-content-center\" style=\"margin-bottom:50px\"><h3 class=\"text-center\">Pagination</h3></div>\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddAttribute(5, "style", "margin:25px;");
#nullable restore
#line 16 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
         if (StoreApps != null)
        {
=======
            __builder.AddMarkupContent(0, "<h1>Pagination</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates pagination of the dataset</p>\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                                          Previous
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(8, @"<thead class=""thead-dark""><tr><th>Id</th>
                        <th>Name</th>
                        <th>Rating</th>
                        <th>People</th>
                        <th>Category</th>
                        <th>Date</th>
                        <th>Price</th></tr></thead>
                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 33 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
                     foreach (var storeapp in StoreApps)
                    {
=======
            ));
            __builder.AddContent(5, "Previous");
            __builder.CloseElement();
            __builder.AddContent(6, "   ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                                                                                                                       Next
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Next");
            __builder.CloseElement();
#nullable restore
<<<<<<< HEAD
#line 36 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
                                 storeapp.Id
=======
#line 15 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
 if (StoreApps == null)
{
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<p><em>Loading...</em></p>");
#nullable restore
<<<<<<< HEAD
#line 37 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
                                 storeapp.Name
=======
#line 18 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
}
else

{
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 38 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
                                 storeapp.Rating
=======
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "<thead><tr><th>Id</th>\r\n                <th>Name</th>\r\n                <th>Rating</th>\r\n                <th>People</th>\r\n                <th>Category</th>\r\n                <th>Date</th>\r\n                <th>Price</th></tr></thead>\r\n        ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 36 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
             foreach (var storeapp in StoreApps)
            {
                if (StoreApps.IndexOf(storeapp) >= pageStart && StoreApps.IndexOf(storeapp) < pageEnd)
                {
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 39 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
                                 storeapp.People
=======
            __builder.OpenElement(16, "tr");
            __builder.AddAttribute(17, "class", "justify-content-center");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 41 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                             storeapp.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 42 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                             storeapp.Name
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
<<<<<<< HEAD
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 40 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
                                 storeapp.Category
=======
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 43 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                             storeapp.Rating
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
<<<<<<< HEAD
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 41 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
                                 storeapp.Date
=======
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 44 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                             storeapp.People
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
<<<<<<< HEAD
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 42 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
                                 storeapp.Price
=======
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 45 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                             storeapp.Category
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
            );
<<<<<<< HEAD
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
                    }
=======
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 46 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                             storeapp.Date
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
         if (!StoreApps.Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<div class=\"justify-content-center\"><h5>No records to show</h5></div>");
#nullable restore
#line 53 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
        }
=======
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 47 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                             storeapp.Price
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 58 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Pagination.razor"
       

    //http://localhost:5002/api/StoreApps/paged?pageNumber=1&pageSize=10

=======
#line 57 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
       
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5
    string responseBody = "";

    List<StoreApp> StoreApps = new List<StoreApp>();

    protected override async Task OnInitializedAsync()
    {
<<<<<<< HEAD
        var apiName = "api/StoreApps/";
        //var apiName = "api/StoreApps/paged?pageNumber=1&pageSize=10";
        //var apiName = "api/StoreApps/paged";
=======
        var apiName = "api/StoreApps";
>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5
        var httpResponse = await client.GetAsync(apiName);

        if (httpResponse.IsSuccessStatusCode)
        {
            responseBody = await httpResponse.Content.ReadAsStringAsync();
            StoreApps = JsonConvert.DeserializeObject<List<StoreApp>>(responseBody);
            StateHasChanged();
        }
<<<<<<< HEAD

    }

=======
    }
    private int pageStart = 0;
    private int pageEnd = 10;
    private int pagerSize = 10;

    private void Next()
    {
        pageStart += pagerSize;
        pageEnd += pagerSize;
    }

    private void Previous()
    {
        pageStart -= pagerSize;
        pageEnd -= pagerSize;

    }

>>>>>>> e4a2ca007a9ed6c16c5a0110fa0ec3aa02eb82e5
#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
