// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CustomValidation.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Forms\CustomValidation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Forms\CustomValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Forms\CustomValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Forms\CustomValidation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Forms\CustomValidation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Forms\CustomValidation\_Imports.razor"
using CustomValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Forms\CustomValidation\_Imports.razor"
using CustomValidation.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Forms\CustomValidation\_Imports.razor"
using CustomValidation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Forms\CustomValidation\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\Forms\CustomValidation\Pages\Index.razor"
       
	Person Person = new Person();

	void ValidFormSubmitted()
	{
		Person = new Person();
	}

	void InvalidFormSubmitted()
	{
		System.Diagnostics.Debug.WriteLine("User submitted an invalid form");
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
