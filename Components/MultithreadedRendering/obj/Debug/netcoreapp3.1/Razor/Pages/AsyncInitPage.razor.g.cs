#pragma checksum "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\Pages\AsyncInitPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cdbf3badd3017037e70384d375c3a28539aae46"
// <auto-generated/>
#pragma warning disable 1591
namespace MultithreadedRendering.Pages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/async-init")]
    public partial class AsyncInitPage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Components with asynchronous OnInitializedAsync()</h1>\n");
#nullable restore
#line 4 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\Pages\AsyncInitPage.razor"
 for (int i = 0; i < 5; i++)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "\t");
            __builder.OpenComponent<global::MultithreadedRendering.Shared.AsynchronousInitComponent>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
#nullable restore
#line 7 "D:\Project-Sample\blazor-university-master\src\Components\MultithreadedRendering\Pages\AsyncInitPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
