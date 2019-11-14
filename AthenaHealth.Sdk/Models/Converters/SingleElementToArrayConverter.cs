using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AthenaHealth.Sdk.Models.Converters
{
    public class SingleElementToArrayConverter : JsonConverter
    {
        public override bool CanRead => true;

        public override bool CanWrite => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken jToken = JToken.Load(reader);

            if (jToken.Type == JTokenType.Array)
            {
                // In case of array just use standard mechanism
                return jToken.ToObject(objectType);
            }

            // In case of single object we have to create array and populate it
            object target = jToken.ToObject(objectType.GetElementType());

            Array array = Array.CreateInstance(objectType.GetElementType(), 1);

            array.SetValue(target, 0);

            return array;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsArray;
        }
    }
}
