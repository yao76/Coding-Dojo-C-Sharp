#pragma checksum "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20c31df25ad915216b3fddbd16d0fceaf917af91"
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
#line 1 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c31df25ad915216b3fddbd16d0fceaf917af91", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 384, true);
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1>Welcome to CRUDelicious</h1>
</div>
<div class=""main"">
    <div class=""row"">
        <div class=""col"">
            <h3>Check out some recent dishes!</h3>
            <hr>
        </div>
        <div class=""col"">
            <a href=""/addDish"">Add a dish!</a>
        </div>
    </div>

    <div class=""row"">
        <div class=""col"">
");
            EndContext();
#line 21 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\Index.cshtml"
             foreach(var dish in ViewBag.AllDishes)
            {

#line default
#line hidden
            BeginContext(497, 21, true);
            WriteLiteral("                <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 518, "\"", 538, 2);
            WriteAttributeValue("", 525, "/", 525, 1, true);
#line 23 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 526, dish.CakeId, 526, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(539, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(541, 9, false);
#line 23 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\Index.cshtml"
                                      Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(550, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(559, 9, false);
#line 23 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\Index.cshtml"
                                                        Write(dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(568, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 24 "D:\Documents\Coding Dojo\C#\Week_12\CRUDelicious\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(589, 42, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    \r\n</div>\r\n");
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