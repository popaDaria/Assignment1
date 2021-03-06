using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models {
public class Family {
    
    //public int Id { get; set; }
    [Required]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber{ get; set; }
    //[MaxLength(2)]
    public List<Adult> Adults { get; set; }
    //[MaxLength(7)]
    public List<Child> Children{ get; set; }
    //[MaxLength(3)]
    public List<Pet> Pets{ get; set; }
    
    public Family() {
        Adults = new List<Adult>();    
        Children = new List<Child>();
        Pets = new List<Pet>();
    }
    

}


}