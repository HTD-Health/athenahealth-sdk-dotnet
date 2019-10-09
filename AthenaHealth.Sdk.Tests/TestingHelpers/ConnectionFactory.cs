using System.Net;
using AthenaHealth.Sdk.Http;

namespace AthenaHealth.Sdk.Tests.TestingHelpers
{
    public static class ConnectionFactory
    {
        public static Connection Create(string responseContent, HttpStatusCode responseStatus = HttpStatusCode.OK)
        {
            var messageHandler = new MockHttpMessageHandler(responseContent, responseStatus);
            var athenaHttpClient = new AthenaHttpClient(messageHandler);
            var athenaHttpAdapter = new AthenaHttpAdapter(athenaHttpClient);
            var connection = new Connection(athenaHttpAdapter, new Credentials("", ""), "http://htdevelopers.com");
            return connection;
        }
    }
}
