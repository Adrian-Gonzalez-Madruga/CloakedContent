#pragma checksum "C:\Users\Chris\Source\Repos\CloakedContent\CloakedContent\Views\Home\ModifySite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892ff61a19997d37414c304ee8fef28570e4847f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ModifySite), @"mvc.1.0.view", @"/Views/Home/ModifySite.cshtml")]
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
#line 1 "C:\Users\Chris\Source\Repos\CloakedContent\CloakedContent\Views\_ViewImports.cshtml"
using CloakedContent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chris\Source\Repos\CloakedContent\CloakedContent\Views\_ViewImports.cshtml"
using CloakedContent.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892ff61a19997d37414c304ee8fef28570e4847f", @"/Views/Home/ModifySite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca34d5b41d67a8d2f330ee5c80f02c4570c3ddc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ModifySite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Chris\Source\Repos\CloakedContent\CloakedContent\Views\Home\ModifySite.cshtml"
  
    ViewData["Title"] = "ModifySite";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Manage Site Layout</h2>

<style>
    #div1, #div2 {
        float: left;
        width: 415px;
        height: 600px;
        margin-left: 10px;
        margin-right: 10px;
        padding: 10px;
        border: 1px solid black;
        overflow-y: scroll;
        flex: auto
        
    }
    #div3, #div4, #div5, #div6, #div7 {
        float: left;
        width: 350px;
        height: 100px;
        margin: 10px;
        padding: 10px;
        border: 1px solid black;
    }
    #div8, #div9, #div10, #div11, #div12 {
        float: left;
        width: 165px;
        height: 100px;
        margin: 10px;
        padding: 10px;
        border: 1px solid black;
    }

    #div10, #div11, #div12 {
        float: left;
        width: 350px;
        height: 200px;
        margin: 10px;
        padding: 10px;
        border: 1px solid black;
    }

    .pretext {
        font-size: 20px;
        margin-top: 5px
    }


    #pre1 {
        font-size: 30px
    }");
            WriteLiteral(@"


    #textbox {
        margin-top: 5px;
        height: 30px;
    }
    #button1 {
        height: 40px;
    }

 
</style>
<div id=""container"">
    <div class=""d-flex flex-row"">
        <pre class=""pretext"">   Choose a site to modify  </pre>
        <div class=""dropdown"">
            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                Android Portfolio
            </button>
            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                <a class=""dropdown-item"" href=""#"">Android Portfolio</a>
                <a class=""dropdown-item"" href=""#"">IOS Portfolio</a>
            </div>
        </div>
    </div>
    <div class=""d-flex flex-row"">
        <pre class=""pretext"">   Or make a new site  </pre>
        <input type=""text"" id=""textbox"">
        <pre>  </pre>
        <button class=""btn btn-secondary"" type=""button"" id=""button1"">
       ");
            WriteLiteral(@"     Create New Site
        </button>
    </div>
    <div class=""d-flex flex-row"">
        <pre>    </pre>
        <button class=""btn btn-secondary"" type=""button"" id=""button1"">
            Save Site
        </button>
        <pre>   </pre>
        <button class=""btn btn-secondary"" type=""button"" id=""button1"">
            Delete Site
        </button>
    </div>
    <br />
    <pre id=""pre1""> Android Portfolio         Pages</pre>
    <div id=""div1"" ondrop=""drop(event)"" ondragover=""allowDrop(event)"">
        <div id=""div3"" draggable=""true"" ondragstart=""drag(event)"">
            <h5>Android project 1</h5>
        </div>
        <div id=""div4"" draggable=""true"" ondragstart=""drag(event)""> <h5>Android project 2</h5></div>
        <div id=""div5"" draggable=""true"" ondragstart=""drag(event)""><h5>Android project 3</h5></div>
        <div id=""div8"" draggable=""true"" ondragstart=""drag(event)""><h6>Android project 4</h6></div>
        <div id=""div9"" draggable=""true"" ondragstart=""drag(event)""><h6>Android p");
            WriteLiteral(@"roject 5</h6></div>
    </div>
    <div id=""div2"" ondrop=""drop(event)"" ondragover=""allowDrop(event)"">
        <div id=""div6"" draggable=""true"" ondragstart=""drag(event)""><h5>IOS project 1</h5></div>
        <div id=""div10"" draggable=""true"" ondragstart=""drag(event)""><h5>IOS project 2</h5></div>
        <div id=""div7"" draggable=""true"" ondragstart=""drag(event)""><h5>IOS project 3</h5></div>
    </div>
</div>

    <script>

        function allowDrop(ev) {
            ev.preventDefault();
        }

        function drag(ev) {
            ev.dataTransfer.setData(""text"", ev.target.id);
        }

        function drop(ev) {
            ev.preventDefault();
            var data = ev.dataTransfer.getData(""text"");
            ev.target.appendChild(document.getElementById(data));
        }

    </script>
");
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
