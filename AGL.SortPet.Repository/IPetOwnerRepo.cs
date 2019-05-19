using AGL.SortPet.Models;
using System.Collections.Generic;

namespace AGL.SortPet.Repository
{
    public interface IPetOwnerRepo
    {
        IEnumerable<PetOwner> GetAllOwners();
    }
}
