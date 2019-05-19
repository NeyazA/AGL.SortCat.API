using System.Net;
using System.Net.Http;

namespace AGL.SortCat.API.ActionResults
{
    public class InternalServerErrorResult : ErrorResult
    {
        public InternalServerErrorResult(HttpRequestMessage request, Error error)
            : base(request, error, HttpStatusCode.InternalServerError)
        {
        }
    }
}