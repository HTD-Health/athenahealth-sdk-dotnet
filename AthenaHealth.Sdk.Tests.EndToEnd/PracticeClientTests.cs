using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Integration.EndToEnd
{
    public class PracticeClientTests
    {
        private readonly IAthenaHealthClient _client;
        public PracticeClientTests()
        {
            _client = new AthenaHealthClient(ApiVersion.Preview, "6yspwuq3wnx5n37jp9phqsmt", "Y9UxkbBge5EXutR", 195900);
        }

        [Fact]
        public async Task GetAll_ReturnsRecords()
        {
            PracticeResponse response = await _client.Practices.GetAll();

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Practices.ShouldNotBe(null);
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Practices.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_LimitEqual5_ReturnsOnly5Records()
        {
            PracticeResponse response = await _client.Practices
                .GetAll(new BaseLimitFilter() { Limit = 5 });

            if (response.Total > 0)
            {
                if (response.Total > 5)
                {
                    response.Practices.Length.ShouldBe(5);
                    response.Total.ShouldBeGreaterThan(response.Practices.Length);
                }
                else
                {
                    response.Total.ShouldBe(response.Practices.Length);
                }
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Practices.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            Practice response = await _client.Practices.GetById(195900);

            response.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetById_NotExistingId_ThrowsApiException()
        {
            await Assert.ThrowsAsync<ApiValidationException>(() => _client.Practices.GetById(666));
        }
    }
}
