using System;
using System.Collections.Generic;
using AGL.SortCat.Models;

namespace AGL.SortCat.Service
{
    public interface IOwnerService
    {
        IEnumerable<PetOwner> GetAllOwners();
    }
}
