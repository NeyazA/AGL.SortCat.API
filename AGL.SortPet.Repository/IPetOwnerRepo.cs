using AGL.SortPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.SortPet.Repository
{
    public interface IPetOwnerRepo
    {
        IEnumerable<PetOwner> GetAllOwners();
    }
}
