#pragma checksum "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b0cbbc229391efbd6d147f178e3d09b6fcc17b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Index), @"mvc.1.0.view", @"/Views/People/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/People/Index.cshtml", typeof(AspNetCore.Views_People_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b0cbbc229391efbd6d147f178e3d09b6fcc17b9", @"/Views/People/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05878d26db6e47778f83c9d849fad560de7f5368", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aula06CrudPeople.Models.Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 374, true);
            WriteLiteral(@"
    
</br></br>
<a href=""People/Create"" class=""btn btn-primary"">Nova Pessoa</a>
</br></br>

<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Endereço</th>
                <th></th>
                <th></th>
            </tr>
        </thead>

");
            EndContext();
#line 20 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(474, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(513, 7, false);
#line 23 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Index.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(520, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(548, 9, false);
#line 24 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Index.cshtml"
               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(557, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(585, 12, false);
#line 25 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Index.cshtml"
               Write(item.address);

#line default
#line hidden
            EndContext();
            BeginContext(597, 52, true);
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                    href=\"", 649, "\"", 699, 2);
            WriteAttributeValue("", 677, "People/Delete/", 677, 14, true);
#line 27 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Index.cshtml"
WriteAttributeValue("", 691, item.id, 691, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(700, 65, true);
            WriteLiteral(">Delete</a> </td>\r\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " \r\n                    href=\"", 765, "\"", 814, 2);
            WriteAttributeValue("", 794, "People/Edit/", 794, 12, true);
#line 29 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Index.cshtml"
WriteAttributeValue("", 806, item.id, 806, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(815, 38, true);
            WriteLiteral(">Editar</a> </td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "c:\Users\Andre\Documents\Ulbra\12 Semestre\Linguagem comercial\lpc2019\aula06CrudPeople\Views\People\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(864, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aula06CrudPeople.Models.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591