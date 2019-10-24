﻿using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.Integration
{
    public class OrderTypeClientTests
    {
        [Fact]
        public async Task Search_TwoDigitsNamePart_ReturnsRecords()
        {
            var client = new OrderTypeClient(ConnectionFactory.CreateFromFile(@"Data\OrderType\Search.json"));

            OrderType[] response = await client.SearchByName("ol");

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.Any(x => x.Id == 421861).ShouldBeTrue();
            response.Any(x => x.Name == "oligoclonal bands, csf").ShouldBeTrue();
            response.Any(x => x.Id == 344746).ShouldBeTrue();
        }
    }
}
