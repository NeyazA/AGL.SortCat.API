using AGL.SortCat.API.Test.Mock;
using AGL.SortPet.Repository;
using AGL.SortPet.Service;
using NSubstitute;
using System.Linq;
using Xunit;
using AssertLibrary;

namespace AGL.SortCat.API.Test.Service
{
    public class PetOwnerServiceTest
    {
        public PetOwnerServiceTest()
        {
        }

        [Fact]
        public void GetPetsByOwnerGenderNotNull()
        {
            // Arrange
            var mockProvider = new MockingClass();
            var mockRepository = Substitute.For<IPetOwnerRepo>();
            mockRepository.GetAllOwners().Returns(mockProvider.GetMockPetOwnerResult());
            var petService = new PetOwnerService(mockRepository);

            // Act
            var result = petService.GetPetsByOwnerGender("Cat");

            // Assert
            Assert.IsNotNull(result);
        }

        [Fact]
        public void GetPetsByOwnerGenderGroupCount()
        {
            // Arrange
            var mockProvider = new MockingClass();
            var mockRepository = Substitute.For<IPetOwnerRepo>();
            mockRepository.GetAllOwners().Returns(mockProvider.GetMockPetOwnerResult());
            var petService = new PetOwnerService(mockRepository);

            // Act
            var result = petService.GetPetsByOwnerGender("Cat").ToList();

            // Assert
            Assert.IsEqual(result.Count, 2);
        }

        [Fact]
        public void GetPetsByOwnerGenderEachGenderGroupAvailable()
        {
            // Arrange
            var mockProvider = new MockingClass();
            var mockRepository = Substitute.For<IPetOwnerRepo>();
            mockRepository.GetAllOwners().Returns(mockProvider.GetMockPetOwnerResult());
            var petService = new PetOwnerService(mockRepository);

            // Act
            var result = petService.GetPetsByOwnerGender("Cat");

            // Assert
            Assert.IsNotNull(result);
            var petGroups = result.ToList();
            Assert.IsTrue(petGroups.Any(r => r.GroupName.Equals("Male", System.StringComparison.InvariantCultureIgnoreCase)));
            Assert.IsTrue(petGroups.Any(r => r.GroupName.Equals("Female", System.StringComparison.InvariantCultureIgnoreCase)));
        }

        [Fact]
        public void GetPetsByOwnerGenderGenderGroupCount()
        {
            // Arrange
            var mockProvider = new MockingClass();
            var mockRepository = Substitute.For<IPetOwnerRepo>();
            mockRepository.GetAllOwners().Returns(mockProvider.GetMockPetOwnerResult());
            var petService = new PetOwnerService(mockRepository);

            // Act
            var result = petService.GetPetsByOwnerGender("Cat");

            // Assert
            Assert.IsEqual(result.Count(r => r.GroupName.Equals("Male", System.StringComparison.InvariantCultureIgnoreCase)), 1);
            Assert.IsEqual(result.Count(r => r.GroupName.Equals("Female", System.StringComparison.InvariantCultureIgnoreCase)), 1);
        }

        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [Theory]
        public void TestOrderSequenceOfPetsForMaleOwner(int index)
        {
            // Arrange
            var mockProvider = new MockingClass();
            var mockRepository = Substitute.For<IPetOwnerRepo>();
            mockRepository.GetAllOwners().Returns(mockProvider.GetMockPetOwnerResult());
            var petService = new PetOwnerService(mockRepository);

            // Act
            var result = petService.GetPetsByOwnerGender("Cat");
            Assert.IsNotNull(result);
            var petNames = result.Where(r => r.GroupName.Equals("Male", System.StringComparison.InvariantCultureIgnoreCase)).SelectMany(p => p.PetNames);
            var expectedResult = mockProvider.GetMockPetGroup().Where(r => r.GroupName.Equals("Male", System.StringComparison.InvariantCultureIgnoreCase)).SelectMany(m => m.PetNames);

            // Assert
            Assert.IsEqual(petNames.ElementAt(index), expectedResult.ElementAt(index));
        }

        [Fact]
        public void TestEmptyPetListExistsForSingleGroup()
        {
            // Arrange
            var mockProvider = new MockingClass();
            var mockRepository = Substitute.For<IPetOwnerRepo>();
            mockRepository.GetAllOwners().Returns(mockProvider.GetMockPetOwnerSingleNullPetArrayResult());
            var petService = new PetOwnerService(mockRepository);

            // Act
            var result = petService.GetPetsByOwnerGender("Cat");
            var maleGroupPetNames = result.Where(r => r.GroupName.Equals("Male", System.StringComparison.InvariantCultureIgnoreCase)).SelectMany(m => m.PetNames);

            // Assert
            Assert.IsEqual(maleGroupPetNames.Count(), 0);
        }

        [Fact]
        public void TestEmptyPetListExistsForAllGroup()
        {
            // Arrange
            var mockProvider = new MockingClass();
            var mockRepository = Substitute.For<IPetOwnerRepo>();
            mockRepository.GetAllOwners().Returns(mockProvider.GetMockPetOwnerBothNullPetArrayResult());
            var petService = new PetOwnerService(mockRepository);

            // Act
            var result = petService.GetPetsByOwnerGender("Cat");
            var maleGroupPetNames = result.Where(r => r.GroupName.Equals("Male")).SelectMany(m => m.PetNames);
            var femaleGroupPetNames = result.Where(r => r.GroupName.Equals("Female")).SelectMany(m => m.PetNames);

            // Assert
            Assert.IsEqual(maleGroupPetNames.Count(), 0);
            Assert.IsEqual(femaleGroupPetNames.Count(), 0);
        }
    }
}
