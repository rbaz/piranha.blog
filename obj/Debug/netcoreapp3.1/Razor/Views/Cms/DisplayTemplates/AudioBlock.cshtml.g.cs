#pragma checksum "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\DisplayTemplates\AudioBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30aaa49ac69c54f919410a5dcc10f219ecf8a738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_AudioBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/AudioBlock.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30aaa49ac69c54f919410a5dcc10f219ecf8a738", @"/Views/Cms/DisplayTemplates/AudioBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_AudioBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.AudioBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<audio width=\"100%\" controls>\n    <source");
            BeginWriteAttribute("src", " src=\"", 82, "\"", 112, 1);
#nullable restore
#line 4 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\DisplayTemplates\AudioBlock.cshtml"
WriteAttributeValue("", 88, Url.Content(Model.Body), 88, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("type", " type=\"", 113, "\"", 120, 0);
            EndWriteAttribute();
            WriteLiteral(">\n    Your browser does not support the audio tag.\n</audio>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.AudioBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
