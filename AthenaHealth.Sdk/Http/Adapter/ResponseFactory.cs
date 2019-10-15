using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Http.Adapter
{
    public static class ResponseFactory
    {
        private static readonly AthenaResponsePipeline ResponsePipeline = new AthenaResponsePipeline();
        public static async Task<Response> Create(HttpResponseMessage httpResponse)
        {
            

            object responseBody = null;
            string contentType = null;

            var binaryContentTypes = new[] {
                "application/zip" ,
                "application/x-gzip" ,
                "application/octet-stream"};

            using (var content = httpResponse.Content)
            {
                if (content != null)
                {
                    contentType = GetContentMediaType(httpResponse.Content);

                    if (contentType != null && (contentType.StartsWith("image/") || binaryContentTypes.Any(item => item.Equals(contentType, StringComparison.OrdinalIgnoreCase))))
                    {
                        responseBody = await httpResponse.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
                    }
                    else
                    {
                        responseBody = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    }
                }
            }

            var response = new Response(
                httpResponse.StatusCode,
                responseBody,
                httpResponse.Headers.ToDictionary(h => h.Key, h => h.Value.First()),
                contentType,
                httpResponse.IsSuccessStatusCode);

            ResponsePipeline.Execute(response);

            return response;
        }

        static string GetContentMediaType(HttpContent httpContent)
        {
            if (httpContent.Headers != null && httpContent.Headers.ContentType != null)
            {
                return httpContent.Headers.ContentType.MediaType;
            }
            return null;
        }
    }
}
