#pragma checksum "D:\Учеба\6 семестр\Web\Лабораторная работа №4\Lab4\Lab4\Views\Controls\ResultControl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe3de37133a602e1d25cad8780881e1bfb813f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controls_ResultControl), @"mvc.1.0.view", @"/Views/Controls/ResultControl.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Controls/ResultControl.cshtml", typeof(AspNetCore.Views_Controls_ResultControl))]
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
#line 1 "D:\Учеба\6 семестр\Web\Лабораторная работа №4\Lab4\Lab4\Views\_ViewImports.cshtml"
using Lab4;

#line default
#line hidden
#line 2 "D:\Учеба\6 семестр\Web\Лабораторная работа №4\Lab4\Lab4\Views\_ViewImports.cshtml"
using Lab4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe3de37133a602e1d25cad8780881e1bfb813f2f", @"/Views/Controls/ResultControl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1dc5fb44c3021da35399707c52c994f788c9f72", @"/Views/_ViewImports.cshtml")]
    public class Views_Controls_ResultControl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab4.Models.ControlModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Учеба\6 семестр\Web\Лабораторная работа №4\Lab4\Lab4\Views\Controls\ResultControl.cshtml"
  
    ViewData["Title"] = "ResultControl";

#line default
#line hidden
            BeginContext(78, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(84, 20, false);
#line 6 "D:\Учеба\6 семестр\Web\Лабораторная работа №4\Lab4\Lab4\Views\Controls\ResultControl.cshtml"
Write(Model.ControlElement);

#line default
#line hidden
            EndContext();
            BeginContext(104, 10, true);
            WriteLiteral("</h2>\n\n<p>");
            EndContext();
            BeginContext(115, 10, false);
#line 8 "D:\Учеба\6 семестр\Web\Лабораторная работа №4\Lab4\Lab4\Views\Controls\ResultControl.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(125, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(128, 12, false);
#line 8 "D:\Учеба\6 семестр\Web\Лабораторная работа №4\Lab4\Lab4\Views\Controls\ResultControl.cshtml"
           Write(Model.Result);

#line default
#line hidden
            EndContext();
            BeginContext(140, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab4.Models.ControlModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
