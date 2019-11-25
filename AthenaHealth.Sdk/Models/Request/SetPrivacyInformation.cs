using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class SetPrivacyInformation
    {
        /// <summary>
        /// The ID of the department where the privacy information was verified.
        /// </summary>
        [JsonProperty("departmentid")]
        [Required]
        public int DepartmentId { get; set; }

        /// <summary>
        /// If presenting an e-signature, the mm/dd/yyyy hh24:mi:ss formatted time that the signer signed. This is required if a signature name is provided.
        /// </summary>
        [JsonProperty("signaturedatetime")]
        [JsonConverter(typeof(DateConverter))]
        [Required]
        public DateTime SignatureDateTime { get; set; }

        /// <summary>
        /// If presenting an e-signature, the name the signer typed, up to 100 characters.
        /// </summary>
        [JsonProperty("signaturename")]
        [Required]
        public string SignatureName { get; set; }

        /// <summary>
        /// The date this approval expires (for release of billing information and assignment of benefits).
        /// </summary>
        [JsonProperty("expirationdate")]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// If set, this flag sets the Assignment of Benefits privacy checkbox.
        /// </summary>
        [JsonProperty("insuredsignature")]
        public bool? InsuredSignature { get; set; }

        /// <summary>
        /// If set, this flag sets the Release of Billing Information privacy checkbox.
        /// </summary>
        [JsonProperty("patientsignature")]
        public bool? PatientSignature { get; set; }

        /// <summary>
        /// If set, this flag sets the Privacy Notice privacy checkbox.
        /// </summary>
        [JsonProperty("privacynotice")]
        public bool? PrivacyNotice { get; set; }

        /// <summary>
        /// If the patient is unable to sign a reason why.
        /// </summary>
        [JsonProperty("reasonpatientunabletosign")]
        public string ReasonPatientUnableToSign { get; set; }

        /// <summary>
        /// If presenting an e-signature, and the signer is signing on behalf of someone else, the relationship of the patient to the signer. There is a documentation page with details.
        /// </summary>
        [JsonProperty("signerrelationshiptopatientid")]
        public string SignerRelationshipToPatient { get; set; }

        public SetPrivacyInformation(int departmentId, DateTime signatureDateTime, string signatureName)
        {
            DepartmentId = departmentId;
            SignatureDateTime = signatureDateTime;
            SignatureName = signatureName;
        }
    }
}
