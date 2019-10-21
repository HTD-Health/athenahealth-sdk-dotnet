using System;
using AthenaHealth.Sdk.Http.Helpers;
using AthenaHealth.Sdk.Models.Converters;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Models.Converters
{
    public class ObjectToDelimitedStringConverterTests
    {
        [Fact]
        public void Convert_PrimitiveTypes_CorrectOutput()
        {
            ObjectToDelimitedStringConverter.Convert(1, ",").ShouldBe("1");
            ObjectToDelimitedStringConverter.Convert("test", ",").ShouldBe("test");
            ObjectToDelimitedStringConverter.Convert(0.4d, ",").ShouldBe("0.4");
            ObjectToDelimitedStringConverter.Convert(0.4f, ",").ShouldBe("0.4");
            ObjectToDelimitedStringConverter.Convert(0.4m, ",").ShouldBe("0.4");
            ObjectToDelimitedStringConverter.Convert(true, ",").ShouldBe("True");
            ObjectToDelimitedStringConverter.Convert(null, ",").ShouldBe("");
        }

        [Fact]
        public void Convert_Arrays_CorrectOutput()
        {
            ObjectToDelimitedStringConverter.Convert(new[]{1,2}, ",").ShouldBe("[1,2]");
            ObjectToDelimitedStringConverter.Convert(new[]{"test1", "test2"}, ",").ShouldBe("[test1,test2]");
            ObjectToDelimitedStringConverter.Convert(new[]{0.4d,0.5d}, ",").ShouldBe("[0.4,0.5]");
            ObjectToDelimitedStringConverter.Convert(new[]{0.4f,0.5f}, ",").ShouldBe("[0.4,0.5]");
            ObjectToDelimitedStringConverter.Convert(new[]{0.4m,0.5m}, ",").ShouldBe("[0.4,0.5]");
            ObjectToDelimitedStringConverter.Convert(new[]{true,false}, ",").ShouldBe("[True,False]");
            ObjectToDelimitedStringConverter.Convert(new int?[] {null, null}, ",").ShouldBeNull();
            ObjectToDelimitedStringConverter.Convert(new int?[]{null, 5, null, 6}, ",").ShouldBe("[5,6]");
        }

        [Fact]
        public void Convert_ArraysNoBrackets_CorrectOutput()
        {
            ObjectToDelimitedStringConverter.Convert(new[]{1,2}, ",", false).ShouldBe("1,2");
            ObjectToDelimitedStringConverter.Convert(new[]{"test1", "test2"}, ",",false).ShouldBe("test1,test2");
            ObjectToDelimitedStringConverter.Convert(new[]{0.4d,0.5d}, ",",false).ShouldBe("0.4,0.5");
            ObjectToDelimitedStringConverter.Convert(new[]{0.4f,0.5f}, ",",false).ShouldBe("0.4,0.5");
            ObjectToDelimitedStringConverter.Convert(new[]{0.4m,0.5m}, ",",false).ShouldBe("0.4,0.5");
            ObjectToDelimitedStringConverter.Convert(new[]{true,false}, ",",false).ShouldBe("True,False");
            ObjectToDelimitedStringConverter.Convert(new int?[]{null, null}, ",",false).ShouldBeNull();
            ObjectToDelimitedStringConverter.Convert(new int?[]{null, 5, null, 6}, ",",false).ShouldBe("5,6");
        }
    }
}