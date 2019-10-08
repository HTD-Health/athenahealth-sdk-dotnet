using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;

namespace AthenaHealth.Sdk.Http
{
    public class Response
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
        public object Body { get;  }

        /// <summary>
        /// Information about the API.
        /// </summary>
        public IReadOnlyDictionary<string, string> Headers { get;  }

        /// <summary>
        /// The response status code.
        /// </summary>
        public HttpStatusCode StatusCode { get;  }

        /// <summary>
        /// The content type of the response.
        /// </summary>
        public string ContentType { get;  }

        public bool IsSuccessStatusCode { get;  }

        public DateTime Time { get; } = DateTime.Now;

        /// <summary>
        /// Deserializes response content to object of specified type.
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="httpResponseMessage">Http response</param>
        /// <returns>Object of specified type</returns>
        public T GetObjectContent<T>()
        {
            return Body == null ? default : JsonConvert.DeserializeObject<T>(Body.ToString());
        }
    }
}
