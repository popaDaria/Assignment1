using System.Collections.Generic;
using Assignment1.Models;
using Assignment1.Persistance;

namespace Assignment1.Data
{
    public class FamilyService : IFamilyService
    {

        private FileContext fileContext;

        public FamilyService()
        {
            fileContext = new FileContext();
        }
        
        public IList<Family> GetFamilies()
        {
            IList<Family> families = fileContext.Families;
            return families;
        }

        public void AddFamily(Family newFamily)
        {
            //check if street+house nr is unique before adding
            if (IsAdressUnique(newFamily))
            {
                fileContext.Families.Add(newFamily);
                fileContext.SaveChanges();
            }
        }

        public IList<int> AdultsInFamilies()
        {
            IList<int> adults = new List<int>();
            foreach (var family in GetFamilies())
            {
                foreach (var adult in family.Adults)
                {
                    adults.Add(adult.Id);
                }
            }
            return adults;
        }

        private bool IsAdressUnique(Family newFamily)
        {
            IList<Family> families = fileContext.Families;
            bool unique = true;
            foreach (Family fam in families)
            {
                if (fam.HouseNumber == newFamily.HouseNumber && fam.StreetName.Equals(newFamily.StreetName))
                    unique = false;
            }
            return unique;
        }
    }
}