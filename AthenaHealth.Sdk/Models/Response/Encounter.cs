using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientEncounterResponse : IPagingResponse<Encounter>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("encounters")]
        public Encounter[] Items { get; set; }
    }

    public class Encounter
    {
        /// <summary>
        /// Athena ID for this encounter
        /// </summary>
        [JsonProperty("encounterid")]
        public int Id { get; set; }

        [JsonProperty("appointmentstartdate")]
        public DateTime? AppointmentStartDate { get; set; }

        /// <summary>
        /// The date the encounter was last reopened. The field will not be present if the encounter has not be closed.
        /// </summary>
        [JsonProperty("lastreopened")]
        public DateTime LastReopened { get; set; }

        /// <summary>
        /// List of diagnoses for this encounter
        /// </summary>
        [JsonProperty("diagnoses")]
        public DiagnoseForEncounter[] Diagnoses { get; set; }

        /// <summary>
        /// The athena department ID of this encounter
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Athena appointment ID resulting in this encounter
        /// </summary>
        [JsonProperty("appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// The visit name for this encounter
        /// </summary>
        [JsonProperty("encountervisitname")]
        public string EncounterVisitName { get; set; }

        /// <summary>
        /// Type of encounter (FLOWSHEET, ORDERSONLY, VISIT, etc.). By default only VISIT and ORDERSONLY are shown, use INCLUDEALLtypeS flag to see others.
        /// </summary>
        [JsonProperty("encountertype")]
        public string EncounterType { get; set; }

        /// <summary>
        /// Status of this encounter (CLOSED, OPEN, PEND). By default only OPEN, CLOSED, and REVIEW statuses are shown, use INCLUDEALLSTATUSES flag to see others.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Athena ID for the patient location
        /// </summary>
        [JsonProperty("patientlocationid")]
        public int? PatientlocationId { get; set; }

        /// <summary>
        /// Patient location
        /// </summary>
        [JsonProperty("patientlocation")]
        public string PatientLocation { get; set; }

        /// <summary>
        /// Athena ID for the patient status
        /// </summary>
        [JsonProperty("patientstatusid")]
        public int? PatientStatusId { get; set; }

        /// <summary>
        /// Patient status
        /// </summary>
        [JsonProperty("patientstatus")]
        public string PatientStatus { get; set; }

        /// <summary>
        /// Date when this encounter occured
        /// </summary>
        [JsonProperty("encounterdate")]
        public DateTime EncounterDate { get; set; }

        /// <summary>
        /// Last stage of the encounter
        /// </summary>
        [JsonProperty("stage")]
        public string Stage { get; set; }

        /// <summary>
        /// The ID of the provider for this encounter
        /// </summary>
        [JsonProperty("providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// First name of the provider for this encounter
        /// </summary>
        [JsonProperty("providerfirstname")]
        public string ProviderFirstName { get; set; }

        /// <summary>
        /// Last name of the provider for this encounter
        /// </summary>
        [JsonProperty("providerlastname")]
        public string ProviderLastName { get; set; }

        /// <summary>
        /// Phone number of the provider for this encounter
        /// </summary>
        [JsonProperty("providerphone")]
        public string ProviderPhone { get; set; }

        /// <summary>
        /// Username of the provider who closed this encounter
        /// </summary>
        [JsonProperty("closeduser")]
        public string ClosedUser { get; set; }

        /// <summary>
        /// date when this encounter was closed
        /// </summary>
        [JsonProperty("closeddate")]
        public string ClosedDate { get; set; }

        /// <summary>
        /// The date the encounter was last updated
        /// </summary>
        [JsonProperty("lastupdated")]
        public DateTime LastUpdated { get; set; }
    }

    public class IcdCode
    {
        /// <summary>
        /// Codeset for this code (ICD9 or ICD10)
        /// </summary>
        [JsonProperty("codeset")]
        public string Codeset { get; set; }

        /// <summary>
        /// Actual ICD code for this diagnosis
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Brief description for this code
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional. Same as <see cref="Code"/>, but without ".", for ex. Code = "289.89", DiagnosisCode = "28989"
        /// </summary>
        [JsonProperty("diagnosiscode")]
        public string DiagnosisCode { get; set; }
    }
}
