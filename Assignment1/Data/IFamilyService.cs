using System.Collections.Generic;
using Assignment1.Models;

namespace Assignment1.Data
{
    public interface IFamilyService
    {
        IList<Family> GetFamilies();
        void AddFamily(Family newFamily);
        IList<int> AdultsInFamilies();
        void RemoveAdult(Adult adult);
    }
}