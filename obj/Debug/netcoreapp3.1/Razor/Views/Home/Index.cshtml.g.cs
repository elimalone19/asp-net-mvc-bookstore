#pragma checksum "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1f899bd467405f43c70311d4f38e80d43623c97"
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
#nullable restore
#line 1 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\_ViewImports.cshtml"
using asp_net_fifth_assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\_ViewImports.cshtml"
using asp_net_fifth_assignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\_ViewImports.cshtml"
using asp_net_fifth_assignment.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1f899bd467405f43c70311d4f38e80d43623c97", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59a4c456ae90c824cbc62d6c2de79e7320e89344", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-outline-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::asp_net_fifth_assignment.Infrastructure.PageLinkTagHelper __asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container py-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-8 mx-auto\">\r\n            <!-- List group-->\r\n            <ul>\r\n");
#nullable restore
#line 12 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                 foreach (var x in Model.Books)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""list-group-item"">
                        <!-- Custom content-->
                        <div class=""media align-items-lg-center flex-column flex-lg-row p-1"">
                            <div class=""media-body order-2 order-lg-1"">
                                <h5 class=""mt-0 font-weight-bold mb-1"">");
#nullable restore
#line 18 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                                                                  Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"font-italic text-muted mb-0 small\">");
#nullable restore
#line 19 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                                                                        Write(x.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 19 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                                                                                           Write(x.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <div class=\"d-flex align-items-center justify-content-between mt-1\">\r\n                                    <h3 class=\"font-weight-bold my-1\">$");
#nullable restore
#line 21 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                                                                  Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                </div>\r\n                                <p style=\"float: right;\">Publisher: ");
#nullable restore
#line 23 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                                                               Write(x.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ISBN: ");
#nullable restore
#line 23 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                                                                                   Write(x.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 23 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                                                                                            Write(x.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral(" pages</p>\r\n                                <span class=\"badge\" style=\"float:left;\">");
#nullable restore
#line 24 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                                                                   Write(x.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"badge\" style=\"float:left;\">");
#nullable restore
#line 25 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                                                                   Write(x.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div> <!-- End -->\r\n                    </li>\r\n                    <br />\r\n                    <br />\r\n");
#nullable restore
#line 31 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul> <!-- End -->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1f899bd467405f43c70311d4f38e80d43623c979466", async() => {
            }
            );
            __asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::asp_net_fifth_assignment.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper);
#nullable restore
#line 37 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
__asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 37 "C:\Users\elima\source\repos\asp-net-mvc-bookstore\Views\Home\Index.cshtml"
__asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper.PageClassEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-class-enabled", __asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper.PageClassEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __asp_net_fifth_assignment_Infrastructure_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
