#pragma checksum "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\RandomPasscode\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6f0d3fbc960ce72dc520c13b64fe80fe8054385"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\RandomPasscode\Views\_ViewImports.cshtml"
using RandomPasscode;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f0d3fbc960ce72dc520c13b64fe80fe8054385", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3efdf283689c54fa35f3a8b3d34cbc068be8c601", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\RandomPasscode\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 32, true);
            WriteLiteral("\r\n<h1>Random Passcode (Passcode ");
            EndContext();
            BeginContext(78, 13, false);
#line 5 "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\RandomPasscode\Views\Home\Index.cshtml"
                         Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(91, 65, true);
            WriteLiteral(")</h1>\r\n<div class=\"main d-flex justify-content-center\">\r\n    <p>");
            EndContext();
            BeginContext(157, 16, false);
#line 7 "D:\Documents\Coding Dojo\C#\Week_11\ASP.NET_Core_Part2\RandomPasscode\Views\Home\Index.cshtml"
  Write(ViewBag.Passcode);

#line default
#line hidden
            EndContext();
            BeginContext(173, 108, true);
            WriteLiteral("</p>\r\n    <a href=\"/\"><button>Generate</button></a>\r\n    <a href=\"/reset\"><button>Reset</button></a>\r\n</div>");
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