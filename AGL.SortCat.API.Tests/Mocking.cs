using AGL.SortCat.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.SortCat.API.Tests
{
    public class Mocking
    {

        #region Gender Pets
        [Ignore]
        public List<Pet> GetMaleMockPetResult()
        {
            return new List<Pet>
            {
                new Pet {Name="Garfield",Type="Cat"},
                new Pet {Name="Fido", Type="Dog" },
                new Pet {Name="Tom", Type="Cat" },
                new Pet {Name="Simba", Type="Cat" },
                new Pet {Name="Nemo", Type="Fish" },
                new Pet {Name="Sam", Type="Dog" },
                new Pet {Name="Garfield", Type="Cat" }
            };
        }
        [Ignore]
        public List<Pet> GetFemaleMockPetResult()
        {
            return new List<Pet>
            {
                new Pet {Name="Rosy",Type="Cat"},
                new Pet {Name="Fido", Type="Dog" },
                new Pet {Name="Lucy", Type="Cat" },
                new Pet {Name="Sweetie", Type="Cat" },
                new Pet {Name="Nemo", Type="Fish" },
                new Pet {Name="Sam", Type="Dog" },
                new Pet {Name="Rosy", Type="Cat" }
            };
        }
        #endregion

        #region PetOwner Setup
        [Ignore]
        public List<PetOwner> GetMockPetOwnerResult()
        {
            return new List<PetOwner>
            {
                new PetOwner { Name ="Bob",Gender = "Male", Age=23, Pets = GetMaleMockPetResult() },
                new PetOwner { Name ="Jennifer",Gender = "Female", Age=18, Pets = GetFemaleMockPetResult()}
             };
        }
        [Ignore]
        public List<PetOwner> GetMockPetOwnerSingleNullPetArrayResult()
        {
            return new List<PetOwner>
            {
                new PetOwner { Name ="Bob",Gender = "Male", Age=23, Pets = null },
                new PetOwner { Name ="Jennifer",Gender = "Female", Age=18, Pets = GetFemaleMockPetResult()}
             };
        }
        [Ignore]
        public List<PetOwner> GetMockPetOwnerBothNullPetArrayResult()
        {
            return new List<PetOwner>
            {
                new PetOwner { Name ="Bob",Gender = "Male", Age=23, Pets = null },
                new PetOwner { Name ="Jennifer",Gender = "Female", Age=18, Pets =null}
             };
        }
        [Ignore]
        public List<PetOwner> GetMockPetOwnerSingleGenderNull()
        {
            return new List<PetOwner>
            {
                new PetOwner { Name ="Bob",Gender = null, Age=23, Pets = GetMaleMockPetResult() },
                new PetOwner { Name ="Jennifer",Gender = null, Age=18, Pets = GetFemaleMockPetResult()}
             };
        }
        #endregion

        #region Mock PetGroup Setup
        [Ignore]
        public List<PetGroup> GetMockPetGroup()
        {
            return new List<PetGroup>
            {
                new PetGroup { GroupName = "Male", PetNames = new List<string> { "Garfield", "Simba", "Tom" }},
                new PetGroup { GroupName = "Female", PetNames = new List<string> { "Lucy", "Rosy", "Sweetie" }},
            };
        }
        //Mock Error Data For Test
        [Ignore]
        public List<PetGroup> GetMockPetGroupWithError()
        {
            return new List<PetGroup>
            {
                new PetGroup { GroupName = "Male", PetNames = null},
                new PetGroup { GroupName = "Female", PetNames = null},
            };
        }
        //Mock Error Data For Test
        [Ignore]
        public List<PetGroup> GetMockPetGroupWithNull()
        {
            return null;
        }
        #endregion
    }
}
