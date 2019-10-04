using AthenaHealth.Sdk.Http.Helpers;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public class Connection : IConnection
    {
        private readonly IAthenaHttpClient _httpClient;

        public Connection(IAthenaHttpClient httpClient, Credentials credentials, string baseAddress)
        {
            _httpClient = httpClient;

            BaseAddress = new Uri(baseAddress);
            Credentials = credentials;
        }

        public Uri BaseAddress { get; }
        public Credentials Credentials { get; }

        public async Task<HttpResponseMessage> GetAsync(string relativeUrl, object queryParameters = null)
        {
            return await _httpClient.GetAsync(BuildUrl(relativeUrl, queryParameters));
        }

        public async Task<HttpResponseMessage> PostAsync(string relativeUrl, object body, object queryParameters = null)
        {
            return await _httpClient.PostAsync(BuildUrl(relativeUrl, queryParameters), CreateJsonContent(body));
        }

        public async Task<HttpResponseMessage> PutAsync(string relativeUrl, object body, object queryParameters = null)
        {
            return await _httpClient.PutAsync(BuildUrl(relativeUrl, queryParameters), CreateJsonContent(body));
        }

        public async Task<HttpResponseMessage> DeleteAsync(string relativeUrl, object queryParameters = null)
        {
            return await _httpClient.DeleteAsync(BuildUrl(relativeUrl, queryParameters));
        }

        private string BuildUrl(string relativeUrl, object queryParameters)
        {
            return UrlHelper.BuildUrl(new Uri(BaseAddress, relativeUrl), queryParameters);
        }

        private HttpContent CreateJsonContent(object body)
        {
            if (body == null)
                return null;

            if (body is string)
                return new StringContent(body as string, Encoding.UTF8, "application/json");

            return new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
        }
    }
}