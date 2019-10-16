using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Response;
using Shouldly;
using Xunit;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.Integration.EndToEnd
{
    public class PatientClientTests
    {
        private readonly IAthenaHealthClient _client;
        public PatientClientTests()
        {
            _client = new AthenaHealthClient(ApiVersion.Preview, "6yspwuq3wnx5n37jp9phqsmt", "Y9UxkbBge5EXutR", 195900);
        }

        [Fact]
        public async Task GetDefaultPharmacy_ReturnsPharmacy()
        {
            Pharmacy pharmacy = await _client.Patients.GetDefaultPharmacy(195900, 300, 1);

            pharmacy.State.ShouldNotBeEmpty();
            pharmacy.ClinicalProviderId.ShouldBeGreaterThan(0);
        }
    }
}
