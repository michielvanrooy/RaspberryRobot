#pragma checksum "C:\Solutions\RaspberryRobot\WebApplicationDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a409e0844c42cc46561bf33920ee56e2563442c3"
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
#line 1 "C:\Solutions\RaspberryRobot\WebApplicationDemo\Views\_ViewImports.cshtml"
using WebApplicationDemo;

#line default
#line hidden
#line 2 "C:\Solutions\RaspberryRobot\WebApplicationDemo\Views\_ViewImports.cshtml"
using WebApplicationDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a409e0844c42cc46561bf33920ee56e2563442c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"519a6507560b6c59f57449537e6f42ac31b5daea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Solutions\RaspberryRobot\WebApplicationDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 3813, true);
            WriteLiteral(@"
<h1>Hello My Robot 5</h1>


<div class=""container"">

    <div class=""row"">
        <div class=""col-xs-3"">

            <div id=""boxRed"" style=""width:100%; height:25vh; background-color:red""></div>
         
        </div>

        <div class=""col-xs-3"">

            <div id=""boxYellow"" style=""width:100%; height:25vh; background-color:yellow""></div>

        </div>

        <div class=""col-xs-3"">

            <div id=""boxGreen"" style=""width:100%; height:25vh; background-color:green""></div>

        </div>

        <div class=""col-xs-3"">

            <div id=""boxBlue"" style=""width:100%; height:25vh; background-color:blue""></div>

        </div>
    </div>

</div>


<script>

    //window.addEventListener('load', function () { // on page load


    document.getElementById(""boxRed"").addEventListener('touchstart', function (e) {
        console.log(""start"");
        var xhttp = new XMLHttpRequest();
        xhttp.open(""POST"", '/Home/PostRed', true);
        xhttp.send()");
            WriteLiteral(@";

        e.preventDefault()
    }, false);

    document.getElementById(""boxRed"").addEventListener('touchend', function (e) {
        console.log(""end"");
        var xhttp = new XMLHttpRequest();
        xhttp.open(""POST"", '/Home/PostRedRelease', true);
        xhttp.send();

        e.preventDefault()
    }, false);

    document.getElementById(""boxYellow"").addEventListener('touchstart', function (e) {
        var xhttp = new XMLHttpRequest();
        xhttp.open(""POST"", '/Home/PostYellow', true);
        xhttp.send();
        e.preventDefault()
    }, false);

    document.getElementById(""boxYellow"").addEventListener('touchend', function (e) {
        var xhttp = new XMLHttpRequest();
        xhttp.open(""POST"", '/Home/PostYellowRelease', true);
        xhttp.send();
        e.preventDefault()
    }, false);

    document.getElementById(""boxGreen"").addEventListener('touchstart', function (e) {
        var xhttp = new XMLHttpRequest();
        xhttp.open(""POST"", '/Home/PostGreen");
            WriteLiteral(@"', true);
        xhttp.send();
        e.preventDefault()
    }, false);

    document.getElementById(""boxGreen"").addEventListener('touchend', function (e) {
        var xhttp = new XMLHttpRequest();
        xhttp.open(""POST"", '/Home/PostGreenRelease', true);
        xhttp.send();
        e.preventDefault()
    }, false);

    document.getElementById(""boxBlue"").addEventListener('touchstart', function (e) {
        var xhttp = new XMLHttpRequest();
        xhttp.open(""POST"", '/Home/PostBlue', true);
        xhttp.send();
        e.preventDefault()
    }, false);

    document.getElementById(""boxBlue"").addEventListener('touchend', function (e) {
        var xhttp = new XMLHttpRequest();
        xhttp.open(""POST"", '/Home/PostBlueRelease', true);
        xhttp.send();
        e.preventDefault()
    }, false);

    //}, false)

    //function onBoxClicked(color, isKeyDown) {
    //    switch (color) {
    //        case 'red':
    //            if (isKeyDown) {
    //              ");
            WriteLiteral(@"  alert(""down"");
    //                //document.getElementById(""btnRed"").click();
    //            }
    //            else {
    //                alert(""up"");
    //                //document.getElementById(""btnRedRelease"").click();
    //            }
    //            break;
    //        case 'yellow':
    //            document.getElementById(""btnYellow"").click();
    //            break;
    //        case 'green':
    //            document.getElementById(""btnGreen"").click();
    //            break;
    //        case 'blue':
    //            document.getElementById(""btnBlue"").click();
    //            break;
    //        default:
    //            break;
    //    }
    //}


</script>



");
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
