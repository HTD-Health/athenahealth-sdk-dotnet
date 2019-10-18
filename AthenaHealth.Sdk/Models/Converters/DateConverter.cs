using Newtonsoft.Json;
using System;
using System.Globalization;

namespace AthenaHealth.Sdk.Models.Converters
{
    public class DateConverter : JsonConverter
    {
        private readonly string _format;

        public override bool CanRead => true;

        public override bool CanWrite => true;

        public DateConverter() : this("MM/dd/yyyy")
        {
        }

        public DateConverter(string format)
        {
            _format = format;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return DateTime.ParseExact((string)reader.Value, _format, CultureInfo.InvariantCulture);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            DateTime dateTime = (DateTime)value;

            writer.WriteValue(dateTime.ToString(_format, CultureInfo.InvariantCulture));
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(DateTime).IsAssignableFrom(objectType);
        }
    }
}
