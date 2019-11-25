using AthenaHealth.Sdk.Http.Helpers;
using AthenaHealth.Sdk.Models;
using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Shouldly;
using System;
using System.IO;
using System.Runtime.Serialization;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Http.Helpers
{
    public class ContentConverterTests
    {
        public enum TestEnum
        {
            [EnumMember(Value = "FIRST")] First,
            [EnumMember(Value = "SECOND")] Second
        }

        [Fact]
        public void ConvertObjectToDictionary_AnonymousType_CorrectOutput()
        {
            var testObject = new
            {
                Time = new ClockTime(01, 15),
                Times = new ClockTime?[] { new ClockTime(02, 30), new ClockTime(03, 45) },
                Date = new DateTime(2019, 11, 21, 01, 02, 03),
                Dates = new DateTime?[] { new DateTime(2019, 11, 20), new DateTime(2019, 11, 19) },
                Enum = TestEnum.First,
                Enums = new TestEnum?[] { TestEnum.First, TestEnum.Second },
                Variable = new
                {
                    BoolVariable = true,
                    DecimalVariable = 10.5m,
                    DoubleVariable = 5.3d,
                    FloatVariable = 1.82f,
                    IntegerVariable = 15,
                    StringVariable = "first"
                },
                Variables = new[]
                {
                    new
                    {
                        BoolVariable = false,
                        DecimalVariable = 120.5m,
                        DoubleVariable = 53.3d,
                        FloatVariable = 14.82f,
                        IntegerVariable = 1,
                        StringVariable = "second"
                    },
                    new
                    {
                        BoolVariable = true,
                        DecimalVariable = 20.5m,
                        DoubleVariable = 53d,
                        FloatVariable = 4.82f,
                        IntegerVariable = 18,
                        StringVariable = "third"
                    }
                },
                IntegerVariable = 1,
                StringVariable = "test",
                DoubleVariable = 0.4d,
                FloatVariable = 0.4f,
                DecimalVariable = 0.4m,
                BoolVariable = true,
                IntegerVariables = new int?[] { 1, 2 },
                StringVariables = new string[] { "test 1", "test 2" },
                DoubleVariables = new double?[] { 0.4d, 0.5d },
                FloatVariables = new float?[] { 0.4f, 0.5f },
                DecimalVariables = new decimal?[] { 0.4m, 0.5m },
                BoolVariables = new bool?[] { true, false },
            };

            var dict = ContentConverter.ConvertObjectToDictionary(testObject);

            dict[nameof(testObject.Time)].ShouldBe("01:15");
            dict[nameof(testObject.Times)].ShouldBe("[\"02:30\",\"03:45\"]");
            dict[nameof(testObject.Date)].ShouldBe("11/21/2019 01:02:03");
            dict[nameof(testObject.Dates)].ShouldBe("[\"11/20/2019 00:00:00\",\"11/19/2019 00:00:00\"]");
            dict[nameof(testObject.Enum)].ShouldBe("0");
            dict[nameof(testObject.Enums)].ShouldBe("[0,1]");
            dict[nameof(testObject.Variable)].ShouldBe("{\"BoolVariable\":true,\"DecimalVariable\":10.5,\"DoubleVariable\":5.3,\"FloatVariable\":1.82,\"IntegerVariable\":15,\"StringVariable\":\"first\"}");
            dict[nameof(testObject.Variables)].ShouldBe("[{\"BoolVariable\":false,\"DecimalVariable\":120.5,\"DoubleVariable\":53.3,\"FloatVariable\":14.82,\"IntegerVariable\":1,\"StringVariable\":\"second\"},{\"BoolVariable\":true,\"DecimalVariable\":20.5,\"DoubleVariable\":53.0,\"FloatVariable\":4.82,\"IntegerVariable\":18,\"StringVariable\":\"third\"}]");
            dict[nameof(testObject.IntegerVariable)].ShouldBe("1");
            dict[nameof(testObject.StringVariable)].ShouldBe("test");
            dict[nameof(testObject.DoubleVariable)].ShouldBe("0.4");
            dict[nameof(testObject.FloatVariable)].ShouldBe("0.4");
            dict[nameof(testObject.DecimalVariable)].ShouldBe("0.4");
            dict[nameof(testObject.BoolVariable)].ShouldBe("true");
            dict[nameof(testObject.IntegerVariables)].ShouldBe("[1,2]");
            dict[nameof(testObject.StringVariables)].ShouldBe("[\"test 1\",\"test 2\"]");
            dict[nameof(testObject.DoubleVariables)].ShouldBe("[0.4,0.5]");
            dict[nameof(testObject.FloatVariables)].ShouldBe("[0.4,0.5]");
            dict[nameof(testObject.DecimalVariables)].ShouldBe("[0.4,0.5]");
            dict[nameof(testObject.BoolVariables)].ShouldBe("[true,false]");

            dict.Count.ShouldBe(20);
        }

        [Fact]
        public void ConvertObjectToDictionary_NotNullValues_CorrectOutput()
        {
            TestClass testObject = new TestClass()
            {
                Time = new ClockTime(01, 15),
                Times = new ClockTime?[] { new ClockTime(02, 30), new ClockTime(03, 45) },
                DelimitedTimes = new ClockTime?[] { new ClockTime(02, 30), new ClockTime(03, 45) },
                Date = new DateTime(2019, 11, 21),
                Dates = new DateTime?[] { new DateTime(2019, 11, 20), new DateTime(2019, 11, 19) },
                DefaultDate = new DateTime(2019, 11, 21, 01, 02, 03),
                Enum = TestEnum.First,
                Enums = new TestEnum?[] { TestEnum.First, TestEnum.Second },
                File = new FileInfo("file.txt"),
                Variable = new InnerTestClass()
                {
                    BoolVariable = true,
                    DecimalVariable = 10.5m,
                    DoubleVariable = 5.3d,
                    FloatVariable = 1.82f,
                    IntegerVariable = 15,
                    StringVariable = "first"
                },
                Variables = new InnerTestClass[]
                {
                    new InnerTestClass()
                    {
                        BoolVariable = false,
                        DecimalVariable = 120.5m,
                        DoubleVariable = 53.3d,
                        FloatVariable = 14.82f,
                        IntegerVariable = 1,
                        StringVariable = "second"
                    },
                    new InnerTestClass()
                    {
                        BoolVariable = true,
                        DecimalVariable = 20.5m,
                        DoubleVariable = 53d,
                        FloatVariable = 4.82f,
                        IntegerVariable = 18,
                        StringVariable = "third"
                    }
                },
                IntegerVariable = 1,
                StringVariable = "test",
                DoubleVariable = 0.4d,
                FloatVariable = 0.4f,
                DecimalVariable = 0.4m,
                BoolVariable = true,
                IntegerVariables = new int?[] { 1, 2 },
                StringVariables = new string[] { "test 1", "test 2" },
                DoubleVariables = new double?[] { 0.4d, 0.5d },
                FloatVariables = new float?[] { 0.4f, 0.5f },
                DecimalVariables = new decimal?[] { 0.4m, 0.5m },
                BoolVariables = new bool?[] { true, false },
                DelimitedIntegerVariables = new int?[] { 1, 2 },
                DelimitedStringVariables = new string[] { "test 1", "test 2" },
                DelimitedDoubleVariables = new double?[] { 0.4d, 0.5d },
                DelimitedFloatVariables = new float?[] { 0.4f, 0.5f },
                DelimitedDecimalVariables = new decimal?[] { 0.4m, 0.5m },
                DelimitedBoolVariables = new bool?[] { true, false },
                EmptyInsteadOfNullDelimitedIntegerVariables = new int?[] { },
                EmptyInsteadOfNullDelimitedStringVariables = new string[] { },
                EmptyInsteadOfNullDelimitedDoubleVariables = new double?[] { },
                EmptyInsteadOfNullDelimitedFloatVariables = new float?[] { },
                EmptyInsteadOfNullDelimitedDecimalVariables = new decimal?[] { },
                EmptyInsteadOfNullDelimitedBoolVariables = new bool?[] { }
            };

            var dict = ContentConverter.ConvertObjectToDictionary(testObject);

            dict["time"].ShouldBe("01:15");
            dict["times"].ShouldBe("[\"02:30\",\"03:45\"]");
            dict["delimited_times"].ShouldBe("02:30,03:45");
            dict["enum"].ShouldBe("FIRST");
            dict["enums"].ShouldBe("[\"FIRST\",\"SECOND\"]");
            dict["date"].ShouldBe("11/21/2019");
            dict["dates"].ShouldBe("[\"11/20/2019\",\"11/19/2019\"]");
            dict["default_date"].ShouldBe("11/21/2019 01:02:03");
            dict["variable"].ShouldBe("{\"int\":15,\"string\":\"first\",\"double\":5.3,\"float\":1.82,\"decimal\":10.5,\"bool\":true}");
            dict["variables"].ShouldBe("[{\"int\":1,\"string\":\"second\",\"double\":53.3,\"float\":14.82,\"decimal\":120.5,\"bool\":false},{\"int\":18,\"string\":\"third\",\"double\":53.0,\"float\":4.82,\"decimal\":20.5,\"bool\":true}]");
            dict["int"].ShouldBe("1");
            dict["string"].ShouldBe("test");
            dict["double"].ShouldBe("0.4");
            dict["float"].ShouldBe("0.4");
            dict["decimal"].ShouldBe("0.4");
            dict["bool"].ShouldBe("true");
            dict["ints"].ShouldBe("[1,2]");
            dict["strings"].ShouldBe("[\"test 1\",\"test 2\"]");
            dict["doubles"].ShouldBe("[0.4,0.5]");
            dict["floats"].ShouldBe("[0.4,0.5]");
            dict["decimals"].ShouldBe("[0.4,0.5]");
            dict["bools"].ShouldBe("[true,false]");
            dict["delimited_ints"].ShouldBe("1,2");
            dict["delimited_strings"].ShouldBe("test 1,test 2");
            dict["delimited_doubles"].ShouldBe("0.4,0.5");
            dict["delimited_floats"].ShouldBe("0.4,0.5");
            dict["delimited_decimals"].ShouldBe("0.4,0.5");
            dict["delimited_bools"].ShouldBe("true,false");
            dict["empty_instead_null_delimited_ints"].ShouldBe("");
            dict["empty_instead_null_delimited_strings"].ShouldBe("");
            dict["empty_instead_null_delimited_doubles"].ShouldBe("");
            dict["empty_instead_null_delimited_floats"].ShouldBe("");
            dict["empty_instead_null_delimited_decimals"].ShouldBe("");
            dict["empty_instead_null_delimited_bools"].ShouldBe("");

            dict.Count.ShouldBe(34);
        }

        [Fact]
        public void ConvertObjectToDictionary_NullValues_CorrectOutput()
        {
            TestClass testObject = new TestClass()
            {
                Times = new ClockTime?[] { new ClockTime(02, 30), null, new ClockTime(03, 45) },
                DelimitedTimes = new ClockTime?[] { new ClockTime(02, 30), null, new ClockTime(03, 45) },
                Dates = new DateTime?[] { new DateTime(2019, 11, 20), null, new DateTime(2019, 11, 19) },
                Enums = new TestEnum?[] { TestEnum.First, null, TestEnum.Second },
                File = new FileInfo("file.txt"),
                Variables = new InnerTestClass[]
                {
                    new InnerTestClass()
                    {
                        BoolVariable = false,
                        DecimalVariable = 120.5m,
                        DoubleVariable = 53.3d,
                        FloatVariable = 14.82f,
                        IntegerVariable = 1,
                        StringVariable = "second"
                    },
                    null,
                    new InnerTestClass()
                    {
                        BoolVariable = true,
                        DecimalVariable = 20.5m,
                        DoubleVariable = 53d,
                        FloatVariable = 4.82f,
                        IntegerVariable = 18,
                        StringVariable = "third"
                    }
                },
                IntegerVariables = new int?[] { 1, null, 2 },
                StringVariables = new string[] { "test 1", null, "test 2" },
                DoubleVariables = new double?[] { 0.4d, null, 0.5d },
                FloatVariables = new float?[] { 0.4f, null, 0.5f },
                DecimalVariables = new decimal?[] { 0.4m, null, 0.5m },
                BoolVariables = new bool?[] { true, null, false },
                DelimitedIntegerVariables = new int?[] { 1, null, 2 },
                DelimitedStringVariables = new string[] { "test 1", null, "test 2" },
                DelimitedDoubleVariables = new double?[] { 0.4d, null, 0.5d },
                DelimitedFloatVariables = new float?[] { 0.4f, null, 0.5f },
                DelimitedDecimalVariables = new decimal?[] { 0.4m, null, 0.5m },
                DelimitedBoolVariables = new bool?[] { true, null, false },
                EmptyInsteadOfNullDelimitedIntegerVariables = new int?[] { null },
                EmptyInsteadOfNullDelimitedStringVariables = new string[] { null },
                EmptyInsteadOfNullDelimitedDoubleVariables = new double?[] { null },
                EmptyInsteadOfNullDelimitedFloatVariables = new float?[] { null },
                EmptyInsteadOfNullDelimitedDecimalVariables = new decimal?[] { null },
                EmptyInsteadOfNullDelimitedBoolVariables = new bool?[] { null }
            };

            var dict = ContentConverter.ConvertObjectToDictionary(testObject);

            dict["times"].ShouldBe("[\"02:30\",\"03:45\"]");
            dict["delimited_times"].ShouldBe("02:30,03:45");
            dict["enums"].ShouldBe("[\"FIRST\",\"SECOND\"]");
            dict["dates"].ShouldBe("[\"11/20/2019\",\"11/19/2019\"]");
            dict["variables"].ShouldBe("[{\"int\":1,\"string\":\"second\",\"double\":53.3,\"float\":14.82,\"decimal\":120.5,\"bool\":false},{\"int\":18,\"string\":\"third\",\"double\":53.0,\"float\":4.82,\"decimal\":20.5,\"bool\":true}]");
            dict["ints"].ShouldBe("[1,2]");
            dict["strings"].ShouldBe("[\"test 1\",\"test 2\"]");
            dict["doubles"].ShouldBe("[0.4,0.5]");
            dict["floats"].ShouldBe("[0.4,0.5]");
            dict["decimals"].ShouldBe("[0.4,0.5]");
            dict["bools"].ShouldBe("[true,false]");
            dict["delimited_ints"].ShouldBe("1,2");
            dict["delimited_strings"].ShouldBe("test 1,test 2");
            dict["delimited_doubles"].ShouldBe("0.4,0.5");
            dict["delimited_floats"].ShouldBe("0.4,0.5");
            dict["delimited_decimals"].ShouldBe("0.4,0.5");
            dict["delimited_bools"].ShouldBe("true,false");
            dict["empty_instead_null_delimited_ints"].ShouldBe("");
            dict["empty_instead_null_delimited_strings"].ShouldBe("");
            dict["empty_instead_null_delimited_doubles"].ShouldBe("");
            dict["empty_instead_null_delimited_floats"].ShouldBe("");
            dict["empty_instead_null_delimited_decimals"].ShouldBe("");
            dict["empty_instead_null_delimited_bools"].ShouldBe("");

            dict.ShouldNotContainKey("time");
            dict.ShouldNotContainKey("enum");
            dict.ShouldNotContainKey("date");
            dict.ShouldNotContainKey("variable");
            dict.ShouldNotContainKey("int");
            dict.ShouldNotContainKey("string");
            dict.ShouldNotContainKey("double");
            dict.ShouldNotContainKey("float");
            dict.ShouldNotContainKey("decimal");
            dict.ShouldNotContainKey("bool");

            dict.Count.ShouldBe(23);
        }

        public class TestClass
        {
            [JsonProperty("time")]
            public ClockTime? Time { get; set; }

            [JsonProperty("times")]
            public ClockTime?[] Times { get; set; }

            [JsonProperty("delimited_times")]
            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public ClockTime?[] DelimitedTimes { get; set; }

            [JsonProperty("enum")]
            [JsonConverter(typeof(EnumConverter))]
            public TestEnum? Enum { get; set; }

            [JsonProperty("enums", ItemConverterType = typeof(EnumConverter))]
            public TestEnum?[] Enums { get; set; }

            [JsonProperty("date")]
            [JsonConverter(typeof(DateConverter))]
            public DateTime? Date { get; set; }

            [JsonProperty("dates", ItemConverterType = typeof(DateConverter), ItemConverterParameters = new[] { "MM/dd/yyyy" })]
            public DateTime?[] Dates { get; set; }

            [JsonProperty("default_date")]
            public DateTime? DefaultDate { get; set; }

            [JsonProperty("variable")]
            public InnerTestClass Variable { get; set; }

            [JsonProperty("variables")]
            public InnerTestClass[] Variables { get; set; }

            [JsonIgnore]
            public FileInfo File { get; set; }

            [JsonProperty("int")]
            public int? IntegerVariable { get; set; }

            [JsonProperty("string")]
            public string StringVariable { get; set; }

            [JsonProperty("double")]
            public double? DoubleVariable { get; set; }

            [JsonProperty("float")]
            public float? FloatVariable { get; set; }

            [JsonProperty("decimal")]
            public decimal? DecimalVariable { get; set; }

            [JsonProperty("bool")]
            public bool? BoolVariable { get; set; }

            [JsonProperty("ints")]
            public int?[] IntegerVariables { get; set; }

            [JsonProperty("strings")]
            public string[] StringVariables { get; set; }

            [JsonProperty("doubles")]
            public double?[] DoubleVariables { get; set; }

            [JsonProperty("floats")]
            public float?[] FloatVariables { get; set; }

            [JsonProperty("decimals")]
            public decimal?[] DecimalVariables { get; set; }

            [JsonProperty("bools")]
            public bool?[] BoolVariables { get; set; }

            [JsonProperty("delimited_ints")]
            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public int?[] DelimitedIntegerVariables { get; set; }

            [JsonProperty("delimited_strings")]
            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public string[] DelimitedStringVariables { get; set; }

            [JsonProperty("delimited_doubles")]
            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public double?[] DelimitedDoubleVariables { get; set; }

            [JsonProperty("delimited_floats")]
            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public float?[] DelimitedFloatVariables { get; set; }

            [JsonProperty("delimited_decimals")]
            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public decimal?[] DelimitedDecimalVariables { get; set; }

            [JsonProperty("delimited_bools")]
            [JsonConverter(typeof(DelimitedStringConverter), ",")]
            public bool?[] DelimitedBoolVariables { get; set; }

            [JsonProperty("empty_instead_null_delimited_ints")]
            [JsonConverter(typeof(DelimitedStringConverter), ",", true)]
            public int?[] EmptyInsteadOfNullDelimitedIntegerVariables { get; set; }

            [JsonProperty("empty_instead_null_delimited_strings")]
            [JsonConverter(typeof(DelimitedStringConverter), ",", true)]
            public string[] EmptyInsteadOfNullDelimitedStringVariables { get; set; }

            [JsonProperty("empty_instead_null_delimited_doubles")]
            [JsonConverter(typeof(DelimitedStringConverter), ",", true)]
            public double?[] EmptyInsteadOfNullDelimitedDoubleVariables { get; set; }

            [JsonProperty("empty_instead_null_delimited_floats")]
            [JsonConverter(typeof(DelimitedStringConverter), ",", true)]
            public float?[] EmptyInsteadOfNullDelimitedFloatVariables { get; set; }

            [JsonProperty("empty_instead_null_delimited_decimals")]
            [JsonConverter(typeof(DelimitedStringConverter), ",", true)]
            public decimal?[] EmptyInsteadOfNullDelimitedDecimalVariables { get; set; }

            [JsonProperty("empty_instead_null_delimited_bools")]
            [JsonConverter(typeof(DelimitedStringConverter), ",", true)]
            public bool?[] EmptyInsteadOfNullDelimitedBoolVariables { get; set; }
        }

        public class InnerTestClass
        {
            [JsonProperty("int")]
            public int IntegerVariable { get; set; }

            [JsonProperty("string")]
            public string StringVariable { get; set; }

            [JsonProperty("double")]
            public double DoubleVariable { get; set; }

            [JsonProperty("float")]
            public float FloatVariable { get; set; }

            [JsonProperty("decimal")]
            public decimal DecimalVariable { get; set; }

            [JsonProperty("bool")]
            public bool BoolVariable { get; set; }
        }
    }
}
