using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class ChangedAppointmentsSlotResponse : IPagingResponse<ChangedAppointmentSlot>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("appointments")]
        public ChangedAppointmentSlot[] Items { get; set; }
    }

    public class ChangedAppointmentSlot
    {
        /// <summary>
        /// A list of reason IDs that could be used for this slot.  Only present if multiple reason IDs are requested.
        /// </summary>
        [JsonProperty("reasonid")]
        public int[] ReasonId { get; set; }

        /// <summary>
        /// An array of appointment notes for this appointment.
        /// </summary>
        [JsonProperty("appointmentnotes")]
        public object AppointmentNotes { get; set; }

        /// <summary>
        /// Whether the note should be displayed on the schedule.
        /// </summary>
        [JsonProperty("displayonschedule")]
        public AppointmentNoteDisplayedOnSchedule DisplayOnSchedule { get; set; }

        /// <summary>
        /// The athenaNet appointment status. There are several possible statuses.  x=cancelled. f=future. (It can include appointments where were never checked in, even if the appointment date is in the past. It is up to a practice to cancel appointments as a no show when appropriate to do so.)  o=open. 2=checked in. 3=checked out. 4=charge entered (i.e. a past appointment).
        /// </summary>
        [JsonProperty("appointmentstatus")]
        public string AppointmentStatus { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss; Eastern time) that this appointment was cancelled (if cancelled)
        /// </summary>
        [JsonProperty("cancelleddatetime")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm:ss")]
        public DateTime CancelledDateTime { get; set; }

        /// <summary>
        /// This field will tell if an appointment has been marked as not requiring change entry.
        /// </summary>
        [JsonProperty("chargeentrynotrequired")]
        public bool? ChargeEntryNotRequired { get; set; }

        /// <summary>
        /// This is the raw provider ID that should be used ONLY if using this appointment in conjunction with an HL7 message and with athenahealth's prior guidance.
        /// It is only available in some situations.
        /// </summary>
        [JsonProperty("hl7providerid")]
        public int? Hl7ProviderId { get; set; }

        /// <summary>
        /// If the appointment was cancelled, the name (local to the practice) for the cancel reason.
        /// </summary>
        [JsonProperty("cancelreasonname")]
        public string CancelReasonName { get; set; }

        /// <summary>
        /// This field will give the reason that an appointment has been marked as not requiring charge entry.
        /// </summary>
        [JsonProperty("chargeentrynotrequiredreason")]
        public string ChargeEntryNotRequiredReason { get; set; }

        /// <summary>
        /// The date/time when the appointment was last modified.
        /// Note: It may be possible for the field to be updated without any other field in the API call being changed.
        /// This occurs when appointment fields not included in the API output are updated.
        /// </summary>
        [JsonProperty("lastmodified")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss) that the appointment was checked out.
        /// </summary>
        [JsonProperty("checkoutdatetime")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm:ss")]
        public DateTime? CheckoutDateTime { get; set; }

        /// <summary>
        /// Expected copay for this appointment. Based on the appointment type, the patient's primary insurance, and any copays collected.  To see the amounts used in this calculated value, see the APPOINTMENTCOPAY fields.
        /// </summary>
        [JsonProperty("copay")]
        public string Copay { get; set; }

        /// <summary>
        /// The encounter id associated with this appointment, useful for certain other calls. Only present for appointments with Clinicals that have been checked in.
        /// </summary>
        [JsonProperty("encounterid")]
        public int? EncounterId { get; set; }

        /// <summary>
        /// The username who scheduled the appointment.
        /// </summary>
        [JsonProperty("scheduledby")]
        public string ScheduledBy { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss) that the appointment was checked in.
        /// </summary>
        [JsonProperty("checkindatetime")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm:ss")]
        public DateTime? CheckInDateTime { get; set; }

        /// <summary>
        /// If the appointment has been cancelled, the username who cancelled the appointment.
        /// </summary>
        [JsonProperty("cancelledby")]
        public string CancelledBy { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss) that the intake process was completed.
        /// </summary>
        [JsonProperty("stopintakedatetime")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm:ss")]
        public DateTime? StopIntakeDateTime { get; set; }

        /// <summary>
        /// The status of this patient in the encounter (READYFORSTAFF, WITHSTAFF, READFORPROVIDER, CHECKEDOUT).
        /// Only present for appointments with Clinics that have been checked in.
        /// </summary>
        [JsonProperty("encounterstatus")]
        public string EncounterStatus { get; set; }

        /// <summary>
        /// If true, this appointment slot is frozen
        /// </summary>
        [JsonProperty("frozen")]
        public bool Frozen { get; set; }

        /// <summary>
        /// The practice-friendly (not patient friendly) name for this appointment type.  Note that this may not be the same as the booked appointment because of "generic" slots.
        /// </summary>
        [JsonProperty("appointmenttype")]
        public string AppointmentType { get; set; }

        /// <summary>
        /// This is the ID for the appointment type.   Note that this may not be the same as the booked appointment because of "generic" slots.
        /// </summary>
        [JsonProperty("appointmenttypeid")]
        public int? AppointmentTypeId { get; set; }

        /// <summary>
        /// If the appointment was cancelled, the numeric ID (local to the practice) for the cancel reason.
        /// </summary>
        [JsonProperty("cancelreasonid")]
        public int? CancelReasonId { get; set; }

        /// <summary>
        /// If the appointment was cancelled, if the cancel reason is marked as a no show reason.
        /// </summary>
        [JsonProperty("cancelreasonnoshow")]
        public bool? CancelReasonNoShow { get; set; }

        /// <summary>
        /// If the appointment was cancelled, if the cancel reason is marked as a slot available reason.
        /// </summary>
        [JsonProperty("cancelreasonslotavailable")]
        public bool? CancelReasonSlotAvailable { get; set; }

        /// <summary>
        /// If true, the appointment was booked through athenaCoordinator Enterprise.
        /// </summary>
        [JsonProperty("coordinatorenterprise")]
        public bool? CoordinatorEnterprise { get; set; }

        /// <summary>
        /// In minutes
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss; Eastern time) that this appointment was scheduled.
        /// </summary>
        [JsonProperty("scheduleddatetime")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm:ss")]
        public DateTime? ScheduledDateTime { get; set; }

        /// <summary>
        /// Urgent flag for the appointment.
        /// </summary>
        [JsonProperty("urgent")]
        public bool Urgent { get; set; }

        /// <summary>
        /// The timestamp when the appointment started the check in process.
        /// If this is set while an appointment is still in status 'f', it means that the check-in process has begun but is not yet completed.
        /// </summary>
        [JsonProperty("startcheckin")]
        public string StartCheckIn { get; set; }

        /// <summary>
        /// If there is an appointment confirmation result for this appointment, the numeric ID (global to athenaNet).
        /// </summary>
        [JsonProperty("appointmentconfirmationid")]
        public int? AppointmentConfirmationId { get; set; }

        /// <summary>
        /// High risk score for Smart Scheduling
        /// </summary>
        [JsonProperty("suggestedoverbooking")]
        public string SuggestedOverBooking { get; set; }

        /// <summary>
        /// Detailed information about the copay for this appointment.
        /// Gives more detail than the COPAY field.
        /// Note: this information is not yet available in all practices, we are rolling this out slowly.
        /// </summary>
        [JsonProperty("appointmentcopay")]
        public AppointmentCopay AppointmentCopay { get; set; }

        /// <summary>
        /// Appointment ID of the booked appointment
        /// </summary>
        [JsonProperty("appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// The appointment date.
        /// </summary>
        [JsonProperty("date")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime Date { get; set; }

        /// <summary>
        /// See /patients for details.
        /// </summary>
        [JsonProperty("patient")]
        public string Patient { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss) that the appointment check-out was started.
        /// </summary>
        [JsonProperty("startcheckoutdatetime")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm:ss")]
        public DateTime? StartCheckoutDateTime { get; set; }

        /// <summary>
        /// If there is an appointment confirmation result for this appointment, the name (global to athenaNet).
        /// </summary>
        [JsonProperty("appointmentconfirmationname")]
        public string AppointmentConfirmationName { get; set; }

        /// <summary>
        /// An array of expected procedure codes attached to this appointment.
        /// </summary>
        [JsonProperty("useexpectedprocedurecodes")]
        public ExpectedProcedureCode UseExpectedProcedureCodes { get; set; }

        /// <summary>
        /// The user who last modified the appointment.
        /// </summary>
        [JsonProperty("lastmodifiedby")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// The patient-friendly name for this appointment type.  Note that this may not be the same as the booked appointment because of "generic" slots.
        /// </summary>
        [JsonProperty("patientappointmenttypename")]
        public string PatientAppointmentTypeName { get; set; }

        /// <summary>
        /// As HH:MM (where HH is the 0-23 hour and MM is the minute).  This time is local to the department.
        /// </summary>
        [JsonProperty("starttime")]
        [JsonConverter(typeof(DateConverter), "HH:mm")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The timestamp when the check-in process was finished for this appointment.
        /// </summary>
        [JsonProperty("stopcheckin")]
        public string StopCheckIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss) that the exam was completed.
        /// </summary>
        [JsonProperty("stopexamdatetime")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm:ss")]
        public DateTime? StopExamDateTime { get; set; }

        /// <summary>
        /// The rendering provider ID.
        /// </summary>
        [JsonProperty("renderingproviderid")]
        public int? RenderingProviderId { get; set; }

        /// <summary>
        /// The supervising provider ID.
        /// </summary>
        [JsonProperty("supervisingproviderid")]
        public int? SupervisingProviderId { get; set; }

        /// <summary>
        /// As detailed in /claims, if requested.
        /// </summary>
        [JsonProperty("claims")]
        public Claim[] Claims { get; set; }

        /// <summary>
        /// List of active patient insurance packages. Only shown for single or multiple booked appointments if SHOWINSURANCE is set.
        /// </summary>
        [JsonProperty("insurances")]
        public Insurance[] Insurances { get; set; }

        /// <summary>
        /// The location of the patient. See /patientlocation for practice list. Only present for appointments with Clinicals that have been checked in.
        /// </summary>
        [JsonProperty("patientlocationid")]
        public int? PatientLocationId { get; set; }

        /// <summary>
        /// The status of the clinical encounter associated with this appointment (OPEN, CLOSED, DELETED, PEND, etc.). This differs from <see cref="EncounterStatus"/>, which refers to the status of the patient in the encounter.
        /// </summary>
        [JsonProperty("encounterstate")]
        public string EncounterState { get; set; }

        /// <summary>
        /// When an appointment is rescheduled, this is the ID of the replacement appointment.
        /// </summary>
        [JsonProperty("rescheduledappointmentid")]
        public int? RescheduledAppointmentId { get; set; }

        /// <summary>
        /// The referring provider ID.
        /// </summary>
        [JsonProperty("referringproviderid")]
        public int? ReferringProviderId { get; set; }

        /// <summary>
        /// Detailed ReminderCall information made for this appointment.
        /// </summary>
        [JsonProperty("reminderdetails")]
        public ReminderCall ReminderDetails { get; set; }

        /// <summary>
        /// The original appointment type for this slot. This can change for generic appointments.
        /// </summary>
        [JsonProperty("templateappointmenttypeid")]
        public int? TemplateAppointmentTypeId { get; set; }

        /// <summary>
        /// The original appointment ID. This is useful if an appointment has been cancelled and you want to find the original ID.
        /// </summary>
        [JsonProperty("templateappointmentid")]
        public int? TemplateAppointmentId { get; set; }

        /// <summary>
        /// The athenaNet patient ID for this appointment
        /// </summary>
        [JsonProperty("patientid")]
        public int? PatientId { get; set; }
    }

    public class ReminderCall
    {
        /// <summary>
        /// The type of message that was attempted.
        /// </summary>
        [JsonProperty("messagetype")]
        public string MessageType { get; set; }

        /// <summary>
        /// Date and time of the call attempt.
        /// </summary>
        [JsonProperty("calltime")]
        public string CallTime { get; set; }

        /// <summary>
        /// Id of the message attempt.
        /// </summary>
        [JsonProperty("messageresultid")]
        public int? MessageResultId { get; set; }

        /// <summary>
        /// A description of what happened during the call attempt.
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class ExpectedProcedureCode
    {
        /// <summary>
        /// The ID of the code.
        /// </summary>
        [JsonProperty("procedurecode")]
        public string Id { get; set; }

        /// <summary>
        /// The description of the code.
        /// </summary>
        [JsonProperty("procedurecodedescription")]
        public string Description { get; set; }
    }

    public class AppointmentNoteDisplayedOnSchedule
    {
        /// <summary>
        /// The id of the appointment note.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The note associated with the appointment.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Whether the note should be displayed on the schedule.
        /// </summary>
        [JsonProperty("displayonschedule")]
        public bool DisplayOnSchedule { get; set; }
    }
}
