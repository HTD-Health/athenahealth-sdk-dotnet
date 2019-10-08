using AthenaHealth.Sdk.Http.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace AthenaHealth.Sdk.Http
{
    public class Request
    {
        public IDictionary<string, string> Headers { get; set; }

        public HttpMethod Method { get; set; }

        public HttpContent Content { get; set; }

        public IDictionary<string, string> Parameters { get; set; }

        public Uri Endpoint { get; set; }

        public Uri RequestUri => UrlBuilder.BuildUri(Endpoint, Parameters, -1);

        public Request()
        {
            Headers = new Dictionary<string, string>();
            Parameters = new Dictionary<string, string>();
        }
    }
}
