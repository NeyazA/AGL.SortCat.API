using AGL.SortPet.Repository;
using NSubstitute;
using System;
using System.Collections.Generic;
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

            //TODO: Please try to mock HttpClient. You have make complete new implementation for HttpClient like factory method then only you can mock and test it. This test is not correct as it makes call to API.


            // Act
            var result = petRepository.GetAllOwners();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsEqual(result.Count(), 6);
        }

    }
}
