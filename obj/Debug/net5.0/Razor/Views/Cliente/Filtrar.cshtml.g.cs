#pragma checksum "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3862df09bbe2b64e1620f6a6afa19b11ce3fc0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Filtrar), @"mvc.1.0.view", @"/Views/Cliente/Filtrar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3862df09bbe2b64e1620f6a6afa19b11ce3fc0e", @"/Views/Cliente/Filtrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5b9248f994d691e9180a6205fdf6f6bf6fa646", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Filtrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DesingYourParadise.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filtrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
  
    ViewData["Title"] = "Filtrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Filtrar</h1>\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3862df09bbe2b64e1620f6a6afa19b11ce3fc0e4557", async() => {
                WriteLiteral("\r\n    <p>\r\n        Cédula: <input type=\"text\" name=\"cedula\" />\r\n                <button type=\"submit\" class=\"btn btn-info\">Filtrar</button>\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 17 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
 if (ViewBag.condicional == 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\"><p>Debe digitar una cédula existente</p></div>\r\n");
#nullable restore
#line 20 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 23 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
 if (ViewBag.condicional == 2)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\"><p>La cédula digitada no existe</p></div>\r\n");
#nullable restore
#line 26 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
 if (ViewBag.condicional == 3)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
               Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 43 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
                   Write(Html.ActionLink("Editar Cliente", "Edit", new { identificacion = item.Cedula }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 59 "D:\UNED\03075 - Fundamentos de programación web\Proyecto1\DesingYourParadise\Views\Cliente\Filtrar.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
