using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public interface IAthenaHttpClient
    {
        Uri BaseAddress { get; set; }
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
    }
}
