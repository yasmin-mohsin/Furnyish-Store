#pragma checksum "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\Shared\Components\CategoryMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2448ba1ff272c6bb01fa2653b69e129fe1823226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
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
#line 1 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2448ba1ff272c6bb01fa2653b69e129fe1823226", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b9317e42a2d2da7e4eccd375bc9e60c2bd0cdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CatVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">-->\r\n");
            WriteLiteral(@"<!--<ul class=""nav navbar-nav"">
            foreach (var item in Model)
            {

                <li class=""dropdown"">

                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        item.Name
                        <span class=""caret""></span>
                    </a>
                    //


                    //
                    <ul class=""dropdown-menu"">
                        foreach (var sub in item.SubCat)
                        {
                            <li>
                                <a asp-controller=""Product""
                                   asp-action=""CatProduct""
                                   asp-route-id=""item.Id"">
                                    sub.Name
                                </a>
                            </li>

                        }
                    </ul>
                </li>

            }

        </ul>
    </div>
</nav>-->
");
#nullable restore
#line 41 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\Shared\Components\CategoryMenu\Default.cshtml"
 foreach (var item in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"grid\">\r\n<a class=\"color2\">");
#nullable restore
#line 43 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\Shared\Components\CategoryMenu\Default.cshtml"
             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n<div class=\"megapanel\">\r\n    <div class=\"row\">\r\n        <div class=\"col1\">\r\n            <div class=\"h_nav\">\r\n");
#nullable restore
#line 48 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\Shared\Components\CategoryMenu\Default.cshtml"
                 foreach (var sub in item.SubCat)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2448ba1ff272c6bb01fa2653b69e129fe18232266023", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 54 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\Shared\Components\CategoryMenu\Default.cshtml"
                   Write(sub.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\Shared\Components\CategoryMenu\Default.cshtml"
                         WriteLiteral(sub.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </h4>\r\n");
#nullable restore
#line 57 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\Shared\Components\CategoryMenu\Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        </li>\r\n");
#nullable restore
#line 63 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\Shared\Components\CategoryMenu\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CatVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591