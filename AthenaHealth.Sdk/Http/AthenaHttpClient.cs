using System.Net.Http;

namespace AthenaHealth.Sdk.Http
{
    /// <summary>
    /// Generic Http client. Useful if you want to swap out System.Net.HttpClient with something else.
    /// </summary>
    public class AthenaHttpClient : HttpClient, IAthenaHttpClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AthenaHttpClient"/> class.
        /// </summary>
        public AthenaHttpClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AthenaHttpClient"/> class with a specific handler.
        /// </summary>
        /// <param name="handler">The HTTP handler stack to use for sending requests.</param>
        public AthenaHttpClient(HttpMessageHandler handler) : base(handler)
        {
        }
    }
}
