#pragma checksum "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\Shared\IncrementCounter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bdaeea7d5cd8db0576dc90e49d092dac304e5b5"
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
    public partial class IncrementCounter : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div>\n\tIncrementing...\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\Project-Sample\blazor-university-master\src\Components\UsingInvokeAsync\Shared\IncrementCounter.razor"
 
	[Parameter]
	public bool ShouldUseInvokeAsync { get; set; }

	[Parameter]
	public System.Threading.WaitHandle Trigger { get; set; }

	protected override void OnInitialized()
	{
		var thread = new System.Threading.Thread(_ =>
		{
			Trigger.WaitOne();
			for (int i = 0; i < 1000; i++)
			{
				if (!ShouldUseInvokeAsync)
				{
					CounterState.Value++;
				}
				else
				{
					InvokeAsync(() => CounterState.Value++);
				}
			}
		});

		thread.Start();
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
