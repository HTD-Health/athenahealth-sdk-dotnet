using System.Net;
using AthenaHealth.Sdk.Http;

namespace AthenaHealth.Sdk.Tests.Helpers
{
    public static class ConnectionFactory
    {
        public static Connection Create(string responseContent, HttpStatusCode responseStatus = HttpStatusCode.OK)
        {
            var messageHandler = new MockHttpMessageHandler(responseContent, responseStatus);
            var athenaHttpClient = new HttpClientExtended(messageHandler);
            var connection = new Connection(athenaHttpClient, new Credentials("", ""), ApiVersion.Preview);
            return connection;
        }
    }
}
