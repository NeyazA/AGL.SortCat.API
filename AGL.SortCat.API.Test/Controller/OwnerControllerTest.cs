using AGL.SortCat.API.Controllers;
using AGL.SortPet.Service;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.SortCat.API.Test.Controller
{
    public class OwnerControllerTest
    {
        private readonly OwnerController ownerController;
        private readonly IPetOwnerService petOwnerService;

        public OwnerControllerTest()
        {
            petOwnerService = Substitute.For<IPetOwnerService>();
            ownerController = new OwnerController(petOwnerService);
        }

        public void GetPetReturnsData()
        {
            petOwnerService.GetPetsByOwnerGender("Cat");
        }
    }
}
