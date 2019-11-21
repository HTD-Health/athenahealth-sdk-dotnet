using Newtonsoft.Json;
using System;
using System.Globalization;

namespace AthenaHealth.Sdk.Models.Converters
{
    public class ClockTimeConverter : JsonConverter
    {
        public override bool CanRead => true;

        public override bool CanWrite => true;

        public ClockTimeConverter()
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                TimeSpan timeSpan = TimeSpan.ParseExact((string)reader.Value, @"hh\:mm", CultureInfo.InvariantCulture);
                return new ClockTime(timeSpan.Hours, timeSpan.Minutes);
            }
            catch
            {
                return null;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            ClockTime clockTime = (ClockTime)value;

            writer.WriteValue(clockTime.ToString());
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ClockTime);
        }
    }
}
