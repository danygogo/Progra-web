#pragma checksum "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3b119b8370997bcad197f4da3c78121312ec2d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proyecto_Details), @"mvc.1.0.view", @"/Views/Proyecto/Details.cshtml")]
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
#line 1 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\_ViewImports.cshtml"
using DesingYourParadise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\_ViewImports.cshtml"
using DesingYourParadise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b119b8370997bcad197f4da3c78121312ec2d3", @"/Views/Proyecto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5b9248f994d691e9180a6205fdf6f6bf6fa646", @"/Views/_ViewImports.cshtml")]
    public class Views_Proyecto_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DesingYourParadise.Models.Proyecto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Detalles del proyecto</h2>\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n     \r\n        <dt class=\"col-sm-2\">\r\n            Código de proyecto\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdProyecto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Cédula del cliente\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Nombre Proyecto\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombreProyecto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Cantidad de dormitorios\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dormitorios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Cantidad de baños completos\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Cantidad de medios baños\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.HalfBathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Sala integrada con la cocina\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.SalaMasCocina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Cuarto de pilas abierto\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.PilasAbierta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Tamaño de terraza\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Terraza));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Tipo de piso\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Piso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Muebles de cocina\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mueble));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Rango en m2\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Metros));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Costo m2 en colones\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Costo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Costo m2 en dólares\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
       Write(Html.DisplayFor(model => model.Costo_Dolar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Imagen ilustrativa\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n");
#nullable restore
#line 103 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
             if (ViewBag.imagenEncontrada)
            {
                
                    var base64 = Convert.ToBase64String(ViewBag.picture);
                    var imgFuente = String.Format("data:image/gif;base64,{0}", base64);
                


#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\'", 3128, "\'", 3144, 1);
#nullable restore
#line 110 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
WriteAttributeValue("", 3134, imgFuente, 3134, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:200px; max-height:200px;\" />\r\n");
#nullable restore
#line 111 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Cliente no suministra</p>\r\n");
#nullable restore
#line 115 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n    </dl>\r\n\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 123 "D:\UNED\03075 - Fundamentos de programación web\Proyecto2\DesingYourParadise\Views\Proyecto\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3b119b8370997bcad197f4da3c78121312ec2d311930", async() => {
                WriteLiteral("Regresar a la lista de proyectos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DesingYourParadise.Models.Proyecto> Html { get; private set; }
    }
}
#pragma warning restore 1591
