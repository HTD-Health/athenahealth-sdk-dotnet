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
using System.Diagnostics;
using System.Net;

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

        [Theory]
        [ClassData(typeof(GetDocumentsData))]
        public async Task GetDocuments_DocumentsExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetDocuments(patientId, new GetDocumentsFilter()
            {
                DepartmentId = 1,
                ShowDeclinedOrders = true,
                ShowDeleted = true
            });

            // Assert
            result.ShouldNotBeNull();
            result.Items.Count().ShouldBeGreaterThan(0);
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
        [ClassData(typeof(GetAllergiesData))]
        public async Task GetAllergies_ResultsExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetAllergies(patientId, 1, true);

            // Assert
            result.ShouldNotBeNull();
            result.Allergies.Count().ShouldBeGreaterThan(0);
        }

        [Theory]
        [ClassData(typeof(GetSocialHistoryData))]
        public async Task GetSocialHistory_HistoryExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetSocialHistory(patientId, new GetSocialHistoryFilter()
            {
                DepartmentId = 1,
                ShowNotPerformedQuestions = true,
                ShowUnansweredQuestions = true
            });

            // Assert
            result.ShouldNotBeNull();
            result.Questions.Length.ShouldBeGreaterThan(0);
        }

        [Theory]
        [ClassData(typeof(GetDefaultLaboratoryData))]
        public async Task GetDefaultLaboratory_LaboratoryExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetDefaultLaboratory(patientId, 1);

            // Assert
            result.ShouldNotBeNull();
        }

        [Fact]
        public void GetDefaultLaboratory_NotExistingLaboratory_ThrowsException()
        {
            // Arrange
            // Act
            // Assert
            var exception = Should.Throw<ApiValidationException>(async () => await _client.Patients.GetDefaultLaboratory(10054, 1));

            exception.Message.ShouldContain("Default lab not found.");
            exception.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        }

        [Theory]
        [ClassData(typeof(GetPatientInsurancesData))]
        public async Task GetPatientInsurances_InsurancesExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetPatientInsurances(patientId, new GetPatientInsurancesFilter()
            {
                ShowCancelled = true,
                ShowFullSSN = true
            });

            // Assert
            result.ShouldNotBeNull();
            result.Items.Length.ShouldBeGreaterThan(0);
        }

        [Theory]
        [ClassData(typeof(GetPatientEncountersData))]
        public async Task GetPatientEncounters_EncountersExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetPatientEncounters(patientId, new GetPatientEncountersFilter()
            {
                DepartmentId = 1,
                ShowAllStatuses = true,
                ShowAllTypes = true,
                ShowDiagnoses = true
            });

            // Assert
            result.ShouldNotBeNull();
            result.Items.Length.ShouldBeGreaterThan(0);
        }

        [Theory]
        [ClassData(typeof(GetSocialHistoryTemplatesData))]
        public async Task GetSocialHistoryTemplates_TemplateExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetSocialHistoryTemplates(patientId, 1);

            // Assert
            result.ShouldNotBeNull();
            result.Length.ShouldBeGreaterThan(0);
        }

        [Theory]
        [ClassData(typeof(GetMedicalHistoryData))]
        public async Task GetMedicalHistory_ResultsExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetMedicalHistory(patientId, 1);

            // Assert
            result.ShouldNotBeNull();
            result.Questions.Length.ShouldBeGreaterThan(0);
        }

        [Theory]
        [ClassData(typeof(GetMedicationsData))]
        public async Task GetMedications_MedicationsExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetMedications(patientId, new GetMedicationsFilter()
            {
                DepartmentId = 1
            });

            // Assert
            result.ShouldNotBeNull();
            result.Medications.Length.ShouldBeGreaterThan(0);
        }

        [Theory]
        [ClassData(typeof(GetPrescriptionsData))]
        public async Task GetPrescriptions_PrescriptionsExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetPrescriptions(patientId, new GetPrescriptionsFilter()
            {
                DepartmentId = 1,
                ShowDeclinedOrders = true,
                ShowDeleted = true
            });

            // Assert
            result.ShouldNotBeNull();
            result.Items.Length.ShouldBeGreaterThan(0);
        }

        [Theory]
        [ClassData(typeof(GetLabResultsData))]
        public async Task GetLabResults_ResultsExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetLabResults(patientId, new GetLabResultsFilter()
            {
                DepartmentId = 1,
                ShowAbnormalDetails = true,
                ShowHidden = true,
                ShowTemplate = true
            });

            // Assert
            result.ShouldNotBeNull();
            result.Items.Length.ShouldBeGreaterThan(0);
        }

        [Theory]
        [ClassData(typeof(GetOrdersData))]
        public async Task GetAnalytes_AnalytesExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetAnalytes(patientId, new GetAnalytesFilter()
            {
                DepartmentId = 1,
                ShowAbnormalDetails = true,
                ShowHidden = true,
                ShowTemplate = true
            });

            // Assert
            result.ShouldNotBeNull();
            result.Items.Length.ShouldBeGreaterThan(0);
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
        [ClassData(typeof(GetPatientsData))]
        public async Task GetPatients_SearchByFirstName_ShouldNotThrowJsonSerializationException(string firstName, int offset)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetPatients(new GetPatientsFilter()
            {
                FirstName = firstName,
                DepartmentId = 1,
                Offset = offset,
                OmitBalances = false,
                OmitDefaultPharmacy = false,
                OmitPhotoInformation = false,
                Show2015EdCehrtValues = true
            });

            // Assert
            result.ShouldNotBeNull();
        }

        [Theory]
        [ClassData(typeof(GetPatientProblemsData))]
        public async Task GetPatientProblems_PatientExists_ShouldNotThrowJsonSerializationException(int patientId)
        {
            // Arrange
            // Act
            var result = await _client.Patients.GetPatientProblems(patientId, new GetPatientProblemsFilter()
            {
                DepartmentId = 1,
                ShowDiagnosisInfo = true,
                ShowInactive = true
            });

            // Assert
            result.ShouldNotBeNull();
            result.Problems.Length.ShouldBeGreaterThan(0);
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
        public async Task AddPreferredPharmacy_ValidData_NotThrow()
        {
            await _client.Patients.AddPreferredPharmacy(5000,
                new SetPharmacyRequest {DepartmentId = 164, ClinicalProviderId = 11242674});
            Should.NotThrow(async () => await _client.Patients.AddPreferredPharmacy(5000, new SetPharmacyRequest{DepartmentId = 164, ClinicalProviderId = 11242674}));
        }
    }
}
