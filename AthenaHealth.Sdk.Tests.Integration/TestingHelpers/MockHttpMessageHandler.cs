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

        public string Input { get; private set; }
        public int NumberOfCalls { get; private set; }

        public MockHttpMessageHandler(string responseContent, HttpStatusCode statusCode)
        {
            _responseContent = responseContent;
            _statusCode = statusCode;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            NumberOfCalls++;
            if (request.Content != null)
                Input = await request.Content.ReadAsStringAsync();

            var response = new HttpResponseMessage
            {
                StatusCode = _statusCode,
            };
            
            if (_responseContent != null)
                response.Content = new StringContent(_responseContent);
            return response;
        }
    }
}
