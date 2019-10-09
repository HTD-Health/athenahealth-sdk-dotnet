using AthenaHealth.Sdk.Http.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;

namespace AthenaHealth.Sdk.Http
{
    public class Connection : IConnection
    {
        private readonly IAthenaHttpAdapter _httpAdapter;

        /// <summary>
        /// Base url address
        /// </summary>
        public Uri BaseAddress { get; }

        /// <summary>
        /// Connection credentials
        /// </summary>
        public Credentials Credentials { get; }

        public Connection(IAthenaHttpAdapter httpAdapter, Credentials credentials, string baseAddress)
        {
            _httpAdapter = httpAdapter;

            BaseAddress = new Uri(baseAddress);
            Credentials = credentials;
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
            IResponse response = await SendData(relativeUrl, queryParameters, HttpMethod.Get);
            return GetObjectContent<T>(response);
        }

        /// <summary>
        /// Sends POST request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        public async Task<T> Post<T>(string relativeUrl, object body, object queryParameters = null)
        {
            IResponse response = await SendData(relativeUrl, queryParameters, HttpMethod.Post, body);
            return GetObjectContent<T>(response);
        }


        /// <summary>
        /// Sends PUT request to url constructed from <see cref="BaseAddress"/> and <paramref name="relativeUrl"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="relativeUrl">Url relative to <see cref="BaseAddress"/>.</param>
        /// <param name="body">Request content</param>
        /// <param name="queryParameters">Query parameters to be added to constructed url.</param>
        /// <returns>Deserialized model</returns>
        public async Task<T> Put<T>(string relativeUrl, object body, object queryParameters = null)
        {
            IResponse response = await SendData(relativeUrl, queryParameters, HttpMethod.Put, body);
            return GetObjectContent<T>(response);
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
            IResponse response = await SendData(relativeUrl, queryParameters, HttpMethod.Delete);
            return GetObjectContent<T>(response);
        }

        private Task<IResponse> SendData(string relativeUrl, object queryParameters, HttpMethod method, object body = null)
        {
            var request = new Request
            {
                Method = method,
                BaseAddress = BaseAddress,
                Endpoint = new Uri(BaseAddress, relativeUrl),
                ContentType = "application/json",
                Parameters = ConvertObjectToQueryParameters(queryParameters)
            };
            return SendDataInternal(body, request);
        }

        private async Task<IResponse> SendDataInternal(object body, Request request)
        {
            //await _authenticator.Apply(request); //TODO Add authentication headers here 

            IResponse response = await _httpAdapter.Send(request);

            HandleErrors(response);

            return response;
        }

        private void HandleErrors(IResponse response)
        {
            if (response.IsSuccessStatusCode)
                return;

            if (IsValidationStatusCode(response.StatusCode))
            {
                throw new ApiValidationException(response.Body.ToString(), response.StatusCode, response);
            }
            throw new ApiException(response.Body.ToString(), response.StatusCode, response);
        }

        private bool IsValidationStatusCode(HttpStatusCode statusCode)
        {
            int statusCodeInt = (int)statusCode;
            return statusCodeInt >= 400 && statusCodeInt <= 409;
        }

        /// <summary>
        /// Deserializes response content to object of specified type.
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="httpResponseMessage">Http response</param>
        /// <returns>Object of specified type</returns>
        private T GetObjectContent<T>(IResponse response)
        {
            return response.Body == null ? default(T) : JsonConvert.DeserializeObject<T>(response.Body.ToString());
        }

        private Dictionary<string, string> ConvertObjectToQueryParameters(object obj)
        {
            var dict = new Dictionary<string, string>();
            if (obj == null)
                return dict;

            foreach (var item in obj.GetType().GetProperties())
            {
                object value = item.GetValue(obj);

                if (value == null)
                    continue;

                JsonPropertyAttribute jsonPropertyAttribute = item.GetCustomAttribute<JsonPropertyAttribute>();

                string key = item.Name;
                if (jsonPropertyAttribute != null)
                    key = jsonPropertyAttribute.PropertyName;

                dict.Add(key, value.ToString());
            }

            return dict;
        }
    }
}
