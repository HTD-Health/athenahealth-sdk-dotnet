using System;
using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Fixtures;
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
                DepartmentIds = new int[] { 1, 2 },
                HideNonPatient = false,
                ProviderIds = new int[] { 1 }
            };

            AppointmentTypeResponse response = await _client.Appointments.GetAppointmentTypes(filter);

            response.Total.ShouldBeGreaterThan(0);
            response.Items.ShouldContain(a => a.Name == "Office Visit");
        }

        [Fact]
        public async Task GetAppointmentType_ValidId_ReturnsAppointmentType()
        {
            AppointmentType appointmentType = await _client.Appointments.GetAppointmentType(622);

            appointmentType.ShouldNotBeNull();
            appointmentType.Name.ShouldNotBeNullOrEmpty();
        }

        [Fact]
        public async Task GetAppointmentType_InvalidId_ThrowException()
        {
            await Should.ThrowAsync<ApiValidationException>(async () => await _client.Appointments.GetAppointmentType(5000000));
        }

        [Fact]
        public async Task GetBookedAppointments_SingleDepartment_ReturnsRecords()
        {
            GetBookedAppointmentsFilter filter = new GetBookedAppointmentsFilter
            {
                StartDate = new DateTime(2019, 01, 01),
                EndDate = new DateTime(2019, 02, 01),
                DepartmentIds = new[] { 1 },
                ShowClaimDetail = true,
                ShowExpectedProcedureCodes = true,
                ShowCopay = true,
                ShowPatientDetail = true,
                ShowInsurance = true,
                ShowReminderCallDetail = true
            };

            AppointmentResponse response = await _client.Appointments.GetBookedAppointments(filter);

            response.Items.ShouldNotBeNull();
            response.Items.ShouldContain(a => a.DepartmentId.HasValue);
            response.Items.ShouldContain(a=>a.Date != null);
            response.Items.First().AppointmentStatus.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetBookedAppointments_MultipleDepartments_ReturnsRecords()
        {
            GetBookedAppointmentsFilter filter = new GetBookedAppointmentsFilter
            {
                StartDate = new DateTime(2019, 01, 01),
                EndDate = new DateTime(2019, 02, 01),
                DepartmentIds = new[] { 1, 21 },
                ShowClaimDetail = true,
                ShowExpectedProcedureCodes = true,
                ShowCopay = true,
                ShowPatientDetail = true,
                ShowInsurance = true,
                ShowReminderCallDetail = true
            };

            AppointmentResponse response = await _client.Appointments.GetBookedAppointments(filter);

            response.Items.ShouldNotBeNull();
            response.Items.ShouldContain(a => a.DepartmentId == 1);
            response.Items.ShouldContain(a => a.DepartmentId == 21);
        }

        [Fact]
        public async Task GetAppointmentById_ValidId_ReturnsAppointment()
        {
            GetAppointmentFilter filter = new GetAppointmentFilter
            {
                ShowClaimDetail = true,
                ShowExpectedProcedureCodes = true,
                ShowCopay = true,
                ShowPatientDetail = true,
                ShowInsurance = true,
            };

            Appointment appointment = await _client.Appointments.GetAppointmentById(997681, filter);

            appointment.ShouldNotBeNull();
            appointment.DepartmentId.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetAppointmentById_InvalidId_ThrowsException()
        {
            await Should.ThrowAsync<ApiException>(async ()=> await _client.Appointments.GetAppointmentById(0));
        }

    }
}
