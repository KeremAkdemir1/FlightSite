#pragma checksum "C:\Users\Lenovo\source\repos\dbrepeat\VacationSite3\Views\Blog\AddComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da46a8f577379b48ae5657153a671093a6bbe7e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_AddComment), @"mvc.1.0.view", @"/Views/Blog/AddComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da46a8f577379b48ae5657153a671093a6bbe7e9", @"/Views/Blog/AddComment.cshtml")]
    public class Views_Blog_AddComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VacationSite3.Models.Data.Comments>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/twitter-bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Lenovo\source\repos\dbrepeat\VacationSite3\Views\Blog\AddComment.cshtml"
  
    ViewData["Title"] = "AddComment";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AddComment</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da46a8f577379b48ae5657153a671093a6bbe7e93559", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\dbrepeat\VacationSite3\Views\Blog\AddComment.cshtml"
 using (Html.BeginForm("AddComment", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\dbrepeat\VacationSite3\Views\Blog\AddComment.cshtml"
Write(Html.LabelFor(x => x.Commenter));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\dbrepeat\VacationSite3\Views\Blog\AddComment.cshtml"
Write(Html.TextBoxFor(x => x.Commenter, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\dbrepeat\VacationSite3\Views\Blog\AddComment.cshtml"
Write(Html.ValidationMessageFor(x => x.Commenter, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\dbrepeat\VacationSite3\Views\Blog\AddComment.cshtml"
Write(Html.LabelFor(x => x.Comment));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\dbrepeat\VacationSite3\Views\Blog\AddComment.cshtml"
Write(Html.TextBoxFor(x => x.Comment, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\dbrepeat\VacationSite3\Views\Blog\AddComment.cshtml"
Write(Html.ValidationMessageFor(x => x.Comment, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\dbrepeat\VacationSite3\Views\Blog\AddComment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VacationSite3.Models.Data.Comments> Html { get; private set; }
    }
}
#pragma warning restore 1591
