#pragma checksum "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de38144b2d7d881a816b0792cb7ab4b0b56c3243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacote_Listar), @"mvc.1.0.view", @"/Views/Pacote/Listar.cshtml")]
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
#line 1 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\_ViewImports.cshtml"
using Trabalho2_Banco_De_Dados;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\_ViewImports.cshtml"
using Trabalho2_Banco_De_Dados.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de38144b2d7d881a816b0792cb7ab4b0b56c3243", @"/Views/Pacote/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd6f4c61857f92f253d10639c9dfb402b6529da", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacote_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pacote>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Lista de pacotes</h1>
    <table class=""table table-bordered table-hover"">
        <thead>
            <tr>
                <th>Id </th>
                <th>Nome do pacote</th>
                <th>Origem do pacote</th>
                <th>Destino do pacote</th>
                <th>Atrativos</th>
                <th>Saída</th>
                <th>Retorno</th>
                <th>Usuário</th>
                <th>#</th>
                <th>#</th>
                <th>#</th>
            </tr>
        </thead>
");
#nullable restore
#line 20 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
     foreach(Pacote p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
               Write(p.IdPacote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
               Write(p.NomePacote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
               Write(p.OrigemPacote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
               Write(p.DestinoPacote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
               Write(p.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
               Write(p.Saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
               Write(p.Retorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
               Write(p.IdUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                   \r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 982, "\"", 1020, 2);
            WriteAttributeValue("", 989, "/Pacote/Detalhar?id=", 989, 20, true);
#nullable restore
#line 32 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
WriteAttributeValue("", 1009, p.IdPacote, 1009, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalhar</a></td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1064, "\"", 1103, 2);
            WriteAttributeValue("", 1071, "/Pacote/Atualizar?id=", 1071, 21, true);
#nullable restore
#line 33 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
WriteAttributeValue("", 1092, p.IdPacote, 1092, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Atualizar</a></td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1148, "\"", 1185, 2);
            WriteAttributeValue("", 1155, "/Pacote/Excluir?id=", 1155, 19, true);
#nullable restore
#line 34 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
WriteAttributeValue("", 1174, p.IdPacote, 1174, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Pacote\Listar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n    <a href=\"/Pacote/Cadastro\">Cadastrar mais um pacote.</a>");
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