#pragma checksum "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\Components\PersonView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1fa0a0b4f0dd4ec9e88d43efd00789c21e1da97"
// <auto-generated/>
#pragma warning disable 1591
namespace LiteralsExpressionsAndDirectives.Components
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
    public partial class PersonView : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\n\t");
            __builder.AddMarkupContent(3, "<div class=\"col-2\">Salutation</div>\n\t");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-10");
#nullable restore
#line 3 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\Components\PersonView.razor"
__builder.AddContent(6, Person?.Salutation);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\n\t");
            __builder.AddMarkupContent(12, "<div class=\"col-2\">Given name</div>\n\t");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-10");
#nullable restore
#line 7 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\Components\PersonView.razor"
__builder.AddContent(15, Person?.GivenName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
            __builder.CloseElement();
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "row");
            __builder.AddMarkupContent(19, "\n\t");
            __builder.AddMarkupContent(20, "<div class=\"col-2\">Family name</div>\n\t");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-10");
#nullable restore
#line 10 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\Components\PersonView.razor"
__builder.AddContent(23, Person?.FamilyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\Project-Sample\blazor-university-master\src\Components\LiteralsExpressionsAndDirectives\Components\PersonView.razor"
 
  [Parameter]
  public Person Person { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
