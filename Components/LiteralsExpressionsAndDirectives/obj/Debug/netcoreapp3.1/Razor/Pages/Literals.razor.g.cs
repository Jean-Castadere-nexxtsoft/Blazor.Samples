#pragma checksum "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\Pages\Literals.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54abc8e9ef20d393c57747523e7fda6b15a38ba0"
// <auto-generated/>
#pragma warning disable 1591
namespace LiteralsExpressionsAndDirectives.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using LiteralsExpressionsAndDirectives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using LiteralsExpressionsAndDirectives.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using LiteralsExpressionsAndDirectives.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\_Imports.razor"
using LiteralsExpressionsAndDirectives.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/literals")]
    public partial class Literals : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Literals</h3>\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\n\t");
            __builder.AddMarkupContent(4, "<tr>\n\t\t<td>&lt;input size=8 /&gt;</td>\n\t\t<td><input size=\"8\"></td>\n\t</tr>\n\t");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\n\t\t");
            __builder.AddMarkupContent(7, "<td>&lt;MyHeader Text=\"Hello\" Visible=true /&gt;</td>\n\t\t");
            __builder.OpenElement(8, "td");
            __builder.AddMarkupContent(9, "\n\t\t\t");
            __builder.OpenComponent<global::LiteralsExpressionsAndDirectives.Components.MyHeader>(10);
            __builder.AddAttribute(11, "Text", "Hello");
            __builder.AddAttribute(12, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 12 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\Pages\Literals.razor"
                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
