#pragma checksum "D:\Schoolstuff\Storefront-Vendor\vendor\Views\Vendor\Entries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f486750b95e6a9247252f0ad6fcf0c39d8f8683"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendor_Entries), @"mvc.1.0.view", @"/Views/Vendor/Entries.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendor/Entries.cshtml", typeof(AspNetCore.Views_Vendor_Entries))]
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
#line 1 "D:\Schoolstuff\Storefront-Vendor\vendor\Views\Vendor\Entries.cshtml"
using VendorTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f486750b95e6a9247252f0ad6fcf0c39d8f8683", @"/Views/Vendor/Entries.cshtml")]
    public class Views_Vendor_Entries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 27, true);
            WriteLiteral("<h1></h1>\r\nWelcome!\r\n<ul>\r\n");
            EndContext();
#line 5 "D:\Schoolstuff\Storefront-Vendor\vendor\Views\Vendor\Entries.cshtml"
     foreach(Vendor vend in Model){

#line default
#line hidden
            BeginContext(94, 8, true);
            WriteLiteral("    <il>");
            EndContext();
            BeginContext(103, 7, false);
#line 6 "D:\Schoolstuff\Storefront-Vendor\vendor\Views\Vendor\Entries.cshtml"
   Write(vend.ID);

#line default
#line hidden
            EndContext();
            BeginContext(110, 7, true);
            WriteLiteral("</il>\r\n");
            EndContext();
            BeginContext(119, 12, true);
            WriteLiteral("        <il>");
            EndContext();
            BeginContext(132, 9, false);
#line 8 "D:\Schoolstuff\Storefront-Vendor\vendor\Views\Vendor\Entries.cshtml"
       Write(vend.Name);

#line default
#line hidden
            EndContext();
            BeginContext(141, 21, true);
            WriteLiteral("</il>\r\n        <il><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 162, "\"", 185, 2);
            WriteAttributeValue("", 169, "/Vendor/", 169, 8, true);
#line 9 "D:\Schoolstuff\Storefront-Vendor\vendor\Views\Vendor\Entries.cshtml"
WriteAttributeValue("", 177, vend.ID, 177, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(186, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(189, 9, false);
#line 9 "D:\Schoolstuff\Storefront-Vendor\vendor\Views\Vendor\Entries.cshtml"
                                   Write(vend.Name);

#line default
#line hidden
            EndContext();
            BeginContext(198, 24, true);
            WriteLiteral(" </a></il>\r\n        <il>");
            EndContext();
            BeginContext(223, 12, false);
#line 10 "D:\Schoolstuff\Storefront-Vendor\vendor\Views\Vendor\Entries.cshtml"
       Write(vend.Address);

#line default
#line hidden
            EndContext();
            BeginContext(235, 7, true);
            WriteLiteral("</il>\r\n");
            EndContext();
#line 11 "D:\Schoolstuff\Storefront-Vendor\vendor\Views\Vendor\Entries.cshtml"
    }

#line default
#line hidden
            BeginContext(249, 54, true);
            WriteLiteral("</ul>\r\n\r\n<a href=\"/Vendor/new\">Add a new opening.</a> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
