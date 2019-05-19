
using AGL.SortPet.Models;
using System.Collections.Generic;

namespace AGL.SortPet.Service
{
    public interface IPetOwnerService
    {
        IEnumerable<PetGroup> GetPetsByOwnerGender(string petType);
    }
}
