using AthenaHealth.Sdk.Http.Helpers;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Helpers
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
            dict[nameof(obj.varBool)].ShouldBe("True");

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
            dict[nameof(obj.varBool)].ShouldBe("[True,False]");

            dict.ShouldNotContainKey(nameof(obj.varEmpty));
        }
    }
}