#pragma checksum "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Asp.net intro\Asp.net intro\Views\SingUp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61a4b7fda18632078ee21755763094445e72fe34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SingUp_Index), @"mvc.1.0.view", @"/Views/SingUp/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61a4b7fda18632078ee21755763094445e72fe34", @"/Views/SingUp/Index.cshtml")]
    #nullable restore
    public class Views_SingUp_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Asp.net intro\Asp.net intro\Views\SingUp\Index.cshtml"
  
    string[] names = { "Huseyn", "Ferid", "Eli", "Veli" };

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 style=\"color:red\">SingUp P130</h1>\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Asp.net intro\Asp.net intro\Views\SingUp\Index.cshtml"
     foreach (var item in names)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 8 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Asp.net intro\Asp.net intro\Views\SingUp\Index.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 9 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Asp.net intro\Asp.net intro\Views\SingUp\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
