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
        /// If JsonConvert attribute is set up, converter is used.
        /// If value is an array, it is converted to delimited string
        /// If value is neither an array nor simple type, it is serialized to JSON
        /// </summary>
        /// <param name="obj">Object to be converted</param>
        /// <returns>Converted object as dictionary</returns>
        public static IDictionary<string, string> ConvertObjectToDictionary(object obj)
        {
            IDictionary<string, string> dictionary = new Dictionary<string, string>();

            if (obj == null) 
                return dictionary;

            foreach (var item in obj.GetType().GetProperties())
            {
                var key = GetKey(item);

                string value = GetValue(obj, item);

                if (value != null) 
                    dictionary[key] = value;
            }
            return dictionary;
        }

        

        /// <summary>
        /// Get value of an object in different cases
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        private static string GetValue(object obj, PropertyInfo item)
        {
            object value = item.GetValue(obj);
            if (value == null)
                return null;
            
            //if JsonConverter attribute is set up
            JsonConverterAttribute jsonConverterAttribute = item.GetAttribute<JsonConverterAttribute>();
            if (jsonConverterAttribute != null)
            {
                return GetValueWithJsonConverter(jsonConverterAttribute, value);
            }

            return ObjectToStringOrDelimitedStringConverter.Convert(value);
        }

        /// <summary>
        /// Gets value of an object using JsonConverter
        /// </summary>
        /// <param name="jsonConverterAttribute"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string GetValueWithJsonConverter(JsonConverterAttribute jsonConverterAttribute, object value)
        {
            JsonConverter converter = (JsonConverter)Activator.CreateInstance(jsonConverterAttribute.ConverterType,
                jsonConverterAttribute.ConverterParameters);

            string stringValue = JsonConvert.SerializeObject(value, converter)
                .Trim('"');

            return stringValue;
        }


        /// <summary>
        /// Get item's key for dictionary
        /// If item has JsonPropertyAttribute, name is get from the attribute
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private static string GetKey(PropertyInfo item)
        {
            JsonPropertyAttribute jsonPropertyAttribute = item.GetAttribute<JsonPropertyAttribute>();

            string key = item.Name;
            if (jsonPropertyAttribute != null)
                key = jsonPropertyAttribute.PropertyName;
            return key;
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
