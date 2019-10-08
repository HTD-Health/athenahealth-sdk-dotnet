using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace AthenaHealth.Sdk.Exceptions
{
    public class ApiValidationException : ApiException
    {
        public ApiValidationException(string responseError, HttpStatusCode statusCode, HttpResponseMessage httpResponseMessage = null) : base(responseError, statusCode, httpResponseMessage)
        {
        }
    }
}
