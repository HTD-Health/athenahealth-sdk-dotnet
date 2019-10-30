using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Extensions;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Clients
{
    public class AppointmentClient : IAppointmentClient
    {
        private readonly IConnection _connection;

        public AppointmentClient(IConnection connection)
        {
            _connection = connection;
        }

        public async Task<AppointmentTypeResponse> GetAppointmentTypes(GetAppointmentTypeFilter filter = null)
        {
            return await _connection.Get<AppointmentTypeResponse>($"{_connection.PracticeId}/appointmenttypes", filter);
        }

        public async Task<AppointmentType> GetAppointmentType(int appointmentTypeId)
        {
            AppointmentType[] result = await _connection.Get<AppointmentType[]>($"{_connection.PracticeId}/appointmenttypes/{appointmentTypeId}");
            return result.FirstOrThrowException();
        }

        public async Task<AppointmentResponse> GetBookedAppointments(GetAppointmentsBookedFilter filter)
        {
            if (filter.DepartmentIds != null && filter.DepartmentIds.Length > 1)
                return await _connection.Get<AppointmentResponse>($"{_connection.PracticeId}/appointments/booked/multipledepartment", filter);
            return await _connection.Get<AppointmentResponse>($"{_connection.PracticeId}/appointments/booked", filter);
        }

        public async Task<Appointment> GetAppointmentById(int id, GetAppointmentFilter filter = null)
        {
            Appointment[] result = await _connection.Get<Appointment[]>($"{_connection.PracticeId}/appointments/{id}", filter);
            return result.FirstOrThrowException();
        }

        public async Task<AppointmentNotesResponse> GetNotes(int appointmentId, bool showDeleted = false)
        {
            return await _connection.Get<AppointmentNotesResponse>($"{_connection.PracticeId}/appointments/{appointmentId}/notes", showDeleted);
        }

        public async Task CreateNote(int appointmentId, string text, bool displayOnSchedule = false)
        {
            await _connection.Post<BaseResponse>(
                $"{_connection.PracticeId}/appointments/{appointmentId}/notes",
                null,
                new { notetext = text, displayonschedule = displayOnSchedule });
        }

        public async Task<AppointmentRemindersResponse> SearchReminders(SearchAppointmentRemindersFilter filter)
        {
            return await _connection.Get<AppointmentRemindersResponse>(
                $"{_connection.PracticeId}/appointments/appointmentreminders", filter);
        }

        public async Task<AppointmentReminder> GetReminderById(int appointmentReminderId)
        {
            return await _connection.Get<AppointmentReminder>(
                $"{_connection.PracticeId}/appointments/appointmentreminders/{appointmentReminderId}");
        }

        public async Task<CreatedAppointmentReminder> CreateReminder(CreateAppointmentReminder reminder)
        {
            return await _connection.Post<CreatedAppointmentReminder>(
                $"{_connection.PracticeId}/appointments/appointmentreminders",
                null,
                reminder);
        }

        public Task DeleteReminderById(int appointmentReminderId)
        {
            return _connection.Delete<StatusResponse>(
                $"{_connection.PracticeId}/appointments/appointmentreminders/{appointmentReminderId}"
            );
        }

        public async Task<AppointmentSlotResponse> GetAppointmentSlots(GetAppointmentSlotsFilter filter)
        {
            return await _connection.Get<AppointmentSlotResponse>($"{_connection.PracticeId}/appointments/open", filter);
        }

        public async Task<AppointmentSlotCreationResponse> CreateAppointmentSlot(CreateAppointmentSlot slot)
        {
            return await _connection.Post<AppointmentSlotCreationResponse>($"{_connection.PracticeId}/appointments/open", null, slot);
        }

        public async Task<CheckInRequirement[]> GetCheckInRequirements(int appointmentId)
        {
            return await _connection.Get<CheckInRequirement[]>($"{_connection.PracticeId}/appointments/{appointmentId}/checkin");
        }

        public async Task<Appointment> BookAppointment(BookAppointment booking)
        {
            Appointment[] result = await _connection.Put<Appointment[]>(
                $"{_connection.PracticeId}/appointments/{booking.AppointmentId}",
                booking);
            return result.FirstOrThrowException();
        }

        public async Task CancelAppointment(CancelAppointment cancelRequest)
        {
            await _connection.Put<object>(
                $"{_connection.PracticeId}/appointments/{cancelRequest.AppointmentId}/cancel",
                cancelRequest);
        }


        public async Task CompleteCheckIn(int appointmentId)
        {
            await _connection.Post<BaseResponse>($"{_connection.PracticeId}/appointments/{appointmentId}/checkin");
        }

        public async Task StartCheckIn(int appointmentId)
        {
            await _connection.Post<BaseResponse>($"{_connection.PracticeId}/appointments/{appointmentId}/startcheckin");
        }

        public async Task CancelCheckIn(int appointmentId)
        {
            await _connection.Post<BaseResponse>($"{_connection.PracticeId}/appointments/{appointmentId}/cancelcheckin");
        }

        public async Task<InsuranceResponse> GetAppointmentInsurances(GetAppointmentInsurancesFilter filter)
        {
            return await _connection.Get<InsuranceResponse>($"{_connection.PracticeId}/appointments/{filter.AppointmentId}/insurances", filter);
        }

        public async Task<AppointmentReasonResponse> GetAppointmentReasons(GetAppointmentReasonsFilter filter)
        {
            string url = "";
            switch (filter.Type)
            {
                case AppointmentReasonTypeEnum.All:
                    url = $"{_connection.PracticeId}/patientappointmentreasons";
                    break;
                case AppointmentReasonTypeEnum.New:
                    url = $"{_connection.PracticeId}/patientappointmentreasons/newpatient";
                    break;
                case AppointmentReasonTypeEnum.Existing:
                    url = $"{_connection.PracticeId}/patientappointmentreasons/existingpatient";
                    break;
            }
            return await _connection.Get<AppointmentReasonResponse>(url, filter);
        }

        public async Task<Appointment> RescheduleAppointment(RescheduleAppointment rescheduledAppointment)
        {
            Appointment[] result =  await _connection.Put<Appointment[]>($"{_connection.PracticeId}/appointments/{rescheduledAppointment.AppointmentId}/reschedule", rescheduledAppointment);
            return result.FirstOrThrowException();
        }
    }
}