using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IAppointmentClient
    {
        Task<AppointmentTypeResponse> GetAppointmentTypes(GetAppointmentTypeFilter filter = null);

        Task<AppointmentType> GetAppointmentType(int appointmentTypeId);

        Task<AppointmentResponse> GetBookedAppointments(GetAppointmentsBookedFilter filter);

        Task<Appointment> GetAppointmentById(int id, GetAppointmentFilter filter = null);

        /// <summary>
        /// Retrieve notes for this appointment.
        /// </summary>
        /// <param name="appointmentId">The athenaNet Appointment ID.</param>
        /// <param name="showDeleted">By default, we prevent deleted appointment notes from being returned via the API. This flag allows you to show deleted notes in the set of results returned.</param>
        /// <returns></returns>
        Task<AppointmentNotesResponse> GetNotes(int appointmentId, bool showDeleted = false);

        /// <summary>
        /// Add a note for an appointment.
        /// </summary>
        /// <param name="appointmentId">The athenaNet Appointment ID.</param>
        /// <param name="text">The note text.</param>
        /// <param name="displayOnSchedule">Add appointment note to homepage display (defaults to false)</param>
        /// <returns></returns>
        Task CreateNote(int appointmentId, string text, bool displayOnSchedule = false);

        /// <summary>
        /// Find appointment reminders for this practice.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<AppointmentRemindersResponse> SearchReminders(SearchAppointmentRemindersFilter filter);

        /// <summary>
        /// Get a single appointment reminder for this practice.
        /// </summary>
        /// <param name="appointmentReminderId"></param>
        /// <returns></returns>
        Task<AppointmentReminder> GetReminderById(int appointmentReminderId);

        /// <summary>
        /// Results for adding an appointment reminder for this practice.
        /// </summary>
        /// <param name="reminder"></param>
        /// <returns></returns>
        Task<CreatedAppointmentReminder> CreateReminder(CreateAppointmentReminder reminder);

        /// <summary>
        /// Results for deleting an appointment reminder for this practice.
        /// </summary>
        /// <param name="appointmentReminderId"></param>
        /// <returns></returns>
        Task DeleteReminderById(int appointmentReminderId);

        Task<AppointmentSlotResponse> GetAppointmentSlots(GetAppointmentSlotsFilter filter);

        Task<AppointmentSlotCreationResponse> CreateAppointmentSlot(CreateAppointmentSlot slot);

        Task<Appointment> BookAppointment(BookAppointment booking);

        Task CancelAppointment(CancelAppointment cancelRequest);

        /// <summary>
        /// Returns the list of conditions required before check-in.
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        Task<CheckInRequirement[]> GetCheckInRequirements(int appointmentId);

        /// <summary>
        /// Completes the check in process for this appointment.
        /// Can NOT be called after <see cref="CancelCheckIn"/>.
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        Task CompleteCheckIn(int appointmentId);

        /// <summary>
        /// The check-in process was started.
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        Task StartCheckIn(int appointmentId);

        /// <summary>
        /// Note that the check-in process was stopped and/or canceled.
        /// Likely called after <see cref="StartCheckIn(int)"/>.
        /// Can NOT be called after <see cref="CompleteCheckIn"/>.
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        Task CancelCheckIn(int appointmentId);

        Task<InsuranceResponse> GetAppointmentInsurances(GetAppointmentInsurancesFilter filter);
    }
}