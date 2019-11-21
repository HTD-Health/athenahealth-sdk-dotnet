using AthenaHealth.Sdk.Models;
using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Models.Converters
{
    public class DelimitedStringConverterTests
    {
        [Fact]
        public void ConvertFromJson_ThrowsException()
        {
            string json = "{\"IntArray\":\"1,2,3\",\"FloatArray\":\"1.0,2.0\",\"StringArray\":\"a,b\",\"TimeArray\":\"01:15,02:30\"}";

            TestClass testObject = JsonConvert.DeserializeObject<TestClass>(json);

            testObject.IntArray.ShouldContain(1);
            testObject.IntArray.ShouldContain(2);
            testObject.IntArray.ShouldContain(3);

            testObject.FloatArray.ShouldContain(1.0f);
            testObject.FloatArray.ShouldContain(2.0f);

            testObject.StringArray.ShouldContain("a");
            testObject.StringArray.ShouldContain("b");

            testObject.TimeArray.ShouldContain(new ClockTime(01, 15));
            testObject.TimeArray.ShouldContain(new ClockTime(02, 30));
        }

        [Fact]
        public void ConvertToJson_Arrays_CorrectJson()
        {
            TestClass testObject = new TestClass()
            {
                IntArray = new int[] { 1, 2, 3 },
                FloatArray = new float[] { 1.0f, 2.0f },
                StringArray = new string[] { "a", "b" },
                TimeArray = new ClockTime[] { new ClockTime(01, 15), new ClockTime(02, 30) }
            };

            string json = JsonConvert.SerializeObject(testObject);

            json.ShouldBe("{\"FloatArray\":\"1.0,2.0\",\"IntArray\":\"1,2,3\",\"StringArray\":\"a,b\",\"TimeArray\":\"01:15,02:30\"}");
        }

        public class TestClass
        {
            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public float[] FloatArray { get; set; }

            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public int[] IntArray { get; set; }

            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public string[] StringArray { get; set; }

            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public ClockTime[] TimeArray { get; set; }
        }
    }
}
