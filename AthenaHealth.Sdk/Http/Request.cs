﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using AthenaHealth.Sdk.Http.Helpers;

namespace AthenaHealth.Sdk.Http
{
    public class Request : IRequest
    {
        public Request()
        {
            Headers = new Dictionary<string, string>();
            Parameters = new Dictionary<string, string>();
        }

        public object Body { get; set; }
        public Dictionary<string, string> Headers { get; private set; }
        public HttpMethod Method { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public Uri BaseAddress { get; set; }
        public Uri Endpoint { get; set; }
        public string ContentType { get; set; }

        public Uri RequestUri => UrlBuilder.BuildUrl(BaseAddress, Parameters);
    }
}
