using System.Net.Http;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http.Adapter
{
    public class AthenaHttpAdapter : IAthenaHttpAdapter
    {
        private readonly IAthenaHttpClient _athenaHttpClient;

        public AthenaHttpAdapter(IAthenaHttpClient athenaHttpClient)
        {
            _athenaHttpClient = athenaHttpClient;
        }

        public async Task<Response> Send(Request request)
        {
            using (HttpRequestMessage httpRequest = RequestFactory.Create(request))
            {
                var httpResponse = await _athenaHttpClient.SendAsync(httpRequest);

                return await ResponseFactory.Create(httpResponse);
            }
        }
    }
}