#pragma checksum "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5d2a991c87b68dc48ccdca9777f77fded4eaccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5d2a991c87b68dc48ccdca9777f77fded4eaccd", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Product List (Admin)";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Products</h2>\r\n\r\n<table cellpadding=\"20\">\r\n");
#nullable restore
#line 9 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Admin\Index.cshtml"
     foreach (Product prod in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 222, "\"", 267, 2);
            WriteAttributeValue("", 229, "../Product/ProductInfo/", 229, 23, true);
#nullable restore
#line 13 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Admin\Index.cshtml"
WriteAttributeValue("", 252, prod.productId, 252, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Admin\Index.cshtml"
                                                            Write(prod.productName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 347, "\"", 387, 2);
            WriteAttributeValue("", 354, "../Admin/EditForm/", 354, 18, true);
#nullable restore
#line 16 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Admin\Index.cshtml"
WriteAttributeValue("", 372, prod.productId, 372, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Edit</a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 475, "\"", 515, 2);
            WriteAttributeValue("", 482, "/admin/deleteform/", 482, 18, true);
#nullable restore
#line 19 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Admin\Index.cshtml"
WriteAttributeValue("", 500, prod.productId, 500, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"");
            BeginWriteAttribute("id", " id=\"", 539, "\"", 559, 1);
#nullable restore
#line 19 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Admin\Index.cshtml"
WriteAttributeValue("", 544, prod.productId, 544, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table><br /><br/>

<a type=""button"" class=""btn btn-primary"" href=""/admin/createform"" >Add a new product</a>




<!--
<div class=""modal modal-danger fade"" id=""delete"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p class=""text-center"">
                    Are you sure you want to delete this item?
                </p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                <button type=""submit"" id=""response"" class=""btn b");
            WriteLiteral("tn-danger\" onclick=\"deleteItem()\">Delete</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    function deleteItem() {\r\n\r\n    }\r\n</script>\r\n\r\n    -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
