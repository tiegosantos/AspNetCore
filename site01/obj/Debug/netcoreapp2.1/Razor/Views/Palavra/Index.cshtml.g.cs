#pragma checksum "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe6de8ec171bb770a0270094512ddfee035a09e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Palavra_Index), @"mvc.1.0.view", @"/Views/Palavra/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Palavra/Index.cshtml", typeof(AspNetCore.Views_Palavra_Index))]
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
#line 4 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe6de8ec171bb770a0270094512ddfee035a09e5", @"/Views/Palavra/Index.cshtml")]
    public class Views_Palavra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<site01.Models.Palavra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
  
    // Layout = "_Layout";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(196, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
  
    ViewBag.Title = "Palavra  - Listagem";

#line default
#line hidden
            BeginContext(249, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(291, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(352, 20, false);
#line 20 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(372, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 22 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
}

#line default
#line hidden
            BeginContext(389, 173, true);
            WriteLiteral("\r\n<link href=\"/Css/PagedList.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n<a href=\"/Palavra/Cadastrar\" class=\"btn btn-primary\">Cadastrar</a>\r\n<span><b>Total de registro :</b>");
            EndContext();
            BeginContext(563, 20, false);
#line 27 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
                           Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(583, 278, true);
            WriteLiteral(@" </span>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Palavra</th>
            <th scope=""col"">Nível</th>
            <th scope=""col"">Ação</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 38 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
         foreach (var palavra in Model)
        {

#line default
#line hidden
            BeginContext(913, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(964, 10, false);
#line 41 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
                           Write(palavra.id);

#line default
#line hidden
            EndContext();
            BeginContext(974, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(1002, 12, false);
#line 42 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
               Write(palavra.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1042, 13, false);
#line 43 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
               Write(palavra.Nivel);

#line default
#line hidden
            EndContext();
            BeginContext(1055, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1106, "\"", 1143, 2);
            WriteAttributeValue("", 1113, "/Palavra/atualizar/", 1113, 19, true);
#line 45 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1132, palavra.id, 1132, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1144, 47, true);
            WriteLiteral(" class=\"btn\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1191, "\"", 1226, 2);
            WriteAttributeValue("", 1198, "/Palavra/excluir/", 1198, 17, true);
#line 46 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
WriteAttributeValue("", 1215, palavra.id, 1215, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1227, 70, true);
            WriteLiteral(" class=\"btn\">Excluir</a>\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 50 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1308, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1335, 81, false);
#line 54 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<site01.Models.Palavra>> Html { get; private set; }
    }
}
#pragma warning restore 1591