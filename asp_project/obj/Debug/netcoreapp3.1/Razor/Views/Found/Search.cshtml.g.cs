#pragma checksum "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3014aea8294cbba8ffef776ce15b407885a68026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Found_Search), @"mvc.1.0.view", @"/Views/Found/Search.cshtml")]
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
#line 1 "/Users/hong/ASP_NET_project/asp_project/Views/_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hong/ASP_NET_project/asp_project/Views/_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3014aea8294cbba8ffef776ce15b407885a68026", @"/Views/Found/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"913d19762f9ae78021f2c0262519d885f2085739", @"/Views/_ViewImports.cshtml")]
    public class Views_Found_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3014aea8294cbba8ffef776ce15b407885a680263131", async() => {
                WriteLiteral("\r\n    <label>Page ");
#nullable restore
#line 8 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
            Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" of ");
#nullable restore
#line 8 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
                                                                           Write(Model.PageCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </label>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>데이터 출처</th>
                <th>분실날짜</th>
                <th>분류</th>
                <th>물건</th>
                <th>위치</th>
                <th>설명</th>
            </tr>
        </thead>
        <tbody>
            x
");
#nullable restore
#line 22 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
             foreach (var found in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
                   Write(found.Found_data);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
                   Write(found.Found_DateTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
                   Write(found.Found_BigCate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
                   Write(found.Found_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
                   Write(found.Found_GetPosition);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
                   Write(found.Found_Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <div class=\"panel text-center\">\r\n");
#nullable restore
#line 36 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
         for (var p = 1; p <= Model.PageCount; p++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 1147, "\"", 1193, 1);
#nullable restore
#line 38 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
WriteAttributeValue("", 1154, Url.Action("Search", new { page = p }), 1154, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-primary\">");
#nullable restore
#line 38 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
                                                                                         Write(p);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 39 "/Users/hong/ASP_NET_project/asp_project/Views/Found/Search.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
