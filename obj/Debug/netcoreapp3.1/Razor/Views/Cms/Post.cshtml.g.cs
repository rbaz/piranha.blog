#pragma checksum "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e436816346880576e8ac5ded666dea9466a27182"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Post), @"mvc.1.0.view", @"/Views/Cms/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e436816346880576e8ac5ded666dea9466a27182", @"/Views/Cms/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<piranha.blog.Models.BlogPost>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
  
    ViewBag.Title = Model.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <article>\r\n        <header>\r\n");
#nullable restore
#line 10 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
             if (Model.Hero.PrimaryImage.HasValue)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 251, "\"", 316, 1);
#nullable restore
#line 12 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
WriteAttributeValue("", 257, Url.Content(Model.Hero.PrimaryImage.Resize(Api, 930, 360)), 257, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 13 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 14 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p class=\"post-meta\">\r\n                <strong>In</strong> <a");
            BeginWriteAttribute("href", " href=\"", 443, "\"", 480, 2);
            WriteAttributeValue("", 450, "/category/", 450, 10, true);
#nullable restore
#line 16 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
WriteAttributeValue("", 460, Model.Category.Slug, 460, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
                                                                        Write(Model.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <span class=\"sep\">&#9670;</span>\r\n                <strong>Tags</strong>\r\n");
#nullable restore
#line 19 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
                 foreach (var tag in Model.Tags)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"tag\"><a");
            BeginWriteAttribute("href", " href=\"", 707, "\"", 728, 2);
            WriteAttributeValue("", 714, "/tag/", 714, 5, true);
#nullable restore
#line 21 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
WriteAttributeValue("", 719, tag.Slug, 719, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 21 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
                                                           Write(tag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n");
#nullable restore
#line 22 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"sep\">&#9670;</span>\r\n                <strong>Published</strong>\r\n                ");
#nullable restore
#line 25 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
           Write(Model.Published.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </header>\r\n        ");
#nullable restore
#line 28 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Post.cshtml"
   Write(Html.DisplayFor(m => m.Blocks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </article>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.IApi Api { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<piranha.blog.Models.BlogPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
