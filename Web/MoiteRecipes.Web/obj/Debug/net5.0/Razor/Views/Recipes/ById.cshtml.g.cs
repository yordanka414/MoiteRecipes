#pragma checksum "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd868aa9b7772d41f41cec74b76dee73583d2da2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_ById), @"mvc.1.0.view", @"/Views/Recipes/ById.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\_ViewImports.cshtml"
using MoiteRecipes.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\_ViewImports.cshtml"
using MoiteRecipes.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd868aa9b7772d41f41cec74b76dee73583d2da2", @"/Views/Recipes/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76dcba36b70b517def570e43cdae962cb5388cff", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoiteRecipes.Web.ViewModels.Recipes.SignalRecipeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
  
    this.ViewData["Title"] = this.Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"single-recipe-layout1\">\r\n    <div class=\"ctg-name\">");
#nullable restore
#line 6 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                     Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <h2 class=\"item-title\">");
#nullable restore
#line 7 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                      Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"row mb-4\">\r\n        <div class=\"col-xl-9 col-12\">\r\n            <ul class=\"entry-meta\">\r\n                <li class=\"single-meta\">\r\n                    <i class=\"far fa-calendar-alt\"></i>");
#nullable restore
#line 12 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                                                  Write(Model.CreatedOn.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li class=\"single-meta\">\r\n\r\n                    <i class=\"fas fa-user\"></i>by\r\n                    <span>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 672, "\"", 697, 1);
#nullable restore
#line 18 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
WriteAttributeValue("", 679, Model.OriginalUrl, 679, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                        ");
#nullable restore
#line 19 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                    Write(Model.AddedByUserUserName ?? Model.OriginalUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </span>

                </li>
                <li class=""single-meta"">
                    <ul class=""item-rating"">
                        <li class=""star-fill""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill""><i class=""fas fa-star""></i></li>
                        <li class=""star-empty""><i class=""fas fa-star""></i></li>
                        <li><span>5<span> / 5</span></span> </li>
                    </ul>
                </li>
                
            </ul>
        </div>

    </div>
    <div class=""item-figure"">
        <img class=""img-fluid w-100""");
            BeginWriteAttribute("src", " src=\"", 1574, "\"", 1595, 1);
#nullable restore
#line 39 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
WriteAttributeValue("", 1580, Model.ImageUrl, 1580, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1596, "\"", 1613, 1);
#nullable restore
#line 39 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
WriteAttributeValue("", 1602, Model.Name, 1602, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
    <div class=""item-feature"">
        <ul>
            <li>
                <div class=""feature-wrap"">
                    <div class=""media"">
                        <div class=""feature-icon"">
                            <i class=""far fa-clock""></i>
                        </div>
                        <div class=""media-body space-sm"">
                            <div class=""feature-title"">PREP TIME</div>
                            <div class=""feature-sub-title"">
                                ");
#nullable restore
#line 52 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                           Write(Model.PreparationTime.TotalMinutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Mins
                            </div>
                        </div>
                    </div>
                </div>
            </li>
            <li>
                <div class=""feature-wrap"">
                    <div class=""media"">
                        <div class=""feature-icon"">
                            <i class=""fas fa-utensils""></i>
                        </div>
                        <div class=""media-body space-sm"">
                            <div class=""feature-title"">COOK TIME</div>
                            <div class=""feature-sub-title"">");
#nullable restore
#line 66 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                                                      Write(Model.CookingTime.TotalMinutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Mins</div>
                        </div>
                    </div>
                </div>
            </li>
            <li>
                <div class=""feature-wrap"">
                    <div class=""media"">
                        <div class=""feature-icon"">
                            <i class=""fas fa-users""></i>
                        </div>
                        <div class=""media-body space-sm"">
                            <div class=""feature-title"">SERVING</div>
                            <div class=""feature-sub-title"">
                                ");
#nullable restore
#line 80 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                           Write(Model.PortionsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 81 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                                 if (Model.PortionsCount == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>Person</span>\r\n");
#nullable restore
#line 84 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span> People</span>\r\n");
#nullable restore
#line 88 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
            </li>
            <li>
                <div class=""feature-wrap"">
                    <div class=""media"">
                        <div class=""feature-icon"">
                            <i class=""far fa-eye""></i>
                        </div>
                        <div class=""media-body space-sm"">
                            <div class=""feature-title"">CATEGORY COUNT</div>
                            <div class=""feature-sub-title"">");
#nullable restore
#line 102 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                                                      Write(Model.CategoryRecipesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                    </div>
                </div>
            </li>
        </ul>
    </div>
    <div class=""making-elements-wrap"">
        <div class=""row"">
            <div class=""col-md-6 d-inline-block text-break"">
                <p class=""item-description ""  >
                    ");
#nullable restore
#line 113 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
               Write(Model.Instructions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"ingridients-wrap\">\r\n                    <h3 class=\"item-title\"><i class=\"fas fa-list-ul\"></i>Ingridients</h3>\r\n");
#nullable restore
#line 119 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                     foreach (var ingredient in Model.Ingredients)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"checkbox checkbox-primary\">\r\n                            <label for=\"checkbox1\">");
#nullable restore
#line 122 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                                              Write(ingredient.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 122 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                                                                   Write(ingredient.IngredientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                        </div>\r\n");
#nullable restore
#line 124 "C:\Users\HP\Desktop\MoiteRecipes\Web\MoiteRecipes.Web\Views\Recipes\ById.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoiteRecipes.Web.ViewModels.Recipes.SignalRecipeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
