#pragma checksum "C:\Users\Engenharia\Desktop\Maro\Trabalho2\Trabalho2_Banco_De_Dados\Views\Home\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d341f11e947494162c0f4524d6555e4253b09b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listagem), @"mvc.1.0.view", @"/Views/Home/Listagem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d341f11e947494162c0f4524d6555e4253b09b2", @"/Views/Home/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd6f4c61857f92f253d10639c9dfb402b6529da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-6 d-flex justify-content-center\">\r\n        <a href=\"/Usuario/Listar\" >Listagem dos usuários</a>\r\n    </div>\r\n    <div class=\"col-6 \">\r\n        <a href=\"/Pacote/Listar\">Listagem dos pacotes</a>\r\n    </div>\r\n</div>");
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