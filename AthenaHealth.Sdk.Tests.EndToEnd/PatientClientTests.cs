using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Fixtures;
using Shouldly;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Tests.EndToEnd.Data.Patient;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.EndToEnd
{
    public class PatientClientTests : IClassFixture<AthenaHealthClientFixture>
    {
        private readonly IAthenaHealthClient _client;

        public PatientClientTests(AthenaHealthClientFixture athenaHealthClientFixture)
        {
            _client = athenaHealthClientFixture.Client;
        }

        [Fact]
        public void GetDefaultPharmacy_NotExistingPharmacy_ThrowsException()
        {
            // Arrange
            // Act
            // Assert
            Should.Throw<ApiValidationException>(async () => await _client.Patients.GetDefaultPharmacy(300, 2));
        }

        [Theory]
        [ClassData(typeof(EnhancedBestmatchData))]
        public async Task EnhancedBestmatch_SearchByFirstNameLastNameAndDob_ShouldNotThrowJsonSerializationException(string firstName, string lastName, string dob)
        {
            // Arrange
            DateTime dateOfBirth = DateTime.ParseExact(dob, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            // Act
            var result = await _client.Patients.EnhancedBestmatch(new EnhancedBestmatchFilter()
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

            // Assert
            result.ShouldNotBeNull();
            result.Count().ShouldBeGreaterThan(0);
        }

        [Theory]
        [ClassData(typeof(GetPatientByIdData))]
        public async Task GetPatientById_PatientExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetPatientById(patientId, new GetPatientByIdFilter()
            {
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

            // Assert
            result.ShouldNotBeNull();
        }

        [Fact]
        public void GetPatientById_PatientDoesNotExists_ShouldThrowException()
        {
            // Arrange
            var queryParameters = new GetPatientByIdFilter()
            {
                ShowAllClaims = true,
                ShowAllPatientDepartmentStatus = true,
                ShowBalanceDetails = true,
                Show2015EdCehrtValues = true,
                ShowCustomFields = true,
                ShowFullSsn = true,
                ShowInsurance = true,
                ShowLocalPatientId = true,
                ShowPortalStatus = true
            };

            // Act
            ApiValidationException exception = Should.Throw<ApiValidationException>(async () => await _client.Patients.GetPatientById(0, queryParameters));

            // Assert
            exception.ShouldNotBeNull();
        }

        [Fact]
        public async Task EnhancedBestmatch_SearchByFirstNameLastNameAndDob_NoMatch()
        {
            // Arrange
            DateTime dateOfBirth = DateTime.ParseExact("01/01/1982", "MM/dd/yyyy", CultureInfo.InvariantCulture);

            // Act
            var result = await _client.Patients.EnhancedBestmatch(new EnhancedBestmatchFilter()
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

            // Assert
            result.ShouldNotBeNull();
            result.Count().ShouldBe(0);
        }

        [Fact]
        public async Task GetDefaultPharmacy_ReturnsPharmacy()
        {
            Pharmacy pharmacy = await _client.Patients.GetDefaultPharmacy(300, 1);

            // Assert
            pharmacy.State.ShouldNotBeEmpty();
            pharmacy.ClinicalProviderId.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetPreferredPharmacies_ReturnsPharmacy()
        {
            PharmacyResponse pharmacies = await _client.Patients.GetPreferredPharmacies(300, new GetPreferredPharmacyFilter { DepartmentId = 1 });

            pharmacies.ShouldNotBeNull();
            pharmacies.Total.ShouldBeGreaterThan(0);
            pharmacies.Items.ShouldNotBeNull();
            pharmacies.Items.Length.ShouldBeGreaterThan(0);
            pharmacies.Items[0].ClinicalProviderId.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetPreferredPharmacies_NotExistingPharmacy_ThrowsException()
        {
            await Should.ThrowAsync<ApiValidationException>(async () => await _client.Patients.GetPreferredPharmacies(300, new GetPreferredPharmacyFilter { DepartmentId = 2 }));
        }


        [Fact]
        public void SetDefaultPharmacy_ValidData_NotThrow()
        {
            Should.NotThrow(async () => await _client.Patients.SetDefaultPharmacy(5000, new SetPharmacyRequest{DepartmentId = 164, ClinicalProviderId = 11242674}));
        }

        [Fact]
        public void AddPreferredPharmacy_ValidData_NotThrow()
        {
            Should.NotThrow(async () => await _client.Patients.AddPreferredPharmacy(5000, new SetPharmacyRequest{DepartmentId = 164, ClinicalProviderId = 11242674}));
        }
    }
}
