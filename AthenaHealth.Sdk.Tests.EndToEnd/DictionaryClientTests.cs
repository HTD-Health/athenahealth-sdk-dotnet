using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Fixtures;
using Shouldly;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.EndToEnd
{
    public class DictionaryClientTests : IClassFixture<AthenaHealthClientFixture>
    {
        private readonly IAthenaHealthClient _client;

        public DictionaryClientTests(AthenaHealthClientFixture athenaHealthClientFixture)
        {
            _client = athenaHealthClientFixture.Client;
        }

        [Fact]
        public async Task GetSocialHistoryTemplates_ReturnsRecords()
        {
            SocialHistoryTemplate[] response = await _client.Dictionaries.GetSocialHistoryTemplates();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetMedicalHistoryQuestions_ShowDeleted_ReturnsRecords()
        {
            MedicalHistoryQuestionResponse response = await _client.Dictionaries.GetMedicalHistoryQuestions(new GetMedicalHistoryQuestionsFilter()
            {
                ShowDeleted = true
            });

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Items.ShouldAllBe(x => x.QuestionId != 0);
        }

        [Fact]
        public async Task SearchOrderTypesByName_TwoDigitsName_ReturnsRecords()
        {
            OrderType[] response = await _client.Dictionaries.SearchOrderTypesByName("ol");

            response.Length.ShouldBeGreaterThan(0);
            response.All(x => !string.IsNullOrWhiteSpace(x.Name)).ShouldBeTrue();
            response.All(x => x.Id > 0).ShouldBeTrue();
        }

        [Fact]
        public async Task SearchOrderTypesByName_OneDigitName_ReturnsApiValidationException()
        {
            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Dictionaries.SearchOrderTypesByName("o")
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("Search value must contain at least 2 characters");
        }

        [Fact]
        public async Task SearchOrderTypesByName_NullName_ReturnsApiValidationException()
        {
            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Dictionaries.SearchOrderTypesByName(null)
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("missingfields");
        }

        [Fact]
        public async Task SearchMedicationsByName_TwoDigitsName_ReturnsRecords()
        {
            Medication[] response = await _client.Dictionaries.SearchMedicationsByName("ol");

            response.Length.ShouldBeGreaterThan(0);
            response.All(x => !string.IsNullOrWhiteSpace(x.Name)).ShouldBeTrue();
            response.All(x => x.Id > 0).ShouldBeTrue();
        }

        [Fact]
        public async Task SearchMedicationsByName_OneDigitName_ReturnsApiValidationException()
        {
            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Dictionaries.SearchMedicationsByName("o")
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("Search term must be at least 2 characters in length");
        }

        [Fact]
        public async Task SearchMedicationsByName_NullName_ReturnsApiValidationException()
        {
            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Dictionaries.SearchMedicationsByName(null)
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("missingfields");
        }

        [Fact]
        public async Task SearchAllergiesByName_TwoDigitsName_ReturnsRecords()
        {
            Allergy[] response = await _client.Dictionaries.SearchAllergiesByName("ol");

            response.Length.ShouldBeGreaterThan(0);
            response.All(x => !string.IsNullOrWhiteSpace(x.Name)).ShouldBeTrue();
            response.All(x => x.Id > 0).ShouldBeTrue();
        }

        [Fact]
        public async Task SearchAllergiesByName_OneDigitName_ReturnsApiValidationException()
        {
            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Dictionaries.SearchAllergiesByName("o")
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("Search term must be at least 2 characters in length");
        }

        [Fact]
        public async Task SearchAllergiesByName_NullName_ReturnsApiValidationException()
        {
            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Dictionaries.SearchAllergiesByName(null)
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("missingfields");
        }

        [Fact]
        public async Task GetProviderTypes_ReturnsRecords()
        {
            ProviderTypeResponse response = await _client.Dictionaries.GetProviderTypes();

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
        public async Task GetPaymentMethods_ReturnsRecords()
        {
            PaymentMethodResponse response = await _client.Dictionaries.GetPaymentMethods();

            if (response.Total > 0)
            {
                response.Total.ShouldBe(response.Items.Length);
                response.Items.Count(x => string.IsNullOrWhiteSpace(x.IdentifierName)).ShouldBe(0);
                response.Items.Count(x => string.IsNullOrWhiteSpace(x.Name)).ShouldBe(0);
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetEthnicities_ReturnsRecords()
        {
            Ethnicity[] response = await _client.Dictionaries.GetEthnicities();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }


        [Fact]
        public async Task GetLanguages_ReturnsRecords()
        {
            Language[] response = await _client.Dictionaries.GetLanguages();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetRaces_ReturnsRecords()
        {
            Race[] response = await _client.Dictionaries.GetRaces();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }


        [Fact]
        public async Task GetStates_ReturnsRecords()
        {
            State[] response = await _client.Dictionaries.GetStates();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetPatientLocations_ReturnsRecords()
        {
            PatientLocation[] response = await _client.Dictionaries.GetPatientLocations();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetGenderIdentities_ReturnsRecords()
        {
            GenderIdentityResponse response = await _client.Dictionaries.GetGenderIdentities();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetCustomFields_ReturnsRecords()
        {
            CustomField[] response = await _client.Dictionaries.GetCustomFields();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetMobileCarriers_ReturnsRecords()
        {
            MobileCarrier[] response = await _client.Dictionaries.GetMobileCarriers();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetAllergyReactions_ReturnsRecords()
        {
            AllergyReaction[] response = await _client.Dictionaries.GetAllergyReactions();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetAllergySeverities_ReturnsRecords()
        {
            AllergySeverity[] response = await _client.Dictionaries.GetAllergySeverities();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetSlidingFeePlans_ReturnsRecords()
        {
            SlidingFeePlanResponse response = await _client.Dictionaries.GetSlidingFeePlans();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetVitals_ReturnsRecords()
        {
            VitalResponse response = await _client.Dictionaries.GetVitals();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetSpecialties_ReturnsRecords()
        {
            SpecialtyResponse response = await _client.Dictionaries.GetSpecialties();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetChartSharingGroups_ReturnsRecords()
        {
            ChartSharingGroup[] response = await _client.Dictionaries.GetChartSharingGroups();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetCommunicatorBrands_ReturnsRecords()
        {
            CommunicatorBrandResponse response = await _client.Dictionaries.GetCommunicatorBrands();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Items.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetOfficeOrderTypes_ReturnsRecords()
        {
            OfficeOrderType[] response = await _client.Dictionaries.GetOfficeOrderTypes();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetOrderSets_ReturnsRecords()
        {
            OrderSetResponse response = await _client.Dictionaries.GetOrderSets();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Items.ShouldAllBe(x => x.Id != 0);
        }
    }
}
