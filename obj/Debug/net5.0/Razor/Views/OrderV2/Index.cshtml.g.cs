#pragma checksum "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "407342ee27b49616396d2cd0bbfd2320a4b049ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderV2_Index), @"mvc.1.0.view", @"/Views/OrderV2/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"407342ee27b49616396d2cd0bbfd2320a4b049ee", @"/Views/OrderV2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b9317e42a2d2da7e4eccd375bc9e60c2bd0cdc", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderV2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Controllers.OrderModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrderV2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("log"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("<div class=\"container\">\n    <ol class=\"breadcrumb\">\n        <li><a href=\"index.html\">Home</a></li>\n        <li class=\"active\">Order</li>\n    </ol>\n\n");
            WriteLiteral("    <div class=\"registration\">\n        <h2>Complete Order</h2>\n        <div class=\"registration_form\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "407342ee27b49616396d2cd0bbfd2320a4b049ee4890", async() => {
                WriteLiteral(@"
                <div>
                    <label>
                        <input placeholder=""first name:"" type=""text"" tabindex=""1"" required autofocus name=""FirstName"" style=""width:50%"">
                    </label>
                </div>
                <div>
                    <label>
                        <input placeholder=""last name:"" type=""text"" tabindex=""2"" required autofocus name=""LastName"" style=""width:50%"">
                    </label>
                </div>
                <div>
                    <label>
                        <input placeholder=""Mobile:"" type=""tel"" tabindex=""3"" required name=""PhoneNumber"" style=""width:50%"">
                    </label>
                </div>

");
                WriteLiteral("                <div class=\"contact-right\">\n                    <h5>Address:</h5>\n                    <div>\n                        <label class=\"ml-2\">\n                            <input class=\"form-control mb-2 mr-sm-2\" name=\"State\"");
                BeginWriteAttribute("autofocus", " autofocus=\"", 1450, "\"", 1462, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1463, "\"", 1474, 0);
                EndWriteAttribute();
                WriteLiteral(@" tabindex=""1"" type=""text"" placeholder=""State:"" style=""margin-left:20px;"">
                        </label>
                    </div>
                    <div>
                        <label>
                            <input placeholder=""City:"" type=""text"" tabindex=""2""");
                BeginWriteAttribute("required", " required=\"", 1746, "\"", 1757, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 1758, "\"", 1770, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""City"" class=""form-control mb-2 mr-sm-2"" style=""margin-left:20px;"">
                        </label>
                    </div>
                    <div>
                        <label>
                            <input placeholder=""Street:"" type=""text"" tabindex=""3""");
                BeginWriteAttribute("required", " required=\"", 2044, "\"", 2055, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"Address\" class=\"form-control mb-3 mr-sm-2\" style=\"margin-left:20px;\">\n                        </label>\n                    </div>\n                </div>\n\n");
                WriteLiteral("                <h5>Order Details:</h5>\n                <div class=\"item-list\">\n                    <ul>\n");
#nullable restore
#line 55 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml"
                         foreach (var item in Model.shoppingProducts)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\n                                <h5>");
#nullable restore
#line 58 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml"
                               Write(item.product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                                <ul>\n                                    <li><h5>Price: ");
#nullable restore
#line 60 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml"
                                              Write(item.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></li>\n                                    <li><h5>Discount:");
#nullable restore
#line 61 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml"
                                                Write(item.product.Discount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></li>\n                                    <li><h5>Count: ");
#nullable restore
#line 62 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml"
                                              Write(item.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></li>\n                                </ul>\n                            </li>\n");
#nullable restore
#line 65 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\n                </div>\n\n");
                WriteLiteral("                <div class=\"price-details\">\n                    <h5>Price Details</h5>\n                    <span>Total</span>\n                    <span class=\"total\">");
#nullable restore
#line 73 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml"
                                   Write(Model.Total);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                    <span>Discount</span>\n                    <span class=\"total\">");
#nullable restore
#line 75 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml"
                                   Write(Model.Discount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                    <span>Delivery Charges</span>
                    <span class=""total"">100</span>
                    <div class=""clearfix""></div>
                </div>
                <h4 class=""last-price"">TOTAL</h4>
                <span class=""total final"">");
#nullable restore
#line 81 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml"
                                     Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                <div class=\"clearfix\"></div>\n\n");
                WriteLiteral("                <h5>Payment:</h5>\n                <div class=\"sky_form1\">\n                    <ul>\n                        <li><label class=\"radio left\"><input type=\"radio\"");
                BeginWriteAttribute("checked", " checked=\"", 3814, "\"", 3824, 0);
                EndWriteAttribute();
                WriteLiteral("><i></i>Stripe</label></li>\n                        <div class=\"clearfix\"></div>\n                    </ul>\n                </div>\n                <div>\n                    \n");
                WriteLiteral("                    <input type=\"submit\" value=\"Payment\">\n                </div>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-totalprice", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "D:\TryFinal\LastVersion\New\3-6-2021\V2\FurnitureStoreLast.Domain\Views\OrderV2\Index.cshtml"
                                                                       WriteLiteral(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["totalprice"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-totalprice", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["totalprice"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Controllers.OrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
