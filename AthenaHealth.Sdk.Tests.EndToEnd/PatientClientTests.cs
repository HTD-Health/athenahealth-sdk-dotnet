using System;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
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

        [Fact]
        public async Task GetDefaultPharmacy_NotExistingPharmacy_ThrowsException()
        {
            await Assert.ThrowsAsync<ApiValidationException>(async () => await _client.Patients.GetDefaultPharmacy(195900, 300, 2));
        }

        [Fact]
        public async Task GetPreferredPharmacies_ReturnsPharmacy()
        {
            Pharmacies pharmacies = await _client.Patients.GetPreferredPharmacies(195900, 300, new GetPreferredPharmacyFilter{DepartmentId = 1});
            pharmacies.ShouldNotBeNull();
            pharmacies.Total.ShouldBe(1);
            pharmacies.Items.ShouldNotBeNull();
            pharmacies.Items.Length.ShouldBe(1);
            pharmacies.Items[0].ClinicalProviderId.ShouldBe(11242674);

        }

        [Fact]
        public async Task GetPreferredPharmacies_NotExistingPharmacy_ThrowsException()
        {
            await Assert.ThrowsAsync<ApiValidationException>(async () => await _client.Patients.GetPreferredPharmacies(195900, 300, new GetPreferredPharmacyFilter{DepartmentId = 2}));
        }

        
    }
}
