using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class PrivacyInformationResponse
    {
        [JsonProperty("privacynotice")]
        public PrivacyNote PrivacyNotice { get; set; }

        [JsonProperty("patientsignature")]
        public PatientSignature PatientSignature { get; set; }

        [JsonProperty("insuredsignature")]
        public InsuredSignature InsuredSignature { get; set; }

        /// <summary>
        /// The number of checkboxes the practice has configured.
        /// </summary>
        [JsonProperty("checkboxesconfigured")]
        public int NumberOfCheckboxesConfigured { get; set; }
    }

    public class PrivacyNote
    {
        /// <summary>
        /// Flag that indicates whether or not the privacy notice check is set.
        /// This is set to false if it is expired.
        /// </summary>
        [JsonProperty("isprivacynoticeonfile")]
        public bool IsOnFile { get; set; }

        /// <summary>
        /// Note for not giving privacy notice.
        /// </summary>
        [JsonProperty("privacynoticenotgivennote")]
        public string GivenNote { get; set; }

        /// <summary>
        /// Reason for not giving privacy notice.
        /// </summary>
        [JsonProperty("privacynoticenotgivenreason")]
        public string GivenReason { get; set; }

        /// <summary>
        /// Date the privacy notice was given.
        /// </summary>
        [JsonProperty("privacynoticegivendate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? GivenDate { get; set; }
    }

    public class PatientSignature
    {
        /// <summary>
        /// Date the release of billing information check expires.
        /// </summary>
        [JsonProperty("patientsignatureexpirationdate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Date the release of billing information check takes effect.
        /// </summary>
        [JsonProperty("patientsignatureeffectivedate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Flag that indicates whether or not the release of billing information check is set.
        /// This is set to false if it is expired.
        /// </summary>
        [JsonProperty("ispatientsignatureonfile")]
        public bool IsOnFile { get; set; }
    }

    public class InsuredSignature
    {
        /// <summary>
        /// Date the assignment of benefits check expires.
        /// </summary>
        [JsonProperty("insuredsignatureexpirationdate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Date the assignment of benefits check takes effect.
        /// </summary>
        [JsonProperty("insuredsignatureeffectivedate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Flag that indicates whether or not the assignment of benefits check is set.
        /// This is set to false if it is expired.
        /// </summary>
        [JsonProperty("isinsuredsignatureonfile")]
        public bool IsOnFile { get; set; }
    }
}
