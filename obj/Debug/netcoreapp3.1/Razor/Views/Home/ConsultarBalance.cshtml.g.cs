#pragma checksum "C:\Users\Edwin\Desktop\CajeroVSCode\Cajero\Views\Home\ConsultarBalance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be489c1a138197bd5130fb0692acab024352d79e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ConsultarBalance), @"mvc.1.0.view", @"/Views/Home/ConsultarBalance.cshtml")]
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
#line 1 "C:\Users\Edwin\Desktop\CajeroVSCode\Cajero\Views\_ViewImports.cshtml"
using Cajero;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Edwin\Desktop\CajeroVSCode\Cajero\Views\_ViewImports.cshtml"
using Cajero.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be489c1a138197bd5130fb0692acab024352d79e", @"/Views/Home/ConsultarBalance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d82ecd6fcbdfe296655d2d7b46668612480c21c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ConsultarBalance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<style>
    body {
        background: linear-gradient(to right, #223E76 0%, #223E76 50%, #8CCBEA 50%, #8CCBEA 100%);
        height: 824px;
    }

    .fondoblanco {
        position: absolute;
        width: 1154px;
        height: 649px;
        left: 97px;
        top: 120px;
        background: #FFFFFF;
        box-shadow: 15px 15px 4px rgba(0, 0, 0, 0.25);
        border-radius: 47px;
    }

    h1 {
        position: absolute;
        width: 760px;
        height: 86px;
        left: 197px;
        top: 180px;
        font-family: Roboto;
        font-style: normal;
        font-weight: bold;
        font-size: 60px;
        line-height: 70px;
        text-align: center;
    }

    .cuadroazuldinero {
        position: absolute;
        width: 456px;
        height: 90px;
        left: 361px;
        top: 279px;
        background: #223E76;
    }

    .efectivo {
        position: absolute;
        width: 386px;
        height: 64px;
        left: 29px;
  ");
            WriteLiteral(@"      top: 10px;
        font-family: Roboto;
        font-style: normal;
        font-weight: bold;
        font-size: 60px;
        line-height: 70px;
        text-align: center;
        color: white;
    }

    .salir {
        position: absolute;
        width: 102.3px;
        height: 38px;
        left: 533px;
        top: 573px;
        border: none;
        font-family: Roboto;
        font-style: normal;
        font-weight: 500;
        font-size: 18px;
        line-height: 20px;
        /* identical to box height */
        text-align: center;
        color: white;
        background: #223E76;
        box-shadow: 0px 3px 3px rgba(0, 0, 0, 0.25);
        border-radius: 5px;
    }

</style>


    <div class=""fondoblanco"">
        <h1>Su balance actual es de: </h1>
        <div class=""cuadroazuldinero"">
            <h1 class=""efectivo"">RD$ ");
#nullable restore
#line 87 "C:\Users\Edwin\Desktop\CajeroVSCode\Cajero\Views\Home\ConsultarBalance.cshtml"
                                Write(Cuenta.balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n\r\n        <input type=\"button\" class=\"salir\" value=\"Salir\" onclick=\"location.href=\'/Home/Menu\'\" />\r\n    </div>");
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