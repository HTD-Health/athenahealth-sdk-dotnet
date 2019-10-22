using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

                    string stringValue = GetStringValue(value);

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

        private static string GetStringValue(object value)
        {
            // Here we convert most common value types
            if (value is string stringValue)
            {
                return stringValue;
            }
            else if (value is int intValue)
            {
                return intValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (value is double doubleValue)
            {
                return doubleValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (value is float floatValue)
            {
                return floatValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (value is decimal decimalValue)
            {
                return decimalValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (value is bool boolValue)
            {
                return boolValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (value is IEnumerable collection)
            {
                var list = collection
                    .Cast<object>()
                    .Where(x => x != null)
                    .Select(x => GetStringValue(x));

                if(list.Any())
                    return $"[{string.Join(",", list)}]";

                return null;
            }

            // Everything which does not suit rules above is converted that way
            return value.ToString();
        }
    }
}
