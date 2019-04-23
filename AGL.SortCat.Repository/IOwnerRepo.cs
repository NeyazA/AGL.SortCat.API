using AGL.SortCat.Models;
using System.Collections.Generic;

namespace AGL.SortCat.Repository
{
    public interface IOwnerRepo
    {
        IEnumerable<PetGroup> GetPetsByOwnerGender(string petType);
    }
}
