// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ComponentLifecycles.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\_Imports.razor"
using ComponentLifecycles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\_Imports.razor"
using ComponentLifecycles.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\Pages\FetchData.razor"
using ComponentLifecycles.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : EmbeddedComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\CascadingValues\ComponentLifecycles\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
