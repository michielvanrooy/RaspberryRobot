#pragma checksum "C:\Solutions\RaspberryRobot\WebCameraTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a19e512b4b51e72ca74055b14e5e8969cabd4d6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Solutions\RaspberryRobot\WebCameraTest\Views\_ViewImports.cshtml"
using WebCameraTest;

#line default
#line hidden
#line 2 "C:\Solutions\RaspberryRobot\WebCameraTest\Views\_ViewImports.cshtml"
using WebCameraTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a19e512b4b51e72ca74055b14e5e8969cabd4d6c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5afa949492199e73644076de0c406a7c71fefed1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebCameraTest.Models.ImageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Solutions\RaspberryRobot\WebCameraTest\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(87, 12, true);
            WriteLiteral("<span>\r\n    ");
            EndContext();
            BeginContext(100, 15, false);
#line 7 "C:\Solutions\RaspberryRobot\WebCameraTest\Views\Home\Index.cshtml"
Write(Model.ImagePath);

#line default
#line hidden
            EndContext();
            BeginContext(115, 55, true);
            WriteLiteral("\r\n</span>\r\n\r\n<h1>Hello Camera</h1>\r\n\r\n<img id=\"imgTest\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 170, "\"", 192, 1);
#line 12 "C:\Solutions\RaspberryRobot\WebCameraTest\Views\Home\Index.cshtml"
WriteAttributeValue("", 176, Model.ImagePath, 176, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(193, 1104, true);
            WriteLiteral(@" alt=""test"" />


<script>


    $(document).ready(function () {


        setInterval(function () {
            var myImageElement = document.getElementById('imgTest');
            myImageElement.src = 'images/test.png?rand=' + Math.random();    //TODO: Must get url from app.settings
        }, 500);

        //$(""#imgTest"").click(function () {

        //    console.log(""Clicked"");

        //    $.ajax({
        //        url: ""/"",
        //        type: ""post"",
        //        success: function (result) {
        //            $(""#imgTest"").attr(""src"", ""/Images/test.png?r="" + Math.random());
        //        }
        //    });
        //});
    });

    //$(document).ready(function () {
    //    $(""#imgTest"").click(function () {
    //        $.ajax({
    //            url: ""/Account/CaptchaImage"",
    //            type: ""post"",
    //            success: function (result) {
    //                $(""#imgTest"").attr(""src"", ""/Account/CaptchaImage/?r="" + Math.random())");
            WriteLiteral(";\r\n    //            }\r\n    //        });\r\n    //    });\r\n    //});\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebCameraTest.Models.ImageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
