using AthenaHealth.Sdk.Http;
using System.Net;

namespace AthenaHealth.Sdk.Exceptions
{
    public class ApiValidationException : ApiException
    {
        public ApiValidationException(string responseError, HttpStatusCode statusCode, Response response = null) : base(responseError, statusCode, response)
        {
        }
    }
}
