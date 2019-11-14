using Newtonsoft.Json;
using System;
using System.Collections.Generic;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class Claim
    {
        /// <summary>
        /// athenaNet's internal ID for this claim, specific to the practice.
        /// </summary>
        [JsonProperty("claimid")]
        public int Id { get; set; }

        /// <summary>
        /// The referring provider ID for this claim.  See /referringproviders.  This is not the same as the ID from the /providers call.
        /// </summary>
        [JsonProperty("referringproviderid")]
        public int? ReferringProviderId { get; set; }

        /// <summary>
        /// The status and notes of a responsible payer.  This payer is the primary insurance.
        /// </summary>
        [JsonProperty("primaryinsurancepayer")]
        public StatusNote PrimaryInsurancePayer { get; set; }

        /// <summary>
        /// Diagnoses is an array of all diagnoses.Each entry in the array is a hash with several fields.  /ccda is a better clinical representation.
        /// </summary>
        [JsonProperty("diagnoses")]
        public Appointment.Diagnosis[] Diagnoses { get; set; }

        /// <summary>
        /// The status and notes of a responsible payer.  This payer is the patient.
        /// </summary>
        [JsonProperty("patientpayer")]
        public StatusNote PatientPayer { get; set; }

        /// <summary>
        /// The date the claim was created.
        /// </summary>
        [JsonProperty("claimcreateddate")]
        public string ClaimCreatedDate { get; set; }

        /// <summary>
        /// Procedures is an array of all procedures.  /ccda is a better clinical representation.These fields are:
        /// </summary>
        [JsonProperty("procedures")]
        public Appointment.Procedure[] Procedures { get; set; }

        /// <summary>
        /// The billed date of service.
        /// </summary>
        [JsonProperty("billedservicedate")]
        public DateTime? BilledServiceDate { get; set; }

        /// <summary>
        /// The provider ID of the billing provider for this claim.
        /// </summary>
        [JsonProperty("billedproviderid")]
        public int? BilledProviderId { get; set; }

        /// <summary>
        /// The appointment ID associated with this claim.
        /// </summary>
        [JsonProperty("appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// The status and notes of a responsible payer.  This payer is the secondary insurace.
        /// </summary>
        [JsonProperty("secondaryinsurancepayer")]
        public StatusNote SecondaryInsurancePayer { get; set; }

        /// <summary>
        /// The total amount billed for all services from this claim.
        /// </summary>
        [JsonProperty("chargeamount")]
        public string ChargeAmount { get; set; }

        /// <summary>
        /// A hash of ids ("transactionid") to amounts; these should sum to the chargeamount. Please note that this has been deprecated in lieu of the data being available in the procedures section.
        /// </summary>
        [JsonProperty("transactiondetails")]
        public Dictionary<string, string> TransactionDetails { get; set; }

        /// <summary>
        /// A unique ID for the primary transaction this claim represents.  May be useful for debugging.
        /// </summary>
        [JsonProperty("transactionid")]
        public int? TransactionId { get; set; }

        public class StatusNote
        {
            /// <summary>
            /// The note that is attached to this status.
            /// </summary>
            [JsonProperty("note")]
            public string Note { get; set; }

            /// <summary>
            /// The status associated with this responsible payer.
            /// </summary>
            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("primarypatientinsuranceid")]
            public string PrimaryPatientInsuranceId { get; set; }

            [JsonProperty("secondarypatientinsuranceid")]
            public string SecondaryPatientInsuranceId { get; set; }
        }
    }
}
