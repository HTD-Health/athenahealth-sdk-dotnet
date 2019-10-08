using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using AthenaHealth.Sdk.Http;

namespace AthenaHealth.Sdk.Exceptions
{
    public class ApiValidationException : ApiException
    {
        public ApiValidationException(string responseError, HttpStatusCode statusCode, Response response = null) : base(responseError, statusCode, response)
        {
        }
    }
}
