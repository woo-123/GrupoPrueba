#pragma checksum "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d2686764e9f6fafad859dac3791e02f7cbc48bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo_Index), @"mvc.1.0.view", @"/Views/Catalogo/Index.cshtml")]
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
#line 1 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\_ViewImports.cshtml"
using GrupoPrueba;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\_ViewImports.cshtml"
using GrupoPrueba.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d2686764e9f6fafad859dac3791e02f7cbc48bf", @"/Views/Catalogo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbbd2a7cc59626795a56831a6f0c71ac400e9e4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GrupoPrueba.Models.Catalogo>>
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
#line 3 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
  
    ViewData["Title"] = "Procesadores";  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-decoration:none;\r\n    font-size: 4em;\r\n    color:#fa9600;\r\n    text-align: center;\r\n    font-weight: bold;\">");
#nullable restore
#line 11 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n  <div>\r\n    <h1>");
#nullable restore
#line 13 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n      <div class=\"col\">\r\n        <div id=\"products\" class=\"mb-3\">\r\n          <div class=\"row\">\r\n");
#nullable restore
#line 18 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
             foreach (var item in Model) {
             if(item.Id < 5 ){ 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-sm-4"">
              <div class=""card mb-3"" style=""margin-left: 10%; margin-right: 30%;"" >
                <div class=""card-body"">
                  <div class=""card-img-actions"">
                    <img class=""img-responsive"" width=""96"" height=""150"" style=""margin-left:35%;""");
            BeginWriteAttribute("src", " \r\n                       src=\"", 800, "\"", 852, 2);
            WriteAttributeValue("", 831, "/img/", 831, 5, true);
#nullable restore
#line 25 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
WriteAttributeValue("", 836, item.ImagenName, 836, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 853, "\"", 875, 1);
#nullable restore
#line 25 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
WriteAttributeValue("", 859, item.ImagenName, 859, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n                  </div>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                  <h5 class=\"card-title\">");
#nullable restore
#line 29 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 30 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  <p class=\"card-text\">");
#nullable restore
#line 31 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b>soles </b></p>\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d2686764e9f6fafad859dac3791e02f7cbc48bf8299", async() => {
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
#line 32 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
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
#line 36 "D:\Onedrive USMP\OneDrive - Universidad de San Martin de Porres\Universidad\2021-2\PROGRAMACIÓN 1\Repositorios\GrupoPrueba-9\GrupoPrueba\Views\Catalogo\Index.cshtml"
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
