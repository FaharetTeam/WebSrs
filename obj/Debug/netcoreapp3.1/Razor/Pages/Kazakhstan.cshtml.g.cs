#pragma checksum "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ceef79d3b12c04cdc5bc667f016cb46feda65fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebSRS.Pages.Pages_Kazakhstan), @"mvc.1.0.razor-page", @"/Pages/Kazakhstan.cshtml")]
namespace WebSRS.Pages
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
#line 1 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\_ViewImports.cshtml"
using WebSRS;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ceef79d3b12c04cdc5bc667f016cb46feda65fd", @"/Pages/Kazakhstan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"218fea9c90eb46e9649bd9e14e573a1d67360d41", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Kazakhstan : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position:relative;height:470px;width:950px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/kz.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
  
    ViewData["Title"] = "Kazakhstan";
    Layout = "~/Pages/Shared/_KZ.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ceef79d3b12c04cdc5bc667f016cb46feda65fd3849", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<br />
<br />
<p style=""position: absolute;left:15%; top: 45px;font-size: 100px;color: #4266bb;text-shadow: black 0 0 50px;font-family: 'Oswald',sans-serif;"">Republic of Kazakhstan</p>
<h2 style=""text-align:center;text-shadow:blue 0 0 5px""> Basic information</h2>
<table class=""table"" style=""color:white"">
    <thead>
        <tr>
            <th>
                <h6 style=""color:white"">");
#nullable restore
#line 20 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
                                   Write(Html.DisplayNameFor(model => model.KZClass[0].Capital));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </th>\r\n            <th>\r\n                <h6 style=\"color:white\">");
#nullable restore
#line 23 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
                                   Write(Html.DisplayNameFor(model => model.KZClass[0].Official_languages));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </th>\r\n            <th>\r\n                <h6 style=\"color:white\">");
#nullable restore
#line 26 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
                                   Write(Html.DisplayNameFor(model => model.KZClass[0].Legislature));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </th>\r\n            <th>\r\n                <h6 style=\"color:white\">");
#nullable restore
#line 29 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
                                   Write(Html.DisplayNameFor(model => model.KZClass[0].President));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </th>\r\n            <th>\r\n                <h6 style=\"color:white\">");
#nullable restore
#line 32 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
                                   Write(Html.DisplayNameFor(model => model.KZClass[0].Chairman_of_the_Security_Council));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </th>\r\n            <th>\r\n                <h6 style=\"color:white\">");
#nullable restore
#line 35 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
                                   Write(Html.DisplayNameFor(model => model.KZClass[0].Prime_Minister));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </th>\r\n            <th>\r\n                <h6 style=\"color:white\">");
#nullable restore
#line 38 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
                                   Write(Html.DisplayNameFor(model => model.KZClass[0].Declared_Independence_from_the_USSR));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </th>\r\n            <th>\r\n                <h6 style=\"color:white\">");
#nullable restore
#line 41 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
                                   Write(Html.DisplayNameFor(model => model.KZClass[0].Current_constitution));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </th>\r\n            <th>\r\n                <h6 style=\"color:white\">");
#nullable restore
#line 44 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
                                   Write(Html.DisplayNameFor(model => model.KZClass[0].Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
         foreach (var item in Model.KZClass)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
               Write(Html.DisplayFor(modelItem => item.Capital));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
               Write(Html.DisplayFor(modelItem => item.Official_languages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
               Write(Html.DisplayFor(modelItem => item.Legislature));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
               Write(Html.DisplayFor(modelItem => item.President));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
               Write(Html.DisplayFor(modelItem => item.Chairman_of_the_Security_Council));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
               Write(Html.DisplayFor(modelItem => item.Prime_Minister));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
               Write(Html.DisplayFor(modelItem => item.Declared_Independence_from_the_USSR));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
               Write(Html.DisplayFor(modelItem => item.Current_constitution));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
               Write(Html.DisplayFor(modelItem => item.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 81 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Kazakhstan.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<br />
<br />
<br />
<iframe width=""910"" height=""470"" src=""https://www.youtube.com/embed/F7nCAOIhIUw"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
<br />
<hr />
<h2 style=""text-align:center;text-shadow:blue 0 0 5px""> Homeland of many nations</h2>
<h5 style=""color:white"">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Kazakhstan has become a homeland for people of different nationalities and religions, united by a common historical destiny.This diversity of traditions, spiritual heritage and languages
    is especially valued in the Republic of Kazakhstan, because it is not without reason that the Japanese proverb says: ""A person can survive without his relatives, but he cannot survive without
    neighbors.""
    <br /><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;The citizens of Kazakhstan are proud of their multinational state. For centuries, from generation to generation in Kazakhstan, a good trad");
            WriteLiteral(@"ition of friendship and good relations between peoples
    has been transmitted and maintained.
    <br /><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;The state language in the Republic of Kazakhstan is Kazakh, the Russian language has the status of a language of interethnic communication and is used on an equal basis with the state language
    in government agencies, government bodies and other organizations. And the younger generation speaks three languages, including English. Kazakh is the language of ancestors, Russian is the language
    of communication, and English is developing and becoming popular due to the fact that it is often used in the business world, when <br />
    communicating with foreign guests of the country.
</h5>
<br />
<hr />
<h2 style=""text-align:center;text-shadow:blue 0 0 5px"">
    Welcome to Kazakhstan!
</h2>
<br />
<h5 style=""color:white"">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;To get acquainted with amazing traditions, delightful nature, skillful interweaving of the ancie");
            WriteLiteral("nt and the modern, it is not necessary to strive to travel around the whole world: come to Kazakhstan.\r\n    They know how to meet guests, and you will feel the warmth of a country located in the very heart of Eurasia.\r\n</h5>\r\n<br />\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSRS.Pages.KazakhstanModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebSRS.Pages.KazakhstanModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebSRS.Pages.KazakhstanModel>)PageContext?.ViewData;
        public WebSRS.Pages.KazakhstanModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
