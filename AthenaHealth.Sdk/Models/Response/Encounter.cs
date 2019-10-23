using System;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class Encounter
    {
        /// <summary>
        /// Athena ID for this encounter
        /// </summary>
        [JsonProperty("encounterid")]
        public int Id { get; set; }

        /// <summary>
        /// The date the encounter was last reopened. The field will not be present if the encounter has not be closed.
        /// </summary>
        [JsonProperty(PropertyName = "lastreopened")]
        public DateTime LastReopened { get; set; }

        /// <summary>
        /// List of diagnoses for this encounter
        /// </summary>
        [JsonProperty(PropertyName = "diagnoses")]
        public DiagnoseForEncounter[] Diagnoses { get; set; }

        /// <summary>
        /// The athena department ID of this encounter
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Athena appointment ID resulting in this encounter
        /// </summary>
        [JsonProperty(PropertyName = "appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// The visit name for this encounter
        /// </summary>
        [JsonProperty(PropertyName = "encountervisitname")]
        public string EncounterVisitName { get; set; }

        /// <summary>
        /// Type of encounter (FLOWSHEET, ORDERSONLY, VISIT, etc.). By default only VISIT and ORDERSONLY are shown, use INCLUDEALLtypeS flag to see others.
        /// </summary>
        [JsonProperty(PropertyName = "encountertype")]
        public string EncounterType { get; set; }

        /// <summary>
        /// Status of this encounter (CLOSED, OPEN, PEND). By default only OPEN, CLOSED, and REVIEW statuses are shown, use INCLUDEALLSTATUSES flag to see others.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Athena ID for the patient location
        /// </summary>
        [JsonProperty(PropertyName = "patientlocationid")]
        public int? PatientlocationId { get; set; }

        /// <summary>
        /// Patient location
        /// </summary>
        [JsonProperty(PropertyName = "patientlocation")]
        public string PatientLocation { get; set; }

        /// <summary>
        /// Athena ID for the patient status
        /// </summary>
        [JsonProperty(PropertyName = "patientstatusid")]
        public int? PatientStatusId { get; set; }

        /// <summary>
        /// Patient status
        /// </summary>
        [JsonProperty(PropertyName = "patientstatus")]
        public string PatientStatus { get; set; }

        /// <summary>
        /// Date when this encounter occured
        /// </summary>
        [JsonProperty(PropertyName = "encounterdate")]
        public DateTime EncounterDate { get; set; }

        /// <summary>
        /// Last stage of the encounter
        /// </summary>
        [JsonProperty(PropertyName = "stage")]
        public string Stage { get; set; }

        /// <summary>
        /// The ID of the provider for this encounter
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// First name of the provider for this encounter
        /// </summary>
        [JsonProperty(PropertyName = "providerfirstname")]
        public string ProviderFirstName { get; set; }

        /// <summary>
        /// Last name of the provider for this encounter
        /// </summary>
        [JsonProperty(PropertyName = "providerlastname")]
        public string ProviderLastName { get; set; }

        /// <summary>
        /// Phone number of the provider for this encounter
        /// </summary>
        [JsonProperty(PropertyName = "providerphone")]
        public string ProviderPhone { get; set; }

        /// <summary>
        /// Username of the provider who closed this encounter
        /// </summary>
        [JsonProperty(PropertyName = "closeduser")]
        public string ClosedUser { get; set; }

        /// <summary>
        /// date when this encounter was closed
        /// </summary>
        [JsonProperty(PropertyName = "closeddate")]
        public string ClosedDate { get; set; }

        /// <summary>
        /// The date the encounter was last updated
        /// </summary>
        [JsonProperty(PropertyName = "lastupdated")]
        public DateTime LastUpdated { get; set; }
    }

    public class IcdCode
    {
        /// <summary>
        /// Codeset for this code (ICD9 or ICD10)
        /// </summary>
        [JsonProperty(PropertyName = "codeset")]
        public string Codeset { get; set; }

        /// <summary>
        /// Actual ICD code for this diagnosis
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Brief description for this code
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional. Same as <see cref="Code"/>, but without ".", for ex. Code = "289.89", DiagnosisCode = "28989"
        /// </summary>
        [JsonProperty(PropertyName = "diagnosiscode")]
        public string DiagnosisCode { get; set; }
    }
}
