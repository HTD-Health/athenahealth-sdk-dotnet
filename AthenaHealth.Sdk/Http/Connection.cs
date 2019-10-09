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

        public async Task<T> Get<T>(string relativeUrl, object queryParameters = null)
        {
            IResponse response = await SendData(relativeUrl, queryParameters, HttpMethod.Get);
            return GetObjectContent<T>(response);
        }

        public async Task<T> Post<T>(string relativeUrl, object body, object queryParameters = null)
        {
            IResponse response = await SendData(relativeUrl, queryParameters, HttpMethod.Post, body);
            return GetObjectContent<T>(response);
        }

        public async Task<T> Put<T>(string relativeUrl, object body, object queryParameters = null)
        {
            IResponse response = await SendData(relativeUrl, queryParameters, HttpMethod.Put, body);
            return GetObjectContent<T>(response);
        }

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
                Parameters = QueryParametersBuilder.Build(queryParameters)
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

        private T GetObjectContent<T>(IResponse response)
        {
            return response.Body == null ? default(T) : JsonConvert.DeserializeObject<T>(response.Body.ToString());
        }
    }
}
