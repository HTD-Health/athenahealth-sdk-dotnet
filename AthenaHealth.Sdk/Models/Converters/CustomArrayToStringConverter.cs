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
        private readonly bool _emptyInsteadOfNull;

        public CustomArrayToStringConverter() : this(",")
        {
        }

        public CustomArrayToStringConverter(string delimiter) : this(delimiter, false)
        { 
        }

        public CustomArrayToStringConverter(string delimiter, bool emptyInsteadOfNull)
        {
            _delimiter = delimiter;
            _emptyInsteadOfNull = emptyInsteadOfNull;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new InvalidOperationException("This class cannot be used for deserialization");
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsArray;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var joinedString = ObjectToStringOrDelimitedStringConverter.Convert(value, _delimiter, false);

            if (_emptyInsteadOfNull && joinedString == null)
                joinedString = "";

            writer.WriteValue(joinedString);
        }
    }
}
