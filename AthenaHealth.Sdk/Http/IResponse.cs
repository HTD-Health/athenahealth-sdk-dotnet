using System.Collections.Generic;
using System.Net;

namespace AthenaHealth.Sdk.Http
{
    public interface IResponse
    {
        /// <summary>
        /// Raw response body. Typically a string, but when requesting images, it will be a byte array.
        /// </summary>
        object Body { get; }

        /// <summary>
        /// Information about the API.
        /// </summary>
        IReadOnlyDictionary<string, string> Headers { get; }

        /// <summary>
        /// The response status code.
        /// </summary>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The content type of the response.
        /// </summary>
        string ContentType { get; }

        bool IsSuccessStatusCode { get; }
    }
}