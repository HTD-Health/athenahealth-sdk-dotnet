using System;
using AthenaHealth.Sdk.Models;
using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Models.Converters
{
    public class CustomClockTimeConverterTests
    {
        [Fact]
        public void ClockTimeSerialization_ValidData_CorrectFormat()
        {
            var obj = new TestClass(new ClockTime(10, 0));
            JsonConvert.SerializeObject(obj).ShouldBe("{\"time\":\"10:00\"}");

            obj = new TestClass(new ClockTime(23, 59));
            JsonConvert.SerializeObject(obj).ShouldBe("{\"time\":\"23:59\"}");

            obj = new TestClass(new ClockTime(0, 0));
            JsonConvert.SerializeObject(obj).ShouldBe("{\"time\":\"00:00\"}");
        }

        [Fact]
        public void ClockTimeSerialization_InvalidData_ThrowsException()
        {
            Should.Throw<ArgumentException>(()=> new ClockTime(25, 00));
            Should.Throw<ArgumentException>(()=> new ClockTime(10, 60));
            Should.Throw<ArgumentException>(()=> new ClockTime(10, -1));
        }


        [Fact]
        public void ClockTimeDeserialization_ValidData_CorrectClockTime()
        {
            
            var testClass = JsonConvert.DeserializeObject<TestClass>("{\"time\":\"10:00\"}");
            testClass.Time.ToString().ShouldBe("10:00");

            testClass = JsonConvert.DeserializeObject<TestClass>("{\"time\":\"23:59\"}");
            testClass.Time.ToString().ShouldBe("23:59");

            testClass = JsonConvert.DeserializeObject<TestClass>("{\"time\":\"00:00\"}");
            testClass.Time.ToString().ShouldBe("00:00");
        }

        [Fact]
        public void ClockTimeDeserialization_InvalidFormat_TimeIsNull()
        {
            var testClass = JsonConvert.DeserializeObject<TestClass>("{\"time\":\"10:00:15\"}");
            testClass.Time.ShouldBeNull();

            testClass = JsonConvert.DeserializeObject<TestClass>("{\"time\":\"08:00AM\"}");
            testClass.Time.ShouldBeNull();
        }
    }

    public class TestClass
    {
        [JsonProperty(PropertyName = "time")]
        [JsonConverter(typeof(CustomClockTimeConverter))]
        public ClockTime? Time { get; set; }
        
        public TestClass()
        {
        }
        public TestClass(ClockTime time)
        {
            Time = time;
        }
    }
}