#pragma checksum "/Users/mac/Desktop/Study/Inflearn/01_ASP.NET Core/workspace/ProjectNC01/Views/Student/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98c4d7335c3ef03c3dcaf1299ee2800e87deb1cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "/Users/mac/Desktop/Study/Inflearn/01_ASP.NET Core/workspace/ProjectNC01/Views/_ViewImports.cshtml"
using ProjectNC01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mac/Desktop/Study/Inflearn/01_ASP.NET Core/workspace/ProjectNC01/Views/_ViewImports.cshtml"
using ProjectNC01.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mac/Desktop/Study/Inflearn/01_ASP.NET Core/workspace/ProjectNC01/Views/_ViewImports.cshtml"
using ProjectNC01.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c4d7335c3ef03c3dcaf1299ee2800e87deb1cb", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1676d62cba54367cb4c2f097b1554235c4957b17", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentTeacherViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/mac/Desktop/Study/Inflearn/01_ASP.NET Core/workspace/ProjectNC01/Views/Student/Index.cshtml"
  
    ViewData["Title"] = "Student Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""jumbotron"">
        <h1>Welcome - Student Index</h1>
        <a href=""/Student/Student"">Create Student</a>
    </div>
</div>

<!--
    await 및 Html.PartialAsync 는 혹시 모를 Deadlock 방지를 위한 안전조치
    ""_TeacherTable"" : 보여 줄 Partial View 이름
    Model : Partial View 에 넘겨 줄 Model. (상단에 선언한 Model을 받아와서 사용.) 
        단순 HTML만 있는 Partial View 에서는 해당 매개변수 전달하지 않아도 됨.
-->
");
#nullable restore
#line 20 "/Users/mac/Desktop/Study/Inflearn/01_ASP.NET Core/workspace/ProjectNC01/Views/Student/Index.cshtml"
Write(await Html.PartialAsync("_StudentTable", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(";");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentTeacherViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
