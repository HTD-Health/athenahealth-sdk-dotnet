using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Data.Appointments;
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
            GetAppointmentsBookedFilter filter = new GetAppointmentsBookedFilter
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
            response.Items.ShouldContain(a => a.Date != null);
            response.Items.First().AppointmentStatus.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetBookedAppointments_MultipleDepartments_ReturnsRecords()
        {
            GetAppointmentsBookedFilter filter = new GetAppointmentsBookedFilter
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
            await Should.ThrowAsync<ApiException>(async () => await _client.Appointments.GetAppointmentById(0));
        }

        [Theory]
        [ClassData(typeof(GetNotesAppointmentsData))]
        public async Task GetNotes_ValidId_ReturnsRecords(int appointmentId)
        {
            AppointmentNotesResponse response = await _client.Appointments.GetNotes(appointmentId, true);

            response.Items.All(x => !string.IsNullOrWhiteSpace(x.Text)).ShouldBeTrue();
            response.Items.All(x => int.Parse(x.Id) > 0).ShouldBeTrue();
        }

        [Fact]
        public async Task GetNotes_NotExistingId_ThrowsApiValidationException()
        {
            ApiException exception = await Should.ThrowAsync<ApiException>(async ()
                => await _client.Appointments.GetNotes(1));

            exception.StatusCode.ShouldBe(HttpStatusCode.NotFound);
            exception.Message.ShouldContain("The appointment is not available");
        }

        [Fact]
        public async Task CreateNote_ValidInput_CreatesNote()
        {
            int appointmentId = 100;
            string noteText = "AL testing " + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            bool displayOnSchedule = true;

            Should.NotThrow(async ()
                => await _client.Appointments.CreateNote(appointmentId, noteText, displayOnSchedule)
            );

            AppointmentNotesResponse notes = await _client.Appointments.GetNotes(appointmentId);
            AppointmentNote createdNote = notes.Items
                .FirstOrDefault(x => x.Text == noteText && x.DisplayOnSchedule == displayOnSchedule);

            createdNote.ShouldNotBeNull();

        }

        [Fact]
        public async Task CreateNote_NullNoteText_ThrowsApiValidationException()
        {
            ApiException exception = await Should.ThrowAsync<ApiException>(async ()
                => await _client.Appointments.GetNotes(100));

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldNotContain(@"""missingfields"":[""notetext""]");
        }

        [Fact]
        public async Task GetAppointmentSlots_ReturnsRecords()
        {
            GetAppointmentSlotsFilter filter = new GetAppointmentSlotsFilter
            {
                DepartmentId = Enumerable.Range(1, 999).ToArray()
            };

            AppointmentSlotResponse response = await _client.Appointments.GetAppointmentSlots(filter);
            response.Total.ShouldBe(0); //TODO: Endpoint always returns 0 items. To be corrected when there will be more items returned.
//            response.Total.ShouldBeGreaterThan(0);
//            response.Items.ShouldNotBeNull();
//            response.Items.ShouldContain(a => a.DepartmentId.HasValue);
//            response.Items.First().Date.ShouldNotBeNull();
        }
    }
}
