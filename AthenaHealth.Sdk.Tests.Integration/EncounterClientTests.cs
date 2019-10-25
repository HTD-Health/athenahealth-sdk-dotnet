using System;
using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using Xunit;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.Integration
{
    public class EncounterClientTests
    {
        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            IEncounterClient client = new EncounterClient(ConnectionFactory.CreateFromFile(@"Data\Encounter\GetById.json"));

            var response = await client.GetById(1);

            response.ShouldNotBeNull();
            response.Id.ShouldBe(1);
            response.Stage.ShouldBe("INTAKE");
            response.Status.ShouldBe("TEMP");
            response.EncounterDate.Date.ShouldBe(new DateTime(2009, 04, 02));
        }

        [Fact]
        public async Task GetSummary_ExistingId_ReturnsRecord()
        {
            IEncounterClient client = new EncounterClient(ConnectionFactory.CreateFromFile(@"Data\Encounter\GetSummary.json"));

            var response = await client.GetSummary(1);

            response.ShouldNotBeNull();
            response.Html.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetDiagnoses_ExistingId_ReturnsRecords()
        {
            IEncounterClient client = new EncounterClient(ConnectionFactory.CreateFromFile(@"Data\Encounter\GetDiagnoses.json"));

            var response = await client.GetDiagnoses(1);

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.Any(x => x.Id == 14453).ShouldBeTrue();
            response.Any(x => x.Id == 14452).ShouldBeTrue();
        }

        [Fact]
        public async Task CreateDiagnoses_ValidModel_NotThrowsException()
        {
            IEncounterClient client = new EncounterClient(ConnectionFactory.CreateFromFile(@"Data\Encounter\CreateDiagnoses.json"));

            await client.CreateDiagnoses(999, new CreateDiagnoses()
            {
                SnomedCode = 52967002
            });
        }

        [Fact]
        public void DeleteDiagnoses_ExistingId_ReturnsSuccess()
        {
            IEncounterClient client = new EncounterClient(ConnectionFactory.Create(@"{ ""success"": true }"));

            Should.NotThrow(async () => await client.DeleteDiagnoses(183, 15548));
        }

        [Fact]
        public async Task CreateOrderLab_ValidModel_NotThrowsException()
        {
            IEncounterClient client = new EncounterClient(ConnectionFactory.Create(@"{""success"": true, ""documentid"": 186347}"));

            OrderLab response = await client.CreateOrderLab(999, new CreateOrderLab(353034, 52967002));

            response.DocumentId.ShouldBe(186347);
        }
    }
}
