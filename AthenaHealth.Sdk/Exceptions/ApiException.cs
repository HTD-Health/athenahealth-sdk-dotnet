using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using AthenaHealth.Sdk.Http;

namespace AthenaHealth.Sdk.Exceptions
{
    public class ApiException : Exception
    {
        public HttpStatusCode StatusCode { get; private set; }
        public string ResponseError { get; private set; }
        public IResponse Response { get; private set; }

        public ApiException()
        {
        }

        public ApiException(string responseError, HttpStatusCode statusCode, IResponse response = null): base("An responseError occured in communication with AthenaHealth API: " + responseError)
        {
            StatusCode = statusCode;
            ResponseError = responseError;
            Response = response;
        }
    }
}
