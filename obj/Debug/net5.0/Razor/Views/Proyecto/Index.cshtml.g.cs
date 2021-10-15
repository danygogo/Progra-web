#pragma checksum "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feacfc8808fdc73c9075c3bac1601339f5d7b649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proyecto_Index), @"mvc.1.0.view", @"/Views/Proyecto/Index.cshtml")]
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
#line 1 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\_ViewImports.cshtml"
using DesingYourParadise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\_ViewImports.cshtml"
using DesingYourParadise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feacfc8808fdc73c9075c3bac1601339f5d7b649", @"/Views/Proyecto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5b9248f994d691e9180a6205fdf6f6bf6fa646", @"/Views/_ViewImports.cshtml")]
    public class Views_Proyecto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DesingYourParadise.Models.Proyecto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Listado de proyectos</h1>

<p>
    <a href = ""cliente/index"">Volver a clientes</a>
</p>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Código
            </th>
            <th>
                Nombre Proyecto
            </th>
            <th>
                # Dormitorios
            </th>
            <th>
                # Baños completos
            </th>
            <th>
                # Medios baños
            </th>
            <th>
                Sala y cocina integrados
            </th>
            <th>
                Cuarto de pilas abierto
            </th>
            <th>
                Tamaño Terraza
            </th>
            <th>
                Tipo de piso
            </th>
            <th>
                Muebles de cocina
            </th>
            <th>
                Metros de construcción
            </th>
            <th>
                Costo
            </th>
            <th></th>
        ");
            WriteLiteral("</tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 56 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdProyecto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NombreProyecto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.dormitorios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.halfBathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SalaMasCocina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PilasAbierta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.terraza));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 84 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.piso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 87 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.mueble));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.metros));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 93 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.costo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
            WriteLiteral("            <!--\r\n            <td>\r\n                ");
#nullable restore
#line 100 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 101 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 102 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        -->\r\n");
#nullable restore
#line 105 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Proyecto\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DesingYourParadise.Models.Proyecto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
