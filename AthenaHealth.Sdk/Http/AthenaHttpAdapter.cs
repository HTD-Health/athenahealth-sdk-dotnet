using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Http.Factories;

namespace AthenaHealth.Sdk.Http
{
    public class AthenaHttpAdapter : IAthenaHttpAdapter
    {
        private readonly IAthenaHttpClient _athenaHttpClient;

        public AthenaHttpAdapter(IAthenaHttpClient athenaHttpClient)
        {
            _athenaHttpClient = athenaHttpClient;
        }

        public async Task<IResponse> Send(IRequest request)
        {
            using (HttpRequestMessage httpRequestMessage = HttpRequestMessageFactory.Create(request))
            {
                var httpResponseMessage = await _athenaHttpClient.SendAsync(httpRequestMessage);
                var response = await ResponseFactory.Create(httpResponseMessage);
                return response;
            }
        }
    }
}