using AthenaHealth.Sdk.Clients;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Integration
{
    public class DepartmentClientTests
    {
        [Fact]
        public async Task GetAll_ReturnsRecords()
        {
            IDepartmentClient client = new DepartmentClient(ConnectionFactory.CreateFromFile(@"Data\Department\GetAll_Extended.json"));

            var departmentResponse = await client.GetAll();

            departmentResponse.ShouldNotBeNull();
            departmentResponse.Total.ShouldBe(31);

            Department mdCallDepartment = departmentResponse.Items.First(x => x.Name == "MD CALL");
            mdCallDepartment.City.ShouldBe("SAUGUS");
            mdCallDepartment.Id.ShouldBe("155");
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            IDepartmentClient client = new DepartmentClient(ConnectionFactory.CreateFromFile(@"Data\Department\GetById_ExistingId.json"));

            var departmentResponse = await client.GetById(1);

            departmentResponse.ShouldNotBeNull();
            departmentResponse.Id.ShouldBe("1");
            departmentResponse.Name.ShouldBe("MAIN ST (HUB)");
            departmentResponse.Address.ShouldBe("8762 STONERIDGE CT");
            departmentResponse.City.ShouldBe("CLAXTON");
        }

        [Fact]
        public async Task SearchFacilities_ReturnsRecords()
        {
            IDepartmentClient client = new DepartmentClient(ConnectionFactory.CreateFromFile(@"Data\Department\SearchFacilities.json"));

            var filter = new SearchFacilitiesFilter(1, "Labcorp", OrderTypeEnum.DurableMedicalEquipment);
            var response = await client.SearchFacilities(filter);

            response.ShouldNotBeNull();
            response.Length.ShouldBeGreaterThan(0);
            response.Any(x => x.Id == 12352190).ShouldBeTrue();
            response.Any(x => x.Id == 12492021).ShouldBeTrue();
            response.All(x => x.Id > 0).ShouldBeTrue();
            response.All(x => !string.IsNullOrWhiteSpace(x.Name)).ShouldBeTrue();
        }
    }
}
