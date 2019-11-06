using AthenaHealth.Sdk.Http.Helpers;
using AthenaHealth.Sdk.Models;
using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using Shouldly;
using System;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Http.Helpers
{
    public class ContentConverterTests
    {
        [Fact]
        public void ConvertObjectToDictionary_PrimitiveTypes_CorrectOutput()
        {
            var obj = new
            {
                varInt = 1,
                varNullableInt = (int?)null,

                varString = "test",
                varNullableString = (string)null,

                varDouble = 0.4d,
                varNullableDouble = (double?)null,

                varFloat = 0.4f,
                varNullableFloat = (float?)null,

                varDecimal = 0.4m,
                varNullableDecimal = (decimal?)null,

                varBool = true,
                varNullableBool = (bool?)null,
            };

            var dict = ContentConverter.ConvertObjectToDictionary(obj);

            dict[nameof(obj.varInt)].ShouldBe("1");
            dict[nameof(obj.varString)].ShouldBe("test");
            dict[nameof(obj.varDouble)].ShouldBe("0.4");
            dict[nameof(obj.varFloat)].ShouldBe("0.4");
            dict[nameof(obj.varDecimal)].ShouldBe("0.4");
            dict[nameof(obj.varBool)].ShouldBe("true");

            dict.ShouldNotContainKey(nameof(obj.varNullableInt));
            dict.ShouldNotContainKey(nameof(obj.varNullableString));
            dict.ShouldNotContainKey(nameof(obj.varNullableDouble));
            dict.ShouldNotContainKey(nameof(obj.varNullableFloat));
            dict.ShouldNotContainKey(nameof(obj.varNullableDecimal));
            dict.ShouldNotContainKey(nameof(obj.varNullableBool));
        }

        [Fact]
        public void ConvertObjectToDictionary_Arrays_CorrectOutput()
        {
            var obj = new
            {
                varInt = new int?[] { 1, 2, null },
                varString = new string[] { "test1", "test2", null },
                varDouble = new double?[] { 0.4d, 0.5d, null },
                varFloat = new float?[] { 0.4f, 0.5f, null },
                varDecimal = new decimal?[] { 0.4m, 0.5m, null },
                varBool = new bool?[] { true, false, null },
                varEmpty = new string[] { }
            };

            var dict = ContentConverter.ConvertObjectToDictionary(obj);

            dict[nameof(obj.varInt)].ShouldBe("[1,2]");
            dict[nameof(obj.varString)].ShouldBe("[test1,test2]");
            dict[nameof(obj.varDouble)].ShouldBe("[0.4,0.5]");
            dict[nameof(obj.varFloat)].ShouldBe("[0.4,0.5]");
            dict[nameof(obj.varDecimal)].ShouldBe("[0.4,0.5]");
            dict[nameof(obj.varBool)].ShouldBe("[true,false]");

            dict.ShouldNotContainKey(nameof(obj.varEmpty));
        }

        /// <summary>
        /// This is more theoretical case rather than business need. Test has been created to check how it behaves with nested objects. 
        /// </summary>
        [Fact]
        public void ConvertObjectToDictionary_NestedProperties_ReturnsNestedAsJson()
        {
            var obj = new
            {
                name = "a",
                address = new
                {
                    street = "b",
                    number = 1
                }
            };

            var dict = ContentConverter.ConvertObjectToDictionary(obj);

            dict[nameof(obj.name)].ShouldBe("a");
            dict[nameof(obj.address)].ShouldBe("{\"street\":\"b\",\"number\":1}"); //This gives the following result for nested json. Not sure what is the expected result in real life.
        }

        [Fact]
        public void ConvertObjectToDictionary_PropertyWithJsonConverterAttribute_ResultWithoutQuotes()
        {
            var obj = new TestClassWithJsonConverter
            {
                DateOfBirth = new DateTime(2019, 01, 02)
            };

            var dict = ContentConverter.ConvertObjectToDictionary(obj);

            dict["dob"].ShouldBe("01/02/2019");
        }

        [Fact]
        public void ConvertObjectToDictionary_PropertyWithJsonConverterAttributeButNull_NoResult()
        {
            var obj = new TestClassWithJsonConverter
            {
                DateOfBirth = null
            };

            var dict = ContentConverter.ConvertObjectToDictionary(obj);

            dict.ShouldBeEmpty();
        }

        [Fact]
        public void ConvertObjectToDictionary_Date_CorrectOutput()
        {
            var obj = new
            {
                date = new DateTime(2019, 01, 01)
            };

            var dict = ContentConverter.ConvertObjectToDictionary(obj);

            dict[nameof(obj.date)].ShouldBe("01/01/2019 00:00:00");
        }

        [Fact]
        public void ConvertObjectToDictionary_ClockTimeArray_CorrectOutput()
        {
            TestClassClockTimeArray obj = new TestClassClockTimeArray
            {
                AppointmentTime = new ClockTime[]
                {
                    new ClockTime(17,00),
                    new ClockTime(18,00)
                }
            };

            var dict = ContentConverter.ConvertObjectToDictionary(obj);

            dict["appointmenttime"].ShouldBe("17:00,18:00");
        }

        public class TestClassWithJsonConverter
        {
            [JsonProperty("dob")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
            public DateTime? DateOfBirth { get; set; }
        }

        public class TestClassClockTimeArray
        {
            [JsonProperty("appointmenttime")]
            [JsonConverter(typeof(CustomArrayToStringConverter), ",")]
            public ClockTime[] AppointmentTime { get; set; }
        }
    }
}
