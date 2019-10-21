using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.Integration
{
    public class PracticeClientTests
    {
        [Fact]
        public async Task GetAll_ReturnsRecords()
        {
            var client = new Sdk.Clients.PracticeClient(ConnectionFactory.CreateFromFile(@"Data\Practice\GetAll.json"));

            var response = await client.GetAll();

            response.ShouldNotBeNull();
            response.Total.ShouldBeGreaterThan(0);
            response.Items.Any(x => x.Name == "athenahealth MDP Sandbox").ShouldBeTrue();
            response.Items.Any(x => x.Id == "195900").ShouldBeTrue();
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            var client = new Sdk.Clients.PracticeClient(ConnectionFactory.CreateFromFile(@"Data\Practice\GetById.json"));

            var response = await client.GetById(195900);

            response.ShouldNotBeNull();
            response.Id.ShouldBe("195900");
            response.Name.ShouldBe("athenahealth MDP Sandbox");
        }
    }
}
