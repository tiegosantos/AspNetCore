#pragma checksum "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6141936551bdf8b87b34b313ba255914fac09d81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Palavra_Cadastrar), @"mvc.1.0.view", @"/Views/Palavra/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Palavra/Cadastrar.cshtml", typeof(AspNetCore.Views_Palavra_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6141936551bdf8b87b34b313ba255914fac09d81", @"/Views/Palavra/Cadastrar.cshtml")]
    public class Views_Palavra_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<site01.Models.Palavra>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
  
    //Layout = "_Layout";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
  
    ViewBag.Title = "Palavra  - Cadastrar";

#line default
#line hidden
            BeginContext(169, 58, true);
            WriteLiteral("\r\n<form method=\"post\">\r\n    <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 227, "\"", 244, 1);
#line 14 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
WriteAttributeValue("", 235, Model.id, 235, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(245, 134, true);
            WriteLiteral(" />\r\n    <div class=\"form-group\">\r\n        <label for=\"nome\">Nome</label>\r\n        <input type=\"text\" name=\"nome\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 379, "\"", 398, 1);
#line 17 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
WriteAttributeValue("", 387, Model.Nome, 387, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(399, 53, true);
            WriteLiteral(" id=\"nome\" placeholder=\"Digite o seu nome\">\r\n        ");
            EndContext();
            BeginContext(453, 30, false);
#line 18 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
   Write(Html.ValidationMessage("nome"));

#line default
#line hidden
            EndContext();
            BeginContext(483, 140, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"nivel\">Nível</label>\r\n        <select name=\"nivel\" class=\"form-control\">\r\n");
            EndContext();
#line 24 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
         foreach (var nivel in ViewBag.Nivel)
         {
            

#line default
#line hidden
#line 26 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
             if (nivel.Id == Model.Nivel)
             {

#line default
#line hidden
            BeginContext(741, 22, true);
            WriteLiteral("               <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 763, "\"", 780, 1);
#line 28 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
WriteAttributeValue("", 771, nivel.Id, 771, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(781, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(792, 10, false);
#line 28 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
                                             Write(nivel.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(802, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 29 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
             }

             else

             {      
                

#line default
#line hidden
            BeginContext(892, 21, true);
            WriteLiteral("              <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 913, "\"", 930, 1);
#line 35 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
WriteAttributeValue("", 921, nivel.Id, 921, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(931, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(933, 10, false);
#line 35 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
                                   Write(nivel.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(943, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 36 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"

             }

#line default
#line hidden
#line 37 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
              

         }

#line default
#line hidden
            BeginContext(986, 91, true);
            WriteLiteral("        </select>\r\n       <!-- <input type=\"text\" name=\"nivel\" class=\"form-control\" value=\"");
            EndContext();
            BeginContext(1078, 11, false);
#line 41 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
                                                                   Write(Model.Nivel);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 90, true);
            WriteLiteral("\" id=\"nivel\" placeholder=\"Digite o Nível 1 - Fácil  2 - Médio 3 - Difícil\">  -->\r\n        ");
            EndContext();
            BeginContext(1180, 31, false);
#line 42 "C:\Users\galodoido\Desktop\site01\site01\Views\Palavra\Cadastrar.cshtml"
   Write(Html.ValidationMessage("nivel"));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 90, true);
            WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">salvar</button>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<site01.Models.Palavra> Html { get; private set; }
    }
}
#pragma warning restore 1591
