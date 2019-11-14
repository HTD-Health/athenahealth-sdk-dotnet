using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class AppointmentResponse : IPagingResponse<Appointment>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("appointments")]
        public Appointment[] Items { get; set; }
    }

    public class Appointment : AppointmentBase
    {
        /// <summary>
        /// An array of appointment notes for this appointment.
        /// </summary>
        [JsonProperty("appointmentnotes")]
        public AppointmentNote[] AppointmentNotes { get; set; }

        /// <summary>
        /// The athenaNet appointment status. There are several possible statuses.  x=cancelled. f=future. (It can include appointments where were never checked in, even if the appointment date is in the past. It is up to a practice to cancel appointments as a no show when appropriate to do so.)  o=open. 2=checked in. 3=checked out. 4=charge entered (i.e. a past appointment).
        /// </summary>
        [JsonProperty("appointmentstatus")]
        public AppointmentStatusEnum AppointmentStatus { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss; Eastern time) that this appointment was cancelled (if cancelled)
        /// </summary>
        [JsonProperty("cancelleddatetime")]
        public DateTime? CancelledDateTime { get; set; }

        /// <summary>
        /// This field will tell if an appointment has been marked as not requiring change entry.
        /// </summary>
        [JsonProperty("chargeentrynotrequired")]
        public bool ChargeEntryNotRequired { get; set; }

        /// <summary>
        /// This is the raw provider ID that should be used ONLY if using this appointment in conjunction with an HL7 message and with athenahealth's prior guidance. It is only available in some situations.
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
        /// The date/time when the appointment was last modified. Note: It may be possible for the lastmodified field to be updated without any other field in the API call being changed. This occurs when appointment fields not included in the API output are updated.
        /// </summary>
        [JsonProperty("lastmodified")]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss) that the appointment was checked out.
        /// </summary>
        [JsonProperty("checkoutdatetime")]
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
        public DateTime? StopIntakeDateTime { get; set; }

        /// <summary>
        /// The status of this patient in the encounter (READYFORSTAFF, WITHSTAFF, READFORPROVIDER, CHECKEDOUT). Only present for appointments with Clinicals that have been checked in.
        /// </summary>
        [JsonProperty("encounterstatus")]
        public string EncounterStatus { get; set; }

        /// <summary>
        /// If the appointment was cancelled, the numeric ID (local to the practice) for the cancel reason.
        /// </summary>
        [JsonProperty("cancelreasonid")]
        public int? CancelReasonId { get; set; }

        /// <summary>
        /// If the appointment was cancelled, if the cancel reason is marked as a no show reason.
        /// </summary>
        [JsonProperty("cancelreasonnoshow")]
        public bool CancelReasonNoShow { get; set; }

        /// <summary>
        /// If the appointment was cancelled, if the cancel reason is marked as a slot available reason.
        /// </summary>
        [JsonProperty("cancelreasonslotavailable")]
        public bool CancelReasonSlotAvailable { get; set; }

        /// <summary>
        /// If true, the appointment was booked through athenaCoordinator Enterprise.
        /// </summary>
        [JsonProperty("coordinatorenterprise")]
        public bool CoordinatorEnterprise { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss; Eastern time) that this appointment was scheduled.
        /// </summary>
        [JsonProperty("scheduleddatetime")]
        public DateTime? ScheduledDateTime { get; set; }

        /// <summary>
        /// Urgent flag for the appointment.
        /// </summary>
        [JsonProperty("urgent")]
        public bool Urgent { get; set; }

        /// <summary>
        /// The timestamp when the appointment started the check in process. If this is set while an appointment is still in status 'f', it means that the check-in process has begun but is not yet completed.
        /// </summary>
        [JsonProperty("startcheckin")]
        public DateTime? StartCheckIn { get; set; }

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
        /// Detailed information about the copay for this appointment.  Gives more detail than the COPAY field.  Note: this information is not yet available in all practices, we are rolling this out slowly.
        /// </summary>
        [JsonProperty("appointmentcopay")]
        public AppointmentCopay[] AppointmentCopay { get; set; }

        /// <summary>
        /// See /patients for details
        /// </summary>
        [JsonProperty("patient")]
        public Patient Patient { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss) that the appointment check-out was started.
        /// </summary>
        [JsonProperty("startcheckoutdatetime")]
        public DateTime? StartCheckOutDateTime { get; set; }

        /// <summary>
        /// If there is an appointment confirmation result for this appointment, the name (global to athenaNet).
        /// </summary>
        [JsonProperty("appointmentconfirmationname")]
        public string AppointmentConfirmationName { get; set; }

        /// <summary>
        /// An array of expected procedure codes attached to this appointment.
        /// </summary>
        [JsonProperty("useexpectedprocedurecodes")]
        public ExpectedProcedureCode[] UseExpectedProcedureCodes { get; set; }

        /// <summary>
        /// The user who last modified the appointment.
        /// </summary>
        [JsonProperty("lastmodifiedby")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// The timestamp when the check-in process was finished for this appointment.
        /// </summary>
        [JsonProperty("stopcheckin")]
        public string StopCheckIn { get; set; }

        /// <summary>
        /// The time (mm/dd/yyyy hh24:mi:ss) that the exam was completed.
        /// </summary>
        [JsonProperty("stopexamdatetime")]
        public DateTime? StopExamDateTime { get; set; }

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
        /// The status of the clinical encounter associated with this appointment (OPEN, CLOSED, DELETED, PEND, etc.). This differs from encounterstatus, which refers to the status of the patient in the encounter.
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
        public ReminderDetail[] ReminderDetails { get; set; }

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

        /// <summary>
        /// If true, encounter prep has been started for the encounter associated with this appointment.
        /// </summary>
        [JsonProperty("encounterprep")]
        public bool? EncounterPrep { get; set; }

        public class AppointmentNote
        {
            /// <summary>
            /// The id of the appointment note.
            /// </summary>
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// Whether the note should be displayed on the schedule.
            /// </summary>
            [JsonProperty("displayonschedule")]
            public bool DisplayOnSchedule { get; set; }

            /// <summary>
            /// The note associated with the appointment.
            /// </summary>
            [JsonProperty("text")]
            public string Text { get; set; }
        }

        public class ExpectedProcedureCode
        {
            /// <summary>
            /// The ID of the code.
            /// </summary>
            [JsonProperty("procedurecode")]
            public string ProcedureCode { get; set; }

            /// <summary>
            /// The description of the code.
            /// </summary>
            [JsonProperty("procedurecodedescription")]
            public string ProcedureCodeDescription { get; set; }
        }

        public class ReminderDetail
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

        public class Diagnosis
        {
            /// <summary>
            /// A unique ID related to this diagnosis.
            /// </summary>
            [JsonProperty("diagnosisid")]
            public int Id { get; set; }

            /// <summary>
            /// A description of this diagnosis.
            /// </summary>
            [JsonProperty("diagnosisdescription")]
            public string DiagnosisDescription { get; set; }

            /// <summary>
            /// The raw ICD-9 code.  This will migrate to ICD-10 in the future.
            /// </summary>
            [JsonProperty("diagnosisrawcode")]
            public string DiagnosisRawCode { get; set; }

            /// <summary>
            /// The category for this diagnosis.
            /// </summary>
            [JsonProperty("diagnosiscategory")]
            public string DiagnosisCategory { get; set; }

            /// <summary>
            /// In certain cases, diagnoses may be added and then removed from a particular claim.  In normal circumstances, this will be false.  However, if a diagnosis was removed, this will be true.
            /// </summary>
            [JsonProperty("deleteddiagnosis")]
            public string DeletedDiagnosis { get; set; }

            /// <summary>
            /// Either ICD9 or ICD10.
            /// </summary>
            [JsonProperty("diagnosiscodeset")]
            public string DiagnosisCodeSet { get; set; }
        }

        public class Procedure
        {
            /// <summary>
            /// The category name associated with this procedure.
            /// </summary>
            [JsonProperty("procedurecategory")]
            public string ProcedureCategory { get; set; }

            /// <summary>
            /// The minimum amount expected from payer for all services from this procedure.
            /// </summary>
            [JsonProperty("allowablemin")]
            public string AllowableMin { get; set; }

            /// <summary>
            /// A description of this procedure.
            /// </summary>
            [JsonProperty("proceduredescription")]
            public string ProcedureDescription { get; set; }

            /// <summary>
            /// The amount charged for this procedure.
            /// </summary>
            [JsonProperty("chargeamount")]
            public string ChargeAmount { get; set; }

            /// <summary>
            /// The ID of the last transaction associated with the claim.
            /// </summary>
            [JsonProperty("transactionid")]
            public int? TransactionId { get; set; }

            /// <summary>
            /// The CPT code associated with this procedure.
            /// </summary>
            [JsonProperty("procedurecode")]
            public string ProcedureCode { get; set; }

            /// <summary>
            /// The maximum amount expected from payer for all services from this procedure.
            /// </summary>
            [JsonProperty("allowablemax")]
            public string AllowableMax { get; set; }

            /// <summary>
            /// The total amount expected from payer for all services from this procedure.
            /// </summary>
            [JsonProperty("allowableamount")]
            public string AllowableAmount { get; set; }
        }
    }
}
