#pragma checksum "C:\Users\Vitor\Desktop\CRUDJsl\TruckTravelsCRUD\TruckTravelsCRUD\Views\Shared\_Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f15bb1256514e71e1b742a553ddf21554712f9d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Messages), @"mvc.1.0.view", @"/Views/Shared/_Messages.cshtml")]
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
#line 1 "C:\Users\Vitor\Desktop\CRUDJsl\TruckTravelsCRUD\TruckTravelsCRUD\Views\_ViewImports.cshtml"
using TruckTravelsCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vitor\Desktop\CRUDJsl\TruckTravelsCRUD\TruckTravelsCRUD\Views\_ViewImports.cshtml"
using TruckTravelsCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f15bb1256514e71e1b742a553ddf21554712f9d3", @"/Views/Shared/_Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f39d86c63f0ead5e5d8f56b79b5f5f591e2e24f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"margin-top-15\">\n");
#nullable restore
#line 2 "C:\Users\Vitor\Desktop\CRUDJsl\TruckTravelsCRUD\TruckTravelsCRUD\Views\Shared\_Messages.cshtml"
     if (TempData["success-message"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-success alert-dismissable\">\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">x</button>\n    <span id=\"temp-success\">");
#nullable restore
#line 6 "C:\Users\Vitor\Desktop\CRUDJsl\TruckTravelsCRUD\TruckTravelsCRUD\Views\Shared\_Messages.cshtml"
                       Write(Html.Raw(TempData["success-message"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n</div>");
#nullable restore
#line 7 "C:\Users\Vitor\Desktop\CRUDJsl\TruckTravelsCRUD\TruckTravelsCRUD\Views\Shared\_Messages.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\Vitor\Desktop\CRUDJsl\TruckTravelsCRUD\TruckTravelsCRUD\Views\Shared\_Messages.cshtml"
     if (TempData["error-message"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger alert-dismissable\">\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">x</button>\n    <span id=\"temp-error\">");
#nullable restore
#line 13 "C:\Users\Vitor\Desktop\CRUDJsl\TruckTravelsCRUD\TruckTravelsCRUD\Views\Shared\_Messages.cshtml"
                     Write(Html.Raw(TempData["error-message"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n</div> ");
#nullable restore
#line 14 "C:\Users\Vitor\Desktop\CRUDJsl\TruckTravelsCRUD\TruckTravelsCRUD\Views\Shared\_Messages.cshtml"
       } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""alert alert-success alert-dismissable"" style=""display:none"" id=""alert-success"">
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">x</button>
        <span id=""success-message""></span>
    </div>

    <div class=""alert alert-danger alert-dismissable"" style=""display:none"" id=""alert-error"">
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">x</button>
        <span id=""error-message""></span>
    </div>
</div>");
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