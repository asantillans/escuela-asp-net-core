#pragma checksum "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3891b6f49a6ebd093d5183eaec9d3ee7de65b370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asignatura_MultiAsignatura), @"mvc.1.0.view", @"/Views/Asignatura/MultiAsignatura.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asignatura/MultiAsignatura.cshtml", typeof(AspNetCore.Views_Asignatura_MultiAsignatura))]
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
#line 1 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/_ViewImports.cshtml"
using Facturacion;

#line default
#line hidden
#line 2 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/_ViewImports.cshtml"
using Facturacion.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3891b6f49a6ebd093d5183eaec9d3ee7de65b370", @"/Views/Asignatura/MultiAsignatura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"153ee7efab221d60c64a3540c1ed58e66c8c7ba0", @"/Views/_ViewImports.cshtml")]
    public class Views_Asignatura_MultiAsignatura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Asignatura>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ObjetoEscuelaSimple", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml"
  
    ViewData["Title"] = "Información Asignatura";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(107, 8, true);
            WriteLiteral("\r\n\r\n<h1>");
            EndContext();
            BeginContext(116, 17, false);
#line 8 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(133, 54, true);
            WriteLiteral(" </h1>\r\n\r\n<strong> Desde la vista parcial</strong>\r\n\r\n");
            EndContext();
#line 12 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml"
 foreach (var asignatura in Model)
{

#line default
#line hidden
            BeginContext(226, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(230, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3891b6f49a6ebd093d5183eaec9d3ee7de65b3704583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 14 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = asignatura;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(289, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml"
}

#line default
#line hidden
            BeginContext(294, 8, true);
            WriteLiteral("\r\n<p><i>");
            EndContext();
            BeginContext(303, 13, false);
#line 17 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml"
 Write(ViewBag.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(316, 9, true);
            WriteLiteral(" </i></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Asignatura>> Html { get; private set; }
    }
}
#pragma warning restore 1591
