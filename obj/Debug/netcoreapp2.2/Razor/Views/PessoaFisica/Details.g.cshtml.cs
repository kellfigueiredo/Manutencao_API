#pragma checksum "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eba777b7ae1166935143160022af65372919787"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PessoaFisica_Details), @"mvc.1.0.view", @"/Views/PessoaFisica/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PessoaFisica/Details.cshtml", typeof(AspNetCore.Views_PessoaFisica_Details))]
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
#line 1 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\_ViewImports.cshtml"
using Cadastro;

#line default
#line hidden
#line 2 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\_ViewImports.cshtml"
using Cadastro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eba777b7ae1166935143160022af65372919787", @"/Views/PessoaFisica/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33aeb0532b4503ec13abfff6c6e730edb9392de", @"/Views/_ViewImports.cshtml")]
    public class Views_PessoaFisica_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cadastro.Models.PessoaFisica>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 133, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>PessoaFisica</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(216, 39, false);
#line 14 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(255, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(317, 35, false);
#line 17 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(352, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(413, 40, false);
#line 20 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(453, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(515, 36, false);
#line 23 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(551, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(612, 38, false);
#line 26 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RG));

#line default
#line hidden
            EndContext();
            BeginContext(650, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(712, 34, false);
#line 29 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.RG));

#line default
#line hidden
            EndContext();
            BeginContext(746, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(807, 55, false);
#line 32 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(862, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(924, 51, false);
#line 35 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.Logradouro));

#line default
#line hidden
            EndContext();
            BeginContext(975, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1036, 51, false);
#line 38 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1149, 47, false);
#line 41 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1257, 51, false);
#line 44 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1370, 47, false);
#line 47 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1478, 48, false);
#line 50 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1588, 44, false);
#line 53 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1693, 54, false);
#line 56 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco.Municipio));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1809, 50, false);
#line 59 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.Municipio));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1920, 47, false);
#line 62 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco.UF));

#line default
#line hidden
            EndContext();
            BeginContext(1967, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2029, 43, false);
#line 65 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco.UF));

#line default
#line hidden
            EndContext();
            BeginContext(2072, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2133, 49, false);
#line 68 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(2182, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2244, 45, false);
#line 71 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(2289, 45, true);
            WriteLiteral("\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2335, 51, false);
#line 73 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(2386, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2448, 47, false);
#line 76 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(2495, 60, true);
            WriteLiteral("\r\n        </dd>\r\n         \r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2555, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eba777b7ae1166935143160022af6537291978713565", async() => {
                BeginContext(2613, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "D:\Consultoria\MGN\Manutencao\Manutencao_API\Views\PessoaFisica\Details.cshtml"
                           WriteLiteral(Model.PessoaFisicaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2621, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2629, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eba777b7ae1166935143160022af6537291978715898", async() => {
                BeginContext(2651, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2667, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cadastro.Models.PessoaFisica> Html { get; private set; }
    }
}
#pragma warning restore 1591
