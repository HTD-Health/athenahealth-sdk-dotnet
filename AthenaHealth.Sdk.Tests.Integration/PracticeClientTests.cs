using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.Integration
{
    public class PracticeClientTests
    {
        [Fact]
        public async Task GetAll_ReturnsRecords()
        {
            IPracticeClient client = new PracticeClient(ConnectionFactory.CreateFromFile(@"Data\Practice\GetAll.json"));

            var response = await client.GetAll();

            response.ShouldNotBeNull();
            response.Total.ShouldBeGreaterThan(0);
            response.Items.Any(x => x.Name == "athenahealth MDP Sandbox").ShouldBeTrue();
            response.Items.Any(x => x.Id == "195900").ShouldBeTrue();
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            IPracticeClient client = new PracticeClient(ConnectionFactory.CreateFromFile(@"Data\Practice\GetById.json"));

            var response = await client.GetById(195900);

            response.ShouldNotBeNull();
            response.Id.ShouldBe("195900");
            response.Name.ShouldBe("athenahealth MDP Sandbox");
        }

        [Fact]
        public async Task HasAccess_ReturnsTrue()
        {
            IPracticeClient client = new PracticeClient(ConnectionFactory.Create("{\"pong\":true}"));

            bool response = await client.HasAccess(195900);

            response.ShouldBeTrue();
        }

        [Fact]
        public void HasAccess_NotExistingPractice_ThrowsException()
        {
            IPracticeClient client = new PracticeClient(ConnectionFactory.Create("{\"error\":\"Invalid practice.\",\"detailedmessage\":\"The practice ID does not exist.\"}", HttpStatusCode.NotFound));

            ApiValidationException exception = Should.Throw<ApiValidationException>(async () => await client.HasAccess(2));

            exception.StatusCode.ShouldBe(HttpStatusCode.NotFound);
            exception.Message.ShouldContain("The practice ID does not exist.");
        }

        [Fact]
        public void HasAccess_UnauthorizedAccess_ThrowsException()
        {
            IPracticeClient client = new PracticeClient(ConnectionFactory.Create("{\"detailedmessage\":\"Bad auth.\",\"error\":\"Incorrect permissions.\"}", HttpStatusCode.Unauthorized));

            ApiValidationException exception = Should.Throw<ApiValidationException>(async () => await client.HasAccess(195901));

            exception.StatusCode.ShouldBe(HttpStatusCode.Unauthorized);
            exception.Message.ShouldContain("Incorrect permissions.");
        }

        [Fact]
        public async Task GetEmployers_ReturnsRecords()
        {
            IPracticeClient client = new PracticeClient(ConnectionFactory.CreateFromFile(@"Data\Practice\GetEmployers.json"));

            var response = await client.GetEmployers();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }
    }
}
