#pragma checksum "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\OneDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b3ed522112aac58b49503f79fe6783c72f5005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneDish), @"mvc.1.0.view", @"/Views/Home/OneDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OneDish.cshtml", typeof(AspNetCore.Views_Home_OneDish))]
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
#line 1 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b3ed522112aac58b49503f79fe6783c72f5005", @"/Views/Home/OneDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dishes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 88, true);
            WriteLiteral("<a class=\"offset-\"href=\"/\">Home</a>\r\n<div class=\"jumbotron text-center\">\r\n    \r\n    <h1>");
            EndContext();
            BeginContext(104, 10, false);
#line 5 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\OneDish.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(114, 15, true);
            WriteLiteral("</h1>\r\n    <h3>");
            EndContext();
            BeginContext(130, 10, false);
#line 6 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\OneDish.cshtml"
   Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(140, 26, true);
            WriteLiteral("</h3>\r\n</div>\r\n<hr>\r\n\r\n<p>");
            EndContext();
            BeginContext(167, 17, false);
#line 10 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\OneDish.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(184, 25, true);
            WriteLiteral("</p>\r\n<br>\r\n<p>Calories: ");
            EndContext();
            BeginContext(210, 14, false);
#line 12 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\OneDish.cshtml"
        Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(224, 20, true);
            WriteLiteral("</p>\r\n<p>Tastiness: ");
            EndContext();
            BeginContext(245, 15, false);
#line 13 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\OneDish.cshtml"
         Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(260, 31, true);
            WriteLiteral("</p>\r\n<hr>\r\n<a class=\"offset-3\"");
            EndContext();
            BeginWriteAttribute("href", "href=\"", 291, "\"", 318, 2);
            WriteAttributeValue("", 297, "/delete/", 297, 8, true);
#line 15 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\OneDish.cshtml"
WriteAttributeValue("", 305, Model.CakeId, 305, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(319, 72, true);
            WriteLiteral("><button class=\"btn btn-danger\">Delete</button></a>\r\n<a class=\"offset-4\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 391, "\"", 417, 2);
            WriteAttributeValue("", 398, "/edit/", 398, 6, true);
#line 16 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\OneDish.cshtml"
WriteAttributeValue("", 404, Model.CakeId, 404, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(418, 54, true);
            WriteLiteral("><button class=\"btn btn-warning\">Edit</button></a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dishes> Html { get; private set; }
    }
}
#pragma warning restore 1591
