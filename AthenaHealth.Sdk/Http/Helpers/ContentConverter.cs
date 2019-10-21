using AthenaHealth.Sdk.Models.Converters.Base;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;

namespace AthenaHealth.Sdk.Http.Helpers
{
    public static class ContentConverter
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

                    JsonConverterAttribute jsonConverterAttribute = item.GetCustomAttribute<JsonConverterAttribute>();
                    
                    string stringValue = GetStringValue(value);

                    if (jsonConverterAttribute != null)
                    {
                        if (Activator.CreateInstance(jsonConverterAttribute.ConverterType) is Converter converter)
                            stringValue = converter.Convert(value).ToString();
                    }

                    dictionary[key] = stringValue;
                }
            }

            return dictionary;
        }

        private static string GetStringValue(object value)
        {
            if (value is Array array)
            {
                var list = array.Cast<object>().ToList();
                var joined = string.Join(",", list);
                return $"[{joined}]";
            }

            return value.ToString();
        }
    }
}
