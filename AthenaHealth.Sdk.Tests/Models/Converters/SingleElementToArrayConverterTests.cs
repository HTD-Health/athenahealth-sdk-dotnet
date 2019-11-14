using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Models.Converters
{
    public class SingleElementToArrayConverterTests
    {
        [Fact]
        public void Deserialize_MultipleBools_CorrectOutput()
        {
            // Arrange
            var json = "{\"bool_array\":[true,false]}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.BoolArray.Length.ShouldBe(2);
            result.BoolArray[0].ShouldBe(true);
            result.BoolArray[1].ShouldBe(false);
        }

        [Fact]
        public void Deserialize_MultipleDoubles_CorrectOutput()
        {
            // Arrange
            var json = "{\"double_array\":[1.2,1.3]}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.DoubleArray.Length.ShouldBe(2);
            result.DoubleArray[0].ShouldBe(1.2);
            result.DoubleArray[1].ShouldBe(1.3);
        }

        [Fact]
        public void Deserialize_MultipleIntegers_CorrectOutput()
        {
            // Arrange
            var json = "{\"int_array\":[1,2]}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.IntegerArray.Length.ShouldBe(2);
            result.IntegerArray[0].ShouldBe(1);
            result.IntegerArray[1].ShouldBe(2);
        }

        [Fact]
        public void Deserialize_MultipleObjects_CorrectOutput()
        {
            // Arrange
            var json = "{\"object_array\":[{\"property\":12},{\"property\":15}]}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.ObjectArray.Length.ShouldBe(2);
            result.ObjectArray[0].Property.ShouldBe(12);
            result.ObjectArray[1].Property.ShouldBe(15);
        }

        [Fact]
        public void Deserialize_MultipleStrings_CorrectOutput()
        {
            // Arrange
            var json = "{\"string_array\":[\"value1\",\"value2\"]}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.StringArray.Length.ShouldBe(2);
            result.StringArray[0].ShouldBe("value1");
            result.StringArray[1].ShouldBe("value2");
        }

        [Fact]
        public void Deserialize_SingleBool_CorrectOutput()
        {
            // Arrange
            var json = "{\"bool_array\":true}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.BoolArray.Length.ShouldBe(1);
            result.BoolArray[0].ShouldBe(true);
        }

        [Fact]
        public void Deserialize_SingleDouble_CorrectOutput()
        {
            // Arrange
            var json = "{\"double_array\":1.2}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.DoubleArray.Length.ShouldBe(1);
            result.DoubleArray[0].ShouldBe(1.2);
        }

        [Fact]
        public void Deserialize_SingleInteger_CorrectOutput()
        {
            // Arrange
            var json = "{\"int_array\":1}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.IntegerArray.Length.ShouldBe(1);
            result.IntegerArray[0].ShouldBe(1);
        }

        [Fact]
        public void Deserialize_SingleObject_CorrectOutput()
        {
            // Arrange
            var json = "{\"object_array\":{\"property\":12}}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.ObjectArray.Length.ShouldBe(1);
            result.ObjectArray[0].Property.ShouldBe(12);
        }

        [Fact]
        public void Deserialize_SingleString_CorrectOutput()
        {
            // Arrange
            var json = "{\"string_array\":\"value\"}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.StringArray.Length.ShouldBe(1);
            result.StringArray[0].ShouldBe("value");
        }

        public class Model
        {
            [JsonProperty("bool_array")]
            [JsonConverter(typeof(SingleElementToArrayConverter))]
            public bool[] BoolArray { get; set; }

            [JsonProperty("double_array")]
            [JsonConverter(typeof(SingleElementToArrayConverter))]
            public double[] DoubleArray { get; set; }

            [JsonProperty("int_array")]
            [JsonConverter(typeof(SingleElementToArrayConverter))]
            public int[] IntegerArray { get; set; }

            [JsonProperty("object_array")]
            [JsonConverter(typeof(SingleElementToArrayConverter))]
            public InnerModel[] ObjectArray { get; set; }

            [JsonProperty("string_array")]
            [JsonConverter(typeof(SingleElementToArrayConverter))]
            public string[] StringArray { get; set; }

            public class InnerModel
            {
                [JsonProperty("property")]
                public int Property { get; set; }
            }
        }
    }
}
