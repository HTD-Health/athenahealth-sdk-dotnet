using System;
using System.Collections.Generic;

namespace AthenaHealth.Sdk.Http.Helpers
{
    public static class UrlBuilder
    {
        public static Uri BuildUrl(Uri baseUrl, Dictionary<string, string> queryParameters)
        {
            var uriBuilder = new UriBuilder(baseUrl);
            uriBuilder.Query = ConvertDictionaryToQueryString(queryParameters);
            return uriBuilder.Uri;


//
//            var uriBuilder = new UriBuilder(baseUrl);
//            uriBuilder.Path += relativeUrl; 
//            uriBuilder.Path += ConvertDictionaryToQueryString(queryParameters);
//            return uriBuilder.Uri;

        }


        public static string ConvertDictionaryToQueryString(Dictionary<string, string> dict)
        {
            var list = new List<string>();
            foreach(var item in dict)
            {
                list.Add(item.Key + "=" + item.Value);
            }
            return string.Join("&", list);
        }
    }
}
