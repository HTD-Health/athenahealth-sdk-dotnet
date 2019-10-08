using System.IO;
using System.Net;
using AthenaHealth.Sdk.Http;

namespace AthenaHealth.Sdk.Tests.Integration.TestingHelpers
{
    public static class ConnectionFactory
    {
        public static Connection Create(string responseContent, HttpStatusCode responseStatus = HttpStatusCode.OK)
        {
            var messageHandler = new MockHttpMessageHandler(responseContent, responseStatus);
            var athenaHttpClient = new AthenaHttpClient(messageHandler);
            var athenaHttpAdapter = new AthenaHttpAdapter(athenaHttpClient);
            var connection = new Connection(athenaHttpAdapter, new Credentials("", ""), ApiVersion.Preview);
            return connection;
        }

        public static Connection CreateFromFile(string responsePath, HttpStatusCode responseStatus = HttpStatusCode.OK)
        {
            if(!File.Exists(responsePath))
                throw new FileNotFoundException($"Couldn't load test data file {responsePath}. Ensure file has Copy output enabled.");

            var content = File.ReadAllText(responsePath);
            return Create(content, responseStatus);
        }
    }
}
