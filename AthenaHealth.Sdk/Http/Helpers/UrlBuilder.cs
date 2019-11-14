using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;

namespace AthenaHealth.Sdk.Http.Helpers
{
    public static class UrlBuilder
    {
        /// <summary>
        /// Adds query parameters to specified url.
        /// </summary>
        /// <param name="url">Base url.</param>
        /// <param name="queryParameters">
        /// Query parameter object. Parameter names are resolved basing on property name or <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <param name="port">If not specified it will not be included in url.</param>
        /// <returns>Concatenated uri.</returns>
        public static Uri BuildUri(string url, object queryParameters, int port)
        {
            return new Uri(BuildUrl(url, queryParameters, port));
        }

        /// <summary>
        /// Adds query parameters to specified url.
        /// </summary>
        /// <param name="url">Base url.</param>
        /// <param name="queryParameters">
        /// Query parameter object. Parameter names are resolved basing on property name or <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <returns>Concatenated uri.</returns>
        public static Uri BuildUri(string url, object queryParameters)
        {
            return new Uri(BuildUrl(url, queryParameters));
        }

        /// <summary>
        /// Adds query parameters to specified uri.
        /// </summary>
        /// <param name="uri">Base uri.</param>
        /// <param name="queryParameters">
        /// Query parameter object. Parameter names are resolved basing on property name or <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <param name="port">If not specified it will not be included in url.</param>
        /// <returns>Concatenated uri.</returns>
        public static Uri BuildUri(Uri uri, object queryParameters, int port)
        {
            return new Uri(BuildUrl(uri, queryParameters, port));
        }

        /// <summary>
        /// Adds query parameters to specified uri.
        /// </summary>
        /// <param name="uri">Base uri.</param>
        /// <param name="queryParameters">
        /// Query parameter object. Parameter names are resolved basing on property name or <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <returns>Concatenated uri.</returns>
        public static Uri BuildUri(Uri uri, object queryParameters)
        {
            return new Uri(BuildUrl(uri, queryParameters));
        }

        /// <summary>
        /// Adds query parameters to specified url.
        /// </summary>
        /// <param name="url">Base url.</param>
        /// <param name="queryParameters">Query parameters dictionary</param>
        /// <param name="port">If not specified it will not be included in url.</param>
        /// <returns>Concatenated uri.</returns>
        public static Uri BuildUri(string url, IDictionary<string, string> queryParameters, int port)
        {
            return new Uri(BuildUrl(url, queryParameters, port));
        }

        /// <summary>
        /// Adds query parameters to specified url.
        /// </summary>
        /// <param name="url">Base url.</param>
        /// <param name="queryParameters">Query parameters dictionary</param>
        /// <returns>Concatenated uri.</returns>
        public static Uri BuildUri(string url, IDictionary<string, string> queryParameters)
        {
            return new Uri(BuildUrl(url, queryParameters));
        }

        /// <summary>
        /// Adds query parameters to specified uri.
        /// </summary>
        /// <param name="uri">Base uri.</param>
        /// <param name="queryParameters">Query parameters dictionary</param>
        /// <param name="port">If not specified it will not be included in url.</param>
        /// <returns>Concatenated uri.</returns>
        public static Uri BuildUri(Uri uri, IDictionary<string, string> queryParameters, int port)
        {
            return new Uri(BuildUrl(uri, queryParameters, port));
        }

        /// <summary>
        /// Adds query parameters to specified uri.
        /// </summary>
        /// <param name="uri">Base uri.</param>
        /// <param name="queryParameters">Query parameters dictionary</param>
        /// <returns>Concatenated uri.</returns>
        public static Uri BuildUri(Uri uri, IDictionary<string, string> queryParameters)
        {
            return new Uri(BuildUrl(uri, queryParameters));
        }

        /// <summary>
        /// Adds query parameters to specified url.
        /// </summary>
        /// <param name="url">Base url.</param>
        /// <param name="queryParameters">
        /// Query parameter object. Parameter names are resolved basing on property name or <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <param name="port">If not specified it will not be included in url.</param>
        /// <returns>Concatenated url.</returns>
        public static string BuildUrl(string url, object queryParameters, int port)
        {
            return BuildUrl(new Uri(url), queryParameters, port);
        }

        /// <summary>
        /// Adds query parameters to specified url.
        /// </summary>
        /// <param name="url">Base url.</param>
        /// <param name="queryParameters">
        /// Query parameter object. Parameter names are resolved basing on property name or <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <returns>Concatenated url.</returns>
        public static string BuildUrl(string url, object queryParameters)
        {
            return BuildUrl(new Uri(url), queryParameters);
        }

        /// <summary>
        /// Adds query parameters to specified uri.
        /// </summary>
        /// <param name="uri">Base uri.</param>
        /// <param name="queryParameters">
        /// Query parameter object. Parameter names are resolved basing on property name or <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <param name="port">If not specified it will not be included in url.</param>
        /// <returns>Concatenated url.</returns>
        public static string BuildUrl(Uri uri, object queryParameters, int port)
        {
            return BuildUrl(uri, ContentConverter.ConvertObjectToDictionary(queryParameters), port);
        }

        /// <summary>
        /// Adds query parameters to specified uri.
        /// </summary>
        /// <param name="uri">Base uri.</param>
        /// <param name="queryParameters">
        /// Query parameter object. Parameter names are resolved basing on property name or <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <returns>Concatenated url.</returns>
        public static string BuildUrl(Uri uri, object queryParameters)
        {
            return BuildUrl(uri, ContentConverter.ConvertObjectToDictionary(queryParameters));
        }

        /// <summary>
        /// Adds query parameters to specified url.
        /// </summary>
        /// <param name="url">Base url.</param>
        /// <param name="queryParameters">Query parameters dictionary</param>
        /// <param name="port">If not specified it will not be included in url.</param>
        /// <returns>Concatenated url.</returns>
        public static string BuildUrl(string url, IDictionary<string, string> queryParameters, int port)
        {
            return BuildUrl(new Uri(url), queryParameters, port);
        }

        /// <summary>
        /// Adds query parameters to specified url.
        /// </summary>
        /// <param name="url">Base url.</param>
        /// <param name="queryParameters">Query parameters dictionary</param>
        /// <returns>Concatenated url.</returns>
        public static string BuildUrl(string url, IDictionary<string, string> queryParameters)
        {
            return BuildUrl(new Uri(url), queryParameters);
        }

        /// <summary>
        /// Adds query parameters to specified uri.
        /// </summary>
        /// <param name="uri">Base uri.</param>
        /// <param name="queryParameters">Query parameters dictionary</param>
        /// <param name="port">If not specified it will not be included in url.</param>
        /// <returns>Concatenated url.</returns>
        public static string BuildUrl(Uri uri, IDictionary<string, string> queryParameters, int port)
        {
            var uriBuilder = new UriBuilder(uri)
            {
                Port = port
            };

            uriBuilder.Query = BuildQueryParameters(uriBuilder.Query, queryParameters);

            return uriBuilder.ToString();
        }

        /// <summary>
        /// Adds query parameters to specified uri.
        /// </summary>
        /// <param name="uri">Base uri.</param>
        /// <param name="queryParameters">Query parameters dictionary</param>
        /// <returns>Concatenated url.</returns>
        public static string BuildUrl(Uri uri, IDictionary<string, string> queryParameters)
        {
            var uriBuilder = new UriBuilder(uri);

            uriBuilder.Query = BuildQueryParameters(uriBuilder.Query, queryParameters);

            return uriBuilder.ToString();
        }

        private static string BuildQueryParameters(string initialQuery, IDictionary<string, string> queryParameters)
        {
            NameValueCollection parametersCollection = HttpUtility.ParseQueryString(initialQuery);

            if (queryParameters != null)
            {
                foreach (var item in queryParameters)
                {
                    parametersCollection[item.Key] = item.Value;
                }
            }

            return parametersCollection.ToString();
        }
    }
}
