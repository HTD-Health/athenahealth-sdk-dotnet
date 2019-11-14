using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Tests.Integration.TestingHelpers
{
    public class MockHttpMessageHandler : HttpMessageHandler
    {
        private readonly string _responseContent;

        private readonly HttpStatusCode _statusCode;

        public MockHttpMessageHandler(string responseContent, HttpStatusCode statusCode)
        {
            _responseContent = responseContent;
            _statusCode = statusCode;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage
            {
                StatusCode = _statusCode,
            };

            if (_responseContent != null)
                response.Content = new StringContent(_responseContent);

            if (request.RequestUri.AbsoluteUri.EndsWith("/token"))
            {
                response.Content = new StringContent("{\"access_token\":\"53nde65ep9dx5f2n4up39hj3\",\"token_type\":\"bearer\",\"expires_in\":3600,\"refresh_token\":\"np4crgmae29cnuvw6p3tgus2\"}");
                response.StatusCode = HttpStatusCode.OK;
            }

            return response;
        }
    }
}
