#pragma checksum "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b55b0530a7121781b13536d2f3c2dddb08d46e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Archive), @"mvc.1.0.view", @"/Views/Cms/Archive.cshtml")]
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
#line 2 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b55b0530a7121781b13536d2f3c2dddb08d46e5", @"/Views/Cms/Archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Archive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<piranha.blog.Models.BlogArchive>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
  
    ViewBag.Title = Model.Title;

    Func<string> BlogLink = () => {
        return Model.Permalink
            + (Model.Archive.Category != null ? $"/category/{Model.Archive.Category.Slug}"  : "")
            + (Model.Archive.Year.HasValue ? $"/{Model.Archive.Year}" : "" )
            + (Model.Archive.Month.HasValue ? $"/{Model.Archive.Month}" : "");
    };

    Func<string> MonthName = () => {
        if (Model.Archive.Month.HasValue) {
            return new DateTime(2018, Model.Archive.Month.Value, 1) .ToString("MMMM", CultureInfo.InvariantCulture);
        }
        return "";
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container archive\">\n");
#nullable restore
#line 23 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
     if (Model.Archive.Category != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Category: ");
#nullable restore
#line 26 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                         Write(Model.Archive.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            </div>\n        </div>\n");
#nullable restore
#line 29 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
    } else if (Model.Archive.Tag != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Tag: ");
#nullable restore
#line 32 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                    Write(Model.Archive.Tag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            </div>\n        </div>\n");
#nullable restore
#line 35 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
    } else if (Model.Archive.Year.HasValue) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Posts from ");
#nullable restore
#line 38 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                          Write(MonthName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                                       Write(Model.Archive.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            </div>\n        </div>\n");
#nullable restore
#line 41 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col blog-filter-header\">\n                <h1>Latest posts</h1>\n            </div>\n        </div>\n");
#nullable restore
#line 47 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 49 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
     foreach (var post in Model.Archive.Posts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <article>\n            <header>\n");
#nullable restore
#line 53 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                 if (post.Regions.Hero.PrimaryImage.HasValue)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                                                                                                                                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2><a");
            BeginWriteAttribute("href", " href=\"", 1888, "\"", 1910, 1);
#nullable restore
#line 57 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1895, post.Permalink, 1895, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                                         Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n                <p class=\"post-meta\">\n                    <strong>In</strong> <a");
            BeginWriteAttribute("href", " href=\"", 2013, "\"", 2065, 3);
#nullable restore
#line 59 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2020, Model.Permalink, 2020, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2036, "/category/", 2036, 10, true);
#nullable restore
#line 59 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2046, post.Category.Slug, 2046, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                                                                                           Write(post.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                    <span class=\"sep\">&#9670;</span>\n                    <strong>Tags</strong>\n");
#nullable restore
#line 62 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                     foreach (var tag in post.Tags)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"tag\"><a");
            BeginWriteAttribute("href", " href=\"", 2305, "\"", 2342, 3);
#nullable restore
#line 64 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2312, Model.Permalink, 2312, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2328, "/tag/", 2328, 5, true);
#nullable restore
#line 64 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2333, tag.Slug, 2333, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 64 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                                                                               Write(tag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\n");
#nullable restore
#line 65 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"sep\">&#9670;</span>\n                    <strong>Published</strong>\n                    ");
#nullable restore
#line 68 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
               Write(post.Published.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n            </header>\n            <div class=\"ingress\">\n                ");
#nullable restore
#line 72 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
           Write(Html.Raw(post.Regions.Hero.Ingress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <p><a class=\"btn btn-link\"");
            BeginWriteAttribute("href", " href=\"", 2741, "\"", 2763, 1);
#nullable restore
#line 74 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 2748, post.Permalink, 2748, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read more</a></p>\n        </article>\n");
#nullable restore
#line 76 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
     if (Model.Archive.TotalPages > 1) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col"">
                <nav aria-label=""Page navigation example"">
                <ul class=""pagination justify-content-center"">
                    <li class=""page-item"">
                        <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 3114, "\"", 3139, 2);
#nullable restore
#line 83 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3121, BlogLink(), 3121, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3132, "/page/1", 3132, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                            <span aria-hidden=""true"">&laquo;</span>
                            <span class=""sr-only"">Previous</span>
                        </a>
                    </li>
                    <li class=""page-item"">
                        <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 3418, "\"", 3485, 3);
#nullable restore
#line 89 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3425, BlogLink(), 3425, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3436, "/page/", 3436, 6, true);
#nullable restore
#line 89 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3442, Math.Max(1, Model.Archive.CurrentPage - 1), 3442, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <span aria-hidden=\"true\">&lsaquo;</span>\n                            <span class=\"sr-only\">Previous</span>\n                        </a>\n                    </li>\n");
#nullable restore
#line 94 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                     for (var n = 1; n <= Model.Archive.TotalPages; n++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3780, "\"", 3847, 2);
            WriteAttributeValue("", 3788, "page-item", 3788, 9, true);
#nullable restore
#line 95 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue(" ", 3797, Model.Archive.CurrentPage == n ? "active" : "", 3798, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3869, "\"", 3895, 3);
#nullable restore
#line 95 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3876, BlogLink(), 3876, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3887, "/page/", 3887, 6, true);
#nullable restore
#line 95 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 3893, n, 3893, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 95 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                                                                                                                                           Write(n);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 96 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4018, "\"", 4108, 3);
#nullable restore
#line 98 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4025, BlogLink(), 4025, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4036, "/page/", 4036, 6, true);
#nullable restore
#line 98 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4042, Math.Min(Model.Archive.TotalPages, Model.Archive.CurrentPage + 1), 4042, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <span aria-hidden=""true"">&rsaquo;</span>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </li>
                    <li class=""page-item"">
                        <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 4384, "\"", 4433, 3);
#nullable restore
#line 104 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4391, BlogLink(), 4391, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4402, "/page/", 4402, 6, true);
#nullable restore
#line 104 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 4408, Model.Archive.TotalPages, 4408, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <span aria-hidden=""true"">&raquo;</span>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </li>
                </ul>
                </nav>
            </div>
        </div>
");
#nullable restore
#line 113 "C:\Users\rochd\source\repos\2019\piranha.blog\Views\Cms\Archive.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<piranha.blog.Models.BlogArchive> Html { get; private set; }
    }
}
#pragma warning restore 1591
