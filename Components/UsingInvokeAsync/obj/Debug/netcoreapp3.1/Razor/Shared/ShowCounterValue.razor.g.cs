#pragma checksum "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\Shared\ShowCounterValue.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbc1257613d88fb200953d68951570f07d56053f"
// <auto-generated/>
#pragma warning disable 1591
namespace UsingInvokeAsync.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\_Imports.razor"
using UsingInvokeAsync;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\_Imports.razor"
using UsingInvokeAsync.Shared;

#line default
#line hidden
#nullable disable
    public partial class ShowCounterValue : global::Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n\tCounter value is: ");
#nullable restore
#line 3 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\Shared\ShowCounterValue.razor"
__builder.AddContent(2, CounterState.Value);

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, " at ");
#nullable restore
#line 3 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\Shared\ShowCounterValue.razor"
__builder.AddContent(4, DateTime.UtcNow.ToString("HH:mm:ss"));

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\Shared\ShowCounterValue.razor"
 
	private System.Threading.Timer Timer;

	protected override void OnInitialized()
	{
		base.OnInitialized();
		Timer = new System.Threading.Timer(_ =>
		{
			InvokeAsync(StateHasChanged);
		}, null, 500, 500);
	}

	void IDisposable.Dispose()
	{
		Timer?.Dispose();
		Timer = null;
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591