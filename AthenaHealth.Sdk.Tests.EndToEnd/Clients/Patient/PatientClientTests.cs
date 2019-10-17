using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Clients.Patient.Data;
using Shouldly;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.EndToEnd
{
    public class PatientClientTests
    {
        public static AthenaHealthClient Client;

        static PatientClientTests()
        {
            Client = new AthenaHealthClient(ApiVersion.Preview, "3jv4q4py8jg9dw4uw3bxgnj9", "RyM7VpBbh89E9cw", 195900);
        }

        [Fact]
        public async Task GetDefaultPharmacy_ReturnsPharmacy()
        {
            Pharmacy pharmacy = await Client.Patients.GetDefaultPharmacy(300, 1);

            pharmacy.State.ShouldNotBeEmpty();
            pharmacy.ClinicalProviderId.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetDefaultPharmacy_NotExistingPharmacy_ThrowsException()
        {
            await Assert.ThrowsAsync<ApiValidationException>(async () => await Client.Patients.GetDefaultPharmacy(300, 2));
        }

        [Fact]
        public async Task GetPreferredPharmacies_ReturnsPharmacy()
        {
            PharmacyResponse pharmacies = await Client.Patients.GetPreferredPharmacies(300, new GetPreferredPharmacyFilter { DepartmentId = 1 });
            pharmacies.ShouldNotBeNull();
            pharmacies.Total.ShouldBe(1);
            pharmacies.Items.ShouldNotBeNull();
            pharmacies.Items.Length.ShouldBe(1);
            pharmacies.Items[0].ClinicalProviderId.ShouldBe(11242674);
        }

        [Fact]
        public async Task GetPreferredPharmacies_NotExistingPharmacy_ThrowsException()
        {
            await Assert.ThrowsAsync<ApiValidationException>(async () => await Client.Patients.GetPreferredPharmacies(300, new GetPreferredPharmacyFilter { DepartmentId = 2 }));
        }

        [Theory]
        [ClassData(typeof(EnhancedBestmatchData))]
        public async Task EnhancedBestmatch_SearchByFirstNameLastNameAndDob_ShouldNotThrowJsonSerializationException(string firstName, string lastName, string dob)
        {
            // Arrange
            DateTime dateOfBirth = DateTime.ParseExact(dob, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            // Act
            var result = await Client.Patients.EnhancedBestmatch(new Models.Request.EnhancedBestmatchFilter()
            {
                DateOfBirth = dateOfBirth,
                FirstName = firstName,
                LastName = lastName,
                ShowAllClaims = true,
                ShowAllPatientDepartmentStatus = true,
                ShowBalanceDetails = true,
                Show2015EdCehrtValues = true,
                ShowCustomFields = true,
                ShowFullSsn = true,
                ShowInsurance = true,
                ShowLocalPatientId = true,
                ShowPortalStatus = true,
                MinScore = 1
            });

            result.ShouldNotBeNull();
            result.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task EnhancedBestmatch_SearchByFirstNameLastNameAndDob_NoMatch()
        {
            // Arrange
            DateTime dateOfBirth = DateTime.ParseExact("01/01/1982", "MM/dd/yyyy", CultureInfo.InvariantCulture);

            // Act
            var result = await Client.Patients.EnhancedBestmatch(new Models.Request.EnhancedBestmatchFilter()
            {
                DateOfBirth = dateOfBirth,
                FirstName = "InvalidName",
                LastName = "InvalidName",
                ShowAllClaims = true,
                ShowAllPatientDepartmentStatus = true,
                ShowBalanceDetails = true,
                Show2015EdCehrtValues = true,
                ShowCustomFields = true,
                ShowFullSsn = true,
                ShowInsurance = true,
                ShowLocalPatientId = true,
                ShowPortalStatus = true
            });

            result.ShouldNotBeNull();
            result.Count().ShouldBe(0);
        }
    }
}
