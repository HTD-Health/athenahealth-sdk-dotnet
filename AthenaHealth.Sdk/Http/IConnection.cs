using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http
{
    public interface IConnection
    {
        Uri BaseAddress { get; }
        Credentials Credentials { get; }
        Task<HttpResponseMessage> GetAsync(string relativeUrl, object queryParameters = null);
        Task<HttpResponseMessage> PostAsync(string relativeUrl, object body, object queryParameters = null);
        Task<HttpResponseMessage> PutAsync(string relativeUrl, object body, object queryParameters = null);
        Task<HttpResponseMessage> DeleteAsync(string relativeUrl, object queryParameters = null);
    }
}