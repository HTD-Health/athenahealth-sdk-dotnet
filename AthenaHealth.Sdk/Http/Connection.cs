using AthenaHealth.Sdk.Http.Helpers;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public class Connection : IConnection
    {
        private readonly IHttpClientExtended _httpClient;

        /// <summary>
        /// Base url adress
        /// </summary>
        public Uri BaseAddress { get; }

        /// <summary>
        /// Connection credentials
        /// </summary>
        public Credentials Credentials { get; }

        public Connection(IHttpClientExtended httpClient, Credentials credentials, string baseAddress)
        {
            _httpClient = httpClient;

            BaseAddress = new Uri(baseAddress);
            Credentials = credentials;
        }

        /// <summary>
        /// Sends GET request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        public async Task<HttpResponseMessage> GetAsync(string relativeUrl, object queryParameters = null)
        {
            return await _httpClient.GetAsync(BuildUrl(relativeUrl, queryParameters));
        }

        /// <summary>
        /// Sends POST request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        public async Task<HttpResponseMessage> PostAsync(string relativeUrl, object body, object queryParameters = null)
        {
            return await _httpClient.PostAsync(BuildUrl(relativeUrl, queryParameters), HttpHelper.CreateJsonContent(body));
        }

        /// <summary>
        /// Sends PUT request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        public async Task<HttpResponseMessage> PutAsync(string relativeUrl, object body, object queryParameters = null)
        {
            return await _httpClient.PutAsync(BuildUrl(relativeUrl, queryParameters), HttpHelper.CreateJsonContent(body));
        }
        /// <summary>
        /// Sends DELETE request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        public async Task<HttpResponseMessage> DeleteAsync(string relativeUrl, object queryParameters = null)
        {
            return await _httpClient.DeleteAsync(BuildUrl(relativeUrl, queryParameters));
        }

        /// <summary>
        /// Sends PATCH request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        public async Task<HttpResponseMessage> PatchAsync(string relativeUrl, object body, object queryParameters = null)
        {
            return await _httpClient.PatchAsync(BuildUrl(relativeUrl, queryParameters), HttpHelper.CreateJsonContent(body));
        }

        /// <summary>
        /// Creates url from <see cref="BaseAddress"/>, <paramref name="relativeUrl"/> and <paramref name="queryParameters"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Constructed url.</returns>
        private string BuildUrl(string relativeUrl, object queryParameters)
        {
            return HttpHelper.BuildUrl(new Uri(BaseAddress, relativeUrl), queryParameters);
        }
    }
}
