using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;

namespace AthenaHealth.Sdk.Http
{
    internal class Response : IResponse
    {
        public Response() : this(new Dictionary<string, string>())
        {
        }

        public Response(IDictionary<string, string> headers)
        {
            Headers = new ReadOnlyDictionary<string, string>(headers);
        }

        public Response(HttpStatusCode statusCode, object body, IDictionary<string, string> headers, string contentType, bool isSuccessStatusCode)
        {

            StatusCode = statusCode;
            Body = body;
            Headers = new ReadOnlyDictionary<string, string>(headers);
            ContentType = contentType;
            IsSuccessStatusCode = isSuccessStatusCode;
        }

        /// <summary>
        /// Raw response body. Typically a string, but when requesting images, it will be a byte array.
        /// </summary>
        public object Body { get; private set; }

        /// <summary>
        /// Information about the API.
        /// </summary>
        public IReadOnlyDictionary<string, string> Headers { get; private set; }

        /// <summary>
        /// The response status code.
        /// </summary>
        public HttpStatusCode StatusCode { get; private set; }

        /// <summary>
        /// The content type of the response.
        /// </summary>
        public string ContentType { get; private set; }

        public bool IsSuccessStatusCode { get; private set; }
    }
}
