#pragma checksum "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06cdf50c5a00c4101e841066c94a88ec609352f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo_Disco), @"mvc.1.0.view", @"/Views/Catalogo/Disco.cshtml")]
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
#line 1 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\_ViewImports.cshtml"
using GrupoPrueba;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\_ViewImports.cshtml"
using GrupoPrueba.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06cdf50c5a00c4101e841066c94a88ec609352f4", @"/Views/Catalogo/Disco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbbd2a7cc59626795a56831a6f0c71ac400e9e4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo_Disco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GrupoPrueba.Models.Catalogo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
  
    ViewData["Title"] = "Disco Duro";  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-decoration:none;\r\n    font-size: 4em;\r\n    color:#fa9600;\r\n    text-align: center;\r\n    font-weight: bold;\">");
#nullable restore
#line 11 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n  <div>\r\n    <h1>");
#nullable restore
#line 13 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n      <div class=\"col\">\r\n        <div id=\"products\" class=\"mb-3\">\r\n          <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
             foreach (var item in Model) {
              if(item.Id >= 17 && item.Id < 21){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-sm-4"">
              <div class=""card mb-3"" style=""margin-left: 10%; margin-right: 30%;"" >
                <div class=""card-body"">
                  <div class=""card-img-actions"">
                    <img class=""img-responsive"" width=""96"" height=""150"" style=""margin-left:35%;""");
            BeginWriteAttribute("src", " \r\n                       src=\"", 815, "\"", 867, 2);
            WriteAttributeValue("", 846, "/img/", 846, 5, true);
#nullable restore
#line 25 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
WriteAttributeValue("", 851, item.ImagenName, 851, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 868, "\"", 890, 1);
#nullable restore
#line 25 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
WriteAttributeValue("", 874, item.ImagenName, 874, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n                  </div>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                  <h5 class=\"card-title\">");
#nullable restore
#line 29 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 30 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b>soles </b></p>\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06cdf50c5a00c4101e841066c94a88ec609352f47234", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </div>\r\n              </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\diego\Desktop\GrupoPrueba\GrupoPrueba\Views\Catalogo\Disco.cshtml"
              }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("         </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GrupoPrueba.Models.Catalogo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
