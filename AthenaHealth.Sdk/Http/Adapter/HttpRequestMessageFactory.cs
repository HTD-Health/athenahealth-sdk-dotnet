using System;
using System.IO;
using System.Net.Http;
using System.Text;

namespace AthenaHealth.Sdk.Http.Adapter
{
    public static class HttpRequestMessageFactory
    {
        public static HttpRequestMessage Create(IRequest request)
        {
            HttpRequestMessage requestMessage = null;
            try
            {
                requestMessage = new HttpRequestMessage(request.Method, request.RequestUri);

                foreach (var header in request.Headers)
                {
                    requestMessage.Headers.Add(header.Key, header.Value);
                }

                if (request.Body is HttpContent httpContent)
                {
                    requestMessage.Content = httpContent;
                }

                if (request.Body is string body)
                {
                    requestMessage.Content = new StringContent(body, Encoding.UTF8, request.ContentType);
                }

                if (request.Body is Stream bodyStream)
                {
                    requestMessage.Content = new StreamContent(bodyStream);
                    requestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(request.ContentType);
                }
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