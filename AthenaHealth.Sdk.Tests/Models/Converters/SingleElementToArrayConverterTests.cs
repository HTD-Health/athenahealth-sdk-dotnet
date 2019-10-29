using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Models.Converters
{
    public class SingleElementToArrayConverterTests
    {
        [Fact]
        public void SingleElementTest()
        {
            // Arrange
            var json = "{\"array\":{\"property\":12}}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.Array.Length.ShouldBe(1);
            result.Array[0].Property.ShouldBe(12);
        }

        [Fact]
        public void MultiElementTest()
        {
            // Arrange
            var json = "{\"array\":[{\"property\":12},{\"property\":15}]}";

            // Act
            var result = JsonConvert.DeserializeObject<Model>(json);

            // Assert
            result.Array.Length.ShouldBe(2);
            result.Array[0].Property.ShouldBe(12);
            result.Array[1].Property.ShouldBe(15);
        }

        public class Model
        {
            [JsonProperty("array")]
            [JsonConverter(typeof(SingleElementToArrayConverter), typeof(InnerModel))]
            public InnerModel[] Array { get; set; }

            public class InnerModel
            {
                [JsonProperty("property")]
                public int Property { get; set; }
            }
        }
    }
}
