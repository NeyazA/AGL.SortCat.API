using AGL.SortPet.Repository;
using System.Linq;
using Xunit;
using AssertLibrary;

namespace AGL.SortCat.API.Test.Repository
{
    public class PetOwnerRepoTest
    {
        public PetOwnerRepoTest()
        {
         
        }

        [Fact]
        public void GetPetsByOwnerGenderNotNull()
        {
            // Arrange
            var petRepository = new PetOwnerRepo();
            // Act
            var result = petRepository.GetAllOwners();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsEqual(result.Count(), 6);
        }

    }
}
