using AthenaHealth.Sdk.Models;
using Newtonsoft.Json;
using Shouldly;
using System;
using System.Linq;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Models.Converters
{
    public class ClockTimeConverterTests
    {
        [Fact]
        public void ClockTimeSerialization_ValidData_CorrectFormat()
        {
            var obj = new TestClass()
            {
                Time = new ClockTime(10, 00),
                Times = new ClockTime[]
                {
                    new ClockTime(23, 59),
                    new ClockTime(00, 00)
                }
            };

            JsonConvert.SerializeObject(obj).ShouldBe("{\"time\":\"10:00\",\"times\":[\"23:59\",\"00:00\"]}");
        }

        [Fact]
        public void ClockTimeSerialization_InvalidData_ThrowsException()
        {
            Should.Throw<ArgumentException>(() => new ClockTime(25, 00));
            Should.Throw<ArgumentException>(() => new ClockTime(10, 60));
            Should.Throw<ArgumentException>(() => new ClockTime(10, -1));
        }

        [Fact]
        public void ClockTimeDeserialization_ValidData_CorrectClockTime()
        {

            var testClass = JsonConvert.DeserializeObject<TestClass>("{\"time\":\"10:00\",\"times\":[\"23:59\",\"00:00\"]}");

            testClass.Time.ShouldBe(new ClockTime(10, 0));

            testClass.Times.Length.ShouldBe(2);
            testClass.Times.First().ShouldBe(new ClockTime(23, 59));
            testClass.Times.Last().ShouldBe(new ClockTime(00, 00));
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
        [JsonProperty("time")]
        public ClockTime? Time { get; set; }

        [JsonProperty("times")]
        public ClockTime[] Times { get; set; }
    }
}
