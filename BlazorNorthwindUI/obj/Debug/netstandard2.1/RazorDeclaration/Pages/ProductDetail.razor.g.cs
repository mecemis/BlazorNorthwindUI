#pragma checksum "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96b864f13518ca75bfc0af8d63602de5b815cf82"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorNorthwindUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using BlazorNorthwindUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using BlazorNorthwindUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
using BlazorNorthwindUI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
using BlazorNorthwindUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
using BlazorNorthwindUI.Utilities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productdetail/{productId:int}")]
    public partial class ProductDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
       
    [Parameter]
    public int ProductId { get; set; }

    ProductViewModel productViewModel;
    Category[] categories;

    protected override async Task OnInitializedAsync()
    {
        productViewModel = await ProductService.GetProductById(ProductId);
        categories = await CategoryService.GetCategories();
    }
    private void HandleSave()
    {
        ProductService.Save(productViewModel);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
