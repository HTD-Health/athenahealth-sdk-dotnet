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
                varString = "test",
                varFloat = 0.4f,
                varBool = true,
                varNull = (string)null
            };

            var dict = ContentConverter.ConvertObjectToDictionary(obj);

            dict["varInt"].ShouldBe("1");
            dict["varString"].ShouldBe("test");
            dict["varFloat"].ShouldBe("0.4");
            dict["varBool"].ShouldBe("True");
            dict.ShouldNotContainKey("varNull");
        }

        [Fact]
        public void ConvertObjectToDictionary_Arrays_CorrectOutput()
        {
            var obj = new
            {
                varInt = new int[] { 1, 2 },
                varString = new string[] {"test1", "test2"},
                varFloat = new float[] {0.4f, 0.5f},
                varBool = new bool[] {true, false}
            };

            var dict = ContentConverter.ConvertObjectToDictionary(obj);

            dict["varInt"].ShouldBe("[1,2]");
            dict["varString"].ShouldBe("[test1,test2]");
            dict["varFloat"].ShouldBe("[0.4,0.5]");
            dict["varBool"].ShouldBe("[True,False]");
        }
    }
}