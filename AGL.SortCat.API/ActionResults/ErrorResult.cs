using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace AGL.SortCat.API.ActionResults
{
    public abstract class ErrorResult: IHttpActionResult
    {
        public readonly Error Error;
        private readonly HttpRequestMessage _request;
        private readonly HttpStatusCode _httpStatusCode;

        protected ErrorResult(HttpRequestMessage request, Error error, HttpStatusCode httpStatusCode)
        {
            _request = request;
            Error = error;
            _httpStatusCode = httpStatusCode;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(_request.CreateResponse(_httpStatusCode, Error));
        }
    }
}