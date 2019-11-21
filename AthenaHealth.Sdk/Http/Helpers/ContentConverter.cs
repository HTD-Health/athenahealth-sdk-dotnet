using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;

namespace AthenaHealth.Sdk.Http.Helpers
{
    public static class ContentConverter
    {
        public static HttpContent ToUrlEncoded(object obj)
        {
            return new FormUrlEncodedContent(ConvertObjectToDictionary(obj));
        }

        public static HttpContent ToMultipart(object obj)
        {
            var content = new MultipartFormDataContent();

            foreach (var item in ConvertObjectToDictionary(obj))
            {
                content.Add(new StringContent(item.Value), $"\"{item.Key}\"");
            }

            foreach (var item in GetFilesDictionary(obj))
            {
                byte[] fileBytes = File.ReadAllBytes(item.Value.FullName);
                content.Add(new ByteArrayContent(fileBytes), $"\"{item.Key}\"", $"\"{item.Value.Name}\"");
            }

            return content;
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

            foreach (var item in JToken.FromObject(obj).Children<JProperty>())
            {
                // First child determine underlying type (other than JTokenType.Property)
                var innerChild = item.Children().First();

                // Omit null values
                if (innerChild.Type == JTokenType.Null)
                    continue;

                // If underlying type is an array
                if (innerChild.Type == JTokenType.Array)
                {
                    // Get all null children
                    var nullChildren = innerChild.Children()
                        .Where(x => x.Type == JTokenType.Null)
                        .ToList();

                    // And remove them
                    foreach (var nullChild in nullChildren)
                    {
                        nullChild.Remove();
                    }
                }

                // There is need to remove trailing "
                string value = item.Value
                    .ToString(Formatting.None, new DateConverter("MM/dd/yyyy HH:mm:ss"))
                    .Trim('"');

                // If everything is OK just add to dictionary
                dictionary.Add(item.Name, value);
            }

            return dictionary;
        }

        private static IDictionary<string, FileInfo> GetFilesDictionary(object obj)
        {
            IDictionary<string, FileInfo> dictionary = new Dictionary<string, FileInfo>();

            if (obj == null)
                return dictionary;

            foreach (var item in obj.GetType().GetProperties())
            {
                if (!typeof(FileInfo).IsAssignableFrom(item.PropertyType))
                    continue;

                var key = GetKey(item);

                if (item.GetValue(obj) is FileInfo value)
                    dictionary[key] = value;
            }

            return dictionary;
        }

        /// <summary>
        /// Get item's key for dictionary. If item has JsonPropertyAttribute, name is get from the attribute.
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
