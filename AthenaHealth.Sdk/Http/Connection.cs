using AthenaHealth.Sdk.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Http.Adapter;
using AthenaHealth.Sdk.Http.Helpers;
using System.Diagnostics;

namespace AthenaHealth.Sdk.Http
{
    public class Connection : IConnection
    {
        private readonly IAthenaHttpAdapter _httpAdapter;

        private readonly IDictionary<string, string> _defaultHeaders;

        private DateTime? _accessTokenExpirationDate;

        /// <summary>
        /// Base url address
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

        public int PracticeId { get; set; }

        /// <summary>
        /// Indicates if access token exists and is still valid.
        /// </summary>
        private bool IsAccessTokenValid => _accessTokenExpirationDate.HasValue && DateTime.Now < _accessTokenExpirationDate.Value;

        public Connection(IAthenaHttpAdapter httpAdapter, Credentials credentials, ApiVersion version)
        {
            _httpAdapter = httpAdapter;

            BaseAddress = new Uri("https://api.athenahealth.com/");
            Credentials = credentials;
            Version = version;

            _defaultHeaders = new Dictionary<string, string>();
        }

        /// <summary>
        /// Sends GET request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        public async Task<T> Get<T>(string relativeUrl, object queryParameters = null)
        {
            await RefreshAccessToken();

            Response response = await SendData(AddVersion(relativeUrl), queryParameters, HttpMethod.Get);

            T output = response.GetObjectContent<T>();
            return output;
        }

        /// <summary>
        /// Sends POST request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <param name="body">Request content</param>
        /// <returns>Deserialized model</returns>
        public async Task<T> Post<T>(string relativeUrl, object queryParameters = null, object body = null)
        {
            await RefreshAccessToken();

            Response response = await SendData(AddVersion(relativeUrl), queryParameters, HttpMethod.Post, ContentConverter.ToJson(body));

            return response.GetObjectContent<T>();
        }

        /// <summary>
        /// Sends PUT request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <param name="body">Request content</param>
        public async Task Put(string relativeUrl, object queryParameters = null, object body = null)
        {
            await RefreshAccessToken();

            Response response = await SendData(AddVersion(relativeUrl), queryParameters, HttpMethod.Put, ContentConverter.ToJson(body));
        }

        /// <summary>
        /// Sends DELETE request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        public async Task<T> Delete<T>(string relativeUrl, object queryParameters = null)
        {
            await RefreshAccessToken();

            Response response = await SendData(AddVersion(relativeUrl), queryParameters, HttpMethod.Delete);

            return response.GetObjectContent<T>();
        }

        /// <summary>
        /// Performs authorization based on provided credentials.
        /// </summary>
        /// <returns>Boolean value indicating success</returns>
        private async Task RefreshAccessToken()
        {
            // No authorization is required
            if (IsAccessTokenValid)
                return;

            string authorizationToken = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Credentials.ClientId}:{Credentials.ClientSecret}"));

            Response response = await SendData(
                Version.OAuthPath,
                null,
                HttpMethod.Post,
                ContentConverter.ToUrlEncoded(new { grant_type = "client_credentials" }),
                new { Authorization = $"Basic {authorizationToken}" });

            AuthorizationResponse authorizationResponse = response.GetObjectContent<AuthorizationResponse>();

            _accessTokenExpirationDate = response.Time.AddSeconds(authorizationResponse.ExpiresIn);
            _defaultHeaders["Authorization"] = $"Bearer {authorizationResponse.AccessToken}";
        }

        private async Task<Response> SendData(string relativeUrl, object queryParameters, HttpMethod method, HttpContent content = null, object headers = null)
        {
            IDictionary<string, string> requestHeaders = new Dictionary<string, string>(_defaultHeaders);

            foreach (var header in ContentConverter.ConvertObjectToDictionary(headers))
            {
                requestHeaders[header.Key] = header.Value;
            }

            var request = new Request
            {
                Method = method,
                Endpoint = new Uri(BaseAddress, relativeUrl),
                Content = content,
                Parameters = ContentConverter.ConvertObjectToDictionary(queryParameters),
                Headers = requestHeaders
            };

            Response response = await _httpAdapter.Send(request);

            Debug.WriteLine(response.Body.ToString());

            HandleErrors(response);

            return response;
        }

        private void HandleErrors(Response response)
        {
            if (response.IsSuccessStatusCode)
                return;

            if (IsValidationStatusCode(response.StatusCode))
                throw new ApiValidationException(response.Body.ToString(), response.StatusCode, response);

            throw new ApiException(response.Body.ToString(), response.StatusCode, response);
        }

        private bool IsValidationStatusCode(HttpStatusCode statusCode)
        {
            int statusCodeInt = (int)statusCode;
            return statusCodeInt >= 400 && statusCodeInt <= 409;
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
