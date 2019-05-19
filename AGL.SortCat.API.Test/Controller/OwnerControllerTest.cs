using AGL.SortCat.API.Controllers;
using AGL.SortPet.Service;
using NSubstitute;

namespace AGL.SortCat.API.Test.Controller
{
    public class OwnerControllerTest
    {
        private  OwnerController ownerController;
        private readonly IPetOwnerService petOwnerService;

        public OwnerControllerTest()
        {
            petOwnerService = Substitute.For<IPetOwnerService>();
        }

        public void GetPet_ReturnsData()
        {
            petOwnerService.GetPetsByOwnerGender("Cat");
            //petOwnerService.GetPetsByOwnerGender(Arg.Any<string>).Returns();
            ownerController = new OwnerController(petOwnerService);
        }

       
    }
}
