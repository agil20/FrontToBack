#pragma checksum "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2febd1960a943808d1d23926e09c081ffe322271"
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
#line 1 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2febd1960a943808d1d23926e09c081ffe322271", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f4ac931d5edb120660d7139af0f0a8b325eff0e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <main>\r\n\r\n        <!-- SLIDER START -->\r\n\r\n        <section id=\"slider\">\r\n            <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 13 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
             foreach (var item in Model.Sliders)
           {  

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div> <img");
            BeginWriteAttribute("src", " src=\"", 275, "\"", 297, 2);
            WriteAttributeValue("", 281, "img/", 281, 4, true);
#nullable restore
#line 15 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 285, item.ImgUrl, 285, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 298, "\"", 304, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n");
#nullable restore
#line 16 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
               
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("          \r\n            </div>\r\n            <div class=\"container context pl-lg-5 ml-lg-3\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-5\">\r\n                        <div class=\"text\">\r\n                       <h1>");
#nullable restore
#line 24 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                      Write(Html.Raw(  @Model.SliderContent.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <h1>you mean it</h1>\r\n                            <p class=\"text-black-50 d-none d-sm-block\">");
#nullable restore
#line 26 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                  Write(Model.SliderContent.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        </div>\r\n                        <div class=\"img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 895, "\"", 932, 2);
            WriteAttributeValue("", 901, "img/", 901, 4, true);
#nullable restore
#line 29 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 905, Model.SliderContent.ImgUrl, 905, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 933, "\"", 939, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SLIDER END -->

        <!-- PRODUCTS START -->

        <section id=""products"">
            <div class=""container"">
                <div class=""row pt-5"">
                    <div class=""col-12 d-flex justify-content-between"">
                        <ul class=""category-mobile d-md-none list-unstyled"">
                            <li>
                                <a");
            BeginWriteAttribute("href", " href=\"", 1464, "\"", 1471, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                                <i class=\"fas fa-caret-down\"></i>\r\n                                <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1714, "\"", 1721, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1793, "\"", 1800, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"popular\">Popular</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1880, "\"", 1887, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"winter\">Winter</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1965, "\"", 1972, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"various\">Various</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2052, "\"", 2059, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"exotic\">Exotic</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2137, "\"", 2144, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"green\">Greens</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2221, "\"", 2228, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cactuse\">Cactuses</a></li>\r\n                                </ul>\r\n                            </li>\r\n                        </ul>\r\n                        <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2484, "\"", 2491, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 61 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                              foreach (var item in Model.Categories)
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2690, "\"", 2697, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 64 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                               Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\">");
#nullable restore
#line 64 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 65 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <ul class=\"list-unstyled\">\r\n                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2934, "\"", 2941, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mr-2"">Filter</a>
                                <i class=""fas fa-caret-down""></i>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""row"">
                
");
#nullable restore
#line 77 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                     foreach (var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\r\n                        <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 79 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                  Write(item.Category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <div class=\"img\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3521, "\"", 3549, 2);
            WriteAttributeValue("", 3528, "/home/detail/", 3528, 13, true);
#nullable restore
#line 81 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 3541, item.Id, 3541, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2febd1960a943808d1d23926e09c081ffe32227112947", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3599, "~/img/", 3599, 6, true);
#nullable restore
#line 82 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3605, item.ImageUrl, 3605, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </a>\r\n                            </div>\r\n                            <div class=\"title mt-3\">\r\n                                <h6>");
#nullable restore
#line 86 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"price\">\r\n                                <span class=\"text-black-50\">Add to cart</span>\r\n                                <span class=\"text-black-50\">");
#nullable restore
#line 90 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 94 "C:\Users\asus\Source\Repos\FrontToBacky\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
          
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
            </div>
        </section>

        <!-- PRODUCTS END -->

        <!-- ABOUT START -->

        <section id=""about"">
            <div class=""container py-5"">
                <div class=""row py-5"">
                    <div class=""col-lg-6"">
                        <div class=""img"">
                            <img src=""img/h3-video-img.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4615, "\"", 4621, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div
                                class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                                <i class=""fas fa-play fa-lg""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                            <h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>
                            <p class=""py-3"">Where flowers are our inspiration to create lasting memories. Whatever the
                                occasion...</p>
                            <ul class=""list-unstyled"">
                                <li class=""mt-3""><img src=""img/h1-custom-icon.png"" class=""mr-2""");
            BeginWriteAttribute("alt", " alt=\"", 5487, "\"", 5493, 0);
            EndWriteAttribute();
            WriteLiteral("> Hand picked just\r\n                                    for you.</li class=\"mt-3\">\r\n                                <li class=\"mt-3\"><img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 5673, "\"", 5679, 0);
            EndWriteAttribute();
            WriteLiteral("> Unique flower\r\n                                    arrangements</li>\r\n                                <li class=\"mt-3\"><img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 5847, "\"", 5853, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Best way to say
                                    you care.</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- ABOUT END -->

        <!-- EXPERTS START -->

        <section id=""experts"">
            <div class=""container"">
                <div class=""row py-5"">
                    <div class=""offset-lg-3 col-lg-6"">
                        <div class=""section-title"">
                            <h1>Flower Experts</h1>
                            <p class=""text-black-50"">A perfect blend of creativity, energy, communication, happiness and
                                love. Let us arrange
                                a smile for you.</p>
                        </div>
                    </div>
                </div>
                <div class=""row pb-5"">
                    <div class=""col-md-6 col-lg-3"">
                        <div class=""item text-cent");
            WriteLiteral("er\">\r\n                            <div class=\"img\">\r\n                                <img src=\"img/h3-team-img-1.png\" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 7028, "\"", 7034, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""text mt-3"">
                                <h6>CRYSTAL BROOKS</h6>
                                <p class=""text-black-50"">Florist</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-3"">
                        <div class=""item text-center"">
                            <div class=""img"">
                                <img src=""img/h3-team-img-2.png"" class=""img-fluid rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 7603, "\"", 7609, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""text mt-3"">
                                <h6>SHIRLEY HARRIS</h6>
                                <p class=""text-black-50"">Manager</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-3"">
                        <div class=""item text-center"">
                            <div class=""img"">
                                <img src=""img/h3-team-img-3.png"" class=""img-fluid rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 8178, "\"", 8184, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""text mt-3"">
                                <h6>BEVERLY CLARK</h6>
                                <p class=""text-black-50"">Florist</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-3"">
                        <div class=""item text-center"">
                            <div class=""img"">
                                <img src=""img/h3-team-img-4.png"" class=""img-fluid rounded-circle""");
            BeginWriteAttribute("alt", " alt=\"", 8752, "\"", 8758, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""text mt-3"">
                                <h6>AMANDA WATKINS</h6>
                                <p class=""text-black-50"">Florist</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3""></div>
                    <div class=""col-lg-3""></div>
                    <div class=""col-lg-3""></div>
                </div>
            </div>
        </section>

        <!-- EXPERTS END -->

        <!-- SUBSCRIBE START -->

        <section id=""subscribe"">
            <div class=""container py-5"">
                <div class=""row py-5"">
                    <div class=""col-12"">
                        <div class=""content text-center py-5"">
                            <h3>Join The Colorful Bunch!</h3>
                            <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                                <input ty");
            WriteLiteral(@"pe=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                                <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SUBSCRIBE END -->

        <!-- BLOG START -->

        <section id=""blog"">
            <div class=""container"">
                <div class=""row py-5"">
                    <div class=""offset-lg-3 col-lg-6"">
                        <div class=""section-title"">
                            <h1>From our Blog</h1>
                            <p class=""text-black-50"">A perfect blend of creativity, energy, communication, happiness and
                                love. Let us arrange
                                a smile for you.</p>
                        </div>
                    </div>
                </div>
                <div cl");
            WriteLiteral(@"ass=""row pb-5"">
                    <div class=""col-md-6 col-lg-4"">
                        <div class=""item"">
                            <div class=""img position-relative"">
                                <img src=""img/blog-feature-img-1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 11073, "\"", 11079, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                    <span>29.12.2019</span>
                                </div>
                            </div>
                            <div class=""text mt-3 text-center px-5"">
                                <h5>Flower Power</h5>
                                <p class=""text-black-50"">Class aptent taciti sociosqu ad litora torquent per conubia
                                    nostra, per</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-4"">
                        <div class=""item"">
                            <div class=""img position-relative"">
                                <img src=""img/blog-feature-img-3.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 11958, "\"", 11964, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                    <span>29.12.2019</span>
                                </div>
                            </div>
                            <div class=""text mt-3 text-center px-5"">
                                <h5>Local Florists</h5>
                                <p class=""text-black-50"">Class aptent taciti sociosqu ad litora torquent per conubia
                                    nostra, per</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-4"">
                        <div class=""item"">
                            <div class=""img position-relative"">
                                <img src=""img/blog-feature-img-4.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 12845, "\"", 12851, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                    <span>29.12.2019</span>
                                </div>
                            </div>
                            <div class=""text mt-3 text-center px-5"">
                                <h5>Flower Beauty</h5>
                                <p class=""text-black-50"">Class aptent taciti sociosqu ad litora torquent per conubia
                                    nostra, per</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- BLOG END -->

        <!-- SAY START -->

        <section id=""say"">
            <div class=""container"">
                <div class=""row py-5 justify-content-center"">
                    <div class=""col-md-8 col-xl-6"">
                        <div class=""owl-carousel say"">
                            <div");
            WriteLiteral(">\r\n                                <div class=\"item text-center\">\r\n                                    <div class=\"img d-flex justify-content-center\">\r\n                                        <img src=\"img/testimonial-img-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 14104, "\"", 14110, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""text text-muted pt-3 pb-5"">
                                        <i>Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus
                                            lingua. </i>
                                    </div>
                                    <div class=""author"">
                                        <h6>Anna Barnes</h6>
                                        <p class=""text-black-50"">Florist</p>
                                    </div>
                                </div>
                            </div>
                            <div>
                                <div class=""item text-center"">
                                    <div class=""img d-flex justify-content-center"">
                                        <img src=""img/testimonial-img-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 15035, "\"", 15041, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""text text-muted pt-3 pb-5"">
                                        <i>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo
                                            ligula eget. </i>
                                    </div>
                                    <div class=""author"">
                                        <h6>Jasmine White</h6>
                                        <p class=""text-black-50"">Florist</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SAY END -->

        <!-- INSTAGRAM START -->

        <section id=""instagram"">
            <div class=""owl-carousel instagram"">
                <div><img src=""img/instagram1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 16052, "\"", 16058, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img src=\"img/instagram2.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16136, "\"", 16142, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img src=\"img/instagram3.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16220, "\"", 16226, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img src=\"img/instagram4.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16304, "\"", 16310, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img src=\"img/instagram5.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16388, "\"", 16394, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img src=\"img/instagram6.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16472, "\"", 16478, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img src=\"img/instagram7.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16556, "\"", 16562, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div><img src=\"img/instagram8.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16640, "\"", 16646, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            </div>\r\n            <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n                #FIORELLO\r\n            </div>\r\n        </section>\r\n\r\n        <!-- INSTAGRAM END -->\r\n\r\n    </main>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
