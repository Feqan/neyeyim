#pragma checksum "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f43f4f343ae4b275fb26ae601c08ba62d26876f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jobad_Detail), @"mvc.1.0.view", @"/Views/Jobad/Detail.cshtml")]
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
#line 1 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\_ViewImports.cshtml"
using neyeyim.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\_ViewImports.cshtml"
using neyeyim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f43f4f343ae4b275fb26ae601c08ba62d26876f3", @"/Views/Jobad/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb900363127bca3854ca107bde25ff7c9a2b1e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Jobad_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Jobad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""workdetail animate__animated animate__fadeIn"">
    <div class=""container"">
        <div class=""row"" style=""padding: 50px;"">
            <div class=""card col-lg-6 col-sm-6 col-xs-6"">
                <div class=""mainabout"">

                    <h1 class=""companyname"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f43f4f343ae4b275fb26ae601c08ba62d26876f33962", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 359, "~/uploads/img/", 359, 14, true);
#nullable restore
#line 13 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
AddHtmlAttributeValue("", 373, Model.Place.Logo, 373, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
                                                                                          Write(Model.Place.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                    <h2 class=\"worksalary\">");
#nullable restore
#line 14 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
                                      Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
                                                        Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN\r\n                    </h2>\r\n                </div>\r\n                <div class=\"secondabout\">\r\n                    <h4>??mumi m??lumat v?? t??l??bl??r</h4>\r\n                    <p class=\"workabout\">????h??r: ");
#nullable restore
#line 19 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
                                           Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"workabout\">Ya??: ");
#nullable restore
#line 20 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
                                         Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"workabout\">T??hsil: ");
#nullable restore
#line 21 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
                                            Write(Model.Education);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"workabout\">???? t??cr??b??si: ");
#nullable restore
#line 22 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
                                                  Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"threeabout\">\r\n                    <h4>???? bar??d?? m??lumat</h4>\r\n                    <p class=\"workabout\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
                   Write(Html.Raw(Model.GeneralInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"contactabout\">\r\n                    <h4>??laq??</h4>\r\n                    <p class=\"workabout\">Telefon: ");
#nullable restore
#line 32 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
                                             Write(Model.ContactPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"workabout\">Email: ");
#nullable restore
#line 33 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Views\Jobad\Detail.cshtml"
                                           Write(Model.ContactMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Jobad> Html { get; private set; }
    }
}
#pragma warning restore 1591
