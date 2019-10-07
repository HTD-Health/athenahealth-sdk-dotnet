using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public interface IConnection
    {
        /// <summary>
        /// Base url adress
        /// </summary>
        Uri BaseAddress { get; }

        /// <summary>
        /// Connection credentials
        /// </summary>
        Credentials Credentials { get; }

        /// <summary>
        /// Sends DELETE request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        Task<HttpResponseMessage> DeleteAsync(string relativeUrl, object queryParameters = null);

        /// <summary>
        /// Sends GET request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        Task<HttpResponseMessage> GetAsync(string relativeUrl, object queryParameters = null);

        /// <summary>
        /// Sends POST request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        Task<HttpResponseMessage> PostAsync(string relativeUrl, object body, object queryParameters = null);

        /// <summary>
        /// Sends PUT request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        Task<HttpResponseMessage> PutAsync(string relativeUrl, object body, object queryParameters = null);

        /// <summary>
        /// Sends PATCH request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        Task<HttpResponseMessage> PatchAsync(string relativeUrl, object body, object queryParameters = null);
    }
}
