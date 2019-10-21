﻿using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Integration
{
    public class ProviderClientTests
    {
        [Fact]
        public async Task GetAll_ReturnsRecords()
        {
            var client = new ProviderClient(ConnectionFactory.CreateFromFile(@"Data\Provider\GetAll.json"));

            var response = await client.GetAll();

            response.ShouldNotBeNull();
            response.Total.ShouldBeGreaterThan(0);
            response.Items.Any(x => x.FirstName == "Terry").ShouldBeTrue();
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            var client = new ProviderClient(ConnectionFactory.CreateFromFile(@"Data\Provider\GetById.json"));

            var response = await client.GetById(86);

            response.ShouldNotBeNull();
            response.Id.ShouldBe("86");
            response.FirstName.ShouldBe("Terry");
        }

        [Fact]
        public async Task GetProviderTypes_ReturnsRecords()
        {
            var client = new ProviderClient(ConnectionFactory.CreateFromFile(@"Data\Provider\GetProviderTypes.json"));

            var response = await client.GetProviderTypes();

            response.ShouldNotBeNull();
            response.Items.Length.ShouldBeGreaterThan(0);
            response.Total.ShouldBe(response.Items.Length);
        }
    }
}