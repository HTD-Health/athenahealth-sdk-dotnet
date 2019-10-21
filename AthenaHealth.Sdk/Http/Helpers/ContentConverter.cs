using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using AthenaHealth.Sdk.Models.Converters;

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

                    string stringValue = ObjectToDelimitedStringConverter.Convert(value);

                    if (stringValue == null)
                        continue;

                    JsonConverterAttribute jsonConverterAttribute = item.GetCustomAttribute<JsonConverterAttribute>();

                    if (jsonConverterAttribute != null)
                    {
                        JsonConverter converter = (JsonConverter)Activator.CreateInstance(jsonConverterAttribute.ConverterType, jsonConverterAttribute.ConverterParameters);

                        stringValue = JsonConvert.SerializeObject(value, converter)
                            .Trim('"');
                    }

                    JsonPropertyAttribute jsonPropertyAttribute = item.GetCustomAttribute<JsonPropertyAttribute>();

                    string key = item.Name;
                    if (jsonPropertyAttribute != null)
                        key = jsonPropertyAttribute.PropertyName;

                    dictionary[key] = stringValue;
                }
            }

            return dictionary;
        }


    }
}
