#pragma checksum "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e653d2ba2e5abd325a5265c93068d4ef502b67cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Summary), @"mvc.1.0.view", @"/Views/Pizza/Summary.cshtml")]
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
#line 1 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\_ViewImports.cshtml"
using PizzaMVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\_ViewImports.cshtml"
using PizzaMVCProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e653d2ba2e5abd325a5265c93068d4ef502b67cc", @"/Views/Pizza/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fba24aa64116d227d28cd220be11a10a3e70f50", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaMVCProject.Models.OrderSummary>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
  
    ViewData["Title"] = "Summary";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e653d2ba2e5abd325a5265c93068d4ef502b67cc4307", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Pizzerio</title>
    

    
    <script type=""text/javascript"">
        function showAlert() {
        
        var alert = confirm(""Once Order placed cannot be cancelled.Are you sure you want to continue?"");
        
            if (alert == true) {
                var pizza = (document.getElementById(""PizzaId"").value);
                var Cus = (document.getElementById(""CustomerId"").value);
                var total = (document.getElementById(""TotalAmount"").value);         
                window.location.href = ""/Pizza/FinalOrder?PizzaId="" + pizza + ""&CustomerId="" + Cus + ""&TotalAmount="" + total;
        }
        
      }
    </script>
    ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e653d2ba2e5abd325a5265c93068d4ef502b67cc5999", async() => {
                WriteLiteral("\r\n    \r\n        <section>\r\n            <div class=\"circle\"></div>\r\n            <header>\r\n\r\n                <a href=\"#\" class=\"logo\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e653d2ba2e5abd325a5265c93068d4ef502b67cc6403", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n\r\n            </header>\r\n        </section>\r\n    \r\n    <div>\r\n        <h4>OrderSummary</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e653d2ba2e5abd325a5265c93068d4ef502b67cc7658", async() => {
                    WriteLiteral("\r\n                <input type=\"hidden\" name=\"PizzaId\" id=\"PizzaId\"");
                    BeginWriteAttribute("value", " value=\"", 1217, "\"", 1239, 1);
#nullable restore
#line 44 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
WriteAttributeValue("", 1225, Model.PizzaId, 1225, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                <input type=\"hidden\" name=\"CustomerId\" id=\"CustomerId\"");
                    BeginWriteAttribute("value", " value=\"", 1313, "\"", 1338, 1);
#nullable restore
#line 45 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
WriteAttributeValue("", 1321, Model.CustomerId, 1321, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                <input type=\"hidden\" name=\"TotalAmount\" id=\"TotalAmount\"");
                    BeginWriteAttribute("value", " value=\"", 1414, "\"", 1440, 1);
#nullable restore
#line 46 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
WriteAttributeValue("", 1422, Model.TotalAmount, 1422, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 51 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.PizzaName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 54 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayFor(model => model.PizzaName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 58 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 61 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayFor(model => model.CustomerId, new { @id = "CustomerId" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 64 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 67 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 70 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 73 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayFor(model => model.DeliveryAddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 76 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 79 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 82 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.MobileNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 85 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayFor(model => model.MobileNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 88 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 91 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 94 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.Crust));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 97 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayFor(model => model.Crust));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 100 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.Toppings));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 103 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayFor(model => model.Toppings));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 106 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 109 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
           Write(Html.DisplayFor(model => model.TotalAmount, new { @id = "Amount" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </dd>\r\n           \r\n        </dl>\r\n    </div>\r\n    <div>\r\n\r\n        <input type=\"button\" value=\"Place Order\" onclick=\"showAlert()\" class=\"btn btn-success\" />\r\n        <input type=\"button\" value=\"Back to Menu Page\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4069, "\"", 4122, 3);
                WriteAttributeValue("", 4079, "location.href=\'", 4079, 15, true);
#nullable restore
#line 117 "D:\FinalProjectSoftura\PizzaMVCSolution\PizzaMVCProject\Views\Pizza\Summary.cshtml"
WriteAttributeValue("", 4094, Url.Action("Menu","Pizza"), 4094, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4121, "\'", 4121, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\" />\r\n    </div>\r\n");
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
            WriteLiteral("\r\n    </html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaMVCProject.Models.OrderSummary> Html { get; private set; }
    }
}
#pragma warning restore 1591
