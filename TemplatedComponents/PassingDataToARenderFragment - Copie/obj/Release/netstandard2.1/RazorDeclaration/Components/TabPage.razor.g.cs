// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PassingDataToARenderFragment.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingDataToARenderFragment - Copie\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingDataToARenderFragment - Copie\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingDataToARenderFragment - Copie\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingDataToARenderFragment - Copie\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingDataToARenderFragment - Copie\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingDataToARenderFragment - Copie\_Imports.razor"
using PassingDataToARenderFragment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingDataToARenderFragment - Copie\_Imports.razor"
using PassingDataToARenderFragment.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingDataToARenderFragment - Copie\_Imports.razor"
using PassingDataToARenderFragment.Shared;

#line default
#line hidden
#nullable disable
    public partial class TabPage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingDataToARenderFragment - Copie\Components\TabPage.razor"
       
	[CascadingParameter]
	private TabControl Parent { get; set; }

	[Parameter]
	public RenderFragment ChildContent { get; set; }

	[Parameter]
	public string Text { get; set; }

	protected override void OnInitialized()
	{
		if (Parent == null)
			throw new ArgumentNullException(nameof(Parent), "TabPage must exist within a TabControl");

		base.OnInitialized();
		Parent.AddPage(this);
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
