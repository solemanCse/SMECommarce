#pragma checksum "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\Item\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "573dfc8b2e6845d417557f8975d61aad58d74495"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Details), @"mvc.1.0.view", @"/Views/Item/Details.cshtml")]
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
#line 1 "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\_ViewImports.cshtml"
using SMECommerce.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\_ViewImports.cshtml"
using SMECommerce.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"573dfc8b2e6845d417557f8975d61aad58d74495", @"/Views/Item/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68de0a6687266e21e8cb0c25aaaa11eb6dbf3182", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SMECommerce.App.Models.ItemModels.ItemDetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary icon-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ItemList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""tile"">
                    <div class=""tile-title-w-btn"">
                        <h3 class=""title-title"">Item Details</h3>
                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "573dfc8b2e6845d417557f8975d61aad58d744954651", async() => {
                WriteLiteral("<i class=\"fa fa-toggle-left\"></i>Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"tile-body\">\r\n                        <div class=\"form-group\">\r\n                            <span class=\"control-label\">Code:</span>&nbsp;<span class=\"control-label\">");
#nullable restore
#line 13 "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\Item\Details.cshtml"
                                                                                                 Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <span class=\"control-label\">Name:</span>&nbsp;<span class=\"control-label\">");
#nullable restore
#line 16 "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\Item\Details.cshtml"
                                                                                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <span class=\"control-label\">Category:</span>&nbsp;<span class=\"control-label\">");
#nullable restore
#line 19 "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\Item\Details.cshtml"
                                                                                                     Write(Model.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <span class=\"control-label\">Brand:</span>&nbsp;<span class=\"control-label\">");
#nullable restore
#line 22 "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\Item\Details.cshtml"
                                                                                                  Write(Model.BrandId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <span class=\"control-label\">Manufacture Date:</span>&nbsp;<span class=\"control-label\">");
#nullable restore
#line 25 "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\Item\Details.cshtml"
                                                                                                             Write(Model.ManufactureDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <span class=\"control-label\">Price:</span>&nbsp;<span class=\"control-label\">");
#nullable restore
#line 28 "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\Item\Details.cshtml"
                                                                                                  Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <span class=\"control-label\">Description:</span>&nbsp;<span class=\"control-label\">");
#nullable restore
#line 31 "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\Item\Details.cshtml"
                                                                                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""tile"">                    
                    <div class=""tile-body"" style=""text-align:center;"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "573dfc8b2e6845d417557f8975d61aad58d7449510088", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2301, "~/Image/Item/", 2301, 13, true);
#nullable restore
#line 39 "D:\Asp.net Core\My_Practice\4.Practice\SMECommerce.App\SMECommerce.App\Views\Item\Details.cshtml"
AddHtmlAttributeValue("", 2314, Model.ImageName, 2314, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SMECommerce.App.Models.ItemModels.ItemDetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591