#pragma checksum "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\Shared\SynchronousInitComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "177734c4a1780fccf1c19f31de58f39b00cb2e55"
// <auto-generated/>
#pragma warning disable 1591
namespace MultithreadedRendering.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\_Imports.razor"
using MultithreadedRendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\_Imports.razor"
using MultithreadedRendering.Shared;

#line default
#line hidden
#nullable disable
    public partial class SynchronousInitComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Sync rendered by thread ");
#nullable restore
#line 1 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\Shared\SynchronousInitComponent.razor"
__builder.AddContent(2, IdOfRenderingThread);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\Shared\SynchronousInitComponent.razor"
 
	int IdOfRenderingThread;

	protected override void OnInitialized()
	{
		base.OnInitialized();
		IdOfRenderingThread = System.Threading.Thread.CurrentThread.ManagedThreadId;
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
