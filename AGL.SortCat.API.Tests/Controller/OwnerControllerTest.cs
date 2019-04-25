using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.SortCat.API.Tests.Controller
{
    [TestClass]
    public class OwnerControllerTest
    {
        [TestMethod]
        public void GetPetTest()
        {
            string petType = "Cat";
            Mocking moc = new Mocking();
            //var mock = new Mock<IOwnerRepo>();
            //mock.Setup(p => p.GetPetsByOwnerGender(petType)).Returns(moc.GetMockPetGroup());
        }
    }
}
