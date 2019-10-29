using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AthenaHealth.Sdk.Models.Converters
{
    public class SingleElementToArrayConverter : JsonConverter
    {
        private readonly Type _type;

        public override bool CanRead => true;

        public override bool CanWrite => false;

        public SingleElementToArrayConverter(Type type)
        {
            _type = type;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken jToken = JToken.Load(reader);

            
            if (jToken.Type == JTokenType.Object)
            {
                // In case of single object we have to create array and populate it
                JObject jObject = jToken as JObject;

                object target = Activator.CreateInstance(_type);

                using (JsonReader jObjectReader = CopyReaderForObject(reader, jObject))
                {
                    serializer.Populate(jObjectReader, target);
                }

                Array array = Array.CreateInstance(_type, 1);

                array.SetValue(target, 0);

                return array;
            }
            else if (jToken.Type == JTokenType.Array)
            {
                // In case of array just use standard mechanism
                JArray jArray = jToken as JArray;

                return jArray.ToObject(objectType);
            }

            // In any other case
            return Array.CreateInstance(_type, 0);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsArray;
        }

        private JsonReader CopyReaderForObject(JsonReader reader, JObject jObject)
        {
            JsonReader jObjectReader = jObject.CreateReader();
            jObjectReader.Culture = reader.Culture;
            jObjectReader.DateFormatString = reader.DateFormatString;
            jObjectReader.DateParseHandling = reader.DateParseHandling;
            jObjectReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
            jObjectReader.FloatParseHandling = reader.FloatParseHandling;
            jObjectReader.MaxDepth = reader.MaxDepth;
            jObjectReader.SupportMultipleContent = reader.SupportMultipleContent;
            return jObjectReader;
        }
    }
}
