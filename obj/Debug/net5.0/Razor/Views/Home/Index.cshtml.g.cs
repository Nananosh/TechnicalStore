#pragma checksum "C:\Users\nanan\Desktop\TechnicalStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c58491ba38346609b380da618fe1af6ad7eb3deb"
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
#line 1 "C:\Users\nanan\Desktop\TechnicalStore\Views\_ViewImports.cshtml"
using TechnicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nanan\Desktop\TechnicalStore\Views\_ViewImports.cshtml"
using TechnicalStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58491ba38346609b380da618fe1af6ad7eb3deb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0ff216b9010f44292a0c04170ac888a6f2d766b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All_Tovars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn essence-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nanan\Desktop\TechnicalStore\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Главная SuperStore";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""welcome_area bg-img background-overlay"" style=""        background-image: url(img/bg-img/bg-1.jpg);"">
    <div class=""container h-100"">
        <div class=""row h-100 align-items-center"">
            <div class=""col-12"">
                <div class=""hero-content"">
                    <h6>asoss</h6>
                    <h2>Новые товары</h2>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c58491ba38346609b380da618fe1af6ad7eb3deb4859", async() => {
                WriteLiteral("Подробнее");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</section>

<div class=""cta-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""cta-content bg-img background-overlay"" style=""background-image: url(img/bg-img/bg-5.jpg);"">
                    <div class=""h-100 d-flex align-items-center justify-content-end"">
                        <div class=""cta--text"">
                            <h6>-60%</h6>
                            <h2>Скидки</h2>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<section class=""new_arrivals_area section-padding-80 clearfix"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""section-heading text-center"">
                    <h2>Популярные товары</h2>
                </div>
            </div>");
            WriteLiteral("\n        </div>\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div class=\"popular-products-slides owl-carousel\">\r\n");
#nullable restore
#line 52 "C:\Users\nanan\Desktop\TechnicalStore\Views\Home\Index.cshtml"
                     foreach (var item in ViewBag.AllTovars)
                    {
                        if (ViewBag.It < 5)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <!-- Single Product -->
                            <div class=""single-product-wrapper"">
                                <!-- Product Image -->
                                <div class=""product-img"">
                                    <img");
            BeginWriteAttribute("src", " src=", 2176, "", 2192, 1);
#nullable restore
#line 60 "C:\Users\nanan\Desktop\TechnicalStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 2181, item.Image, 2181, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2192, "\"", 2198, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <!-- Hover Thumb -->\r\n                                    <img class=\"hover-img\"");
            BeginWriteAttribute("src", " src=", 2318, "", 2334, 1);
#nullable restore
#line 62 "C:\Users\nanan\Desktop\TechnicalStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 2323, item.Image, 2323, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2334, "\"", 2340, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                                    <!-- Product Badge -->
                                    <div class=""product-badge new-badge"">
                                        <span>Новый</span>
                                    </div>

                                   
                                </div>
                                <!-- Product Description -->
                                <div class=""product-description"">
                                   
                                    <a href=""single-product-details.html"">
                                        <h6>");
#nullable restore
#line 75 "C:\Users\nanan\Desktop\TechnicalStore\Views\Home\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    </a>\r\n                                    <p class=\"product-price\">");
#nullable restore
#line 77 "C:\Users\nanan\Desktop\TechnicalStore\Views\Home\Index.cshtml"
                                                        Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                                    <!-- Hover Content -->
                                    <div class=""hover-content"">
                                        <!-- Add to Cart -->
                                        <div class=""add-to-cart-btn"">
                                            <a");
            BeginWriteAttribute("href", "  href=\"", 3407, "\"", 3433, 2);
            WriteAttributeValue("", 3415, "/Home/Buy/", 3415, 10, true);
#nullable restore
#line 83 "C:\Users\nanan\Desktop\TechnicalStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 3425, item.Id, 3425, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn essence-btn\">Подробнее</a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 88 "C:\Users\nanan\Desktop\TechnicalStore\Views\Home\Index.cshtml"
                            ViewBag.It += 1;
                        }
                        else
                        {
                            break;
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
