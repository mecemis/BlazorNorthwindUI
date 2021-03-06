#pragma checksum "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96b864f13518ca75bfc0af8d63602de5b815cf82"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 9 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
 if (productViewModel != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "ProductDetail for ");
            __builder.AddContent(3, 
#nullable restore
#line 11 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                           productViewModel.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                      productViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                        HandleSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "PlaceHolder", "Ürün Adı");
                __builder2.AddAttribute(19, "Class", "form-control");
                __builder2.AddAttribute(20, "Id", "productName");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                                                 productViewModel.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productViewModel.ProductName = __value, productViewModel.ProductName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => productViewModel.ProductName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __Blazor.BlazorNorthwindUI.Pages.ProductDetail.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 17 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                      ()=>productViewModel.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "\r\n            ");
                __Blazor.BlazorNorthwindUI.Pages.ProductDetail.TypeInference.CreateInputNumber_1(__builder2, 32, 33, "Ürün Fiyatı", 34, "form-control", 35, "unitPrice", 36, 
#nullable restore
#line 20 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                                                      productViewModel.UnitPrice

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productViewModel.UnitPrice = __value, productViewModel.UnitPrice)), 38, () => productViewModel.UnitPrice);
                __builder2.AddMarkupContent(39, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(44);
                __builder2.AddAttribute(45, "PlaceHolder", "Açıklama");
                __builder2.AddAttribute(46, "Class", "form-control");
                __builder2.AddAttribute(47, "Id", "quantityPerUnit");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                                                     productViewModel.QuantityPerUnit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productViewModel.QuantityPerUnit = __value, productViewModel.QuantityPerUnit))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => productViewModel.QuantityPerUnit));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n            ");
                __Blazor.BlazorNorthwindUI.Pages.ProductDetail.TypeInference.CreateInputNumber_2(__builder2, 56, 57, "Stok Adedi", 58, "form-control", 59, "unitsInStock", 60, 
#nullable restore
#line 27 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                                                     productViewModel.UnitsInStock

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productViewModel.UnitsInStock = __value, productViewModel.UnitsInStock)), 62, () => productViewModel.UnitsInStock);
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "\r\n");
#nullable restore
#line 30 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
             if (categories != null)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(68, "                ");
                __Blazor.BlazorNorthwindUI.Pages.ProductDetail.TypeInference.CreateInputSelectNumber_3(__builder2, 69, 70, "form-control", 71, "categoryId", 72, 
#nullable restore
#line 32 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                                                      productViewModel.CategoryId

#line default
#line hidden
#nullable disable
                , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productViewModel.CategoryId = __value, productViewModel.CategoryId)), 74, () => productViewModel.CategoryId, 75, (__builder3) => {
                    __builder3.AddMarkupContent(76, "\r\n");
#nullable restore
#line 33 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                     foreach (var category in categories)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(77, "                        ");
                    __builder3.OpenElement(78, "option");
                    __builder3.AddAttribute(79, "value", 
#nullable restore
#line 35 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                       category.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(80, 
#nullable restore
#line 35 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                                            category.CategoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n");
#nullable restore
#line 36 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(82, "                    \r\n                ");
                }
                );
                __builder2.AddMarkupContent(83, "\r\n");
#nullable restore
#line 39 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(84, "\r\n            ");
                __Blazor.BlazorNorthwindUI.Pages.ProductDetail.TypeInference.CreateValidationMessage_4(__builder2, 85, 86, 
#nullable restore
#line 41 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
                                      ()=>productViewModel.CategoryId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n            ");
                __builder2.AddMarkupContent(89, "<button class=\"btn btn-primary\" type=\"submit\">Kaydet</button>\r\n        \r\n        \r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 49 "C:\Users\Murat\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductDetail.razor"
}

#line default
#line hidden
#nullable disable
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
namespace __Blazor.BlazorNorthwindUI.Pages.ProductDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "PlaceHolder", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "PlaceHolder", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelectNumber_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::BlazorNorthwindUI.Utilities.InputSelectNumber<T>>(seq);
        __builder.AddAttribute(__seq0, "Class", __arg0);
        __builder.AddAttribute(__seq1, "Id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
