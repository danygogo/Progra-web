#pragma checksum "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7438422d7ed1ad78bb68b9957c76c47268158f37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7438422d7ed1ad78bb68b9957c76c47268158f37", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5b9248f994d691e9180a6205fdf6f6bf6fa646", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DesingYourParadise.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listado de Clientes</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7438422d7ed1ad78bb68b9957c76c47268158f373805", async() => {
                WriteLiteral("Nuevo Cliente");
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
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Cédula
            </th>
            <th>
                Nombre
            </th>
            <th>
                Telefono
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Index.cshtml"
           Write(Html.ActionLink("Editar Cliente", "Edit", new { identificacion = item.Cedula }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!--Orden del actionLink:  \"texto\", \"vista\", \"controlador\"-->\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Index.cshtml"
           Write(Html.ActionLink("Crear proyecto", "Create", "Proyecto", new { identificacion = item.Cedula }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Index.cshtml"
           Write(Html.ActionLink("Ver proyectos", "Index", "Proyecto", new { identificacion = item.Cedula }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 54 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DesingYourParadise.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
