#pragma checksum "D:\rider\Assignment1\Assignment1\Pages\AddFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffad490f6a087691b4e50c2365425b6e245737ab"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "D:\rider\Assignment1\Assignment1\Pages\AddFamily.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\rider\Assignment1\Assignment1\Pages\AddFamily.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\rider\Assignment1\Assignment1\Pages\AddFamily.razor"
using System.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\rider\Assignment1\Assignment1\Pages\AddFamily.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\rider\Assignment1\Assignment1\Pages\AddFamily.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\rider\Assignment1\Assignment1\Pages\AddFamily.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddFamily")]
    public partial class AddFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 186 "D:\rider\Assignment1\Assignment1\Pages\AddFamily.razor"
       
    
    private Family newFamily = new Family();
    private string firstAdult;
    private string secondAdult;
    
    private IList<Adult> singleAdults = new List<Adult>();
    private IList<ChildInterest> childInterests = new List<ChildInterest>();
    private IList<Pet> pets = new List<Pet>();
    private IList<Child> children = new List<Child>();
    private IList<Pet> familyPets = new List<Pet>();
    
    private Child newChild = new Child();
    private string interestMessage="", petMessage="", interestString, childrenMessage="", familyPetMessage="";
    private Pet newPet = new Pet();
    private Pet newFamilyPet = new Pet();
    
    
    
    protected override async Task OnInitializedAsync()
    {
        IList<int> adultsInFamilies = FamilyService.AdultsInFamilies();
        foreach (var adult in AdultService.GetAdults())
        {
            if(!adultsInFamilies.Contains(adult.Id))
                singleAdults.Add(adult);
        }
        childInterests.Clear();
        pets.Clear();
        children.Clear();
    }

    private void AddNewFamily()
    {
    //adds a new family type object to the file 
        if (firstAdult != null)
        {
            string[] str = firstAdult.Split(" ");
            int id1 = Int32.Parse(str.ElementAt(0));
            Adult adult = AdultService.GetAdults().First((adult1 => adult1.Id==id1));
            newFamily.Adults.Add(adult);
        }
        if (secondAdult != null && secondAdult!=firstAdult)
        {
            string[] str = secondAdult.Split(" ");
            int id = Int32.Parse(str.ElementAt(0));
            Adult adult = AdultService.GetAdults().First((adult1 => adult1.Id==id));
            newFamily.Adults.Add(adult);
        }
        if(children!=null)
            if (children.Count != 0)
                newFamily.Children = children.ToList();
        if(familyPets!=null)
            if (familyPets.Count != 0)
                newFamily.Pets = familyPets.ToList();
        FamilyService.AddFamily(newFamily);
        NavigationManager.NavigateTo("/Families");
    }

    private void AddNewInterest()
    {
    //modify interest message and saves the new interest in the list of interests
        if (interestMessage.Equals(""))
        {
            interestMessage += interestString;
        }
        else
        {
            interestMessage += ", " + interestString;
        }
        ChildInterest ci = new ChildInterest();
        ci.InterestId = interestString;
        childInterests.Add(ci);
    }

    private void AddNewPersonalPet()
    {
    //change message and add pet to list of pets
        if (petMessage.Equals(""))
        {
            petMessage += newPet.Name;
        }
        else
        {
            petMessage += ", "+newPet.Name;
        }
        pets.Add(newPet);
    }

    private void AddNewChild()
    {
    //adds the pets and interests, then adds child to the list of children
        if (childrenMessage.Equals(""))
        {
            childrenMessage += newChild.FirstName + " " + newChild.LastName;
        }
        else
        {
            childrenMessage += ", " + newChild.FirstName + " " + newChild.LastName;
        }
        Child child = newChild;
        child.Pets =pets.ToList();
        child.ChildInterests =childInterests.ToList();
        children.Add(child);
    //clear lists in case of new child being added
        childInterests.Clear();
        pets.Clear();
        petMessage = "";
        interestMessage = "";
    }

    private void AddNewFamilyPet()
    {
        if (familyPetMessage.Equals(""))
        {
            familyPetMessage += newFamilyPet.Name;
        }
        else
        {
            familyPetMessage += ", " + newFamilyPet.Name;
        }
        familyPets.Add(newFamilyPet);
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
