#pragma checksum "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\DojoSurveyValidation\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f3ad2c7a1a52cf34bceae05b01c19fc3dfa7046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Success.cshtml", typeof(AspNetCore.Views_Home_Success))]
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
#line 1 "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\DojoSurveyValidation\Views\_ViewImports.cshtml"
using DojoSurveyValidation;

#line default
#line hidden
#line 2 "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\DojoSurveyValidation\Views\_ViewImports.cshtml"
using DojoSurveyValidation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3ad2c7a1a52cf34bceae05b01c19fc3dfa7046", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a024f8a5533dc9edb8f42b9eacd75f35085f98a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 610, true);
            WriteLiteral(@"<div class=""card col-6 offset-3 mt-3"">
    <div class=""card-body"">
        <h4 class=""card-title"">Submitted Information</h4>
        <hr>
        <div class=""row offset-1"">   
            <div class=""col-6"">
                <p class=""card-text"">Name:</p>
                <hr>
                <p class=""card-text"">Dojo Location:</p>
                <hr>
                <p class=""card-text"">Favorite Language:</p>
                <hr>
                <p class=""card-text"">Comment:</p>
                <hr>
            </div>
            <div class=""col-6"">
                <p class=""card-text""> ");
            EndContext();
            BeginContext(611, 10, false);
#line 17 "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\DojoSurveyValidation\Views\Home\Success.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(621, 67, true);
            WriteLiteral(" </p>\r\n                <hr>\r\n                <p class=\"card-text\"> ");
            EndContext();
            BeginContext(689, 14, false);
#line 19 "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\DojoSurveyValidation\Views\Home\Success.cshtml"
                                 Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(703, 67, true);
            WriteLiteral(" </p>\r\n                <hr>\r\n                <p class=\"card-text\"> ");
            EndContext();
            BeginContext(771, 14, false);
#line 21 "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\DojoSurveyValidation\Views\Home\Success.cshtml"
                                 Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(785, 67, true);
            WriteLiteral(" </p>\r\n                <hr>\r\n                <p class=\"card-text\"> ");
            EndContext();
            BeginContext(853, 13, false);
#line 23 "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\DojoSurveyValidation\Views\Home\Success.cshtml"
                                 Write(Model.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(866, 151, true);
            WriteLiteral(" </p>\r\n                <hr>\r\n            </div>\r\n        </div>\r\n\r\n        <a href=\"/\" class=\"btn btn-primary offset-9\">Go back</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
