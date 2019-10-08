using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Http.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public class Connection : IConnection
    {
        /// <summary>
        /// Http client
        /// </summary>
        private readonly IHttpClientExtended _httpClient;

        /// <summary>
        /// Authorization token expiration date.
        /// </summary>
        private DateTime? _authorizationTokenExpirationDate;

        /// <summary>
        /// Base url adress
        /// </summary>
        public Uri BaseAddress { get; }

        /// <summary>
        /// Current API version
        /// </summary>
        public ApiVersion Version { get; }

        /// <summary>
        /// Connection credentials
        /// </summary>
        public Credentials Credentials { get; }

        public Connection(IHttpClientExtended httpClient, Credentials credentials, ApiVersion version)
        {
            _httpClient = httpClient;

            BaseAddress = new Uri("https://api.athenahealth.com/");
            Credentials = credentials;
            Version = version;
        }

        /// <summary>
        /// Sends GET request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Server response.</returns>
        public async Task<HttpResponseMessage> GetAsync(string relativeUrl, object queryParameters = null)
        {
            await AuthorizeIfRequired();

            HttpResponseMessage response = await _httpClient.GetAsync(BuildUrl(AddVersion(relativeUrl), queryParameters));
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
            await AuthorizeIfRequired();

            HttpResponseMessage response = await _httpClient.GetAsync(BuildUrl(AddVersion(relativeUrl), queryParameters));
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
            await AuthorizeIfRequired();

            HttpResponseMessage response = await _httpClient.PostAsync(BuildUrl(AddVersion(relativeUrl), queryParameters), CreateJsonContent(body));
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
            await AuthorizeIfRequired();

            HttpResponseMessage response = await _httpClient.PostAsync(BuildUrl(AddVersion(relativeUrl), queryParameters), CreateJsonContent(body));
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
            await AuthorizeIfRequired();

            HttpResponseMessage response = await _httpClient.PutAsync(BuildUrl(AddVersion(relativeUrl), queryParameters), CreateJsonContent(body));
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
            await AuthorizeIfRequired();

            HttpResponseMessage response = await _httpClient.PutAsync(BuildUrl(AddVersion(relativeUrl), queryParameters), CreateJsonContent(body));
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
            await AuthorizeIfRequired();

            HttpResponseMessage response = await _httpClient.DeleteAsync(BuildUrl(AddVersion(relativeUrl), queryParameters));
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
            await AuthorizeIfRequired();

            HttpResponseMessage response = await _httpClient.DeleteAsync(BuildUrl(AddVersion(relativeUrl), queryParameters));
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
            await AuthorizeIfRequired();

            HttpResponseMessage response = await _httpClient.PatchAsync(BuildUrl(AddVersion(relativeUrl), queryParameters), CreateJsonContent(body));
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
            await AuthorizeIfRequired();

            HttpResponseMessage response = await _httpClient.PatchAsync(BuildUrl(AddVersion(relativeUrl), queryParameters), CreateJsonContent(body));
            await HandleErrors(response);
            return await GetObjectContent<T>(response);
        }

        /// <summary>
        /// Performs authorization if no authorizaton was performed befor or if token expired.
        /// </summary>
        /// <returns>Boolean value if is authorized</returns>
        private async Task AuthorizeIfRequired()
        {
            // No authorization is required
            if (_authorizationTokenExpirationDate.HasValue && DateTime.Now < _authorizationTokenExpirationDate.Value)
                return;

            await Authorize();
        }

        /// <summary>
        /// Performs authorization basing on provided credentials.
        /// </summary>
        /// <returns>Boolean value indicating success</returns>
        private async Task Authorize()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, BuildUrl(Version.OAuthPath, null));

            string authorizationToken = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Credentials.Login}:{Credentials.Password}"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", authorizationToken);

            request.Content = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                { "grant_type", "client_credentials" }
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);
            DateTime responseTime = DateTime.Now;

            if (response.IsSuccessStatusCode)
            {
                AuthorizationResponse authorizationResponse = await GetObjectContent<AuthorizationResponse>(response);

                _authorizationTokenExpirationDate = responseTime.AddSeconds(authorizationResponse.ExpiresIn);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authorizationResponse.AccessToken);

                return;
            }

            throw new Exception("UNAUTHORIZED"); // TODO: Replace with appropriate exception
        }

        /// <summary>
        /// Builds relative url by prepending version name.
        /// </summary>
        /// <param name="relativeUrl"></param>
        /// <returns></returns>
        private string AddVersion(string relativeUrl)
        {
            return $"{Version.ApiPath}/{relativeUrl}";
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

            return content == null ? default : JsonConvert.DeserializeObject<T>(content);
        }

        /// <summary>
        /// Creates url from <see cref="BaseAddress"/>, <paramref name="relativeUrl"/> and <paramref name="queryParameters"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Constructed url.</returns>
        private string BuildUrl(string relativeUrl, object queryParameters)
        {
            return UrlHelper.BuildUrl(new Uri(BaseAddress, relativeUrl), queryParameters, -1);
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

        public class AuthorizationResponse
        {
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }

            [JsonProperty("token_type")]
            public string TokenType { get; set; }

            [JsonProperty("expires_in")]
            public int ExpiresIn { get; set; }

            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }
        }
    }
}
