using System;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Converters
{
    /// <summary>
    /// Converts arrays to delimited string.
    /// May be used for serialization.
    /// May not be used for deserialization.
    /// </summary>
    public class CustomArrayToStringConverter : JsonConverter
    {
        private readonly string _delimiter;

        public CustomArrayToStringConverter() : this(",")
        {
        }

        public CustomArrayToStringConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new InvalidOperationException("This class cannot be used for deserialization");
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType.IsArray)
                return true;
            return false;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var joinedString = ObjectToStringOrDelimitedStringConverter.Convert(value, _delimiter.ToString(), false);
            writer.WriteValue(joinedString);
        }
    }
}
