using AthenaHealth.Sdk.Http.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;

namespace AthenaHealth.Sdk.Http
{
   internal static class ContentConverter
    {
        public static HttpContent ToJson(object obj)
        {
            if (obj == null)
                return null;

            if (obj is string)
                return new StringContent(obj as string, Encoding.UTF8, "application/json");

            return new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
        }

        public static HttpContent ToUrlEncoded(object obj)
        {
            return new FormUrlEncodedContent(ConvertObjectToDictionary(obj));
        }

        /// <summary>
        /// Performs conversion from object to dictionary.
        /// </summary>
        /// <param name="obj">Object to be converted</param>
        /// <returns>Converted object.</returns>
        public static IDictionary<string, string> ConvertObjectToDictionary(object obj)
        {
            IDictionary<string, string> dictionary = new Dictionary<string, string>();

            if (obj != null)
            {
                foreach (var item in obj.GetType().GetProperties())
                {
                    object value = item.GetValue(obj);

                    if (value == null)
                        continue;

                    JsonPropertyAttribute jsonPropertyAttribute = item.GetCustomAttribute<JsonPropertyAttribute>();

                    string key = item.Name;
                    if (jsonPropertyAttribute != null)
                        key = jsonPropertyAttribute.PropertyName;

                    dictionary[key] = value.ToString();
                }
            }

            return dictionary;
        }

    }
}
