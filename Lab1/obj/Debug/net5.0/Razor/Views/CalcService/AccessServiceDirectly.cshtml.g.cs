#pragma checksum "C:\Users\appac\Desktop\931803.Postnyh.Ivan.lab1-master\Lab1\Views\CalcService\AccessServiceDirectly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c73d738c50776b3ae233b7884584021f1bb0b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_AccessServiceDirectly), @"mvc.1.0.view", @"/Views/CalcService/AccessServiceDirectly.cshtml")]
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
#line 1 "C:\Users\appac\Desktop\931803.Postnyh.Ivan.lab1-master\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
using Lab1.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c73d738c50776b3ae233b7884584021f1bb0b6", @"/Views/CalcService/AccessServiceDirectly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_CalcService_AccessServiceDirectly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\appac\Desktop\931803.Postnyh.Ivan.lab1-master\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
  
    ViewBag.Title = "AccessServiceDirectly - Backend1";
    var model = Service.GetCalcModel();

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>AccessServiceDirectly</h1>\n\n<b>Rand value first:</b> ");
#nullable restore
#line 9 "C:\Users\appac\Desktop\931803.Postnyh.Ivan.lab1-master\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
                     Write(model.X);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n<b>Rand value second:</b> ");
#nullable restore
#line 10 "C:\Users\appac\Desktop\931803.Postnyh.Ivan.lab1-master\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
                      Write(model.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n\n<b>Add:</b><br />\n");
#nullable restore
#line 13 "C:\Users\appac\Desktop\931803.Postnyh.Ivan.lab1-master\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n<b>Dif:</b><br />\n");
#nullable restore
#line 16 "C:\Users\appac\Desktop\931803.Postnyh.Ivan.lab1-master\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(model.Dif);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n<b>Mult:</b><br/>\n");
#nullable restore
#line 19 "C:\Users\appac\Desktop\931803.Postnyh.Ivan.lab1-master\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(model.Mult);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n<b>Div:</b><br/>\n");
#nullable restore
#line 22 "C:\Users\appac\Desktop\931803.Postnyh.Ivan.lab1-master\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(model.Div);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CalcService Service { get; private set; }
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
