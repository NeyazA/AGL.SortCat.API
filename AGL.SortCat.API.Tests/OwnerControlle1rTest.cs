using AGL.SortCat.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AGL.SortCat.Repository;
using AGL.SortCat.API.Controllers;

namespace AGL.SortCat.API.Tests
{
    [TestClass]
    public class OwnerControlle1rTest
    {
        [TestMethod]
        public void GetPetTest()
        {
            string petType = "Cat";
            Mocking moc = new Mocking();
            var mock = new Mock<IOwnerRepo>();
            mock.Setup(p => p.GetPetsByOwnerGender(petType)).Returns(moc.GetMockPetGroup());
        }

    }
}
