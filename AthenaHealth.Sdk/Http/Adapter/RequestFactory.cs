using System;
using System.Net.Http;

namespace AthenaHealth.Sdk.Http.Adapter
{
    public static class RequestFactory
    {
        public static HttpRequestMessage Create(Request request)
        {
            HttpRequestMessage requestMessage = null;
            try
            {
                requestMessage = new HttpRequestMessage(request.Method, request.RequestUri);

                foreach (var header in request.Headers)
                {
                    requestMessage.Headers.Add(header.Key, header.Value);
                }

                requestMessage.Content = request.Content;
            }
            catch (Exception)
            {
                requestMessage?.Dispose();
                throw;
            }

            return requestMessage;
        }
        
    }
}