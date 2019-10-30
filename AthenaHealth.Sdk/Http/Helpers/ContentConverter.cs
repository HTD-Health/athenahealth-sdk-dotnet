using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;
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
        /// Name of the property becomes a dictionary key. Value of the property becomes dictionary value. 
        /// </summary>
        /// <param name="obj">Object to be converted</param>
        /// <returns>Converted object as dictionary</returns>
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

                    string stringValue = ObjectToStringOrDelimitedStringConverter.Convert(value);

                    if (stringValue == null)
                        continue;

                    JsonConverterAttribute jsonConverterAttribute = item.GetAttribute<JsonConverterAttribute>();

                    if (jsonConverterAttribute != null)
                    {
                        JsonConverter converter = (JsonConverter)Activator.CreateInstance(jsonConverterAttribute.ConverterType, jsonConverterAttribute.ConverterParameters);

                        stringValue = JsonConvert.SerializeObject(value, converter)
                            .Trim('"');
                    }

                    JsonPropertyAttribute jsonPropertyAttribute = item.GetAttribute<JsonPropertyAttribute>();

                    string key = item.Name;
                    if (jsonPropertyAttribute != null)
                        key = jsonPropertyAttribute.PropertyName;

                    dictionary[key] = stringValue;
                }
            }

            return dictionary;
        }

        /// <summary>
        /// Gets custom attribute directly from property or from implemented interface property attribute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property"></param>
        /// <returns></returns>
        private static T GetAttribute<T>(this PropertyInfo property) where T : Attribute
        {
            T attribute = property.GetCustomAttribute<T>(true);

            if (attribute != null)
                return attribute;

            property = property.DeclaringType.GetInterfaces()
                 .Select(x => x.GetProperty(property.Name))
                 .FirstOrDefault();

            if (property == null)
                return null;

            return property.GetCustomAttribute<T>(true);
        }
    }
}
