using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.Integration.Clients.Patient
{
    public class PatientClientTests
    {
        [Fact]
        public async Task GetPatientById_ValidId_ReturnsPatient()
        {
            // Arrange
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.CreateFromFile(@"Clients\Patient\Patient.json"));

            // Act
            var result = await patientClient.GetPatientById(1);

            // Assert
            result.ShouldNotBeNull();
            result.Email.ShouldBe("monroe86@hotmail.com");
            result.DepartmentId.ShouldBe(162);
            result.Balances.ShouldNotBeEmpty();
            result.Balances.First().Value.ShouldBe(10);
        }

        [Fact]
        public void GetPatientById_InvalidId_ThrowsApiException()
        {
            // Arrange
            var responseBody = "{\"error\": \"Invalid practice.\",\"detailedmessage\": \"The practice ID does not exist.\"}";
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.Create(responseBody, HttpStatusCode.NotFound));

            // Act
            ApiException exc = Should.Throw<ApiValidationException>(async () => await patientClient.GetPatientById(0));

            // Assert
            exc.StatusCode.ShouldBe(HttpStatusCode.NotFound);
            exc.ResponseError.ShouldBe(responseBody);
        }

        [Fact]
        public async Task EnhancedBestmatch_ValidData_ReturnsPatientsCollection()
        {
            // Arrange
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.CreateFromFile(@"Clients\Patient\EnhancedBestmatch.json"));
            var queryParameters = new EnhancedBestmatchFilter()
            {
                DateOfBirth = new DateTime(1989, 09, 07),
                FirstName = "Peter",
                LastName = "Tots",
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
            var result = await patientClient.EnhancedBestmatch(queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task EnhancedBestmatch_ValidData_ReturnsNoPatient()
        {
            // Arrange
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.Create("[]"));
            var queryParameters = new EnhancedBestmatchFilter()
            {
                DateOfBirth = new DateTime(1989, 09, 07),
                FirstName = "Peter",
                LastName = "Tots",
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
            var result = await patientClient.EnhancedBestmatch(queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Count().ShouldBe(0);
        }

        [Fact]
        public void EnhancedBestmatch_InvalidDateOfBirthFormat_ThrowsException()
        {
            // Arrange
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.CreateFromFile(@"Clients\Patient\EnhancedBestmatch_InvalidDateOfBirthFormat.json", HttpStatusCode.BadRequest));
            var queryParameters = new EnhancedBestmatchFilter()
            {
                DateOfBirth = new DateTime(01, 09, 07),
                FirstName = "Peter",
                LastName = "Tots",
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
            ApiException exception = Should.Throw<ApiException>(async () => await patientClient.EnhancedBestmatch(queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public void EnhancedBestmatch_MissingFields_ThrowsException()
        {
            // Arrange
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.CreateFromFile(@"Clients\Patient\EnhancedBestmatch_MissingFields.json", HttpStatusCode.BadRequest));
            var queryParameters = new EnhancedBestmatchFilter()
            {
                DateOfBirth = new DateTime(1989, 09, 07),
                LastName = "Tots",
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
            ApiException exception = Should.Throw<ApiException>(async () => await patientClient.EnhancedBestmatch(queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetDefaultPharmacy_ValidId_ReturnsDefaultPharmacy()
        {
            // Arrange
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.CreateFromFile(@"Clients\Patient\GetDefaultPharmacy.json", HttpStatusCode.OK));

            // Act
            var result = await patientClient.GetDefaultPharmacy(300, 1);

            // Assert
            result.ShouldNotBeNull();
            result.State.ShouldBe("NY");
            result.ClinicalProviderName.ShouldBe("Himani Shishodia");
        }

        [Fact]
        public async Task GetPreferredPharmacies_ReturnsPreferredPharmacies()
        {
            // Arrange
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.CreateFromFile(@"Clients\Patient\GetPreferredPharmacies.json", HttpStatusCode.OK));
            var queryParameters = new GetPreferredPharmacyFilter
            {
                DepartmentId = 1
            };

            // Act
            var result = await patientClient.GetPreferredPharmacies(300, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Total.ShouldBe(1);
            result.Items.ShouldNotBeNull();
            result.Items.Length.ShouldBe(1);
            result.Items[0].ClinicalProviderId.ShouldBe(11242674);
        }
    }
}
