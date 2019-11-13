using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.Integration
{
    public class PatientClientTests
    {
        [Fact]
        public async Task GetDocuments_ValidData_ReturnsDocuments()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetDocuments.json"));
            var queryParameters = new GetDocumentsFilter(1)
            {
                ShowDeleted = true,
                ShowDeclinedOrders = true
            };

            // Act
            var result = await client.GetDocuments(1, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Items.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetDocuments_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"The specified patient does not exist in that department.\",\"error\":\"The specified patient does not exist in that department.\"}", HttpStatusCode.BadRequest));
            var queryParameters = new GetDocumentsFilter(2)
            {
                ShowDeleted = true,
                ShowDeclinedOrders = true
            };

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetDocuments(1, queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetAllergies_ValidData_ReturnsAllergies()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetAllergies.json"));

            // Act
            var result = await client.GetAllergies(1, 1, true);

            // Assert
            result.ShouldNotBeNull();
            result.Allergies.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetAllergies_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"The specified patient does not exist in that department.\",\"error\":\"The specified patient does not exist in that department.\"}", HttpStatusCode.BadRequest));

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetAllergies(1, 2, true));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetSocialHistoryTemplates_ValidData_ReturnsTemplates()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetSocialHistoryTemplates.json"));

            // Act
            var result = await client.GetSocialHistoryTemplates(1, 1);

            // Assert
            result.ShouldNotBeNull();
            result.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetSocialHistoryTemplates_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"The specified patient does not exist in that department.\",\"error\":\"The specified patient does not exist in that department.\"}", HttpStatusCode.BadRequest));

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetSocialHistoryTemplates(1, 2));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetPatientEncounters_ValidData_ReturnsEncounters()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetPatientEncounters.json"));
            var queryParameters = new GetPatientEncountersFilter(1)
            {
                ShowDiagnoses = true,
                ShowAllStatuses = true,
                ShowAllTypes = true
            };

            // Act
            var result = await client.GetPatientEncounters(1, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Items.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetPatientEncounters_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"The specified patient does not exist in that department.\",\"error\":\"The specified patient does not exist in that department.\"}", HttpStatusCode.BadRequest));
            var queryParameters = new GetPatientEncountersFilter(2)
            {
                ShowDiagnoses = true,
                ShowAllStatuses = true,
                ShowAllTypes = true
            };

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetPatientEncounters(1, queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetPatientById_ValidId_ReturnsPatient()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetPatient.json"));

            // Act
            var result = await client.GetPatientById(1);

            // Assert
            result.ShouldNotBeNull();
            result.Email.ShouldBe("test@test.com");
            result.DepartmentId.ShouldBe(1);
            result.Balances.ShouldNotBeEmpty();
        }

        [Fact]
        public void GetPatientById_InvalidId_ThrowsApiException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{ \"missingfields\": [ \"patientid\" ], \"error\": \"Additional fields are required.\" }", HttpStatusCode.BadRequest));

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetPatientById(0));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetMedications_ValidData_ReturnsMedications()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetMedications.json"));
            var queryParameters = new GetMedicationsFilter(1);

            // Act
            var result = await client.GetMedications(1, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Medications.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetMedications_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"The specified patient does not exist in that department.\",\"error\":\"The specified patient does not exist in that department.\"}", HttpStatusCode.BadRequest));
            var queryParameters = new GetMedicationsFilter(1);

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetMedications(1, queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetSocialHistory_ValidData_ReturnsHistory()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetSocialHistory.json"));
            var queryParameters = new GetSocialHistoryFilter(1)
            {
                ShowUnansweredQuestions = true,
                ShowNotPerformedQuestions = true
            };

            // Act
            var result = await client.GetSocialHistory(1, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Questions.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetSocialHistory_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"The specified patient does not exist in that department.\",\"error\":\"The specified patient does not exist in that department.\"}", HttpStatusCode.BadRequest));
            var queryParameters = new GetSocialHistoryFilter(2)
            {
                ShowUnansweredQuestions = true,
                ShowNotPerformedQuestions = true
            };

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetSocialHistory(1, queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetAnalytes_ValidData_ReturnsAnalytes()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetAnalytes.json"));
            var queryParameters = new GetAnalytesFilter(1)
            {
                ShowAbnormalDetails = true,
                ShowHidden = true,
                ShowTemplate = true
            };

            // Act
            var result = await client.GetAnalytes(1, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Items.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetAnalytes_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"The specified patient does not exist in that department.\",\"error\":\"The specified patient does not exist in that department.\"}", HttpStatusCode.BadRequest));
            var queryParameters = new GetAnalytesFilter(2)
            {
                ShowAbnormalDetails = true,
                ShowHidden = true,
                ShowTemplate = true
            };

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetAnalytes(1, queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetMedicalHistory_ValidData_ReturnsMedicalHistory()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetMedicalHistory.json"));

            // Act
            var result = await client.GetMedicalHistory(1, 1);

            // Assert
            result.ShouldNotBeNull();
            result.Questions.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetMedicalHistory_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"The specified patient does not exist in that department.\",\"error\":\"The specified patient does not exist in that department.\"}", HttpStatusCode.NotFound));

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetMedicalHistory(1, 2));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task GetPrescriptions_ValidData_ReturnsPrescriptions()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetPrescriptions.json"));
            var queryParameters = new GetPrescriptionsFilter(1)
            {
                ShowDeleted = true,
                ShowDeclinedOrders = true
            };

            // Act
            var result = await client.GetPrescriptions(1, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Items.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetPrescriptions_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"The specified patient does not exist in that department.\",\"error\":\"The specified patient does not exist in that department.\"}", HttpStatusCode.BadRequest));
            var queryParameters = new GetPrescriptionsFilter(2)
            {
                ShowDeleted = true,
                ShowDeclinedOrders = true
            };

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetPrescriptions(1, queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetLabResultDetails_ValidData_ReturnsLabResult()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetLabResultDetails.json"));

            // Act
            var result = await client.GetLabResultDetails(1, 1, true);

            // Assert
            result.ShouldNotBeNull();
        }

        [Fact]
        public void GetLabResultDetails_NoResult_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"Document not found\",\"error\":\"The requested ID does not exist.\"}", HttpStatusCode.NotFound));

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetLabResultDetails(1, 22308, true));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task GetLabResults_ValidData_ReturnsLabResultCollection()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetLabResults.json"));
            var queryParameters = new GetLabResultsFilter(1)
            {
                ShowAbnormalDetails = true,
                ShowHidden = true,
                ShowTemplate = true
            };

            // Act
            var result = await client.GetLabResults(1, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Items.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetLabResults_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"error\":\"The Patient ID or Department ID is invalid.\"}", HttpStatusCode.NotFound));
            var queryParameters = new GetLabResultsFilter(2)
            {
                ShowAbnormalDetails = true,
                ShowHidden = true,
                ShowTemplate = true
            };

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetLabResults(1, queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task GetPatientProblems_ValidData_ReturnsProblemsCollection()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetPatientProblems.json"));
            var queryParameters = new GetPatientProblemsFilter(1)
            {
                ShowDiagnosisInfo = true,
                ShowInactive = true
            };

            // Act
            var result = await client.GetPatientProblems(1, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Problems.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetPatientProblems_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"error\":\"Invalid departmentid or departmentid / patientid combination.\"}", HttpStatusCode.BadRequest));
            var queryParameters = new GetPatientProblemsFilter(2)
            {
                ShowDiagnosisInfo = true,
                ShowInactive = true
            };

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetPatientProblems(1, queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetPatients_ValidData_ReturnsPatientsCollection()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetPatients.json"));
            var queryParameters = new GetPatientsFilter()
            {
                FirstName = "Michael",
                DepartmentId = 1,
                OmitBalances = false,
                OmitDefaultPharmacy = false,
                OmitPhotoInformation = false,
                Show2015EdCehrtValues = true
            };

            // Act
            var result = await client.GetPatients(queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Items.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public void GetPatients_TooMuchDataFound_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"error\":\"The given search parameters would produce a total data set larger than 1000 records.Please refine your search and try again.\"}", HttpStatusCode.BadRequest));
            var queryParameters = new GetPatientsFilter()
            {
                DepartmentId = 1,
                OmitBalances = false,
                OmitDefaultPharmacy = false,
                OmitPhotoInformation = false,
                Show2015EdCehrtValues = true
            };

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetPatients(queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public void GetPatients_InvalidFilter_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"fields\":[\"guarantorfirstname\",\"dob\",\"firstname\",\"workphone\",\"departmentid\",\"guarantorsuffix\",\"guarantorlastname\",\"mobilephone\",\"middlename\",\"suffix\",\"guarantormiddlename\",\"lastname\",\"homephone\",\"anyphone\"],\"error\":\"Data for one or more of the fields listed above are required to successfully find a patient record.Note: invalid phone numbers are ignored.\"}", HttpStatusCode.BadRequest));
            var queryParameters = new GetPatientsFilter()
            {
                OmitBalances = false,
                OmitDefaultPharmacy = false,
                OmitPhotoInformation = false,
                Show2015EdCehrtValues = true
            };

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetPatients(queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task EnhancedBestmatch_ValidData_ReturnsPatientsCollection()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\EnhancedBestmatch.json"));
            var queryParameters = new EnhancedBestmatchFilter(new DateTime(1989, 09, 07), "Peter", "Tots")
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
            var result = await client.EnhancedBestmatch(queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Count().ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task EnhancedBestmatch_ValidData_ReturnsNoPatient()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("[]"));
            var queryParameters = new EnhancedBestmatchFilter(new DateTime(1989, 09, 07), "Peter", "Tots")
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
            var result = await client.EnhancedBestmatch(queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Count().ShouldBe(0);
        }

        [Fact]
        public void EnhancedBestmatch_InvalidDateOfBirthFormat_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\EnhancedBestmatch_InvalidDateOfBirthFormat.json", HttpStatusCode.BadRequest));
            var queryParameters = new EnhancedBestmatchFilter(new DateTime(01, 09, 07), "Peter", "Tots")
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
            ApiException exception = Should.Throw<ApiException>(async () => await client.EnhancedBestmatch(queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public void EnhancedBestmatch_MissingFields_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\EnhancedBestmatch_MissingFields.json", HttpStatusCode.BadRequest));
            var queryParameters = new EnhancedBestmatchFilter(new DateTime(1989, 09, 07), "", "Tots")
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
            ApiException exception = Should.Throw<ApiException>(async () => await client.EnhancedBestmatch(queryParameters));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetDefaultPharmacy_ValidId_ReturnsDefaultPharmacy()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetDefaultPharmacy.json", HttpStatusCode.OK));

            // Act
            var result = await client.GetDefaultPharmacy(300, 1);

            // Assert
            result.ShouldNotBeNull();
            result.State.ShouldBe("NY");
            result.ClinicalProviderName.ShouldBe("Himani Shishodia");
        }

        [Fact]
        public async Task GetDefaultLaboratory_ValidId_ReturnsDefaultLaboratory()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetDefaultLaboratory.json"));

            // Act
            var result = await client.GetDefaultLaboratory(1, 1);

            // Assert
            result.ShouldNotBeNull();
        }

        [Fact]
        public void GetDefaultLaboratory_PatientInDifferentDepartment_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"detailedmessage\":\"The specified patient does not exist in that department.\",\"error\":\"The specified patient does not exist in that department.\"}", HttpStatusCode.BadRequest));

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetDefaultLaboratory(1, 2));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public void GetDefaultLaboratory_NoDefaultLaboratory_ThrowsException()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"error\":\"Default lab not found.\"}", HttpStatusCode.NotFound));

            // Act
            ApiException exception = Should.Throw<ApiException>(async () => await client.GetDefaultLaboratory(1, 2));

            // Assert
            exception.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task GetPreferredPharmacies_ReturnsPreferredPharmacies()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetPreferredPharmacies.json", HttpStatusCode.OK));
            var queryParameters = new GetPreferredPharmacyFilter(1);

            // Act
            var result = await client.GetPreferredPharmacies(300, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Total.ShouldBe(1);
            result.Items.ShouldNotBeNull();
            result.Items.Length.ShouldBe(1);
            result.Items[0].ClinicalProviderId.ShouldBe(11242674);
        }

        [Fact]
        public async Task GetPatientInsurances_ReturnsInsurances()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetPatientInsurances.json", HttpStatusCode.OK));
            var queryParameters = new GetPatientInsurancesFilter
            {
                ShowFullSSN = true,
                ShowCancelled = true
            };

            // Act
            var result = await client.GetPatientInsurances(1, queryParameters);

            // Assert
            result.ShouldNotBeNull();
            result.Total.ShouldBe(33);
            result.Items.ShouldNotBeNull();
            result.Items.Length.ShouldBe(33);
        }

        [Fact]
        public void SetDefaultPharmacy_ValidData_NotThrow()
        {
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"success\": true}", HttpStatusCode.OK));

            Should.NotThrow(async () => await client.SetDefaultPharmacy(5000, new SetPharmacyRequest(164) { ClinicalProviderId = 11242674 }));
        }

        [Fact]
        public void AddPreferredPharmacy_ValidData_NotThrow()
        {
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"success\": true}", HttpStatusCode.OK));

            Should.NotThrow(async () => await client.AddPreferredPharmacy(5000, new SetPharmacyRequest(164) { ClinicalProviderId = 11242674 }));
        }

        [Fact]
        public async Task GetPatientAppointments_ReturnsAppointments()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetPatientAppointments.json"));

            // Act
            var result = await client.GetPatientAppointments(1);

            // Assert
            result.ShouldNotBeNull();
            result.Total.ShouldBe(2205);
            result.Items.ShouldContain(a => a.PatientAppointmentTypeName == "Office Visit");
        }

        [Fact]
        public async Task AddMedication_ValidData_ReturnsCreatedId()
        {
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\AddMedication.json", HttpStatusCode.OK));

            MedicationAddedResponse response = await client.AddMedication(100, new AddMedication(1, 296232));

            response.MedicationEntryId.ShouldNotBeNullOrWhiteSpace();
            response.IsSuccess.ShouldBeTrue();
        }

        [Fact]
        public void SetMedicationSettings_ValidData_NotThrowsException()
        {
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"success\": true}", HttpStatusCode.OK));

            Should.NotThrow(async ()
                => await client.SetMedicationSettings(100, new MedicationSetting(1, "Test 123", false))
                );
        }

        [Fact]
        public void SetPatientDefaultLaboratory_NotThrowsException()
        {
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"success\": true}", HttpStatusCode.OK));

            Should.NotThrow(async () => await client.SetPatientDefaultLaboratory(1, 1, 10943173));
        }

        [Fact]
        public void SetAllergies_NotThrowsException()
        {
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"success\": true}", HttpStatusCode.OK));
            SetPatientAllergies request = new SetPatientAllergies(1)
            {
                SectionNote = "test",
                Allergies = new[]
                {
                    new SetPatientAllergies.Allergy
                    {
                        Id = 27488,
                        AllergenName = "Ala-Quin",
                        Note = "allergy test",
                        Reactions = new[]
                        {
                            new SetPatientAllergies.Allergy.Reaction()
                            {
                                ReactionName = "chest pain",
                                Severity = "moderate to severe",
                                SeveritySnomedCode = "371924009",
                                SnomedCode = "29857009"
                            }
                        }
                    }
                }
            };

            Should.NotThrow(async () => await client.SetAllergies(111, request));
        }

        [Fact]
        public async Task CreateInsurance_ValidData_ReturnsInsurance()
        {
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\CreateInsurance.json", HttpStatusCode.OK));

            Insurance response = await client.CreateInsurance(100,
                new CreateInsurance(31724, SequenceEnum.Primary, "1842", "Test1", "Test2", SexEnum.Male));

            response.InsuranceId.HasValue.ShouldBeTrue();
        }

        [Fact]
        public void DeleteInsurance_NotThrowsException()
        {
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"success\": true}", HttpStatusCode.OK));

            Should.NotThrow(async () => await client.DeleteInsurance(100, SequenceEnum.Primary));
        }

        [Fact]
        public void UpdateInsurance_NotThrowsException()
        {
            IPatientClient client = new PatientClient(ConnectionFactory.Create("{\"success\": true}", HttpStatusCode.OK));

            var insurance = new CreateInsurance(31724, SequenceEnum.Primary, "1842", "Test1", "Test2", SexEnum.Male);

            Should.NotThrow(async () => await client.UpdateInsurance(100, insurance));
        }

        [Fact]
        public async Task GetPrivacyInformation_ReturnsResult()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\GetPrivacyInformation.json", HttpStatusCode.OK));

            // Act
            var result = await client.GetPrivacyInformation(34772, 1);

            // Assert
            result.ShouldNotBeNull();
            result.NumberOfCheckboxesConfigured.ShouldBe(1);
        }

        [Fact]
        public async Task SetPrivacyInformation_ValidRequest_ReturnsPatientId()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\SetPrivacyInformation.json", HttpStatusCode.OK));

            SetPrivacyInformation request = new SetPrivacyInformation(
                1,
                new DateTime(2019, 11, 5, 14, 53, 0),
                "TestSignature"
            );

            int patientId = 34772;


            // Act
            var result = await client.SetPrivacyInformation(patientId, request);

            // Assert
            result.ShouldNotBeNull();
            result.PatientId.ShouldBe(patientId);
        }

        [Fact]
        public async Task CreateOrderGroup_ValidRequest_ReturnsEncounterId()
        {
            // Arrange
            IPatientClient client = new PatientClient(ConnectionFactory.CreateFromFile(@"Data\Patient\CreateOrderGroup.json", HttpStatusCode.OK));

            // Act
            var result = await client.CreateOrderGroup(34772, new CreateOrderGroup(1));

            // Assert
            result.ShouldNotBeNull();
            result.EncounterId.ShouldBe(36480);
        }
    }
}
