using AGL.Sortcat.Utility;
using AGL.SortCat.Repository;
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
        private IOwnerRepo OwnerRepo;

        public OwnerController(IOwnerRepo OwnerRepo)
        {
            this.OwnerRepo = OwnerRepo;
        }
        // GET: api/Owner

        [HttpGet]
        [Route("api/petowner/")]
        public HttpResponseMessage GetPet()

        {
            try
            {
            var result = OwnerRepo.GetPetsByOwnerGender("Cat");
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
