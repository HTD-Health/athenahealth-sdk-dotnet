using AthenaHealth.Sdk.Clients;
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
            var client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetProviderTypes.json"));

            var response = await client.GetProviderTypes();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetPaymentMethods_ReturnsRecords()
        {
            var client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetPaymentMethods.json"));

            var response = await client.GetPaymentMethods();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }

        [Fact]
        public async Task GetMedicalHistoryQuestions_ReturnsRecords()
        {
            var client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetMedicalHistoryQuestions.json"));

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
            var client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\GetSocialHistoryTemplates.json"));

            var response = await client.GetSocialHistoryTemplates();

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task SearchOrderTypesByName_TwoDigitsNamePart_ReturnsRecords()
        {
            var client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\SearchOrderTypesByName.json"));

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
            var client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\SearchMedicationsByName.json"));

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
            var client = new DictionaryClient(ConnectionFactory.CreateFromFile(@"Data\Dictionary\SearchAllergiesByName.json"));

            var response = await client.SearchAllergiesByName("ol");

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.Any(x => x.Id == 16818).ShouldBeTrue();
            response.Any(x => x.Name == "olaparib").ShouldBeTrue();
            response.Any(x => x.Id == 91387).ShouldBeTrue();
        }
    }
}
