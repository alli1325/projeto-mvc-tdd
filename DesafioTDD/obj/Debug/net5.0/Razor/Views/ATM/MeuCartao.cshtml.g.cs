#pragma checksum "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2324d493849c47e705e8aea0db870726ebeda83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ATM_MeuCartao), @"mvc.1.0.view", @"/Views/ATM/MeuCartao.cshtml")]
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
#line 1 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\_ViewImports.cshtml"
using DesafioTDD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\_ViewImports.cshtml"
using DesafioTDD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2324d493849c47e705e8aea0db870726ebeda83", @"/Views/ATM/MeuCartao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e59c750e6dc4a4c7b318c6e5d300830ff58915a", @"/Views/_ViewImports.cshtml")]
    public class Views_ATM_MeuCartao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DesafioTDD.DTO.CartaoDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("arrow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Depositar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ATM", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sacar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
  
    ViewData["Title"] = "Meu Cartao";
    var NumeroSemEspaco = @Model.Numero.Replace(" ", "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2324d493849c47e705e8aea0db870726ebeda836793", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Lato:wght@300;400;900&family=Poppins:wght@300;400;500;600;700&family=Roboto:wght@400;500;700;900&display=swap"" rel=""stylesheet"">
    
    <!-- Bootstrap -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-i");
                WriteLiteral("cons@1.8.1/font/bootstrap-icons.css\">\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2324d493849c47e705e8aea0db870726ebeda838196", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Meu Cartão</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2324d493849c47e705e8aea0db870726ebeda8310112", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"device\">\r\n            <div class=\"header\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2324d493849c47e705e8aea0db870726ebeda8310492", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
            <div class=""cards"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""card-upper"">
                            <div class=""chip""></div>
                            <div class=""wifi""></div>
                        </div>
                        <div class=""card-bottom"">
                            <div class=""number"">");
#nullable restore
#line 39 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                                           Write(Model.Numero);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                            <div class=\"mastercard\"></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"buttons\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2324d493849c47e705e8aea0db870726ebeda8312925", async() => {
                    WriteLiteral("\r\n                        <input type=\"hidden\" name=\"numeroCartao\" id=\"numeroCartao\"");
                    BeginWriteAttribute("value", " value=\"", 2302, "\"", 2326, 1);
#nullable restore
#line 46 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
WriteAttributeValue("", 2310, NumeroSemEspaco, 2310, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                        <button class=""deposito btn"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""#FFF"" class=""bi bi-piggy-bank"" viewBox=""0 0 16 16"">
                                <path d=""M5 6.25a.75.75 0 1 1-1.5 0 .75.75 0 0 1 1.5 0zm1.138-1.496A6.613 6.613 0 0 1 7.964 4.5c.666 0 1.303.097 1.893.273a.5.5 0 0 0 .286-.958A7.602 7.602 0 0 0 7.964 3.5c-.734 0-1.441.103-2.102.292a.5.5 0 1 0 .276.962z""/>
                                <path fill-rule=""evenodd"" d=""M7.964 1.527c-2.977 0-5.571 1.704-6.32 4.125h-.55A1 1 0 0 0 .11 6.824l.254 1.46a1.5 1.5 0 0 0 1.478 1.243h.263c.3.513.688.978 1.145 1.382l-.729 2.477a.5.5 0 0 0 .48.641h2a.5.5 0 0 0 .471-.332l.482-1.351c.635.173 1.31.267 2.011.267.707 0 1.388-.095 2.028-.272l.543 1.372a.5.5 0 0 0 .465.316h2a.5.5 0 0 0 .478-.645l-.761-2.506C13.81 9.895 14.5 8.559 14.5 7.069c0-.145-.007-.29-.02-.431.261-.11.508-.266.705-.444.315.306.815.306.815-.417 0 .223-.5.223-.461-.026a.95.95 0 0 0 .09-.255.7.7 0 0 0-.202-.6");
                    WriteLiteral(@"45.58.58 0 0 0-.707-.098.735.735 0 0 0-.375.562c-.024.243.082.48.32.654a2.112 2.112 0 0 1-.259.153c-.534-2.664-3.284-4.595-6.442-4.595zM2.516 6.26c.455-2.066 2.667-3.733 5.448-3.733 3.146 0 5.536 2.114 5.536 4.542 0 1.254-.624 2.41-1.67 3.248a.5.5 0 0 0-.165.535l.66 2.175h-.985l-.59-1.487a.5.5 0 0 0-.629-.288c-.661.23-1.39.359-2.157.359a6.558 6.558 0 0 1-2.157-.359.5.5 0 0 0-.635.304l-.525 1.471h-.979l.633-2.15a.5.5 0 0 0-.17-.534 4.649 4.649 0 0 1-1.284-1.541.5.5 0 0 0-.446-.275h-.56a.5.5 0 0 1-.492-.414l-.254-1.46h.933a.5.5 0 0 0 .488-.393zm12.621-.857a.565.565 0 0 1-.098.21.704.704 0 0 1-.044-.025c-.146-.09-.157-.175-.152-.223a.236.236 0 0 1 .117-.173c.049-.027.08-.021.113.012a.202.202 0 0 1 .064.199z""/>
                            </svg>
                            <span>Depositar</span>
                        </button>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2324d493849c47e705e8aea0db870726ebeda8317119", async() => {
                    WriteLiteral("\r\n                        <input type=\"hidden\" name=\"numeroCartao\" id=\"numeroCartao\"");
                    BeginWriteAttribute("value", " value=\"", 4372, "\"", 4396, 1);
#nullable restore
#line 56 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
WriteAttributeValue("", 4380, NumeroSemEspaco, 4380, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                        <button class=""saque btn"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""#FFF"" class=""bi bi-currency-dollar"" viewBox=""0 0 16 16"">
                                <path d=""M4 10.781c.148 1.667 1.513 2.85 3.591 3.003V15h1.043v-1.216c2.27-.179 3.678-1.438 3.678-3.3 0-1.59-.947-2.51-2.956-3.028l-.722-.187V3.467c1.122.11 1.879.714 2.07 1.616h1.47c-.166-1.6-1.54-2.748-3.54-2.875V1H7.591v1.233c-1.939.23-3.27 1.472-3.27 3.156 0 1.454.966 2.483 2.661 2.917l.61.162v4.031c-1.149-.17-1.94-.8-2.131-1.718H4zm3.391-3.836c-1.043-.263-1.6-.825-1.6-1.616 0-.944.704-1.641 1.8-1.828v3.495l-.2-.05zm1.591 1.872c1.287.323 1.852.859 1.852 1.769 0 1.097-.826 1.828-2.2 1.939V8.73l.348.086z""/>
                            </svg>
                            <span>Sacar</span>
                        </button>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"funds\">\r\n                    <div>Saldo Disponível:</div>\r\n                    <div class=\"amount\">R$");
#nullable restore
#line 67 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                                     Write(Model.Saldo.ToString("0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"transactions\">\r\n                    <h2>Extrato</h2>\r\n");
#nullable restore
#line 71 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                     if(Model.Extrato.FirstOrDefault() == null){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"operation\">\r\n                                <div class=\"info\">\r\n                                    Não há operações neste cartão\r\n                                </div>\r\n                        </div>\r\n");
#nullable restore
#line 77 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                    }else{
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                         foreach(var view in Model.Extrato){
                            if(view.Tipo == "Saque"){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"operation\">\r\n                                    <div class=\"info\">\r\n                                        <h3>");
#nullable restore
#line 82 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                                       Write(view.Tipo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                        <span>");
#nullable restore
#line 83 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                                         Write(view.Data);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"amount withdraw\">-R$");
#nullable restore
#line 85 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                                                               Write(view.Valor.ToString("0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n");
#nullable restore
#line 87 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                            }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"operation\">\r\n                                    <div class=\"info\">\r\n                                        <h3>");
#nullable restore
#line 90 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                                       Write(view.Tipo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                        <span>");
#nullable restore
#line 91 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                                         Write(view.Data);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"amount deposit\">+R$");
#nullable restore
#line 93 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                                                              Write(view.Valor.ToString("0.00"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n");
#nullable restore
#line 95 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\alor\OneDrive - GFT Technologies SE\Desktop\Treinamento\cluster\DesafioTDD\Views\ATM\MeuCartao.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DesafioTDD.DTO.CartaoDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
