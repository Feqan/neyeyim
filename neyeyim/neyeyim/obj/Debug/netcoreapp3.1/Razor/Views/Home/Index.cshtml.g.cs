#pragma checksum "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f3d0fb36ac4474956951a18a25c182715874f58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\_ViewImports.cshtml"
using neyeyim.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\_ViewImports.cshtml"
using neyeyim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f3d0fb36ac4474956951a18a25c182715874f58", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb900363127bca3854ca107bde25ff7c9a2b1e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("book-modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "place", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!--Start of Slider Area-->\r\n\r\n<div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <div class=\"carousel-inner\">\r\n        <div class=\"carousel-item active\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 227, "\"", 234, 0);
            EndWriteAttribute();
            WriteLiteral("><img class=\"d-block w-100\" src=\"uploads/img/1.jpg\" alt=\"First slide\"></a>\r\n        </div>\r\n        <div class=\"carousel-item\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 378, "\"", 385, 0);
            EndWriteAttribute();
            WriteLiteral("><img class=\"d-block w-100\" src=\"uploads/img/2.png\" alt=\"Second slide\"></a>\r\n        </div>\r\n        <div class=\"carousel-item\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 530, "\"", 537, 0);
            EndWriteAttribute();
            WriteLiteral(@"><img class=""d-block w-100"" src=""uploads/img/3.jpg"" alt=""Second slide""></a>
        </div>
    </div>

    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<!--End of Slider Area-->

<!--Start of Selected places Area-->
<section class=""cards animate__animated animate__fadeIn"">
    <div class=""container"">
        <div class=""row"">
            <h1 class=""cardcaption"" style=""padding: 20px;"">Seçilmiş məkanlar</h1>
");
#nullable restore
#line 35 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
             foreach (var item in Model.Places.Where(x => x.IsSelected == true))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f3d0fb36ac4474956951a18a25c182715874f586534", async() => {
                WriteLiteral("\r\n                        <div class=\"card\" style=\"width: 18rem; border-bottom: 5px solid #009de0;\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 1810, "\"", 1839, 2);
                WriteAttributeValue("", 1816, "uploads/img/", 1816, 12, true);
#nullable restore
#line 40 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
WriteAttributeValue("", 1828, item.Image, 1828, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <h class=\"restname\">");
#nullable restore
#line 42 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h>\r\n                                <p class=\"Category-name\">Kateqoriya: ");
#nullable restore
#line 43 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                Write(item.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br /> İş saatı: ");
#nullable restore
#line 43 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                                     Write(item.OpenTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 43 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                                                                        Write(item.CloseTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <hr>\r\n                                <i class=\"fas fa-star\" style=\"color: #009de0;\">\r\n                                    ");
#nullable restore
#line 46 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                               Write(item.Rate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </i>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 52 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<!--End of Selected places Area-->

<!--Start of Most Popular places Area-->
<section class=""cards4 animate__animated animate__fadeIn"" style=""background-color: #F8F9FA;"">
    <div class=""container"">
        <div class=""row"">
            <h1 class=""cardcaption"" style=""padding: 20px;"">Ən populyar məkanlar</h1>
");
#nullable restore
#line 63 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
            foreach (var item in Model.Places.OrderByDescending(x => x.Rate).Take(3))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f3d0fb36ac4474956951a18a25c182715874f5812565", async() => {
                WriteLiteral("\r\n                        <div class=\"card\" style=\"width: 18rem; border-bottom: 5px solid #009de0;\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 3295, "\"", 3324, 2);
                WriteAttributeValue("", 3301, "uploads/img/", 3301, 12, true);
#nullable restore
#line 68 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
WriteAttributeValue("", 3313, item.Image, 3313, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <h class=\"restname\">");
#nullable restore
#line 70 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h>\r\n                                <p class=\"Category-name\">Kateqoriya: ");
#nullable restore
#line 71 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                Write(item.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br /> İş saatı: ");
#nullable restore
#line 71 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                                     Write(item.OpenTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 71 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                                                                        Write(item.CloseTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <hr>\r\n                                <i class=\"fas fa-star\" style=\"color: #009de0;\"> ");
#nullable restore
#line 73 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                           Write(item.Rate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 78 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<!--End of Most Popular places Area-->

<!--Start of Last Ordered places Area-->
<section class=""cards4 animate__animated animate__fadeIn"">
    <div class=""container"">
        <div class=""row"">
            <h1 class=""cardcaption"" style=""padding: 20px;"">Son sifariş verdiyiniz məkanlar</h1>
");
#nullable restore
#line 89 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
             foreach (var item in Model.Places.Take(3))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f3d0fb36ac4474956951a18a25c182715874f5818514", async() => {
                WriteLiteral("\r\n                        <div class=\"card\" style=\"width: 18rem; border-bottom: 5px solid #009de0;\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 4659, "\"", 4688, 2);
                WriteAttributeValue("", 4665, "uploads/img/", 4665, 12, true);
#nullable restore
#line 94 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
WriteAttributeValue("", 4677, item.Image, 4677, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <h class=\"restname\">");
#nullable restore
#line 96 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h>\r\n                                <p class=\"Category-name\">Kateqoriya: ");
#nullable restore
#line 97 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                Write(item.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br /> İş saatı: ");
#nullable restore
#line 97 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                                     Write(item.OpenTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 97 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                                                                        Write(item.CloseTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <hr>\r\n                                <i class=\"fas fa-star\" style=\"color: #009de0;\"> ");
#nullable restore
#line 99 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                           Write(item.Rate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 104 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<!--End of Last Ordered places Area-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591