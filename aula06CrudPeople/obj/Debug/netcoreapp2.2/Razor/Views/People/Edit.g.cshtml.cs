#pragma checksum "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1601173a8a5a1c5215a4da83cdfcb8275bd18217"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Edit), @"mvc.1.0.view", @"/Views/People/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/People/Edit.cshtml", typeof(AspNetCore.Views_People_Edit))]
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
#line 1 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\_ViewImports.cshtml"
using aula06CrudPeople;

#line default
#line hidden
#line 2 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\_ViewImports.cshtml"
using aula06CrudPeople.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1601173a8a5a1c5215a4da83cdfcb8275bd18217", @"/Views/People/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05878d26db6e47778f83c9d849fad560de7f5368", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<aula06CrudPeople.Models.Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 37, true);
            WriteLiteral("\r\n<div class=\"form-horizontal\">\r\n    ");
            EndContext();
            BeginContext(76, 780, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1601173a8a5a1c5215a4da83cdfcb8275bd182174141", async() => {
                BeginContext(110, 152, true);
                WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            <label>Id</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value = \"", 262, "\"", 302, 1);
#line 10 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Edit.cshtml"
WriteAttributeValue("", 293, Model.id, 293, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(303, 174, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Nome</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", "      value=\"", 477, "\"", 501, 1);
#line 16 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Edit.cshtml"
WriteAttributeValue("", 490, Model.name, 490, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(502, 181, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Endereço</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"address\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value = \"", 683, "\"", 728, 1);
#line 23 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Edit.cshtml"
WriteAttributeValue("", 714, Model.address, 714, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(729, 120, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n\r\n        <input  class=\"btn btn-primary\" \r\n                type=\"submit\" value=\"Salvar\"/>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(856, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<aula06CrudPeople.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
