#pragma checksum "C:\Users\49541849830\Documents\Role-top-projeto-\RoleTOPMVC\Views\Contratar\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41240de1106100c37055e2322cc06c22c6f26c9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratar_index), @"mvc.1.0.view", @"/Views/Contratar/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contratar/index.cshtml", typeof(AspNetCore.Views_Contratar_index))]
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
#line 1 "C:\Users\49541849830\Documents\Role-top-projeto-\RoleTOPMVC\Views\_ViewImports.cshtml"
using RoleTOPMVC;

#line default
#line hidden
#line 2 "C:\Users\49541849830\Documents\Role-top-projeto-\RoleTOPMVC\Views\_ViewImports.cshtml"
using RoleTOPMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41240de1106100c37055e2322cc06c22c6f26c9b", @"/Views/Contratar/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dac2758acc7bd733d17639a392dba085b51c09", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratar_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Selecione", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "furioso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "combo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 76, true);
            WriteLiteral("<DOCTYPE! html>\r\n    <html lang=\"pt-bt\">\r\n    <meta charset=\"utf-8\">\r\n\r\n    ");
            EndContext();
            BeginContext(76, 343, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41240de1106100c37055e2322cc06c22c6f26c9b4475", async() => {
                BeginContext(82, 330, true);
                WriteLiteral(@"
        <title> Rolê TOP</title>
        <link rel=""stylesheet"" type=""text/css"" href=""css/cadastro.css"">
        <link rel=""stylesheet"" type=""text/css"" href=""css/style.css"">
        <link rel=""stylesheet"" type=""text/css"" href=""css/roletop.css"">
        <script src=""https://kit.fontawesome.com/349a64cb04.js""></script>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(419, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(431, 5174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41240de1106100c37055e2322cc06c22c6f26c9b6022", async() => {
                BeginContext(437, 1090, true);
                WriteLiteral(@"
      

        <div class=""contratar"">
            <div id=""tabela1"">

                <h5>Contratar o serviço</h5>
                <br>

                <label for=""nome"">Nome Completo</label>
                <input class=""inputcontratar"" name=""nome"" maxlength=""20"" minlength=""3"" placeholder=""Usuário"" autofocus>
                </br>
                </br>
                <br>

                <label for=""Endereço"">Email</label>
                <input class=""inputcontratar"" id=""Endereço"" name=""Endereço"" placeholder=""Rolêtop@hotmail.com"" autofocus>
                <br>
                </br>
                </br>

                <label for=""nome"">Data da Festa</label>
                <input class=""inputcontratar"" id=""nome"" name=""nome"" maxlength=""20"" minlength=""3"" placeholder=""dd/mm/nn""
                    autofocus>
                <br>
                <br>

                <label for=""tipo de festa"">Tipo de festa</label>
                <select id=""tipo de festa"" required>
      ");
                WriteLiteral("              <br>\r\n                    <br>\r\n                    ");
                EndContext();
                BeginContext(1527, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41240de1106100c37055e2322cc06c22c6f26c9b7577", async() => {
                    BeginContext(1571, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1589, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1611, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41240de1106100c37055e2322cc06c22c6f26c9b9711", async() => {
                    BeginContext(1635, 9, true);
                    WriteLiteral("Formatura");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1653, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1675, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41240de1106100c37055e2322cc06c22c6f26c9b11199", async() => {
                    BeginContext(1697, 4, true);
                    WriteLiteral("Show");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1710, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1732, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41240de1106100c37055e2322cc06c22c6f26c9b12683", async() => {
                    BeginContext(1756, 5, true);
                    WriteLiteral("Baile");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1770, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1792, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41240de1106100c37055e2322cc06c22c6f26c9b14168", async() => {
                    BeginContext(1814, 18, true);
                    WriteLiteral("Festa de Casamento");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1841, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1863, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41240de1106100c37055e2322cc06c22c6f26c9b15667", async() => {
                    BeginContext(1885, 14, true);
                    WriteLiteral("Festa Infantil");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1908, 3690, true);
                WriteLiteral(@"
                </select>
                <br>
                <br>

                <label for=""Endereço"">Qtde de pessoas</label>
                <input class=""inputcontratar"" id=""Endereço"" maxlength=""20"" minlength=""3"" placeholder=""123"" autofocus>
                <br>
                <br>
                <br>
                <label for=""nome"">Horário da festa</label>
                <input class=""inputcontratar"" id=""nome"" name=""nome"" maxlength=""20"" minlength=""3"" placeholder=""00:00""
                    autofocus>
                <br>
                <br>
                <h5>Pagamento</h5>
                <br>

                <label for=""nome"">Número do Evento</label>
                <input id=""nome"" name=""nome"" maxlength=""20"" minlength=""3"" placeholder=""123"" autofocus>
                </br>
                </br>
                <label for=""nome"">Orçamento do Evento</label>
                <input id=""nome"" name=""nome"" maxlength=""20"" minlength=""3"" placeholder=""R$10000"" autofocus>

    ");
                WriteLiteral(@"            <br>
                <br>
                <input class=""inputcontratar"" type=""submit"" value=""Contratar Evento"" />
            </div>
            <div id=""tabela03"">
                <br>

                <p>Irá utilizar algum serviço do Rolê TOP?</p>
                <br>
                <p>
                    <input type=""checkbox"" name=""citizenship"" /> Sim<br />
                    <br>
                    <input type=""checkbox"" name=""citizenship"" /> Não<br />

                </p>
                <p>Qual?</p>
                <br>
                <p>
                    <input type=""checkbox"" name=""citizenship"" /> Iluminação<br />
                    <br>
                    <input type=""checkbox"" name=""citizenship"" /> Som<br />

                </p>

                <p>Selecionar os espaços que serão utilizados</p>
                <br>
                <p>
                    <input type=""checkbox"" name=""citizenship"" /> Palco<br />
                    <br>
           ");
                WriteLiteral(@"         <input type=""checkbox"" name=""citizenship"" /> Cozinha<br />
                    <br>
                    <br>
                    <img src=""img/meiospagamento.JPG"" style=""width:400; height:400px"">
                </p>
            </div>
        </div>


        <h5>Pagamento</h5>
        <br>


        <section>
            <P>Alameida Barão de Limeira, 539 Santa Cecília,São Paulo - SP 01202-001 </P>
            <P>Telefone:(011) 3273-5000</P>
            <P>Facebook/RolêTOP</P>
            <p>Instagram/RolêTOP</p>
            <a href=""#"">Voltar para o topo!</a>
        </section>
        <script>
            function toggleMobileMenu() {
                var ul = document.querySelector(""nav ul"");
                var commonButtons = document.querySelectorAll(""nav .bt-common-menu"");
                var icon = document.querySelector("".icon > i"");

                ul.classList.toggle(""mobile-mode"");

                if (icon.classList.contains(""fa-bars"")) {
                   ");
                WriteLiteral(@" icon.classList.remove(""fa-bars"");
                    icon.classList.remove(""fa"");

                    icon.classList.add(""fas"");
                    icon.classList.add(""fa-times"");
                } else {
                    icon.classList.remove(""fas"");
                    icon.classList.remove(""fa-times"");

                    icon.classList.add(""fa"");
                    icon.classList.add(""fa-bars"");
                }

                for (var button of commonButtons) {
                    button.classList.toggle(""active"");
                }

            }
        </script>



    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5605, 15, true);
            WriteLiteral("\r\n\r\n    </html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
