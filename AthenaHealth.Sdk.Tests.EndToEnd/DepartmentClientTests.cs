using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Fixtures;
using Shouldly;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AthenaHealth.Sdk.Tests.EndToEnd
{
    public class DepartmentClientTests : IClassFixture<AthenaHealthClientFixture>
    {
        private readonly IAthenaHealthClient _client;

        public DepartmentClientTests(AthenaHealthClientFixture athenaHealthClientFixture)
        {
            _client = athenaHealthClientFixture.Client;
        }

        [Fact]
        public async Task GetAll_ReturnsRecords()
        {
            DepartmentResponse response = await _client.Departments.GetAll();

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Items.ShouldNotBe(null);
                response.Items.All(x => !x.IsHospitalDepartment).ShouldBeTrue();
                response.Items.All(x => x.ProviderList == null).ShouldBeTrue();
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_ProviderListRequested_ReturnedRecordsWithProviders()
        {
            DepartmentResponse response = await _client.Departments
                .GetAll(new GetDepartmentFilter() { ProviderList = true });

            if (response.Total > 0)
            {
                response.ShouldNotBe(null);
                response.Total.ShouldBeGreaterThan(0);
                response.Items.ShouldNotBe(null);
                response.Items.All(x => x.ProviderList.Length > 0).ShouldBeTrue();
            }
            else
            {
                response.Total.ShouldBe(0);
                response.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_ShowAllDepartments_ReturnsMoreRecords()
        {
            DepartmentResponse hiddenDepartmentResponse = await _client.Departments
                .GetAll(new GetDepartmentFilter() { ShowAllDepartments = true });

            DepartmentResponse onlyShownDepartmentResponse = await _client.Departments
                .GetAll(new GetDepartmentFilter() { ShowAllDepartments = false });

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
                .GetAll(new GetDepartmentFilter() { HospitalOnly = true });

            if (departmentResponse.Total > 0)
            {
                departmentResponse.Items.All(x => x.IsHospitalDepartment).ShouldBeTrue();
            }
            else
            {
                departmentResponse.Total.ShouldBe(0);
                departmentResponse.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetAll_LimitEqual5_ReturnsOnly5Records()
        {
            DepartmentResponse departmentResponse = await _client.Departments
                .GetAll(new GetDepartmentFilter() { Limit = 5 });

            if (departmentResponse.Total > 0)
            {
                if (departmentResponse.Total > 5)
                {
                    departmentResponse.Items.Length.ShouldBe(5);
                    departmentResponse.Total.ShouldBeGreaterThan(departmentResponse.Items.Length);
                }
                else
                {
                    departmentResponse.Total.ShouldBe(departmentResponse.Items.Length);
                }
            }
            else
            {
                departmentResponse.Total.ShouldBe(0);
                departmentResponse.Items.Length.ShouldBe(0);
            }
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            Department response = await _client.Departments.GetById(1);

            response.Name.Length.ShouldNotBeNull();
        }

        [Fact]
        public void GetById_NotExistingId_ThrowsApiException()
        {
             Should.Throw<ApiValidationException>(async () => await _client.Departments.GetById(999));
        }
    }
}
