#pragma checksum "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e28baf3f66c914c6849ef3a2f1bed8f251b73c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_ShowItem), @"mvc.1.0.view", @"/Views/Basket/ShowItem.cshtml")]
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
#line 1 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e28baf3f66c914c6849ef3a2f1bed8f251b73c9", @"/Views/Basket/ShowItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef499bc641b395c15c4ec72c4f836c4ebb7b5c6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Basket_ShowItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
  
    ViewData["Title"] = "ShowItem";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int count = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
         if (Model.Count()>0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">No</th>
      <th scope=""col"">Image</th>
      <th scope=""col"">Name</th>
      <th scope=""col"">Price</th>
         <th scope=""col"">Quantity</th>
           <th scope=""col"">Total</th>
    
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 26 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
    foreach (var item in Model)
     {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n      <th scope=\"row\">");
#nullable restore
#line 30 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
                 Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e28baf3f66c914c6849ef3a2f1bed8f251b73c95760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 683, "~/img/", 683, 6, true);
#nullable restore
#line 31 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
AddHtmlAttributeValue("", 689, item.ImageUrl, 689, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 32 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 33 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
           Write(item.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 35 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
              Write(item.Price*item.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 37 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n  </tbody>\r\n            </table>\r\n");
#nullable restore
#line 41 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e28baf3f66c914c6849ef3a2f1bed8f251b73c98909", async() => {
                WriteLiteral("Go to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\asus\Source\Repos\FrontToBackq\FrontToBack\FrontToBack\Views\Basket\ShowItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
