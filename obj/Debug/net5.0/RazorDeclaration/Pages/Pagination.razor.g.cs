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
#line 2 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using BapBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using BapBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
using Microsoft.Extensions.Logging;

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
#line 76 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
       


    private SearchModel searchModel = new();

    private void SearchStore()
    {
        Logger.LogInformation("SearchStore called");
        Logger.LogInformation(searchModel.Name);
    }

    public void EnterSearch()
    {
        GetSearch(searchModel.Name);
    }

    public async Task GetSearch(string search)
    {
        var apiName = "api/StoreApps/Search?searchTerm=" + search;

        var httpResponse = await client.GetAsync(apiName);

        if (httpResponse.IsSuccessStatusCode)
        {
            responseBody = await httpResponse.Content.ReadAsStringAsync();

            StoreApps = JsonConvert.DeserializeObject<List<StoreApp>>(responseBody);

            StateHasChanged();
        }
    }


    private string responseBody = "";
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

            foreach (var storeapp in StoreApps)
            {
                String sourceDate = storeapp.Date;
                DateTime dateNew = DateTime.Parse(storeapp.Date);
                string formatted = dateNew.ToString("yyyy-MM-dd");
                storeapp.Date = formatted;
            }

            StoreApps = StoreApps.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x)).ToList();
        }
        else
        {
            foreach (var storeapp in StoreApps)
            {
                String sourceDate = storeapp.Date;
                DateTime dateNew = DateTime.Parse(storeapp.Date);
                string formatted = dateNew.ToString("yyyy-MM-dd");
                storeapp.Date = formatted;
            }
            StoreApps = StoreApps.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x)).ToList();
        }

        IsSortedAscending = !IsSortedAscending;

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Search> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
