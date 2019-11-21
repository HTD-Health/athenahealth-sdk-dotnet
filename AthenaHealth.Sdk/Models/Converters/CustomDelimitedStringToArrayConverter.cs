using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AthenaHealth.Sdk.Models.Converters
{
    /// <summary>
    /// Converts arrays to delimited string.
    /// May be used for serialization.
    /// May not be used for deserialization.
    /// </summary>
    public class CustomDelimitedStringToArrayConverter : JsonConverter
    {
        private readonly char _delimiter;

        public override bool CanRead => true;

        public CustomDelimitedStringToArrayConverter() : this(',')
        {
        }

        public CustomDelimitedStringToArrayConverter(char delimiter)
        {
            _delimiter = delimiter;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (!(reader.Value is string value))
                return null;

            if (value == null)
                return null;

            if (reader.Value == null)
                return null;

            string[] splittedString = value.Split(_delimiter);

            Array array = Array.CreateInstance(objectType.GetElementType(), splittedString.Length);

            for (int i = 0; i < splittedString.Length; i++)
            {
                object item = JToken.Parse(splittedString[i]).ToObject(objectType.GetElementType());

                array.SetValue(item, i);
            }

            return array;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsArray;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
