// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PassingPlaceholdersToRenderFragments.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\_Imports.razor"
using PassingPlaceholdersToRenderFragments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\_Imports.razor"
using PassingPlaceholdersToRenderFragments.Shared;

#line default
#line hidden
#nullable disable
    public partial class PagedDataList<TItem> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\Shared\PagedDataList.razor"
 
  [Parameter]
  public int Page { get; set; }
  [Parameter]
  public EventCallback<int> PageChanged { get; set; }

  [Parameter]
  public int ItemsPerPage { get; set; }

  [Parameter]
  public IEnumerable<TItem> Data { get; set; }

  [Parameter]
  public RenderFragment<TItem> ItemTemplate { get; set; }

  [Parameter]
  public RenderFragment<RenderFragment> ListTemplate { get; set; }

  public bool CanGoToPreviousPage => Page > 0;
  public bool CanGoToNextPage => Page < LastPageIndex;

  private IEnumerable<TItem> CheckedData => Data ?? Array.Empty<TItem>();
  private int LastPageIndex => CheckedData.Count() / ItemsPerPage;

  private IEnumerable<TItem> CurrentPage =>
	  CheckedData.Skip(Page * ItemsPerPage).Take(ItemsPerPage);

  protected override void OnParametersSet()
  {
	  if (ItemsPerPage < 1)
		  ItemsPerPage = 5;

	  if (Page < 0)
		  Page = 0;

	  if (Page > LastPageIndex)
		  Page = LastPageIndex;

	  if (ItemTemplate == null)
	  {
		  ItemTemplate = (item) => 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(0, "\t\t\t");
            __builder2.OpenElement(1, "li");
            __builder2.AddAttribute(2, "@key", "item");
#nullable restore
#line 67 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\Shared\PagedDataList.razor"
__builder2.AddContent(3, item.ToString());

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
            __builder2.AddMarkupContent(4, "\n");
        }
#nullable restore
#line 68 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\Shared\PagedDataList.razor"
		  ;
	  }

	  if (ListTemplate == null)
	  {
		  ListTemplate = _ => 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(5, "\t\t\t");
            __builder2.OpenElement(6, "ul");
            __builder2.AddMarkupContent(7, "\n");
#nullable restore
#line 75 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\Shared\PagedDataList.razor"
                 foreach(TItem item in CurrentPage)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\Shared\PagedDataList.razor"
__builder2.AddContent(8, ItemTemplate(item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\Shared\PagedDataList.razor"
                                       
				}

#line default
#line hidden
#nullable disable
            __builder2.AddMarkupContent(9, "\n\t\t\t");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(10, "\n");
            __builder2.AddMarkupContent(11, "\n");
        }
#nullable restore
#line 81 "C:\Users\CASTADERER-LENOVO\Source\Repos\Blazor.Samples\TemplatedComponents\PassingPlaceholdersToRenderFragments\Shared\PagedDataList.razor"
		;
	  }
  }

  public Task GoToPreviousPageAsync()
  {
	  if (!CanGoToPreviousPage)
		  throw new InvalidOperationException();
	  Page--;
	  return PageChanged.InvokeAsync(Page);
  }

  public Task GoToNextPageAsync()
  {
	  if (!CanGoToNextPage)
		  throw new InvalidOperationException();
	  Page++;
	  return PageChanged.InvokeAsync(Page);
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
