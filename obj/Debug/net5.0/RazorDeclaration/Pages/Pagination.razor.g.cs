// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BapBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\_Imports.razor"
using BapBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\_Imports.razor"
using BapBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\Pages\Pagination.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\Pages\Pagination.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\Pages\Pagination.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\ruper\OneDrive\Desktop\bapteam01\BapBlazor\Pages\Pagination.razor"
       
    string responseBody = "";
    private bool IsSortedAscending;
    private string CurrentSortColumn;

    List<StoreApp> StoreApps = new List<StoreApp>();

    protected override async Task OnInitializedAsync()
    {
        var apiName = "api/StoreApps";
        var httpResponse = await client.GetAsync(apiName);

        if (httpResponse.IsSuccessStatusCode)
        {
            responseBody = await httpResponse.Content.ReadAsStringAsync();
            StoreApps = JsonConvert.DeserializeObject<List<StoreApp>>(responseBody);
            StateHasChanged();
        }
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
    private void SortTable(string columnName)
    {
        //if (columnName != CurrentSortColumn)
        //{
        //    //We need to force order by descending on the new column
        //    StoreApps = StoreApps.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x)).ToList();
        //    CurrentSortColumn = columnName;
        //    IsSortedAscending = true;

        //}

        if (IsSortedAscending)
        {
            StoreApps = StoreApps.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x)).ToList();
        }
        else
        {
            StoreApps = StoreApps.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x)).ToList();
        }

        IsSortedAscending = !IsSortedAscending;

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
