#pragma checksum "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Asp.net intro\Asp.net intro\Views\SingIn\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f89238c2d136095953cde9e61e0a8dd452d73e51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SingIn_Index), @"mvc.1.0.view", @"/Views/SingIn/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f89238c2d136095953cde9e61e0a8dd452d73e51", @"/Views/SingIn/Index.cshtml")]
    #nullable restore
    public class Views_SingIn_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Asp.net intro\Asp.net intro\Views\SingIn\Index.cshtml"
  
    string[] names = { "Huseyn", "Ferid", "Eli", "Veli" };

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 style=\"color:red\">SingIn P130</h1>\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Asp.net intro\Asp.net intro\Views\SingIn\Index.cshtml"
     foreach (var item in names)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 8 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Asp.net intro\Asp.net intro\Views\SingIn\Index.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 9 "C:\Users\HP\Desktop\CodeAcademy\ASP.NET Core\Asp.net intro\Asp.net intro\Views\SingIn\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n");
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