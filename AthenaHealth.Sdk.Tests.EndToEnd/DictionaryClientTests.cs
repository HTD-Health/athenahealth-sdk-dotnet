using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Fixtures;
using Shouldly;
using Xunit;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.EndToEnd
{
    public class DictionaryClientTests : IClassFixture<AthenaHealthClientFixture>
    {
        private readonly IAthenaHealthClient _client;

        public DictionaryClientTests(AthenaHealthClientFixture athenaHealthClientFixture)
        {
            _client = athenaHealthClientFixture.Client;
        }

        [Fact]
        public async Task SearchOrderTypesByName_TwoDigitsName_ReturnsRecords()
        {
            OrderType[] response = await _client.Dictionaries.SearchOrderTypesByName("ol");

            response.Length.ShouldBeGreaterThan(0);
            response.All(x => !string.IsNullOrWhiteSpace(x.Name)).ShouldBeTrue();
            response.All(x => x.Id > 0).ShouldBeTrue();
        }

        [Fact]
        public async Task SearchOrderTypesByName_OneDigitName_ReturnsApiValidationException()
        {
            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Dictionaries.SearchOrderTypesByName("o")
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("Search value must contain at least 2 characters.");
        }

        [Fact]
        public async Task SearchOrderTypesByName_NullName_ReturnsApiValidationException()
        {
            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Dictionaries.SearchOrderTypesByName(null)
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("missingfields");
        }
    }
}
