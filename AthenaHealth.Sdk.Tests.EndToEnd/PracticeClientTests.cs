using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Fixtures;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace AthenaHealth.Sdk.Tests.EndToEnd
{
    public class PracticeClientTests : IClassFixture<AthenaHealthClientFixture>
    {
        private readonly IAthenaHealthClient _client;

        public PracticeClientTests(AthenaHealthClientFixture athenaHealthClientFixture)
        {
            _client = athenaHealthClientFixture.Client;
        }

        [Fact]
        public async Task GetAll_ReturnsRecords()
        {
            PracticeResponse response = await _client.Practices.GetAll();

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Items.ShouldNotBe(null);
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_LimitEqual5_ReturnsOnly5Records()
        {
            PracticeResponse response = await _client.Practices.GetAll(new GetPracticeFilter() { Limit = 5 });

            if (response.Total > 0)
            {
                if (response.Total > 5)
                {
                    response.Items.Length.ShouldBe(5);
                    response.Total.ShouldBeGreaterThan(response.Items.Length);
                }
                else
                {
                    response.Total.ShouldBe(response.Items.Length);
                }
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            Practice response = await _client.Practices.GetById(195900);

            response.ShouldNotBeNull();
        }

        [Fact]
        public void GetById_NotExistingId_ThrowsApiException()
        {
            Should.Throw<ApiValidationException>(async () => await _client.Practices.GetById(666));
        }
    }
}
