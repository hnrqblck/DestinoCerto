#pragma checksum "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b66af2809e1ff0eea77e3fe77c613f3b417d38d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacote_Vitrine), @"mvc.1.0.view", @"/Views/Pacote/Vitrine.cshtml")]
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
#nullable restore
#line 1 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\_ViewImports.cshtml"
using DestinoCerto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\_ViewImports.cshtml"
using DestinoCerto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b66af2809e1ff0eea77e3fe77c613f3b417d38d", @"/Views/Pacote/Vitrine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6f7132d3cd5c589c7af821b0f291ce7ba9a6d97", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacote_Vitrine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pacote>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml"
  
    ViewData["Title"] = "Pacotes de Viagem";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"vitrine\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 9 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"cards\">\r\n            <h1>");
#nullable restore
#line 12 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml"
           Write(p.NomePacote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p>Saindo de ");
#nullable restore
#line 13 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml"
                    Write(p.Origem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" para ");
#nullable restore
#line 13 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml"
                                   Write(p.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p>");
#nullable restore
#line 14 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml"
          Write(p.Saida.ToString("dd-MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml"
                                       Write(p.Retorno.ToString("dd-MM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 15 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml"
          Write(p.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\jorge\OneDrive\Documents\GitHub\Projetos Pessoais\DestinoCerto\Views\Pacote\Vitrine.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pacote>> Html { get; private set; }
    }
}
#pragma warning restore 1591