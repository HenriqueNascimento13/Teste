#pragma checksum "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97e1457a4e4220de8759d2a6c6b96f8b6804355f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservas_Details), @"mvc.1.0.view", @"/Views/Reservas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservas/Details.cshtml", typeof(AspNetCore.Views_Reservas_Details))]
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
#line 1 "C:\Users\admin\Desktop\Booking\Booking\Views\_ViewImports.cshtml"
using Booking;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\Booking\Booking\Views\_ViewImports.cshtml"
using Booking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97e1457a4e4220de8759d2a6c6b96f8b6804355f", @"/Views/Reservas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48cb8ea961cb0ab3563b2a23336f52fa904a03b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking.Reservas>
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
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "_LayoutBack";

#line default
#line hidden
            BeginContext(99, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Reservas</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(222, 48, false);
#line 15 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantAdultos));

#line default
#line hidden
            EndContext();
            BeginContext(270, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(314, 44, false);
#line 18 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuantAdultos));

#line default
#line hidden
            EndContext();
            BeginContext(358, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(402, 49, false);
#line 21 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantCriancas));

#line default
#line hidden
            EndContext();
            BeginContext(451, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(495, 45, false);
#line 24 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuantCriancas));

#line default
#line hidden
            EndContext();
            BeginContext(540, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(584, 43, false);
#line 27 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(627, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(671, 39, false);
#line 30 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayFor(model => model.CheckIn));

#line default
#line hidden
            EndContext();
            BeginContext(710, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(754, 44, false);
#line 33 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CheckOut));

#line default
#line hidden
            EndContext();
            BeginContext(798, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(842, 40, false);
#line 36 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayFor(model => model.CheckOut));

#line default
#line hidden
            EndContext();
            BeginContext(882, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(926, 58, false);
#line 39 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodPagamentoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(984, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1028, 73, false);
#line 42 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodPagamentoNavigation.DataValidadeCartao));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1145, 55, false);
#line 45 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdclienteNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1244, 54, false);
#line 48 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdclienteNavigation.Cc));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1342, 53, false);
#line 51 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdhotelNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1439, 59, false);
#line 54 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdhotelNavigation.CodPostal));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1542, 54, false);
#line 57 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdregimeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1640, 61, false);
#line 60 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdregimeNavigation.TipoRegime));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1745, 58, false);
#line 63 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdtipoQuartoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1847, 64, false);
#line 66 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdtipoQuartoNavigation.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1958, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0973c6d28f7448b5b9aa9e7a483a7714", async() => {
                BeginContext(2011, 4, true);
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
#line 71 "C:\Users\admin\Desktop\Booking\Booking\Views\Reservas\Details.cshtml"
                           WriteLiteral(Model.Idreserva);

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
            BeginContext(2019, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2027, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b64f6a6b92514604b9f8778f72206d57", async() => {
                BeginContext(2049, 12, true);
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
            BeginContext(2065, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking.Reservas> Html { get; private set; }
    }
}
#pragma warning restore 1591
