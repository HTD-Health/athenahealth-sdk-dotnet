using System;
using System.ComponentModel.DataAnnotations;
using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class CreateInsurance
    {
        public CreateInsurance(int insurancePackageId, SequenceEnum sequenceNumber)
        {
            InsurancePackageId = insurancePackageId;
            SequenceNumber = sequenceNumber;
        }

        public CreateInsurance(int insurancePackageId, SequenceEnum sequenceNumber, string insuranceIdNumber, string insurancePolicyHolderFirstName, string insurancePolicyHolderLastName, SexEnum insurancePolicyHolderSex)
            :this(insurancePackageId, sequenceNumber)
        {
            InsuranceIdNumber = insuranceIdNumber;
            InsurancePolicyHolderFirstName = insurancePolicyHolderFirstName;
            InsurancePolicyHolderLastName = insurancePolicyHolderLastName;
            InsurancePolicyHolderSex = insurancePolicyHolderSex;
        }


        /// <summary>
        /// If set, we will use the department id in an attempt to add to the local patient.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Set the date that the insurance will expire. This is usually a date within the next year and not in the past.
        /// </summary>
        [JsonProperty(PropertyName = "expirationdate")]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// The insurance policy ID number (as presented on the insurance card itself).
        /// </summary>
        [JsonProperty(PropertyName = "insuranceidnumber")]
        public string InsuranceIdNumber { get; set; }

        /// <summary>
        /// The athenaNet insurance package ID.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepackageid")]
        [Required]
        public int InsurancePackageId { get; set; }

        /// <summary>
        /// The phone number for the insurance company. Note: This defaults to the insurance package phone number. If this is set, it will override it. Likewise if blanked out, it will go back to default.
        /// </summary>
        [JsonProperty(PropertyName = "insurancephone")]
        public string InsurancePhone { get; set; }

        /// <summary>
        /// Name of the entity who holds this insurance policy. Required if entity type is set to non-person.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholder")]
        public string InsurancePolicyHolder { get; set; }

        /// <summary>
        /// The first address line of the insurance policy holder.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholderaddress1")]
        public string InsurancePolicyHolderAddress1 { get; set; }

        /// <summary>
        /// The second address line of the insurance policy holder.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholderaddress2")]
        public string InsurancePolicyHolderAddress2 { get; set; }

        /// <summary>
        /// The city of the insurance policy holder.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholdercity")]
        public string InsurancePolicyHolderCity { get; set; }

        /// <summary>
        /// The country code (3 letter) of the insurance policy holder.  Either this or insurancepolicyholdercountryiso3166 are acceptable.  Defaults to USA.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholdercountrycode")]
        public string InsurancePolicyHolderCountryCode { get; set; }

        /// <summary>
        /// The ISO 3166 country code of the insurance policy holder.  Either this or insurancepolicyholdercountrycode are acceptable.  Defaults to US.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholdercountryiso3166")]
        public string InsurancePolicyHolderCountryIso3166 { get; set; }

        /// <summary>
        /// The DOB of the insurance policy holder (mm/dd/yyyy).
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholderdob")]
        public string InsurancePolicyHolderDob { get; set; }

        /// <summary>
        /// The first name of the insurance policy holder.  Except for self-pay, required for new policies.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholderfirstname")]
        public string InsurancePolicyHolderFirstName { get; set; }

        /// <summary>
        /// The last name of the insurance policy holder.  Except for self-pay, required for new policies.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholderlastname")]
        public string InsurancePolicyHolderLastName { get; set; }

        /// <summary>
        /// The middle name of the insurance policy holder.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholdermiddlename")]
        public string InsurancePolicyHolderMiddleName { get; set; }

        /// <summary>
        /// The sex of the insurance policy holder.  Except for self-pay, required for new policies.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholdersex")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public SexEnum InsurancePolicyHolderSex { get; set; }

        /// <summary>
        /// The SSN of the insurance policy holder.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholderssn")]
        public string InsurancePolicyHolderSsn { get; set; }

        /// <summary>
        /// The state of the insurance policy holder.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholderstate")]
        public string InsurancePolicyHolderState { get; set; }

        /// <summary>
        /// The suffix of the insurance policy holder.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholdersuffix")]
        public string InsurancePolicyHolderSuffix { get; set; }

        /// <summary>
        /// The zip of the insurance policy holder.
        /// </summary>
        [JsonProperty(PropertyName = "insurancepolicyholderzip")]
        public string InsurancePolicyHolderZip { get; set; }

        [JsonProperty(PropertyName = "insuredentitytypeid")]
        public string InsuredEntityTypeId { get; set; }

        /// <summary>
        /// Set the date that the insurance was issued. This is usually a date in the past year and not in the future.
        /// </summary>
        [JsonProperty(PropertyName = "issuedate")]
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// The insurance group number.  This is sometimes present on an insurance card.
        /// </summary>
        [JsonProperty(PropertyName = "policynumber")]
        public string PolicyNumber { get; set; }

        /// <summary>
        /// This patient's relationship to the policy holder (as an ID).  See  the mapping. Please note that if this is set to 12, Entity Type must be set to 2.
        /// </summary>
        [JsonProperty(PropertyName = "relationshiptoinsuredid")]
        public int? RelationshipToInsuredId { get; set; }

        /// <summary>
        /// 1 = primary, 2 = secondary.  Must have a primary before a secondary. This field is required if the insurance package is not a case policy.
        /// </summary>
        [JsonProperty(PropertyName = "sequencenumber")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public SequenceEnum SequenceNumber { get; set; }

        /// <summary>
        /// If set to true, automatically updates all future appointments to use this insurance as primary or secondary, respective to the sequence number.
        /// </summary>
        [JsonProperty(PropertyName = "updateappointments")]
        public bool UpdateAppointments { get; set; }

        /// <summary>
        /// BETA FIELD: If true, this makes sure that you have entered a valid INSURANCEIDNUMBER.  If you didn't it will error.  Setting this is probably a good thing and means you shouldn't have to do a ton of validation on the ID number.
        /// </summary>
        [JsonProperty(PropertyName = "validateinsuranceidnumber")]
        public bool ValidateInsuranceIdNumber { get; set; }
    }
}