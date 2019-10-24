using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using Xunit;
using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request;

namespace AthenaHealth.Sdk.Tests.Integration
{
    public class InsurancePackageTests
    {
        [Fact]
        public async Task GetTop_ReturnsRecords()
        {
            var client = new InsurancePackageClient(ConnectionFactory.CreateFromFile(@"Data\InsurancePackage\GetTop.json"));

            var response = await client.GetTop();

            response.ShouldNotBeNull();
            response.Total.ShouldBeGreaterThan(0);

            response.Items.Any(x => x.Ranking == "1").ShouldBeTrue();
            response.Items.Any(x => x.Name == "*SELF PAY*").ShouldBeTrue();
            response.Items.Any(x => int.Parse(x.Id) == 0).ShouldBeTrue();

            response.Items.Any(x => x.Ranking == "3").ShouldBeTrue();
            response.Items.Any(x => x.Name == "PAYMENT PLAN").ShouldBeTrue();
            response.Items.Any(x => int.Parse(x.Id) == -500).ShouldBeTrue();
        }

        [Fact]
        public async Task GetCommon_ReturnsRecord()
        {
            var client = new InsurancePackageClient(ConnectionFactory.CreateFromFile(@"Data\InsurancePackage\GetCommon.json"));

            var response = await client.GetCommon();

            response.ShouldNotBeNull();
            response.Total.ShouldBeGreaterThan(0);
            response.Items.Any(x => x.Name == "HUMANA (PPO) [31724] ").ShouldBeTrue();
            response.Items.Any(x => x.Id == 31724).ShouldBeTrue();
        }

        [Fact]
        public async Task Search_ValidModel_ReturnsRecords()
        {
            var client = new InsurancePackageClient(ConnectionFactory.CreateFromFile(@"Data\InsurancePackage\Search.json"));

            var response = await client.Search(new SearchInsuranceFilter("*SELF PAY*", "1")
            {
                ProductType = ProductTypeEnum.PPO
            });

            response.ShouldNotBeNull();
            response.Total.ShouldBeGreaterThan(0);
            response.Items.Any(x => x.Id == 47700).ShouldBeTrue();
            response.Items.All(x => x.Id > 0).ShouldBeTrue();
            response.Items.All(x => !string.IsNullOrWhiteSpace(x.InsurancePlanName)).ShouldBeTrue();
            response.Items.Any(x => x.InsurancePlanName == "PARAMOUNT HEALTH CARE - MULTIPLAN (PPO)").ShouldBeTrue();
            response.Items.Any(x => x.Affiliations.Any()).ShouldBeTrue();
        }
    }
}
