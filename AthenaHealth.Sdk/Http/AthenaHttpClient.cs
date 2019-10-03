using AthenaHealth.Sdk.Http;
using System.Net.Http;

namespace AthenaHealth.Sdk.Http
{
    public class AthenaHttpClient : HttpClient, IAthenaHttpClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AthenaHttpClient"/> class.
        /// </summary>
        public AthenaHttpClient() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AthenaHttpClient"/> class with a specific handler.
        /// </summary>
        /// <param name="handler">The HTTP handler stack to use for sending requests.</param>
        public AthenaHttpClient(HttpMessageHandler handler) : base(handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AthenaHttpClient"/> class with a specific handler.
        /// </summary>
        /// <param name="handler">
        /// The <see cref="HttpMessageHandler"/> responsible for processing the HTTP response messages.
        /// </param>
        /// <param name="disposeHandler">
        /// true if the inner handler should be disposed of by <see cref="Dispose()"/>, false if you
        /// intend to reuse the inner handler.
        /// </param>
        public AthenaHttpClient(HttpMessageHandler handler, bool disposeHandler) : base(handler, disposeHandler)
        {
        }
    }
}