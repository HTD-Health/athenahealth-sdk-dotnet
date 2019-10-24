using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Fixtures;
using Shouldly;
using Xunit;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.EndToEnd
{
    public class InsurancePackageClientTests : IClassFixture<AthenaHealthClientFixture>
    {
        private readonly IAthenaHealthClient _client;

        public InsurancePackageClientTests(AthenaHealthClientFixture athenaHealthClientFixture)
        {
            _client = athenaHealthClientFixture.Client;
        }

        [Fact]
        public async Task GetTop_ReturnsRecords()
        {
            InsurancePackageResponse<TopInsurancePackage> response = await _client.InsurancePackage.GetTop();

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Items.ShouldNotBe(null);
                response.Items
                    .Count(x => !string.IsNullOrWhiteSpace(x.Percentage))
                    .ShouldBe(response.Total);
                response.Items
                    .Count(x => !string.IsNullOrWhiteSpace(x.Ranking))
                    .ShouldBe(response.Total);
                response.Items
                    .Count(x => int.Parse(x.Id) > 0)
                    .ShouldBeGreaterThan(0);
                response.Items
                    .Count(x => int.Parse(x.Id) == -500)
                    .ShouldBe(1);
                response.Items
                    .Count(x => int.Parse(x.Id) == 0)
                    .ShouldBe(1);
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetTop_ForExistingDepartment_ReturnsRecords()
        {
            InsurancePackageResponse<TopInsurancePackage> response = await _client.InsurancePackage.GetTop(new GetTopInsurancePackageFilter() { DepartmentId = 1 });

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Items.ShouldNotBe(null);
                response.Items
                    .Count(x => !string.IsNullOrWhiteSpace(x.Percentage))
                    .ShouldBe(response.Total);
                response.Items
                    .Count(x => !string.IsNullOrWhiteSpace(x.Ranking))
                    .ShouldBe(response.Total);
                response.Items
                    .Count(x => int.Parse(x.Id) > 0)
                    .ShouldBeGreaterThan(0);
                response.Items
                    .Count(x => int.Parse(x.Id) == -500)
                    .ShouldBe(1);
                response.Items
                    .Count(x => int.Parse(x.Id) == 0)
                    .ShouldBe(1);
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetCommon_ReturnsRecords()
        {
            InsurancePackageResponse<CommonInsurancePackage> response =
                await _client.InsurancePackage.GetCommon(new GetCommonInsurancePackageFilter(1));

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Items.ShouldNotBe(null);
                response.Items.Count(x => !string.IsNullOrWhiteSpace(x.Name)).ShouldBe(response.Total);
                response.Items.Count(x => x.Id > 0).ShouldBe(response.Total);
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetCommon_ShowOnlyCasePolicies_ReturnsRecords()
        {
            InsurancePackageResponse<CommonInsurancePackage> response =
                await _client.InsurancePackage.GetCommon(new GetCommonInsurancePackageFilter(1, true));

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Items.ShouldNotBe(null);
                response.Items.Count(x => !string.IsNullOrWhiteSpace(x.Name)).ShouldBe(response.Total);
                response.Items.Count(x => x.Id > 0).ShouldBe(response.Total);
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public void GetCommon_NotExistingDepartmentId_ThrowsApiException()
        {
            Should.Throw<ApiValidationException>(async () => await _client.InsurancePackage.GetCommon(new GetCommonInsurancePackageFilter(999)));
        }

#warning Below test is slow, takes around ~9.7 seconds to run it. So in order to do that uncomment <see cref="FactAttribute"/>.
        // [Fact]
        public async Task Search_ValidModel_ReturnsRecords()
        {
            SearchInsuranceFilter model = new SearchInsuranceFilter("PAYMENT PLAN", "1")
            {
                ProductType = ProductTypeEnum.PPO
            };

            InsurancePackageResponse response = await _client.InsurancePackage.Search(model);

            response.Total.ShouldBeGreaterThan(0);
            response.Items.Any(x => !string.IsNullOrWhiteSpace(x.InsurancePlanName)).ShouldBeTrue();
            response.Items.Any(x => x.Id > 0).ShouldBeTrue();
        }

        [Fact]
        public async Task Search_NullInsurancePlanName_ThrowsException()
        {
            SearchInsuranceFilter model = new SearchInsuranceFilter(null, "1")
            {
                ProductType = ProductTypeEnum.PPO
            };

            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                    _client.InsurancePackage.Search(model)
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain(@"""missingfields"":[""insuranceplanname""]");
        }
    }
}
