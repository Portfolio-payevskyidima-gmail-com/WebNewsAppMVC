#pragma checksum "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e62b467e0f06401afb4eb3d48dfd96590014904"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e62b467e0f06401afb4eb3d48dfd96590014904", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsWebApp.PL.Models.ViewPage>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";

    List<SelectListItem> listItems = new List<SelectListItem>();
    foreach (var item in Model.Headings)
    {
        listItems.Add(new SelectListItem
        {
            Text = item.Name,
            Value = item.Id.ToString()
        });
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e62b467e0f06401afb4eb3d48dfd965900149043246", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>News Web App</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e62b467e0f06401afb4eb3d48dfd965900149044281", async() => {
                WriteLiteral("\r\n    <h2 align=\"center\">Home page</h2>\r\n    <h2 align=\"center\">");
#nullable restore
#line 30 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
                  Write(Html.ActionLink("Autorisation", "Autorisation"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n    <div>\r\n");
#nullable restore
#line 33 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
         using (Html.BeginForm("SearchName", "Home"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
       Write(Html.HiddenFor(m => m.Headings));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
                                            ;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Filter.Name, new { placeholder = "NewsName", @type = "name" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"submit\" name=\"ByName\" value=\"ByName\" />\r\n");
#nullable restore
#line 38 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <div>\r\n");
#nullable restore
#line 41 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
         using (Html.BeginForm("SearchTopyc", "Home"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
       Write(Html.HiddenFor(m => m.Headings));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
                                            ;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Filter.Topyc, new { placeholder = "Topyc", @type = "name" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"submit\" name=\"ByTopic\" value=\"ByTopic\" />\r\n");
#nullable restore
#line 46 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <div>\r\n");
#nullable restore
#line 49 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
         using (Html.BeginForm("SearchHeading", "Home"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
       Write(Html.HiddenFor(m => m.Headings));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
                                            ;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
       Write(Html.DropDownListFor(m => m.Filter.HeadingId, listItems, "-- Select Heading --"));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"submit\" name=\"ByTopic\" value=\"ByTopic\" />\r\n");
#nullable restore
#line 54 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n\r\n\r\n    <table>\r\n        <tr>\r\n            <th>NewsName</th>\r\n            <th>Publish Date</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 65 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
         foreach (var item in Model.News)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 68 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(model => item.NewsName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 69 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(model => item.PublishDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 70 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
               Write(Html.ActionLink("View", "ViewNews", item));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 72 "E:\KPI\Semestr_5\.NET\NewsWebApp4\WebNewsApp.PL\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebApp.PL.Models.ViewPage> Html { get; private set; }
    }
}
#pragma warning restore 1591
