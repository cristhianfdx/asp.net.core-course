#pragma checksum "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d0672636e1ba79e655b23ddcecb84c66d41d32d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
#line 1 "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\_ViewImports.cshtml"
using App2;

#line default
#line hidden
#line 2 "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\_ViewImports.cshtml"
using App2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0672636e1ba79e655b23ddcecb84c66d41d32d", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c9a78a3c7bb84ed8c286d732f5953ebe1861c2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Información Escuela";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(97, 34, true);
            WriteLiteral("\r\n<h1>Escuela </h1>\r\n<h2>Nombre : ");
            EndContext();
            BeginContext(132, 12, false);
#line 9 "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\Escuela\Index.cshtml"
        Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(144, 29, true);
            WriteLiteral(" </h2>\r\n<h3>Tipo de escuela: ");
            EndContext();
            BeginContext(174, 17, false);
#line 10 "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\Escuela\Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
            EndContext();
            BeginContext(191, 39, true);
            WriteLiteral("</h3>\r\n\r\n<address>\r\n    <p> Dirección: ");
            EndContext();
            BeginContext(231, 15, false);
#line 13 "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\Escuela\Index.cshtml"
              Write(Model.Direccion);

#line default
#line hidden
            EndContext();
            BeginContext(246, 20, true);
            WriteLiteral(" </p>\r\n    <p>País: ");
            EndContext();
            BeginContext(267, 10, false);
#line 14 "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\Escuela\Index.cshtml"
        Write(Model.Pais);

#line default
#line hidden
            EndContext();
            BeginContext(277, 21, true);
            WriteLiteral("</p>\r\n    <p>Ciudad: ");
            EndContext();
            BeginContext(299, 12, false);
#line 15 "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\Escuela\Index.cshtml"
          Write(Model.Ciudad);

#line default
#line hidden
            EndContext();
            BeginContext(311, 55, true);
            WriteLiteral("</p>\r\n</address>\r\n\r\n<p>\r\n    <strong>Año de fundación: ");
            EndContext();
            BeginContext(367, 20, false);
#line 19 "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\Escuela\Index.cshtml"
                         Write(Model.AnhoDeCreacion);

#line default
#line hidden
            EndContext();
            BeginContext(387, 32, true);
            WriteLiteral(" </strong>\r\n</p>\r\n\r\n<p>\r\n    <i>");
            EndContext();
            BeginContext(420, 24, false);
#line 23 "D:\CURSOS\PLATZI\CURSO ASP.NET\PROYECTOS\App2\Views\Escuela\Index.cshtml"
  Write(ViewData["CosaDinamica"]);

#line default
#line hidden
            EndContext();
            BeginContext(444, 10, true);
            WriteLiteral("</i>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
