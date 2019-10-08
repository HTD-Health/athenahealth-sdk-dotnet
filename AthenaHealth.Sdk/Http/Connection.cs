using AthenaHealth.Sdk.Http.Helpers;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using Newtonsoft.Json.Linq;

namespace AthenaHealth.Sdk.Http
{
    public class Connection : IConnection
    {
        private readonly IHttpClientExtended _httpClient;

        /// <summary>
        /// Base url address
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
            HttpResponseMessage response = await _httpClient.GetAsync(BuildUrl(relativeUrl, queryParameters));
            await HandleErrors(response);
            return response;
        }

        /// <summary>
        /// Sends GET request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        public async Task<T> GetAsync<T>(string relativeUrl, object queryParameters = null)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(BuildUrl(relativeUrl, queryParameters));
            await HandleErrors(response);
            return await GetObjectContent<T>(response);
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
            HttpResponseMessage response = await _httpClient.PostAsync(BuildUrl(relativeUrl, queryParameters), CreateJsonContent(body));
            await HandleErrors(response);
            return response;
        }

        /// <summary>
        /// Sends POST request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        public async Task<T> PostAsync<T>(string relativeUrl, object body, object queryParameters = null)
        {
            HttpResponseMessage response = await _httpClient.PostAsync(BuildUrl(relativeUrl, queryParameters), CreateJsonContent(body));
            await HandleErrors(response);
            return await GetObjectContent<T>(response);
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
            HttpResponseMessage response = await _httpClient.PutAsync(BuildUrl(relativeUrl, queryParameters), CreateJsonContent(body));
            await HandleErrors(response);
            return response;
        }

        /// <summary>
        /// Sends PUT request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        public async Task<T> PutAsync<T>(string relativeUrl, object body, object queryParameters = null)
        {
            HttpResponseMessage response = await _httpClient.PutAsync(BuildUrl(relativeUrl, queryParameters), CreateJsonContent(body));
            await HandleErrors(response);
            return await GetObjectContent<T>(response);
        }

        /// <summary>
        /// Sends DELETE request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        public async Task<HttpResponseMessage> DeleteAsync(string relativeUrl, object queryParameters = null)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync(BuildUrl(relativeUrl, queryParameters));
            await HandleErrors(response);
            return response;
        }

        /// <summary>
        /// Sends DELETE request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        public async Task<T> DeleteAsync<T>(string relativeUrl, object queryParameters = null)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync(BuildUrl(relativeUrl, queryParameters));
            await HandleErrors(response);
            return await GetObjectContent<T>(response);
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
            HttpResponseMessage response = await _httpClient.PatchAsync(BuildUrl(relativeUrl, queryParameters), CreateJsonContent(body));
            await HandleErrors(response);
            return response;
        }

        /// <summary>
        /// Sends PATCH request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        public async Task<T> PatchAsync<T>(string relativeUrl, object body, object queryParameters = null)
        {
            HttpResponseMessage response = await _httpClient.PatchAsync(BuildUrl(relativeUrl, queryParameters), CreateJsonContent(body));
            await HandleErrors(response);
            return await GetObjectContent<T>(response);
        }

        /// <summary>
        /// Creates json content from provided object.
        /// </summary>
        /// <param name="body">Object to serialize.</param>
        /// <returns></returns>
        private HttpContent CreateJsonContent(object body)
        {
            if (body == null)
                return null;

            if (body is string)
                return new StringContent(body as string, Encoding.UTF8, "application/json");

            return new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
        }

        /// <summary>
        /// Deserializes response content to object of specified type.
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="httpResponseMessage">Http response</param>
        /// <returns>Object of specified type</returns>
        private async Task<T> GetObjectContent<T>(HttpResponseMessage httpResponseMessage)
        {
            string content = await GetContentFromHttpResponse(httpResponseMessage);

            return content == null ? default(T) : JsonConvert.DeserializeObject<T>(content);
        }

        /// <summary>
        /// Creates url from <see cref="BaseAddress"/>, <paramref name="relativeUrl"/> and <paramref name="queryParameters"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Constructed url.</returns>
        private string BuildUrl(string relativeUrl, object queryParameters)
        {
            return UrlHelper.BuildUrl(new Uri(BaseAddress, relativeUrl), queryParameters);
        }


        private async Task<string> GetContentFromHttpResponse(HttpResponseMessage response)
        {
            if (response.Content == null)
                return null;
            return await response.Content.ReadAsStringAsync();
        }

        private async Task HandleErrors(HttpResponseMessage response)
        {
            string content = await GetContentFromHttpResponse(response);

            if (response.IsSuccessStatusCode)
                return;
            
            if (IsValidationStatusCode(response.StatusCode))
            {
                throw new ApiValidationException(content, response.StatusCode, response);
            }
            throw new ApiException(content, response.StatusCode, response);
        }

        private bool IsValidationStatusCode(HttpStatusCode statusCode)
        {
            int statusCodeInt = (int)statusCode;
            return statusCodeInt >= 400 && statusCodeInt <= 409;
        }

        private void HandleErrorsInPositiveResponse(string content)
        {
            JObject json = JObject.Parse(content);


        }
    }
}
