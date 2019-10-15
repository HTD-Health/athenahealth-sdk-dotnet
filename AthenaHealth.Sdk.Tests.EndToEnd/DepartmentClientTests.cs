using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Integration.EndToEnd
{
    public class DepartmentClientTests
    {
        private readonly IAthenaHealthClient _client;
        public DepartmentClientTests()
        {
            _client = new AthenaHealthClient(ApiVersion.Preview, "6yspwuq3wnx5n37jp9phqsmt", "Y9UxkbBge5EXutR", 195900);
        }

        [Fact]
        public async Task GetAll_ReturnsRecords()
        {
            DepartmentResponse response = await _client.Departments.GetAll(195900);

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Departments.ShouldNotBe(null);
                response.Departments.All(x => !x.IsHospitalDepartment).ShouldBeTrue();
                response.Departments.All(x => x.ProviderList == null).ShouldBeTrue();
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Departments.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_ProviderListRequested_ReturnedRecordsWithProviders()
        {
            DepartmentResponse response = await _client.Departments
                .GetAll(195900, new GetDepartmentFilter() { ProviderList = true });

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Departments.ShouldNotBe(null);
                response.Departments.All(x => x.ProviderList.Length > 0).ShouldBeTrue();
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Departments.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_ShowAllDepartments_ReturnsMoreRecords()
        {
            DepartmentResponse hiddenDepartmentResponse = await _client.Departments
                .GetAll(195900, new GetDepartmentFilter() { ShowAllDepartments = true });

            DepartmentResponse onlyShownDepartmentResponse = await _client.Departments
                .GetAll(195900, new GetDepartmentFilter() { ShowAllDepartments = false });

            if (hiddenDepartmentResponse.Total > 0 && onlyShownDepartmentResponse.Total > 0)
            {
                hiddenDepartmentResponse.Total.ShouldBeGreaterThan(onlyShownDepartmentResponse.Total);
            }
            else
            {
                hiddenDepartmentResponse.Total.ShouldBe(onlyShownDepartmentResponse.Total);
            }
        }

        [Fact]
        public async Task GetAll_HospitalOnly_ReturnsOnlyHospitalDepartments()
        {
            DepartmentResponse departmentResponse = await _client.Departments
                .GetAll(195900, new GetDepartmentFilter() { HospitalOnly = true });

            if (departmentResponse.Total > 0)
            {
                departmentResponse.Departments.All(x => x.IsHospitalDepartment).ShouldBeTrue();
            }
            else
            {
                departmentResponse.Total.ShouldBe(0);
                departmentResponse.Departments.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_LimitEqual5_ReturnsOnly5Records()
        {
            DepartmentResponse departmentResponse = await _client.Departments
                .GetAll(195900, new GetDepartmentFilter() { Limit = 5 });

            if (departmentResponse.Total > 0)
            {
                if (departmentResponse.Total > 5)
                {
                    departmentResponse.Departments.Length.ShouldBe(5);
                    departmentResponse.Total.ShouldBeGreaterThan(departmentResponse.Departments.Length);
                }
                else
                {
                    departmentResponse.Total.ShouldBe(departmentResponse.Departments.Length);
                }
            }
            else
            {
                departmentResponse.Total.ShouldBe(0);
                departmentResponse.Departments.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            Department response = await _client.Departments.GetById(195900, 1);

            response.Name.Length.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetById_NotExistingId_ThrowsApiException()
        {
            await Assert.ThrowsAsync<ApiValidationException>(() => _client.Departments.GetById(195900, 999));
        }
    }
}
