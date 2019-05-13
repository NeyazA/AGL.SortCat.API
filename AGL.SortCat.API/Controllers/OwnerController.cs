using AGL.SortPet.Service;
using AGL.SortPet.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AGL.SortCat.API.Controllers
{
    public class OwnerController : ApiController
    {
        private IPetOwnerService petOwnerService;

        public OwnerController(IPetOwnerService petOwnerService)
        {
            this.petOwnerService = petOwnerService;
        }
        // GET: api/Owner

        [HttpGet]
        [Route("api/petowner/")]
        public HttpResponseMessage GetPet()

        {
            try
            {
            var result = petOwnerService.GetPetsByOwnerGender("Cat");
                //Enum to .....
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
