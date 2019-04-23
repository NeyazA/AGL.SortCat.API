using AGL.Sortcat.Utility;
using AGL.SortCat.Models;
using AGL.SortCat.Service;
using System.Collections.Generic;
using System.Linq;

namespace AGL.SortCat.Repository
{
    public class OwnerRepo:IOwnerRepo
    {
        private IOwnerService OwnerService;

        public OwnerRepo(IOwnerService OwnerService)
        {
            this.OwnerService = OwnerService;
        }
        public IEnumerable<PetGroup> GetPetsByOwnerGender(string petType)
        {
            List<PetGroup> _result = null;
            List<PetOwner> petOwners = this.OwnerService.GetAllOwners().ToList();
            if (!string.IsNullOrWhiteSpace(petType) && petOwners.Count > 0)
            {
                _result = new List<PetGroup>();

                _result = petOwners.GroupBy(p => p.Gender)
                    .Select(p => new PetGroup
                    {
                        GroupName = p.Key,
                        PetNames = p.SelectManyExceptNull(po => po.Pets)
                        .Where(c => petType == c.Type)
                        .Select(c => c.Name)
                        .Distinct()
                        .OrderBy(c => c)
                        .ToList()
                    }).ToList<PetGroup>();
            }
            return _result;
        }
    }
}
