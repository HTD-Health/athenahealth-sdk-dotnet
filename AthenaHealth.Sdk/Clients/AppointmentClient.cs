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

        [Endpoint("GET /appointmenttypes")]
        public async Task<AppointmentTypeResponse> GetAppointmentTypes(GetAppointmentTypeFilter filter = null)
        {
            return await _connection.Get<AppointmentTypeResponse>($"{_connection.PracticeId}/appointmenttypes", filter);
        }

        [Endpoint("GET /appointmenttypes/{appointmenttypeid}")]
        public async Task<AppointmentType> GetAppointmentType(int appointmentTypeId)
        {
            AppointmentType[] result = await _connection.Get<AppointmentType[]>($"{_connection.PracticeId}/appointmenttypes/{appointmentTypeId}");
            return result.FirstOrThrowException();
        }

        [Endpoint("GET /appointments/booked")]
        [Endpoint("GET /appointments/booked/multipledepartment")]
        public async Task<AppointmentResponse> GetBookedAppointments(GetAppointmentsBookedFilter filter)
        {
            if (filter.DepartmentIds != null && filter.DepartmentIds.Length > 1)
                return await _connection.Get<AppointmentResponse>($"{_connection.PracticeId}/appointments/booked/multipledepartment", filter);
            return await _connection.Get<AppointmentResponse>($"{_connection.PracticeId}/appointments/booked", filter);
        }

        [Endpoint("GET /appointments/{appointmentid}")]
        public async Task<Appointment> GetById(int appointmentId, GetAppointmentFilter filter = null)
        {
            Appointment[] result = await _connection.Get<Appointment[]>($"{_connection.PracticeId}/appointments/{appointmentId}", filter);
            return result.FirstOrThrowException();
        }

        [Endpoint("GET /appointments/{appointmentid}/notes")]
        public async Task<AppointmentNotesResponse> GetNotes(int appointmentId, bool showDeleted = false)
        {
            return await _connection.Get<AppointmentNotesResponse>($"{_connection.PracticeId}/appointments/{appointmentId}/notes", showDeleted);
        }

        [Endpoint("POST /appointments/{appointmentid}/notes")]
        public async Task CreateNote(int appointmentId, string text, bool displayOnSchedule = false)
        {
            await _connection.Post<BaseResponse>( $"{_connection.PracticeId}/appointments/{appointmentId}/notes", null, new { notetext = text, displayonschedule = displayOnSchedule });
        }

        [Endpoint("GET /appointments/appointmentreminders")]
        public async Task<AppointmentRemindersResponse> SearchReminders(SearchAppointmentRemindersFilter filter)
        {
            return await _connection.Get<AppointmentRemindersResponse>(
                $"{_connection.PracticeId}/appointments/appointmentreminders", filter);
        }

        [Endpoint("GET /appointments/appointmentreminders/{appointmentreminderid}")]
        public async Task<AppointmentReminder> GetReminderById(int appointmentReminderId)
        {
            return await _connection.Get<AppointmentReminder>(
                $"{_connection.PracticeId}/appointments/appointmentreminders/{appointmentReminderId}");
        }

        [Endpoint("POST /appointments/appointmentreminders")]
        public async Task<CreatedAppointmentReminder> CreateReminder(CreateAppointmentReminder reminder)
        {
            return await _connection.Post<CreatedAppointmentReminder>(
                $"{_connection.PracticeId}/appointments/appointmentreminders",
                null,
                reminder);
        }

        [Endpoint("DELETE /appointments/appointmentreminders/{appointmentreminderid}")]
        public Task DeleteReminderById(int appointmentReminderId)
        {
            return _connection.Delete<StatusResponse>(
                $"{_connection.PracticeId}/appointments/appointmentreminders/{appointmentReminderId}"
            );
        }

        [Endpoint("GET /appointments/open")]
        public async Task<AppointmentSlotResponse> GetAppointmentSlots(GetAppointmentSlotsFilter filter)
        {
            return await _connection.Get<AppointmentSlotResponse>($"{_connection.PracticeId}/appointments/open", filter);
        }

        [Endpoint("POST /appointments/open")]
        public async Task<AppointmentSlotCreationResponse> CreateAppointmentSlot(CreateAppointmentSlot slot)
        {
            return await _connection.Post<AppointmentSlotCreationResponse>($"{_connection.PracticeId}/appointments/open", null, slot);
        }

        [Endpoint("GET /appointments/{appointmentid}/checkin")]
        public async Task<CheckInRequirement[]> GetCheckInRequirements(int appointmentId)
        {
            return await _connection.Get<CheckInRequirement[]>($"{_connection.PracticeId}/appointments/{appointmentId}/checkin");
        }

        [Endpoint("PUT /appointments/{appointmentid}")]
        public async Task<Appointment> BookAppointment(BookAppointment booking)
        {
            Appointment[] result = await _connection.Put<Appointment[]>(
                $"{_connection.PracticeId}/appointments/{booking.AppointmentId}",
                booking);
            return result.FirstOrThrowException();
        }

        [Endpoint("PUT /appointments/{appointmentid}/cancel")]
        public async Task CancelAppointment(CancelAppointment cancelRequest)
        {
            await _connection.Put<object>(
                $"{_connection.PracticeId}/appointments/{cancelRequest.AppointmentId}/cancel",
                cancelRequest);
        }

        [Endpoint("POST /appointments/{appointmentid}/checkin")]
        public async Task CompleteCheckIn(int appointmentId)
        {
            await _connection.Post<BaseResponse>($"{_connection.PracticeId}/appointments/{appointmentId}/checkin");
        }

        [Endpoint("POST /appointments/{appointmentid}/startcheckin")]
        public async Task StartCheckIn(int appointmentId)
        {
            await _connection.Post<BaseResponse>($"{_connection.PracticeId}/appointments/{appointmentId}/startcheckin");
        }

        [Endpoint("POST /appointments/{appointmentid}/cancelcheckin")]
        public async Task CancelCheckIn(int appointmentId)
        {
            await _connection.Post<BaseResponse>($"{_connection.PracticeId}/appointments/{appointmentId}/cancelcheckin");
        }

        [Endpoint("GET /appointments/{appointmentid}/insurances")]
        public async Task<InsuranceResponse> GetAppointmentInsurances(GetAppointmentInsurancesFilter filter)
        {
            return await _connection.Get<InsuranceResponse>($"{_connection.PracticeId}/appointments/{filter.AppointmentId}/insurances", filter);
        }

        [Endpoint("GET /patientappointmentreasons")]
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

        [Endpoint("PUT /appointments/{appointmentid}/reschedule")]
        public async Task<Appointment> RescheduleAppointment(RescheduleAppointment rescheduledAppointment)
        {
            Appointment[] result =  await _connection.Put<Appointment[]>($"{_connection.PracticeId}/appointments/{rescheduledAppointment.AppointmentId}/reschedule", rescheduledAppointment);
            return result.FirstOrThrowException();
        }

        [Endpoint("GET /appointments/waitlist")]
        public async Task<WaitListResponse> GetWaitList(GetWaitlistFilter filter = null)
        {
            return await _connection.Get<WaitListResponse>($"{_connection.PracticeId}/appointments/waitlist", filter);
        }

        [Endpoint("POST /appointments/waitlist")]
        public async Task<AddToWaitListResponse> AddToWaitList(AddToWaitListRequest request)
        {
            return await _connection.Post<AddToWaitListResponse>($"{_connection.PracticeId}/appointments/waitlist", null, request);
        }

        [Endpoint("GET /appointments/changed/subscription/events")]
        public async Task<AppointmentSubscriptionEvent> GetAppointmentSubscriptionEvents()
        {
            return await _connection.Get<AppointmentSubscriptionEvent>($"{_connection.PracticeId}/appointments/changed/subscription/events");
        }

        [Endpoint("GET /appointments/changed/subscription")]
        public async Task<AppointmentSubscriptionEvent> GetAppointmentSubscriptions(GetAppointmentSubscriptionsFilter queryParameters = null)
        {
            return await _connection.Get<AppointmentSubscriptionEvent>($"{_connection.PracticeId}/appointments/changed/subscription", queryParameters);
        }

        [Endpoint("POST /appointments/changed/subscription")]
        public async Task<BaseResponse> SubscribeToEvent(SubscribeToEvent request = null)
        {
            return await _connection.Post<BaseResponse>($"{_connection.PracticeId}/appointments/changed/subscription", body: request);
        }

        [Endpoint("DELETE /appointments/changed/subscription")]
        public async Task<BaseResponse> UnsubscribeFromEvent(UnsubscribeFromEvent queryParameters = null)
        {
            return await _connection.Delete<BaseResponse>($"{_connection.PracticeId}/appointments/changed/subscription", queryParameters);
        }
    }
}