using System.Threading.Tasks;
using System.Web;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Fixtures;
using Newtonsoft.Json;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.EndToEnd
{
    public class AppointmentClientTests : IClassFixture<AthenaHealthClientFixture>
    {
        private readonly IAthenaHealthClient _client;

        public AppointmentClientTests(AthenaHealthClientFixture athenaHealthClientFixture)
        {
            _client = athenaHealthClientFixture.Client;
        }

        [Fact]
        public async Task GetAppointmentTypes_ReturnsRecords()
        {
            AppointmentTypeResponse response = await _client.Appointments.GetAppointmentTypes();
            response.Total.ShouldBeGreaterThan(0);
            response.Items.ShouldContain(a => a.Name == "Office Visit");
        }

        [Fact]
        public async Task GetAppointmentTypes_FilterApplied_ReturnsFilteredRecords()
        {

            GetAppointmentTypeFilter filter = new GetAppointmentTypeFilter
            {
                DepartmentIds = new int[] {1, 2},
                HideNonPatient = false,
                ProviderIds = new int[] {1}
            };

            AppointmentTypeResponse response = await _client.Appointments.GetAppointmentTypes(filter);
            response.Total.ShouldBeGreaterThan(0);
            response.Items.ShouldContain(a => a.Name == "Office Visit");
        }
    }
}
