using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using Shouldly;
using System;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Models.Converters
{
    public class CustomArrayToStringConverterTests
    {
        [Fact]
        public void ConvertToJson_Arrays_CorrectJson()
        {
            string json = JsonConvert.SerializeObject(new ClassWithArrays());

            json.ShouldBe("{\"IntArray\":\"1,2,3\",\"FloatArray\":\"1,2\",\"StringArray\":\"a,b\"}");
        }

        [Fact]
        public void ConvertFromJson_ThrowsException()
        {
            string json = "{\"IntArray\":\"1,2,3\",\"FloatArray\":\"1,2\",\"StringArray\":\"a,b\"}";
            Should.Throw<InvalidOperationException>(() => JsonConvert.DeserializeObject<ClassWithArrays>(json));
        }

        public class ClassWithArrays
        {
            [JsonConverter(typeof(CustomArrayToStringConverter), ",")]
            public int[] IntArray = { 1, 2, 3 };

            [JsonConverter(typeof(CustomArrayToStringConverter), ",")]
            public float[] FloatArray = { 1.0f, 2.0f };

            [JsonConverter(typeof(CustomArrayToStringConverter), ",")]
            public string[] StringArray = { "a", "b" };
        }
    }
}
