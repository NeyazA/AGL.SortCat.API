using AGL.SortPet.Repository;
using AGL.SortPet.Service;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AGL.SortCat.API.Test.Service
{
    public class PetOwnerServiceTest
    {
        private readonly PetOwnerService _petOwnerService;
        private readonly IPetOwnerRepo _petOwnerRepository;

        public PetOwnerServiceTest()
        {
            _petOwnerRepository= Substitute.For<IPetOwnerRepo>();
            _petOwnerService = new PetOwnerService(_petOwnerRepository);
        }

        [Fact(DisplayName = "Call repo layer")]
        public void Call_Repository()
        {
            //_OwnerRepo.GetPetsByOwnerGender("Cat");
            //_ownerService.Received().GetById(Arg.Any<int>());
        }
    }
}
