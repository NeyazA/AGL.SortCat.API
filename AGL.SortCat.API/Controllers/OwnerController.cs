using AGL.SortPet.Service;
using AGL.SortPet.Utility;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AGL.SortCat.API.Controllers
{
    public class OwnerController : ApiController
    {
        private readonly IPetOwnerService petOwnerService;
        public OwnerController(IPetOwnerService petOwnerService)
        {
            this.petOwnerService = petOwnerService;
        }
        [HttpGet]
        [Route("api/petowner/")]
        public HttpResponseMessage GetPet()
        {
            try
            {
            var result = petOwnerService.GetPetsByOwnerGender("Cat");
            Logging.Log(result.ToString());
            return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                Logging.HandleException(ex);
                throw;
            }
        }
    }
}
