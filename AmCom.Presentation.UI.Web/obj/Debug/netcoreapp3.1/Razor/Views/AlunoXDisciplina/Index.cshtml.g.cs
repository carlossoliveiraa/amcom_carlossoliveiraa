#pragma checksum "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\AlunoXDisciplina\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1449b98d9bd9d1508eea5b59e148993e45dcef9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlunoXDisciplina_Index), @"mvc.1.0.view", @"/Views/AlunoXDisciplina/Index.cshtml")]
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
#line 1 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\_ViewImports.cshtml"
using AmCom.Presentation.UI.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\_ViewImports.cshtml"
using AmCom.Presentation.UI.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1449b98d9bd9d1508eea5b59e148993e45dcef9a", @"/Views/AlunoXDisciplina/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca3a464512c350ac36fc903a9a03bda609fb88af", @"/Views/_ViewImports.cshtml")]
    public class Views_AlunoXDisciplina_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AmCom.Domain.Entities.Aluno>>
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
            WriteLiteral("\r\n<br />\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1449b98d9bd9d1508eea5b59e148993e45dcef9a3503", async() => {
                WriteLiteral("Novo Aluno");
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

<div class=""card"">
    <div class=""card-header"">
        <h4 class=""card-title""> Alunos Cadastrados</h4>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table"">
                <thead class="" text-primary"">
                <th>
                    Nome
                </th>
                <th>
                    E-mail
                </th>
                <th>
                    Cpf
                </th>
               
                <th colspan=""2"" class=""text-center"">
                    Ações
                </th>
                </thead>
                <tbody>
");
#nullable restore
#line 31 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\AlunoXDisciplina\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 35 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\AlunoXDisciplina\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 38 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\AlunoXDisciplina\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 41 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\AlunoXDisciplina\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>                          \r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 45 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\AlunoXDisciplina\Index.cshtml"
                           Write(Html.ActionLink("Adicionar Disciplina", "AdicionarDisciplinas", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 48 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\AlunoXDisciplina\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AmCom.Domain.Entities.Aluno>> Html { get; private set; }
    }
}
#pragma warning restore 1591
