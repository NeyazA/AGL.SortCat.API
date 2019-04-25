using AGL.SortPet.Models;
using AGL.SortPet.Repository;
using AGL.SortPet.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.SortPet.Service
{
    public class PetOwnerService:IPetOwnerService
    {
        private IPetOwnerRepo petOwnerRepo;
        public PetOwnerService(IPetOwnerRepo petOwnerRepo)
        {
            this.petOwnerRepo = petOwnerRepo;
        }

        public IEnumerable<PetGroup> GetPetsByOwnerGender(string petType)
        {
            List<PetGroup> _result = null;
            List<PetOwner> petOwners = this.petOwnerRepo.GetAllOwners().ToList();
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
