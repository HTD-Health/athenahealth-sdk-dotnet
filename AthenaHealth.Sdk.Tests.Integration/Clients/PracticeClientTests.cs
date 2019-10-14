using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Response;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Integration.Clients
{
    public class PracticeClientTests
    {
        private readonly IAthenaHealthClient _client;
        public PracticeClientTests()
        {
            _client = new AthenaHealthClient(ApiVersion.Preview, "6yspwuq3wnx5n37jp9phqsmt", "Y9UxkbBge5EXutR", 123);
        }

        [Fact]
        public async Task PatientGetAll_ReturnsRecords()
        {
            PracticeResponse response = await _client.Practices.GetAll();

            response.ShouldNotBe(null);
            response.Total.ShouldBeGreaterThan(0);
            response.Practices.ShouldNotBe(null);
        }

        [Fact]
        public async Task PatientGetById_ExistingId_ReturnsRecord()
        {
            PracticeResponse response = await _client.Practices.GetById(195900);

            response.ShouldNotBe(null);
            response.Total.ShouldBe(1);
            response.Practices.ShouldNotBe(null);
            response.Practices.Length.ShouldBe(1);
        }

        [Fact]
        public async Task PatientGetById_NotExistingId_ThrowsApiException()
        {
            await Assert.ThrowsAsync<ApiValidationException>(() => _client.Practices.GetById(666));
        }
    }
}
