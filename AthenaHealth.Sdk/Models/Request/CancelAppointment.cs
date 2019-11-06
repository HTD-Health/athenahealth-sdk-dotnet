using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class CancelAppointment
    {
        public CancelAppointment(int appointmentId, int patientId, string cancellationReason)
        {
            AppointmentId = appointmentId;
            PatientId = patientId;
            CancellationReason = cancellationReason;
        }

        /// <summary>
        /// Passing in this parameter will override the default cancel reason. Valid reasons can be retrieved via a call to the GET /appointmentcancelreasons endpoint.
        /// </summary>
        [JsonProperty("appointmentcancelreasonid")]
        public int? AppointmentCancelReasonId { get; set; }

        /// <summary>
        /// The appointment slot to schedule into.
        /// </summary>
        [Required]
        [JsonProperty("appointmentid")]
        public int AppointmentId { get; set; }

        /// <summary>
        /// A text explanation why the appointment is being cancelled
        /// </summary>
        [Required]
        [JsonProperty("cancellationreason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// By default, we allow booking of appointments marked as schedulable via the web.  This flag allows you to bypass that restriction for booking.
        /// </summary>
        [JsonProperty("ignoreschedulablepermission")]
        // ReSharper disable once IdentifierTypo
        public bool? IgnoreSchedulablePermission { get; set; }

        /// <summary>
        /// By default, we create a patient case upon booking an appointment for new patients.  Setting this to true bypasses that patient case.
        /// </summary>
        [JsonProperty("nopatientcase")]
        public bool? NoPatientCase { get; set; }

        /// <summary>
        /// The athenaNet patient ID.
        /// </summary>
        [Required]
        [JsonProperty("patientid")]
        public int PatientId { get; set; }


    }
}
