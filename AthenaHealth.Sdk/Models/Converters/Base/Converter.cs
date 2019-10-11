using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AthenaHealth.Sdk.Models.Converters.Base
{
    public abstract class Converter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return ConvertBack(reader.Value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(Convert(value));
        }

        /// <summary>
        /// Converts to json format.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public abstract object Convert(object value);

        /// <summary>
        /// Converts from json format.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public abstract object ConvertBack(object value);
    }
}
