// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OptionalRouteParameters.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Routing\OptionalRouteParameters\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Routing\OptionalRouteParameters\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Routing\OptionalRouteParameters\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Routing\OptionalRouteParameters\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Routing\OptionalRouteParameters\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Routing\OptionalRouteParameters\_Imports.razor"
using OptionalRouteParameters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Routing\OptionalRouteParameters\_Imports.razor"
using OptionalRouteParameters.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/counter/{CurrentCount:int}")]
    public partial class Counter : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Routing\OptionalRouteParameters\Pages\Counter.razor"
       
	[Parameter]
	public int? CurrentCount { get; set; }

	void IncrementCount()
	{
		CurrentCount++;
	}

	protected override void OnInitialized()
	{
		base.OnInitialized();
		CurrentCount = CurrentCount ?? 1;
	}

	string GetStyle()
	{
		string style = "padding:4px";
		if (CurrentCount == null)
			return style + ";background-color:red;color:white";
		if (CurrentCount == 1)
			return style + ";background-color:green;color:white";
		return style;
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
