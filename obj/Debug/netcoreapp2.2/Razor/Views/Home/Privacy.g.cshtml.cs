#pragma checksum "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\DisplayTemplatesEditorTemplates\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6b41d4e886f33ef9588738d7960a2ff6f0dd3c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\DisplayTemplatesEditorTemplates\Views\_ViewImports.cshtml"
using DisplayTemplatesEditorTemplates;

#line default
#line hidden
#line 2 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\DisplayTemplatesEditorTemplates\Views\_ViewImports.cshtml"
using DisplayTemplatesEditorTemplates.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b41d4e886f33ef9588738d7960a2ff6f0dd3c2", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc6e9c53f8b5f05faf368d305bf373f496cc2fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DisplayTemplatesEditorTemplates.Models.Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\DisplayTemplatesEditorTemplates\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "EditorTemplates";

#line default
#line hidden
            BeginContext(116, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(121, 17, false);
#line 7 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\DisplayTemplatesEditorTemplates\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(138, 78, true);
            WriteLiteral("</h1>\r\n<p>Lista de datos con Html.EditorFor() </p>\r\n\r\n<div class=\"row mt-2\">\r\n");
            EndContext();
#line 11 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\DisplayTemplatesEditorTemplates\Views\Home\Privacy.cshtml"
 for(int i=0; i < Model.Count; i++ )
{

#line default
#line hidden
            BeginContext(258, 34, false);
#line 13 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\DisplayTemplatesEditorTemplates\Views\Home\Privacy.cshtml"
Write(Html.EditorFor(model => model[i] ));

#line default
#line hidden
            EndContext();
#line 13 "C:\Users\Armando\Desktop\DEVELOPER\.NET Core Projects\DisplayTemplatesEditorTemplates\Views\Home\Privacy.cshtml"
                                   ;
}

#line default
#line hidden
            BeginContext(298, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DisplayTemplatesEditorTemplates.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
