#pragma checksum "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5b2cc5afccbfd1a59de1731777d90b3bd98c8c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Motorcycles), @"mvc.1.0.view", @"/Views/Car/Motorcycles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5b2cc5afccbfd1a59de1731777d90b3bd98c8c1", @"/Views/Car/Motorcycles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a506c1aa88ad80a36949b47b6582aa790be615", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Motorcycles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarRent.Models.CarModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeAvailability", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
  
    ViewData["Tilte"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5b2cc5afccbfd1a59de1731777d90b3bd98c8c13816", async() => {
                WriteLiteral("\r\n     <div class=\"row\">    \r\n\r\n                              \r\n                        \r\n");
#nullable restore
#line 17 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                     foreach (var item in Model) 
                    {
                        if(item.Availability is true && item.Category == 2)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""col-sm-4 mt-3"">       
                    <div class=""card"">
                        <div class=""card-body"">
                              <img class=""col-sm-12"" src=""https://st.depositphotos.com/1987177/3470/v/950/depositphotos_34700099-stock-illustration-no-photo-available-or-missing.jpg""/>
");
#nullable restore
#line 25 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                     if (item.Category == 1) { Write("CAR");}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                     if (item.Category == 2) { Write("MOTORBIKE");}

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                     if (item.Category == 3) { Write("OTHER");}

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <h5 class=\"card-title\">");
#nullable restore
#line 28 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.CarMark));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 28 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                     <p class=\"card-text ml-4\"><b>Price </b>");
#nullable restore
#line 29 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                                                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(" PLN</p>\r\n                                      <p class=\"card-text ml-4\"><b>Power </b>");
#nullable restore
#line 30 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => item.Power));

#line default
#line hidden
#nullable disable
                WriteLiteral(" km</p>\r\n                                       <p class=\"card-text ml-4\"><b>Mileage </b>");
#nullable restore
#line 31 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                                                           Write(Html.DisplayFor(modelItem => item.Mileage));

#line default
#line hidden
#nullable disable
                WriteLiteral(" mi</p>\r\n\r\n                                    ");
#nullable restore
#line 33 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                               Write(Html.ActionLink("Details", "Details", new { id=item.CarId }, new {@class = "btn btn-success col-sm-12 br-0"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n");
#nullable restore
#line 34 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                         if (ViewContext.HttpContext.User.IsInRole("Admin"))
                                            { 
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                           Write(Html.ActionLink("Edit", "Edit", new { id=item.CarId }, new {@class = "btn btn-warning col-sm-5 mt-2 mr-1"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                           Write(Html.ActionLink("Delete", "Delete", new { id=item.CarId }, new {@class = "btn btn-danger col-sm-5 mt-2 ml-1"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                            Write(Html.ActionLink("X", "ChangeAvailability", new { id=item.CarId }, new {@class = "btn btn-danger mt-2 ml-1"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                                                                                                                                              
                                                
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                       </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\Krzysztof\source\repos\CarRent-Pro-AspNet\Views\Car\Motorcycles.cshtml"
                                    }
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n            </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(">\r\n\r\n\r\n                     \r\n   \r\n       ");
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
