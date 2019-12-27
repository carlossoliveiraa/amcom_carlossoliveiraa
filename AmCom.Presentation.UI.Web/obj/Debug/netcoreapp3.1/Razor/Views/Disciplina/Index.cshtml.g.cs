#pragma checksum "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\Disciplina\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5359b9aa92b1e12785a3cd29c558f3c5d579c941"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disciplina_Index), @"mvc.1.0.view", @"/Views/Disciplina/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5359b9aa92b1e12785a3cd29c558f3c5d579c941", @"/Views/Disciplina/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca3a464512c350ac36fc903a9a03bda609fb88af", @"/Views/_ViewImports.cshtml")]
    public class Views_Disciplina_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AmCom.Domain.Entities.Disciplina>>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5359b9aa92b1e12785a3cd29c558f3c5d579c9413478", async() => {
                WriteLiteral("Nova Disciplina");
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
        <h4 class=""card-title""> Disciplinas Cadastradas</h4>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table"">
                 
                <th>
                    Disciplina
                </th>
               
                <th colspan=""2"" class=""text-center"">
                    Ações
                </th>
                
                <tbody>
");
#nullable restore
#line 25 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\Disciplina\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 29 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\Disciplina\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                           \r\n                            <td>\r\n                                ");
#nullable restore
#line 33 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\Disciplina\Index.cshtml"
                           Write(Html.ActionLink("Editar", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n                                ");
#nullable restore
#line 35 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\Disciplina\Index.cshtml"
                           Write(Html.ActionLink("Deletar", "Delete", new { id = item.Id }, new { onclick = "return confirm('Deseja apagar este registro?');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                               \r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 39 "C:\Projetos\APROVADO\AmCom\AmCom.Presentation.UI.Web\Views\Disciplina\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AmCom.Domain.Entities.Disciplina>> Html { get; private set; }
    }
}
#pragma warning restore 1591
