using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Integration.Clients.Department
{
    public class DepartmentClientTests
    {
        [Fact]
        public async Task GetAll_ValidPractice_ReturnsDepartments()
        {
            var departmentClient = new Sdk.Clients.DepartmentClient(ConnectionFactory.CreateFromFile(@"Clients\Department\GetAll_Extended.json"));

            DepartmentResponse departmentResponse = await departmentClient.GetAll();

            departmentResponse.ShouldNotBeNull();
            departmentResponse.Total.ShouldBe(31);

            Models.Response.Department mdCallDepartment = departmentResponse.Items.First(x => x.Name == "MD CALL");
            mdCallDepartment.City.ShouldBe("SAUGUS");
            mdCallDepartment.Id.ShouldBe("155");
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsDepartment()
        {
            var departmentClient = new Sdk.Clients.DepartmentClient(ConnectionFactory.CreateFromFile(@"Clients\Department\GetById_ExistingId.json"));

            var departmentResponse = await departmentClient.GetById(1);

            departmentResponse.ShouldNotBeNull();
            departmentResponse.Id.ShouldBe("1");
            departmentResponse.Name.ShouldBe("MAIN ST (HUB)");
            departmentResponse.Address.ShouldBe("8762 STONERIDGE CT");
            departmentResponse.City.ShouldBe("CLAXTON");
        }
    }
}
