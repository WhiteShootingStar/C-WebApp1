#pragma checksum "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e60069d9ec374ec50a8e23ab9370505ab93a709"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Details.cshtml", typeof(AspNetCore.Views_Movies_Details))]
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
#line 1 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\_ViewImports.cshtml"
using Site;

#line default
#line hidden
#line 2 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\_ViewImports.cshtml"
using Site.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e60069d9ec374ec50a8e23ab9370505ab93a709", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70e3a3f90f6d4c226913e942091a3f82dd825d74", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Site.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(71, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Movie</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(191, 41, false);
#line 14 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(232, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(276, 37, false);
#line 17 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(313, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(357, 47, false);
#line 20 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(404, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(448, 43, false);
#line 23 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(491, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(535, 41, false);
#line 26 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(620, 37, false);
#line 29 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(657, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(701, 41, false);
#line 32 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(742, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(786, 37, false);
#line 35 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(823, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(867, 42, false);
#line 38 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(909, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(953, 38, false);
#line 41 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(991, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1038, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c7348519edf41bf8ddf87aa610e7395", async() => {
                BeginContext(1084, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "D:\ECLIPSE\VISStud\MyWebAp1\Site\Views\Movies\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1092, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1100, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18b85b8ff7914eb3b62331ebc1a31765", async() => {
                BeginContext(1122, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1138, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Site.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
