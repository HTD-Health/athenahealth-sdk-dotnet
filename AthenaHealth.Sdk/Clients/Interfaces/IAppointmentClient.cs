using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IAppointmentClient
    {
        [Endpoint("GET /appointmenttypes")]
        Task<AppointmentTypeResponse> GetAppointmentTypes(GetAppointmentTypeFilter filter = null);

        [Endpoint("GET /appointmenttypes/{appointmenttypeid}")]
        Task<AppointmentType> GetAppointmentType(int appointmentTypeId);

        [Endpoint("GET /appointments/booked")]
        [Endpoint("GET /appointments/booked/multipledepartment")]
        Task<AppointmentResponse> GetBookedAppointments(GetAppointmentsBookedFilter filter);

        [Endpoint("GET /appointments/{appointmentid}")]
        Task<Appointment> GetById(int appointmentId, GetAppointmentFilter filter = null);

        /// <summary>
        /// Retrieve notes for this appointment.
        /// </summary>
        /// <param name="appointmentId">The athenaNet Appointment ID.</param>
        /// <param name="showDeleted">
        /// By default, we prevent deleted appointment notes from being returned via the API. This
        /// flag allows you to show deleted notes in the set of results returned.
        /// </param>
        /// <returns></returns>
        [Endpoint("GET /appointments/{appointmentid}/notes")]
        Task<AppointmentNotesResponse> GetNotes(int appointmentId, bool showDeleted = false);

        /// <summary>
        /// Add a note for an appointment.
        /// </summary>
        /// <param name="appointmentId">The athenaNet Appointment ID.</param>
        /// <param name="text">The note text.</param>
        /// <param name="displayOnSchedule">
        /// Add appointment note to homepage display (defaults to false)
        /// </param>
        /// <returns></returns>
        [Endpoint("POST /appointments/{appointmentid}/notes")]
        Task CreateNote(int appointmentId, string text, bool displayOnSchedule = false);

        /// <summary>
        /// Find appointment reminders for this practice.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /appointments/appointmentreminders")]
        Task<AppointmentRemindersResponse> SearchReminders(SearchAppointmentRemindersFilter filter);

        /// <summary>
        /// Get a single appointment reminder for this practice.
        /// </summary>
        /// <param name="appointmentReminderId"></param>
        /// <returns></returns>
        [Endpoint("GET /appointments/appointmentreminders/{appointmentreminderid}")]
        Task<AppointmentReminder> GetReminderById(int appointmentReminderId);

        /// <summary>
        /// Results for adding an appointment reminder for this practice.
        /// </summary>
        /// <param name="reminder"></param>
        /// <returns></returns>
        [Endpoint("POST /appointments/appointmentreminders")]
        Task<CreatedAppointmentReminder> CreateReminder(CreateAppointmentReminder reminder);

        /// <summary>
        /// Results for deleting an appointment reminder for this practice.
        /// </summary>
        /// <param name="appointmentReminderId"></param>
        /// <returns></returns>
        [Endpoint("DELETE /appointments/appointmentreminders/{appointmentreminderid}")]
        Task DeleteReminderById(int appointmentReminderId);

        [Endpoint("GET /appointments/open")]
        Task<AppointmentSlotResponse> GetAppointmentSlots(GetAppointmentSlotsFilter filter);

        [Endpoint("POST /appointments/open")]
        Task<AppointmentSlotCreationResponse> CreateAppointmentSlot(CreateAppointmentSlot slot);

        /// <summary>
        /// Returns the list of conditions required before check-in.
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        [Endpoint("GET /appointments/{appointmentid}/checkin")]
        Task<CheckInRequirement[]> GetCheckInRequirements(int appointmentId);

        [Endpoint("PUT /appointments/{appointmentid}")]
        Task<Appointment> BookAppointment(int appointmentId, BookAppointment booking);

        [Endpoint("PUT /appointments/{appointmentid}/cancel")]
        Task CancelAppointment(int appointmentId, CancelAppointment cancelRequest);

        /// <summary>
        /// Completes the check in process for this appointment. Can NOT be called after <see cref="CancelCheckIn"/>.
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        [Endpoint("POST /appointments/{appointmentid}/checkin")]
        Task CompleteCheckIn(int appointmentId);

        /// <summary>
        /// The check-in process was started.
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        [Endpoint("POST /appointments/{appointmentid}/startcheckin")]
        Task StartCheckIn(int appointmentId);

        /// <summary>
        /// Note that the check-in process was stopped and/or canceled. Likely called after <see
        /// cref="StartCheckIn(int)"/>. Can NOT be called after <see cref="CompleteCheckIn"/>.
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        [Endpoint("POST /appointments/{appointmentid}/cancelcheckin")]
        Task CancelCheckIn(int appointmentId);

        [Endpoint("GET /appointments/{appointmentid}/insurances")]
        Task<InsuranceResponse> GetAppointmentInsurances(GetAppointmentInsurancesFilter filter);

        [Endpoint("GET /patientappointmentreasons")]
        Task<AppointmentReasonResponse> GetAppointmentReasons(GetAppointmentReasonsFilter filter);

        [Endpoint("GET /patientappointmentreasons/newpatient")]
        Task<AppointmentReasonResponse> GetAppointmentReasonsForNewPatient(GetAppointmentReasonsFilter filter);

        [Endpoint("GET /patientappointmentreasons/existingpatient")]
        Task<AppointmentReasonResponse> GetAppointmentReasonsForExistingPatient(GetAppointmentReasonsFilter filter);

        [Endpoint("PUT /appointments/{appointmentid}/reschedule")]
        Task<Appointment> RescheduleAppointment(int appointmentId, RescheduleAppointment rescheduledAppointment);

        /// <summary>
        /// Returns entries on the wait list
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /appointments/waitlist")]
        Task<WaitListResponse> GetWaitList(GetWaitlistFilter filter = null);

        /// <summary>
        /// Adds a wait list entry.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Endpoint("POST /appointments/waitlist")]
        Task<AddToWaitListResponse> AddToWaitList(AddToWaitListRequest request);

        [Endpoint("GET /appointments/changed/subscription/events")]
        Task<AppointmentSubscriptionEvent> GetAppointmentSubscriptionEvents();

        [Endpoint("GET /appointments/changed/subscription")]
        Task<AppointmentSubscriptionEvent> GetAppointmentSubscriptions(GetAppointmentSubscriptionsFilter queryParameters = null);

        [Endpoint("POST /appointments/changed/subscription")]
        Task<BaseResponse> SubscribeToEvent(SubscribeToEvent request = null);

        [Endpoint("DELETE /appointments/changed/subscription")]
        Task<BaseResponse> UnsubscribeFromEvent(UnsubscribeFromEvent queryParameters = null);

        /// <summary>
        /// This path provides access to booked appointments
        /// Note: This endpoint may rely on specific settings to be enabled in athenaNet Production to function properly that are not required in other environments.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /appointments/changed")]
        Task<ChangedAppointmentsSlotResponse> GetChangedAppointmentSlots(GetChangedAppointmentSlotsFilter filter = null);

        [Endpoint("GET /appointments/{appointmentid}/accidentdata")]
        Task<AccidentData> GetAccidentInfo(int appointmentId);
    }
}
