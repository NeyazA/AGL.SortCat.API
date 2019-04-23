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
        //public IEnumerable<string> Get()
        //{
        //    OwnerRepo.GetPetsByOwnerGender();
        //}

        //public IHttpActionResult Get()
        //{
        //    OwnerRepo.GetPetsByOwnerGender();
        //}

        // GET: api/Owner
        public HttpResponseMessage GetPet()
        {
            var result = OwnerRepo.GetPetsByOwnerGender("CAT");
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
