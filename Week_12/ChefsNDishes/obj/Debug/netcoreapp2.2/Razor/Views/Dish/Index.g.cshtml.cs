#pragma checksum "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\Dish\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "673c7f83a7c71a4a3dd344955b9452e34db5ab6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_Index), @"mvc.1.0.view", @"/Views/Dish/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dish/Index.cshtml", typeof(AspNetCore.Views_Dish_Index))]
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
#line 1 "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#line 2 "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"673c7f83a7c71a4a3dd344955b9452e34db5ab6c", @"/Views/Dish/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\Dish\Index.cshtml"
  
    ViewData["Title"] = "Dishes";

#line default
#line hidden
            BeginContext(61, 497, true);
            WriteLiteral(@"<a class = ""offset-10 mt-4"" href=""/dishes/new"">Add a Dish</a>
<div class=""text-center"">
    <h1 class=""display-4""><a href=""/"">Chefs</a> | Dishes</h1>   
</div>

<div class=""row"">
    <div class=""col"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Chef</th>
                    <th>Tastiness</th>
                    <th>Calories</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 22 "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\Dish\Index.cshtml"
                 foreach(var dish in Model)
                {

#line default
#line hidden
            BeginContext(622, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(677, 9, false);
#line 25 "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\Dish\Index.cshtml"
                       Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(686, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(722, 22, false);
#line 26 "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\Dish\Index.cshtml"
                       Write(dish.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(744, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(746, 21, false);
#line 26 "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\Dish\Index.cshtml"
                                               Write(dish.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(767, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(803, 14, false);
#line 27 "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\Dish\Index.cshtml"
                       Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(817, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(853, 13, false);
#line 28 "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\Dish\Index.cshtml"
                       Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(866, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 30 "D:\Documents\Coding Dojo\C#\Week_12\ChefsNDishes\Views\Dish\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(919, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
