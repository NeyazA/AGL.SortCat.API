using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AGL.SortCat.API.ActionResults;


namespace AGL.SortCat.API.Controllers
{
    public class ErrorController : ApiController
    {
        [HttpGet]
        [HttpPost]
        [HttpPut]
        [HttpDelete]
        [HttpHead]
        [HttpOptions]
        [HttpPatch]
        public IHttpActionResult ResourceNotFound()
        {
            return new NotFoundErrorResult(Request,
                new Error($"The requested resource is not found, Requested URI: {Request.RequestUri}"));
        }
    }
}
