#pragma checksum "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Story\Question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b611b1b072e49f758fa2481676638cee7982e2ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebSRS.Pages.Story.Pages_Story_Question), @"mvc.1.0.razor-page", @"/Pages/Story/Question.cshtml")]
namespace WebSRS.Pages.Story
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b611b1b072e49f758fa2481676638cee7982e2ec", @"/Pages/Story/Question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"218fea9c90eb46e9649bd9e14e573a1d67360d41", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Story_Question : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Story/Question", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-1 buttonShadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Story\Question.cshtml"
  
    ViewData["title"] = "Question";
    Layout = "~/Pages/Shared/_KZ.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<h2 style=\"text-align:center;color:white;text-shadow: blue 0 0 20px;\">Write your problem that you are facing and we will work on this problem.</h2>\r\n<h4>&nbsp;&nbsp;Please introduce yourself:      </h4>\r\n<h4>&nbsp;");
#nullable restore
#line 12 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Story\Question.cshtml"
     Write(Html.TextBox("name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br /></h4>\r\n<h4>&nbsp;&nbsp;Your email:      </h4>\r\n<h4> &nbsp;");
#nullable restore
#line 14 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Story\Question.cshtml"
      Write(Html.TextBox("email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br /></h4>\r\n<h4>&nbsp;&nbsp;Choose the correct problem:<br /> &nbsp;");
#nullable restore
#line 15 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Story\Question.cshtml"
                                                   Write(Html.DropDownList("user", new SelectList(new string[] { "with the transition to another page", "with the transition to another page", "can't leave a comment", "I can not delete my history", "another problem" }), "Choose your option"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br /></h4>\r\n<h4>&nbsp;&nbsp;Describe the problem you encountered on the site:<br /><br />  &nbsp;");
#nullable restore
#line 16 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Story\Question.cshtml"
                                                                                Write(Html.TextArea("your_story"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><br />\r\n<h4>How many times have you encountered this problem?</h4><br />\r\n");
#nullable restore
#line 18 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Story\Question.cshtml"
Write(Html.RadioButton("text", "t1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>For the first time</h4> \r\n");
#nullable restore
#line 20 "C:\Users\fahar\source\repos\WebSRS\WebSRS\Pages\Story\Question.cshtml"
Write(Html.RadioButton("text", "t1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Already several times</h4> <br />\r\n&nbsp;&nbsp;&nbsp;");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b611b1b072e49f758fa2481676638cee7982e2ec6118", async() => {
                WriteLiteral("Submit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuestionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuestionModel>)PageContext?.ViewData;
        public QuestionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
