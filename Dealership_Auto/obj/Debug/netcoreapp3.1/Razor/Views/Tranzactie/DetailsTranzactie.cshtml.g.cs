#pragma checksum "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da7cf6d0d0284f122115e74e656d4ea02bd17f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tranzactie_DetailsTranzactie), @"mvc.1.0.view", @"/Views/Tranzactie/DetailsTranzactie.cshtml")]
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
#line 1 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\_ViewImports.cshtml"
using Dealership_Auto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\_ViewImports.cshtml"
using Dealership_Auto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da7cf6d0d0284f122115e74e656d4ea02bd17f5f", @"/Views/Tranzactie/DetailsTranzactie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fd30592026e550b36cd2440ff1af92235dbc24c", @"/Views/_ViewImports.cshtml")]
    public class Views_Tranzactie_DetailsTranzactie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dealership_Auto.Models.Tranzactie>
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
#line 3 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>View</h1>\r\n\r\n<div>\r\n    <h4>Tranzactie</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.TranzactieID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.TranzactieID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.MasinaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.MasinaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.AngajatID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.AngajatID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.ClientID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.Suma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.Suma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.masina.MasinaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.masina.MasinaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.masina.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.masina.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.masina.Producator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.masina.Producator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.masina.Pret));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.masina.Pret));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.masina.Motorizare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.masina.Motorizare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.masina.Combustibil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.masina.Combustibil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.masina.Culoare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.masina.Culoare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            Anul Fabricatiei\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.masina.AnFabricatie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.masina.KM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.masina.KM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.masina.Descriere));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.masina.Descriere));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.client.ClientID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.client.ClientID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.client.Nume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.client.Nume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.client.Prenume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.client.Prenume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.client.Adresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.client.Adresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.client.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.client.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.client.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.client.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.angajat.AngajatID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.angajat.AngajatID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.angajat.Nume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.angajat.Nume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.angajat.Prenume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.angajat.Prenume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.angajat.Adresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.angajat.Adresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.angajat.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.angajat.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayNameFor(model => model.angajat.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
       Write(Html.DisplayFor(model => model.angajat.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 185 "C:\Users\Florin\Desktop\Anul 3\Semestrul 1\BD\Dealership_Auto\Dealership_Auto\Views\Tranzactie\DetailsTranzactie.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da7cf6d0d0284f122115e74e656d4ea02bd17f5f24455", async() => {
                WriteLiteral("Back to List");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dealership_Auto.Models.Tranzactie> Html { get; private set; }
    }
}
#pragma warning restore 1591