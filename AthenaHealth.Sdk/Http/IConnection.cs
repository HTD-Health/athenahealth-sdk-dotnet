using System;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public interface IConnection
    {
        /// <summary>
        /// Base url address
        /// </summary>
        Uri BaseAddress { get; }

        /// <summary>
        /// Connection credentials
        /// </summary>
        Credentials Credentials { get; }

        int PracticeId { get; set; }

        /// <summary>
        /// Sends GET request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        Task<T> Get<T>(string relativeUrl, object queryParameters = null);

        /// <summary>
        /// Sends POST request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <param name="body">Request content</param>
        /// <returns>Deserialized model</returns>
        Task<T> Post<T>(string relativeUrl, object queryParameters = null, object body = null);

        /// <summary>
        /// Sends PUT request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <param name="body">Request content</param>
        Task Put(string relativeUrl, object queryParameters = null, object body = null);

        /// <summary>
        /// Sends DELETE request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        Task<T> Delete<T>(string relativeUrl, object queryParameters = null);
    }
}
