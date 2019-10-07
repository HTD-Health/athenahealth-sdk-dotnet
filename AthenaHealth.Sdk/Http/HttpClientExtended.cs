using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public class HttpClientExtended : HttpClient, IHttpClientExtended
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientExtended"/> class.
        /// </summary>
        public HttpClientExtended() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientExtended"/> class with a specific handler.
        /// </summary>
        /// <param name="handler">The HTTP handler stack to use for sending requests.</param>
        public HttpClientExtended(HttpMessageHandler handler) : base(handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientExtended"/> class with a specific handler.
        /// </summary>
        /// <param name="handler">
        /// The <see cref="HttpMessageHandler"/> responsible for processing the HTTP response messages.
        /// </param>
        /// <param name="disposeHandler">
        /// true if the inner handler should be disposed of by <see cref="Dispose()"/>, false if you
        /// intend to reuse the inner handler.
        /// </param>
        public HttpClientExtended(HttpMessageHandler handler, bool disposeHandler) : base(handler, disposeHandler)
        {
        }

        /// <summary>
        /// Send a PATCH request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        /// <exception cref="HttpRequestException">
        /// The request failed due to an underlying issue such as network connectivity, DNS failure,
        /// server certificate validation or timeout.
        /// </exception>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<HttpResponseMessage> PatchAsync(Uri requestUri, HttpContent content)
        {
            return SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), requestUri) { Content = content });
        }

        /// <summary>
        /// Send a PATCH request with a cancellation token as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <exception cref="ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        /// <exception cref="HttpRequestException">
        /// The request failed due to an underlying issue such as network connectivity, DNS failure,
        /// server certificate validation or timeout.
        /// </exception>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<HttpResponseMessage> PatchAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), requestUri) { Content = content }, cancellationToken);
        }

        /// <summary>
        /// Send a PATCH request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        /// <exception cref="HttpRequestException">
        /// The request failed due to an underlying issue such as network connectivity, DNS failure,
        /// server certificate validation or timeout.
        /// </exception>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content)
        {
            return SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), requestUri) { Content = content });
        }

        /// <summary>
        /// Send a PATCH request with a cancellation token as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <param name="cancellationToken">
        /// A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <exception cref="ArgumentNullException">The <paramref name="requestUri"/> was null.</exception>
        /// <exception cref="HttpRequestException">
        /// The request failed due to an underlying issue such as network connectivity, DNS failure,
        /// server certificate validation or timeout.
        /// </exception>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), requestUri) { Content = content }, cancellationToken);
        }
    }
}
