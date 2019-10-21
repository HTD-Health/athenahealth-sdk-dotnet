using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Fixtures;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.EndToEnd
{
    public class ProviderClientTests : IClassFixture<AthenaHealthClientFixture>
    {
        private readonly IAthenaHealthClient _client;

        public ProviderClientTests(AthenaHealthClientFixture athenaHealthClientFixture)
        {
            _client = athenaHealthClientFixture.Client;
        }

        [Fact]
        public async Task GetAll_ReturnsRecords()
        {
            ProviderResponse response = await _client.Providers.GetAll();

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Items.ShouldNotBe(null);
                response.Items
                    .Count(x => !string.IsNullOrWhiteSpace(x.FirstName))
                    .ShouldBe(response.Total);
                response.Items.Count(x => int.Parse(x.Id) > 0)
                    .ShouldBe(response.Total);
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_ProviderListRequested_ReturnedRecordsWithProviders()
        {
            ProviderResponse response = await _client.Providers
                .GetAll(new GetProviderFilter() { ShowAllProviderIds = true });

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Items.ShouldNotBe(null);
                response.Items.Any(x => x.ProviderGroupList.Length > 0).ShouldBeTrue();
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_ProviderListNotRequested_ReturnedRecordsWithoutProviders()
        {
            var departmentResponse = await _client.Providers
                .GetAll(new GetProviderFilter() { ShowAllProviderIds = false });

            if (departmentResponse.Total > 0)
            {
                departmentResponse.Items.All(x => x.ProviderGroupList == null).ShouldBeTrue();
            }
            else
            {
                departmentResponse.Total.ShouldBe(0);
                departmentResponse.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_LimitEqual5_ReturnsOnly5Records()
        {
            ProviderResponse departmentResponse = await _client.Providers
                .GetAll(new GetProviderFilter() { Limit = 5 });

            if (departmentResponse.Total > 0)
            {
                if (departmentResponse.Total > 5)
                {
                    departmentResponse.Items.Length.ShouldBe(5);
                    departmentResponse.Total.ShouldBeGreaterThan(departmentResponse.Items.Length);
                }
                else
                {
                    departmentResponse.Total.ShouldBe(departmentResponse.Items.Length);
                }
            }
            else
            {
                departmentResponse.Total.ShouldBe(0);
                departmentResponse.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecordWithFederalIdNumber()
        {
            ProviderExtended response = await _client.Providers.GetById(86,
                new GetByIdProviderFilter() { ShowFederalIdNumber = 1 });

            response.FederalIdNumber.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            ProviderExtended response = await _client.Providers.GetById(86,
                new GetByIdProviderFilter() { ShowFederalIdNumber = 0 });

            response.FederalIdNumber.ShouldBe(0);
        }

        [Fact]
        public async Task GetById_NotExistingId_ThrowsApiException()
        {
            await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Providers.GetById(999)
                );
        }

        [Fact]
        public async Task GetProviderTypes_ReturnsRecords()
        {
            ProviderTypeResponse response = await _client.Providers.GetProviderTypes();

            if (response.Total > 0)
            {
                response.Total.ShouldBe(response.Items.Length);
                response.Items.Count(x => string.IsNullOrWhiteSpace(x.Id)).ShouldBe(0);
                response.Items.Count(x => string.IsNullOrWhiteSpace(x.Name)).ShouldBe(0);
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetProviderTypes_LimitEqual5_ReturnsOnly5Records()
        {
            ProviderTypeResponse response = await _client.Providers
                .GetProviderTypes(new BaseLimitFilter() { Limit = 5 });

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
    }
}
