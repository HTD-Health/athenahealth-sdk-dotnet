using System.Net.Http;
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
            using (HttpRequestMessage httpRequest = HttpRequestMessageFactory.Create(request))
            {
                var httpResponse = await _athenaHttpClient.SendAsync(httpRequest);
                var response = await ResponseFactory.Create(httpResponse);
                return response;
            }
        }
    }
}