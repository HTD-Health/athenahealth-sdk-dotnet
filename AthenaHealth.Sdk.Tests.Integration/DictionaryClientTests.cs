using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.Integration
{
    public class DictionaryClientTests
    {
        [Fact]
        public async Task GetProviderTypes_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetProviderTypes.json"));

            var response = await client.GetProviderTypes();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetPaymentMethods_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetPaymentMethods.json"));

            var response = await client.GetPaymentMethods();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetMedicalHistoryQuestions_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetMedicalHistoryQuestions.json"));

            var response = await client.GetMedicalHistoryQuestions(new GetMedicalHistoryQuestionsFilter()
            {
                ShowDeleted = true
            });

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetSocialHistoryTemplates_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetSocialHistoryTemplates.json"));

            var response = await client.GetSocialHistoryTemplates();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task SearchOrderTypesByName_TwoDigitsNamePart_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\SearchOrderTypesByName.json"));

            OrderType[] response = await client.SearchOrderTypesByName("ol");

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.Any(x => x.Id == 421861).ShouldBeTrue();
            response.Any(x => x.Name == "oligoclonal bands, csf").ShouldBeTrue();
            response.Any(x => x.Id == 344746).ShouldBeTrue();
        }

        [Fact]
        public async Task SearchMedicationsByName_TwoDigitsNamePart_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\SearchMedicationsByName.json"));

            var response = await client.SearchMedicationsByName("ol");

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.Any(x => x.Id == 296232).ShouldBeTrue();
            response.Any(x => x.Name == "OLANZapine").ShouldBeTrue();
            response.Any(x => x.Id == 247373).ShouldBeTrue();
        }

        [Fact]
        public async Task SearchAllergiesByName_TwoDigitsNamePart_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\SearchAllergiesByName.json"));

            var response = await client.SearchAllergiesByName("ol");

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.Any(x => x.Id == 16818).ShouldBeTrue();
            response.Any(x => x.Name == "olaparib").ShouldBeTrue();
            response.Any(x => x.Id == 91387).ShouldBeTrue();
        }

        [Fact]
        public async Task GetEthnicities_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetEthnicities.json"));

            var response = await client.GetEthnicities();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetLanguages_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetLanguages.json"));

            var response = await client.GetLanguages();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetRaces_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetRaces.json"));

            var response = await client.GetRaces();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetStates_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetStates.json"));

            var response = await client.GetStates();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetPatientLocations_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetPatientLocations.json"));

            var response = await client.GetPatientLocations();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetGenderIdentities_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetGenderIdentities.json"));

            var response = await client.GetGenderIdentities();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetCustomFields_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetCustomFields.json"));

            var response = await client.GetCustomFields();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetMobileCarriers_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetMobileCarriers.json"));

            var response = await client.GetMobileCarriers();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetAllergyReactions_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetAllergyReactions.json"));

            var response = await client.GetAllergyReactions();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetAllergySeverities_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetAllergySeverities.json"));

            var response = await client.GetAllergySeverities();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetSlidingFeePlans_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetSlidingFeePlans.json"));

            var response = await client.GetSlidingFeePlans();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetVitals_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetVitals.json"));

            var response = await client.GetVitals();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetSpecialties_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetSpecialties.json"));

            var response = await client.GetSpecialties();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetChartSharingGroups_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetChartSharingGroups.json"));

            var response = await client.GetChartSharingGroups();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.ShouldAllBe(x => x.Id != 0);
        }

        [Fact]
        public async Task GetCommunicatorBrands_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetCommunicatorBrands.json"));

            var response = await client.GetCommunicatorBrands();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetOfficeOrderTypes_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetOfficeOrderTypes.json"));

            var response = await client.GetOfficeOrderTypes();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task GetOrderSets_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetOrderSets.json"));

            var response = await client.GetOrderSets();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetReferringProviders_ReturnsRecords()
        {
            IDictionaryClient client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetReferringProviders.json"));

            var response = await client.GetReferringProviders();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }
    }
}
