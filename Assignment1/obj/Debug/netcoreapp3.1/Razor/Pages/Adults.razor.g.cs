#pragma checksum "D:\rider\Assignment1\Assignment1\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f17313fe300a89dd58e030abe9c0efe78f8d33b1"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\rider\Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\rider\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\rider\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\rider\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\rider\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\rider\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\rider\Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\rider\Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\rider\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by Age: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                                                    (arg)=>Filter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "\r\n    Filter by Gender: ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                                                     (arg)=>FilterByGender(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "style", "width: 50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n\r\n");
#nullable restore
#line 19 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
 if (allAdults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.AddMarkupContent(18, "<p class=\"text-info font-weight-bold\">\r\n        Loading...\r\n    </p>\r\n");
#nullable restore
#line 24 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
}
else if (!allAdults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.AddMarkupContent(20, "<p>\r\n        <em>No Adult items exist. Please add some</em>\r\n    </p>\r\n");
#nullable restore
#line 30 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "d-flex");
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "thead");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.AddMarkupContent(32, "<th>Person ID</th>\r\n                ");
            __builder.AddMarkupContent(33, "<th>Full Name</th>\r\n                ");
            __builder.AddMarkupContent(34, "<th>Hair Colour</th>\r\n                ");
            __builder.AddMarkupContent(35, "<th>Eye Colour</th>\r\n                ");
            __builder.AddMarkupContent(36, "<th>Age</th>\r\n                ");
            __builder.AddMarkupContent(37, "<th>Weight</th>\r\n                ");
            __builder.AddMarkupContent(38, "<th>Height</th>\r\n                ");
            __builder.AddMarkupContent(39, "<th>Sex</th>\r\n                ");
            __builder.AddMarkupContent(40, "<th>Job</th>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(41);
            __builder.AddAttribute(42, "Policy", "MustBeAdmin");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __builder2.AddMarkupContent(45, "<th>Remove</th>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "tbody");
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 52 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
             foreach (var items in adultsToShow)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                ");
            __builder.OpenElement(52, "tr");
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "class", "font-weight-bold");
            __builder.AddContent(56, 
#nullable restore
#line 55 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                                                  items.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 56 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                         items.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, " ");
            __builder.AddContent(61, 
#nullable restore
#line 56 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                                          items.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 57 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                     if (@items.HairColor == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                        ");
            __builder.AddMarkupContent(64, "<td>unspecified</td>\r\n");
#nullable restore
#line 60 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "                        ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 63 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                             items.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 64 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                    ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 65 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                         items.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 66 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                         items.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 67 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                         items.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 68 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                         items.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 69 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                         items.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.OpenElement(85, "td");
            __builder.AddContent(86, 
#nullable restore
#line 70 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                         items.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(88);
            __builder.AddAttribute(89, "Policy", "MustBeAdmin");
            __builder.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __builder2.OpenElement(92, "td");
                __builder2.AddMarkupContent(93, "\r\n                            ");
                __builder2.OpenElement(94, "button");
                __builder2.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
                                                () => RemoveAdult(items)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(96, "\r\n                                <i class=\"oi oi-trash\" style=\"color:darkred\"></i>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 79 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 83 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "D:\rider\Assignment1\Assignment1\Pages\Adults.razor"
       
    private IList<Adult> allAdults;
    private IList<Adult> adultsToShow;

    private int? filterByAge;
    private string filterByGender;

    protected override async Task OnInitializedAsync()
    {
        allAdults = AdultService.GetAdults();
        adultsToShow = allAdults;
    }

    private void RemoveAdult(Adult adult)
    {
        allAdults.Remove(adult);
        AdultService.RemoveAdult(adult);
        FamilyService.RemoveAdult(adult);
    }

    private void Filter(ChangeEventArgs args)
    {
        filterByAge = null;
        try
        {
            filterByAge = int.Parse(args.Value.ToString());
        }
        catch (Exception e)
        {
    //does nothing
        }
        if (filterByAge != null)
        {
            adultsToShow = allAdults.Where(t => t.Age == filterByAge).ToList();
        }
        else
        {
            adultsToShow = allAdults;
        }
    }

    private void FilterByGender(ChangeEventArgs args)
    {
        filterByGender = args.Value.ToString();
        if(filterByGender!=null || filterByGender!=""||args.Value!=null)
            ExecuteFilter();
        else
        {
            adultsToShow = allAdults;
        }
    }
    
    private void ExecuteFilter()
    {
        adultsToShow = allAdults.Where(t =>
            (filterByAge != null && t.Age == filterByAge || filterByAge == null) &&
            (filterByGender != null && t.Sex == filterByGender || filterByGender == null)
            ).ToList();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
