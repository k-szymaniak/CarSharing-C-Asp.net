#pragma checksum "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39de1766e59abb4e9240c524d2d40d905d90408e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Admin), @"mvc.1.0.view", @"/Views/Car/Admin.cshtml")]
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
#line 1 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\_ViewImports.cshtml"
using CarRent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\_ViewImports.cshtml"
using CarRent.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39de1766e59abb4e9240c524d2d40d905d90408e", @"/Views/Car/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a506c1aa88ad80a36949b47b6582aa790be615", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarRent.Models.CarModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39de1766e59abb4e9240c524d2d40d905d90408e5524", async() => {
                WriteLiteral("\r\n\r\n<p>\r\n   \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39de1766e59abb4e9240c524d2d40d905d90408e5804", async() => {
                    WriteLiteral("Add new vehicle");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39de1766e59abb4e9240c524d2d40d905d90408e7123", async() => {
                    WriteLiteral("Delete selected");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39de1766e59abb4e9240c524d2d40d905d90408e8442", async() => {
                    WriteLiteral("Hide/Show selected");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n</p>\r\n<h2>Availability</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    <b>#</b>\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
               Write(Html.DisplayNameFor(model => model.CarMark));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
               Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(" (PLN)\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
               Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
#nullable disable
                WriteLiteral(" (KM)\r\n                </th>\r\n                 <th>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
               Write(Html.DisplayNameFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
                WriteLiteral(" (MI)\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n");
#nullable restore
#line 44 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
             foreach (var item in Model) 
            {
               
                if(item.Availability is true)

                    {                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tbody>\r\n                                <tr>\r\n                                    <td>   \r\n \r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 56 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CarMark));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 59 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 62 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(" PLN\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 65 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
#nullable disable
                WriteLiteral(" km\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 68 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Mileage));

#line default
#line hidden
#nullable disable
                WriteLiteral(" mi\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 71 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.ActionLink("Edit", "Edit", new {id=item.CarId}, new {@class = "btn btn-success"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                                        ");
#nullable restore
#line 72 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.ActionLink("Details", "Details", new { id=item.CarId }, new {@class = "btn btn-info"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                                        ");
#nullable restore
#line 73 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.ActionLink("Delete", "Delete", new {id=item.CarId}, new {@class = "btn btn-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                       </tbody>\r\n");
#nullable restore
#line 77 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                }
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("     </table>\r\n\r\n\t <h2>No-Availability</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    <b>#</b>\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 89 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
               Write(Html.DisplayNameFor(model => model.CarMark));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 92 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
               Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 95 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(" (PLN)\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 98 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
               Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
#nullable disable
                WriteLiteral(" (KM)\r\n                </th>\r\n                 <th>\r\n                    ");
#nullable restore
#line 101 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
               Write(Html.DisplayNameFor(model => model.Mileage));

#line default
#line hidden
#nullable disable
                WriteLiteral(" (MI)\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n");
#nullable restore
#line 106 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
             foreach (var item in Model) 
            {
                if(item.Availability is false)
                    {                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <tbody>
                                <tr>
                                    <td>
                                        <input type=""checkbox"" />
                                    </td>
                                    <td>
                                        ");
#nullable restore
#line 116 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CarMark));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 119 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 122 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(" PLN\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 125 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
#nullable disable
                WriteLiteral(" km\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 128 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Mileage));

#line default
#line hidden
#nullable disable
                WriteLiteral(" mi\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 131 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.ActionLink("Edit", "Edit", new {id=item.CarId}, new {@class = "btn btn-success"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                                        ");
#nullable restore
#line 132 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.ActionLink("Details", "Details", new { id=item.CarId }, new {@class = "btn btn-info"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                                        ");
#nullable restore
#line 133 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                                   Write(Html.ActionLink("Delete", "Delete", new {id=item.CarId}, new {@class = "btn btn-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n                       </tbody>\r\n");
#nullable restore
#line 137 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Admin.cshtml"
                }
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("     </table>\r\n     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarRent.Models.CarModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591