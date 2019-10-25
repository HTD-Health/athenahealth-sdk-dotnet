using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IAppointmentClient
    {
        Task<AppointmentTypeResponse> GetAppointmentTypes(GetAppointmentTypeFilter filter = null);

        Task<AppointmentType> GetAppointmentType(int appointmentTypeId);

        Task<AppointmentResponse> GetBookedAppointments(GetBookedAppointmentsFilter filter);

        Task<Appointment> GetAppointmentById(int id, GetAppointmentFilter filter = null);

        /// <summary>
        /// Retrieve notes for this appointment.
        /// </summary>
        /// <param name="appointmentId">The athenaNet Appointment ID.</param>
        /// <param name="showDeleted">By default, we prevent deleted appointment notes from being returned via the API. This flag allows you to show deleted notes in the set of results returned.</param>
        /// <returns></returns>
        Task<AppointmentNotesResponse> GetNotes(int appointmentId, bool showDeleted = false);
    }
}