#pragma checksum "C:\Users\49541849830\Documents\Role-top-projeto-\RoleTOPMVC\Views\Contratar\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e9fafeae87490a663f58e772ef5f98364371bd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e9fafeae87490a663f58e772ef5f98364371bd", @"/Views/Contratar/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51dac2758acc7bd733d17639a392dba085b51c09", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratar_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("toggleMobileMenu()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Selecione", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "furioso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "combo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 76, true);
            WriteLiteral("<DOCTYPE! html>\r\n    <html lang=\"pt-bt\">\r\n    <meta charset=\"utf-8\">\r\n\r\n    ");
            EndContext();
            BeginContext(76, 343, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e9fafeae87490a663f58e772ef5f98364371bd5916", async() => {
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
            BeginContext(431, 6441, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e9fafeae87490a663f58e772ef5f98364371bd7463", async() => {
                BeginContext(437, 682, true);
                WriteLiteral(@"
        <header>

            <img src=""img/logo.roletop.png"" alt=""logo"" style=""width:300; height:250px;"" />
            <br>
            <br>
            <br>
            <br>
            <nav>
                <div class=""section-container"">
                    <ul>
                        <li id=""bt-mobile-menu"">
                            <!-- HTML para colocar os ícones do FA -->
                            <a href=""javascript:void(0);"" class=""icon"" onclick=""toggleMobileMenu()"">
                                <i class=""fa fa-bars""></i>
                            </a>

                        </li>
                        <li class=""bt-common-menu"">");
                EndContext();
                BeginContext(1119, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e9fafeae87490a663f58e772ef5f98364371bd8546", async() => {
                    BeginContext(1207, 4, true);
                    WriteLiteral("Home");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1215, 1579, true);
                WriteLiteral(@"</li>
                        <li class=""bt-common-menu""><a onclick=""toggleMobileMenu()"" href=""eventos.html"">Evento</a></li>
                        <li class=""bt-common-menu""><a onclick=""toggleMobileMenu()""href=""contato.html"">Contato</a></li>
                        <li class=""bt-common-menu""><a onclick=""toggleMobileMenu()"" href=""login.html"">Área do Cliente</a></li>
                        </li>

                    </ul>
                </div>
            </nav>

        </header>

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
                <input class=""inputcontratar"" id=""Endereço"" name=""Endereço"" placehold");
                WriteLiteral(@"er=""Rolêtop@hotmail.com"" autofocus>
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
                    <br>
                    <br>
                    ");
                EndContext();
                BeginContext(2794, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e9fafeae87490a663f58e772ef5f98364371bd12069", async() => {
                    BeginContext(2838, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                BeginContext(2856, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2878, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e9fafeae87490a663f58e772ef5f98364371bd14204", async() => {
                    BeginContext(2902, 9, true);
                    WriteLiteral("Formatura");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2920, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2942, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e9fafeae87490a663f58e772ef5f98364371bd15693", async() => {
                    BeginContext(2964, 4, true);
                    WriteLiteral("Show");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2977, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2999, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e9fafeae87490a663f58e772ef5f98364371bd17177", async() => {
                    BeginContext(3023, 5, true);
                    WriteLiteral("Baile");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3037, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3059, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e9fafeae87490a663f58e772ef5f98364371bd18662", async() => {
                    BeginContext(3081, 18, true);
                    WriteLiteral("Festa de Casamento");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3108, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3130, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e9fafeae87490a663f58e772ef5f98364371bd20161", async() => {
                    BeginContext(3152, 14, true);
                    WriteLiteral("Festa Infantil");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3175, 3690, true);
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
            BeginContext(6872, 15, true);
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
