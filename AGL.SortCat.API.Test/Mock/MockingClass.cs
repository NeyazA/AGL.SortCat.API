using AGL.SortPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.SortCat.API.Test.Mock
{
   public class MockingClass
    {
        #region Gender Pets

        public List<Pet> GetMaleMockPetResult()
        {
            return new List<Pet>
            {
                new Pet { Name = "Garfield", Type = "Cat" },
                new Pet { Name = "Fido", Type = "Dog" },
                new Pet { Name = "Tom", Type = "Cat" },
                new Pet { Name = "Simba", Type = "Cat" },
                new Pet { Name = "Nemo", Type = "Fish" },
                new Pet { Name = "Sam", Type = "Dog" },
                new Pet { Name = "Garfield", Type = "Cat" }
            };
        }
        public List<Pet> GetFemaleMockPetResult()
        {
            return new List<Pet>
            {
                new Pet { Name = "Rosy", Type = "Cat" },
                new Pet { Name = "Fido", Type = "Dog" },
                new Pet { Name = "Lucy", Type = "Cat" },
                new Pet { Name = "Sweetie", Type = "Cat" },
                new Pet { Name = "Nemo", Type = "Fish" },
                new Pet { Name = "Sam", Type = "Dog" },
                new Pet { Name = "Rosy", Type = "Cat" }
            };
        }
        #endregion

        #region PetOwner Setup
        public List<PetOwner> GetMockPetOwnerResult()
        {
            return new List<PetOwner>
            {
                new PetOwner { Name = "Bob", Gender = "Male", Age = 23, Pets = GetMaleMockPetResult() },
                new PetOwner { Name = "Jennifer", Gender = "Female", Age = 18, Pets = GetFemaleMockPetResult() }
            };
        }

        public List<PetOwner> GetMockPetOwnerSingleNullPetArrayResult()
        {
            return new List<PetOwner>
            {
                new PetOwner { Name = "Bob", Gender = "Male", Age = 23, Pets = null },
                new PetOwner { Name = "Jennifer", Gender = "Female" , Age = 18, Pets = GetFemaleMockPetResult() }
            };
        }

        public List<PetOwner> GetMockPetOwnerBothNullPetArrayResult()
        {
            return new List<PetOwner>
            {
                new PetOwner { Name = "Bob", Gender = "Male", Age = 23, Pets = null },
                new PetOwner { Name = "Jennifer", Gender = "Female", Age = 18, Pets = null }
            };
        }

        #endregion

        #region Mock PetGroup Setup
        public List<PetGroup> GetMockPetGroup()
        {
            return new List<PetGroup>
            {
                new PetGroup { GroupName = "Male", PetNames = new List<string> { "Garfield", "Simba", "Tom" } },
                new PetGroup { GroupName = "Female", PetNames = new List<string> { "Lucy", "Rosy", "Sweetie" } },
            };
        }

        public List<PetGroup> GetMockPetGroupWithError()
        {
            return new List<PetGroup>
            {
                new PetGroup { GroupName = "Male", PetNames = null },
                new PetGroup { GroupName = "Female", PetNames = null },
            };
        }
        public List<PetGroup> GetMockPetGroupWithNull()
        {
            return null;
        }
        #endregion

    }
}
