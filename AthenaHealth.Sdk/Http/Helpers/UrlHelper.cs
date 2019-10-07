using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AthenaHealth.Sdk.Http.Helpers
{
    internal static class UrlHelper
    {
       

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
        /// <param name="queryParameters">
        /// Query parameter object. Parameter names are resolved basing on property name or <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <returns>Concatenated url.</returns>
        public static string BuildUrl(Uri uri, object queryParameters)
        {
            var uriBuilder = new UriBuilder(uri);

            uriBuilder.Query = BuildQueryParameters(uriBuilder.Query, queryParameters);

            return uriBuilder.ToString();
        }

        /// <summary>
        /// Build query string from parameters.
        /// </summary>
        /// <param name="initialQuery">Initial query string.</param>
        /// <param name="queryParameters">
        /// Query parameter object. Parameter names are resolved basing on property name or <see cref="JsonPropertyAttribute"/>.
        /// </param>
        /// <returns></returns>
        private static string BuildQueryParameters(string initialQuery, object queryParameters)
        {
            NameValueCollection parametersCollection = HttpUtility.ParseQueryString(initialQuery);

            if (queryParameters != null)
            {
                foreach (var item in queryParameters.GetType().GetProperties())
                {
                    object value = item.GetValue(queryParameters);

                    if (value == null)
                        continue;

                    JsonPropertyAttribute jsonPropertyAttribute = item.GetCustomAttribute<JsonPropertyAttribute>();

                    string key = item.Name;
                    if (jsonPropertyAttribute != null)
                        key = jsonPropertyAttribute.PropertyName;

                    parametersCollection[key] = value.ToString();
                }
            }

            return parametersCollection.ToString();
        }
    }
}
