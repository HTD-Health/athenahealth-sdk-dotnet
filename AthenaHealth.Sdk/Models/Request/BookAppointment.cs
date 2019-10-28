using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class BookAppointment
    {
        /// <summary>
        /// The appointment slot to schedule into.
        /// </summary>
        [JsonProperty(PropertyName = "{appointmentid}")]
        [Required]
        public int AppointmentId { get; set; }

        /// <summary>
        /// The appointment type to be booked.  This field should never be used for booking appointments for web-based scheduling. The use of this field is reserved for digital check-in (aka "kiosk") or an application used by practice staff.  One of this or reasonid is required.
        /// </summary>
        [JsonProperty(PropertyName = "appointmenttypeid")]
        public int? AppointmentTypeId { get; set; }

        /// <summary>
        /// A note from the patient about why this appointment is being booked
        /// </summary>
        [JsonProperty(PropertyName = "bookingnote")]
        public string BookingNote { get; set; }

        /// <summary>
        /// The athenaNet department ID.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// For clients with athenaCommunicator, certain appointment types can be configured to have an appointment confirmation email sent to the patient at time of appointment booking. If this parameter is set to true, that email will not be sent.  This should only be used if you plan on sending a confirmation email via another method.
        /// </summary>
        [JsonProperty(PropertyName = "donotsendconfirmationemail")]
        public bool? DoNotSendConfirmationEmail { get; set; }

        /// <summary>
        /// By default, we allow booking of appointments marked as schedulable via the web.  This flag allows you to bypass that restriction for booking.
        /// </summary>
        [JsonProperty(PropertyName = "ignoreschedulablepermission")]
        // ReSharper disable once IdentifierTypo
        public bool? IgnoreSchedulablePermission { get; set; }

        /// <summary>
        /// Patient insurance information, which will be added to the note on the appointment.
        /// </summary>
        [JsonProperty(PropertyName = "insuranceinfo")]
        public object InsuranceInfo { get; set; }

        /// <summary>
        /// By default, we create a patient case upon booking an appointment for new patients.  Setting this to true bypasses that patient case.
        /// </summary>
        [JsonProperty(PropertyName = "nopatientcase")]
        public bool? NoPatientCase { get; set; }

        /// <summary>
        /// The athenaNet patient ID.
        /// </summary>
        [JsonProperty(PropertyName = "patientid")]
        public int? PatientId { get; set; }

        /// <summary>
        /// The appointment reason ID to be booked.  This field is required for booking appointments for web-based scheduling and is a reason that is retrieved from the /patientappointmentreasons call.
        /// </summary>
        [JsonProperty(PropertyName = "reasonid")]
        public int? ReasonId { get; set; }

        /// <summary>
        /// Set this field in order to set the urgent flag in athena (if the practice settings allow for this).
        /// </summary>
        [JsonProperty(PropertyName = "urgent")]
        public bool? Urgent { get; set; }
    }
}
