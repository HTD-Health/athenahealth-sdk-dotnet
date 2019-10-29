using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Castle.Core.Internal;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Shouldly;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.Integration
{
    public class AppointmentClientTests
    {
        [Fact]
        public async Task GetAppointmentTypes_ReturnsRecords()
        {
            var client =
                new Clients.AppointmentClient(
                    ConnectionFactory.CreateFromFile(@"Data\Appointment\GetAppointmentTypes.json"));

            AppointmentTypeResponse response = await client.GetAppointmentTypes();

            response.Total.ShouldBe(466);
            response.Items.ShouldContain(a => a.Name == "Office Visit");
        }

        [Fact]
        public async Task GetAppointmentType_ValidId_ReturnsAppointmentType()
        {
            var client =
                new Clients.AppointmentClient(
                    ConnectionFactory.CreateFromFile(@"Data\Appointment\GetAppointmentType.json"));

            AppointmentType appointmentType = await client.GetAppointmentType(622);

            appointmentType.ShouldNotBeNull();
            appointmentType.Name.ShouldBe("Sick Visit");
        }

        [Fact]
        public async Task GetAppointmentType_InvalidId_ThrowException()
        {
            var client = new Clients.AppointmentClient(ConnectionFactory.Create("[]"));
            await Should.ThrowAsync<ApiValidationException>(async () => await client.GetAppointmentType(5000000));
        }

        [Fact]
        public async Task GetBookedAppointments_ReturnsRecords()
        {
            var client =
                new Clients.AppointmentClient(
                    ConnectionFactory.CreateFromFile(@"Data\Appointment\GetBookedAppointments.json"));
            GetAppointmentsBookedFilter filter = new GetAppointmentsBookedFilter(
                new[] { 1 },
                new DateTime(2019, 01, 01),
                new DateTime(2019, 02, 01))
            {
                ShowClaimDetail = true,
                ShowExpectedProcedureCodes = true,
                ShowCopay = true,
                ShowPatientDetail = true,
                ShowInsurance = true,
                ShowReminderCallDetail = true
            };

            AppointmentResponse response = await client.GetBookedAppointments(filter);
            response.Total.ShouldBe(2031);
            response.Items.ShouldNotBeNull();
            response.Items.Length.ShouldBe(1000);
            response.Items.ShouldContain(a => a.DepartmentId.HasValue);
            response.Items.First().Date.ShouldNotBeNull();
            response.Items.First().AppointmentStatus.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetAppointmentById_ValidId_ReturnsAppointment()
        {
            var client =
                new Clients.AppointmentClient(
                    ConnectionFactory.CreateFromFile(@"Data\Appointment\GetAppointment.json"));
            GetAppointmentFilter filter = new GetAppointmentFilter
            {
                ShowClaimDetail = true,
                ShowExpectedProcedureCodes = true,
                ShowCopay = true,
                ShowPatientDetail = true,
                ShowInsurance = true,
            };

            Appointment appointment = await client.GetAppointmentById(997681, filter);

            appointment.ShouldNotBeNull();
            appointment.DepartmentId.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetNotes_ValidId_ReturnsEmptyResult()
        {
            IAppointmentClient client =
                new Clients.AppointmentClient(ConnectionFactory.CreateFromFile(@"Data\Appointment\GetNotes.json"));

            AppointmentNotesResponse response = await client.GetNotes(2, true);

            response.Items.All(x => !string.IsNullOrWhiteSpace(x.Text)).ShouldBeTrue();
            response.Items.All(x => int.Parse(x.Id) > 0).ShouldBeTrue();
        }

        [Fact]
        public void CreateNote_ValidInput_NotThrowsException()
        {
            IAppointmentClient client =
                new Clients.AppointmentClient(ConnectionFactory.CreateFromFile(@"Data\Appointment\GetNotes.json"));

            Should.NotThrow(async ()
                => await client.CreateNote(100, "testing", true)
            );
        }

        [Fact]
        public async Task SearchReminders_ValidFilter_ReturnsRecords()
        {
            IAppointmentClient client =
                new Clients.AppointmentClient(
                    ConnectionFactory.CreateFromFile(@"Data\Appointment\SearchReminders.json"));

            SearchAppointmentRemindersFilter filter = new SearchAppointmentRemindersFilter(
                1,
                new DateTime(2018, 1, 1),
                new DateTime(2019, 12, 31));

            AppointmentRemindersResponse response = await client.SearchReminders(filter);

            response.Total.ShouldBeGreaterThan(0);
            response.Items.All(x => x.ApproximateDate != DateTime.MinValue).ShouldBeTrue();
            response.Items.All(x => x.Id > 0).ShouldBeTrue();
            response.Items.All(x => x.DepartmentId > 0).ShouldBeTrue();
        }

        [Fact]
        public async Task GetReminderById_ExistingId_ReturnsRecord()
        {
            IAppointmentClient client =
                new Clients.AppointmentClient(
                    ConnectionFactory.CreateFromFile(@"Data\Appointment\GetReminderById.json"));

            var response = await client.GetReminderById(15042);

            response.ShouldNotBeNull();
            response.Id.ShouldBe(15042);
            response.DepartmentId.ShouldBe(150);
            response.PatientId.ShouldBe(33339);
        }

        [Fact]
        public async Task CreateReminder_ValidModel_ReturnsCreatedReminder()
        {
            IAppointmentClient client =
                new Clients.AppointmentClient(
                    ConnectionFactory.CreateFromFile(@"Data\Appointment\CreateReminder.json"));

            var model = new CreateAppointmentReminder(
                new DateTime(2019, 10, 28),
                82,
                31014,
                144);
            CreatedAppointmentReminder response = await client.CreateReminder(model);

            response.ShouldNotBeNull();
            response.Id.ShouldBe(15123);
            response.IsSuccess.ShouldBeTrue();
        }

        [Fact]
        public void DeleteReminderById_ValidAppointmentReminderId_NotThrowsException()
        {
            IAppointmentClient client =
                new Clients.AppointmentClient(ConnectionFactory.Create(@"{ ""success"": true }"));

            Should.NotThrow(async ()
                => await client.DeleteReminderById(15128)
            );
        }

        [Fact]
        public async Task GetOpenAppointments_ReturnsRecords()
        {
            var client =
                new Clients.AppointmentClient(
                    ConnectionFactory.CreateFromFile(@"Data\Appointment\GetAppointmentSlots.json"));

            GetAppointmentSlotsFilter filter = new GetAppointmentSlotsFilter(new int[] { 1 });

            AppointmentSlotResponse response = await client.GetAppointmentSlots(filter);
            response.Total.ShouldBe(131);
            response.Items.ShouldNotBeNull();
            response.Items.Length.ShouldBe(131);
            response.Items.ShouldContain(a => a.DepartmentId.HasValue);
            response.Items.First().Date.ShouldNotBeNull();
            response.Items.First(a => a.StartTime != null).StartTime.ToString().IsNullOrEmpty();
        }

        [Fact]
        public async Task CreateAppointmentSlot_ValidData_IdReturned()
        {
            var client = new Clients.AppointmentClient(
                ConnectionFactory.Create("{\"appointmentids\": {\"1205956\": \"16:00\"}}"));
            CreateAppointmentSlot slot = new CreateAppointmentSlot(
                1,
                86,
                new DateTime(2020, 1, 1),
                new ClockTime[] { new ClockTime(16, 00) })
            {
                ReasonId = 962
            };

            AppointmentSlotCreationResponse response = await client.CreateAppointmentSlot(slot);

            response.AppointmentIds.First(a => a.Key == "1205956" && a.Value == "16:00").ShouldNotBeNull();
        }

        [Fact]
        public async Task BookAppointment_ValidData_ReturnsAppointment()
        {
            var client = new Clients.AppointmentClient(
                ConnectionFactory.CreateFromFile(@"Data\Appointment\BookAppointment.json"));

            BookAppointment booking = new BookAppointment(1205967)
            {
                PatientId = 1,
                ReasonId = 962,
                IgnoreSchedulablePermission = true
            };

            Appointment appointment = await client.BookAppointment(booking);
            appointment.Id = 1205967;
            appointment.Date.ShouldNotBeNull();
        }

        [Fact]
        public void CancelAppointment_ValidData_NoExceptionIsThrown()
        {
            var client = new Clients.AppointmentClient(ConnectionFactory.Create(""));

            CancelAppointment cancelRequest = new CancelAppointment(1, 1, "test");

            Should.NotThrow(() => client.CancelAppointment(cancelRequest));
        }

        [Fact]
        public async Task GetCheckInRequirements_ExistingId_ReturnsRecords()
        {
            IAppointmentClient client = new Clients.AppointmentClient(ConnectionFactory.CreateFromFile(@"Data\Appointment\GetCheckInRequirements.json"));

            var response = await client.GetCheckInRequirements(1313);

            response.ShouldNotBeNull();
            response.All(x => x.Fields != null).ShouldBeTrue();
            response.All(x => !string.IsNullOrEmpty(x.Name)).ShouldBeTrue();
        }

        [Fact]
        public void CompleteCheckIn_ExistingId_NotThrowsException()
        {
            IAppointmentClient client = new Clients.AppointmentClient(ConnectionFactory.Create(@"{ ""success"": true }"));

            Should.NotThrow(async ()
                => await client.CompleteCheckIn(2267)
            );
        }

        [Fact]
        public void StartCheckIn_ExistingId_NotThrowsException()
        {
            IAppointmentClient client = new Clients.AppointmentClient(ConnectionFactory.Create(@"{ ""success"": true }"));

            Should.NotThrow(async ()
                => await client.StartCheckIn(2267)
            );
        }

        [Fact]
        public void CancelCheckIn_ExistingId_NotThrowsException()
        {
            IAppointmentClient client = new Clients.AppointmentClient(ConnectionFactory.Create(@"{ ""success"": true }"));

            Should.NotThrow(async ()
                => await client.CancelCheckIn(2267)
            );
        }
    }
}
