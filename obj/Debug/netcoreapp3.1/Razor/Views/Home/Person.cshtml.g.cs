#pragma checksum "C:\Users\jahhh\GrandCircus\SWAPI\Views\Home\Person.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d9edbb66cb9b97e2d4eae2922a39f6073741618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Person), @"mvc.1.0.view", @"/Views/Home/Person.cshtml")]
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
#line 1 "C:\Users\jahhh\GrandCircus\SWAPI\Views\_ViewImports.cshtml"
using SWAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jahhh\GrandCircus\SWAPI\Views\_ViewImports.cshtml"
using SWAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d9edbb66cb9b97e2d4eae2922a39f6073741618", @"/Views/Home/Person.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a2a7524a3e15c6deb36b004187595012c6cbad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Person : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Name: ");
#nullable restore
#line 2 "C:\Users\jahhh\GrandCircus\SWAPI\Views\Home\Person.cshtml"
     Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Population ");
#nullable restore
#line 3 "C:\Users\jahhh\GrandCircus\SWAPI\Views\Home\Person.cshtml"
          Write(Model.height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Gravity: ");
#nullable restore
#line 4 "C:\Users\jahhh\GrandCircus\SWAPI\Views\Home\Person.cshtml"
        Write(Model.homeworld);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
