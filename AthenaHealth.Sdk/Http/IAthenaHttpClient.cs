using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public interface IAthenaHttpClient
    {
        Uri BaseAddress { get; set; }

        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
    }
}
