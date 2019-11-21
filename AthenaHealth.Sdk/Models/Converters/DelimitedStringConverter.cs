using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AthenaHealth.Sdk.Models.Converters
{
    /// <summary>
    /// Converts arrays to delimited string (and vice versa).
    /// </summary>
    public class DelimitedStringConverter : JsonConverter
    {
        private readonly char _delimiter;

        private readonly bool _emptyInsteadOfNull;

        public override bool CanRead => true;

        public override bool CanWrite => true;

        public DelimitedStringConverter() : this(",")
        {
        }

        public DelimitedStringConverter(string delimiter) : this(delimiter, false)
        {
        }

        public DelimitedStringConverter(string delimiter, bool emptyInsteadOfNull)
        {
            _delimiter = delimiter.ToCharArray().First();
            _emptyInsteadOfNull = emptyInsteadOfNull;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsArray;
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
                var item = JToken.Parse($"\"{splittedString[i]}\"");
                var b = item.ToObject(objectType.GetElementType());

                array.SetValue(b, i);
            }

            return array;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Array array = value as Array;

            IList<string> elements = new List<string>();
            foreach (var item in array)
            {
                if (item == null)
                    continue;

                JToken token = JToken.FromObject(item);

                string convertedValue = token
                     .ToString(Formatting.None, new DateConverter("MM/dd/yyyy HH:mm:ss"))
                     .Trim('"');

                elements.Add(convertedValue);
            }

            var joinedString = string.Join(_delimiter.ToString(), elements);

            if (!_emptyInsteadOfNull && joinedString == "")
                joinedString = null;

            writer.WriteValue(joinedString);
        }
    }
}
