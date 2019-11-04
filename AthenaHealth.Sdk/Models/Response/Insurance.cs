using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class InsuranceResponse : IPagingResponse<Insurance>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("insurances")]
        public Insurance[] Items { get; set; }
    }

    public class Insurance
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("insuredcountrycode")]
        public string InsuredCountryCode { get; set; }

        [JsonProperty("insuredcity")]
        public string InsuredCity { get; set; }

        [JsonProperty("insureddob")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? InsuredDateOfBirth { get; set; }

        [JsonProperty("insuredaddress")]
        public string InsuredAddress { get; set; }

        [JsonProperty("insuredaddress2")]
        public string InsuredAddress2 { get; set; }

        [JsonProperty("insuredzip")]
        public string InsuredZip { get; set; }

        [JsonProperty("insuredsex")]
        public SexEnum? InsuredSex { get; set; }

        [JsonProperty("insuredstate")]
        public string InsuredState { get; set; }

        [JsonProperty("insuredcountryiso3166")]
        public string InsuredCountryIso3166 { get; set; }

        [JsonProperty("insuredfirstname")]
        public string InsuredFirstName { get; set; }

        [JsonProperty("insuredlastname")]
        public string InsuredLastName { get; set; }

        [JsonProperty("insuredssn")]
        public string InsuredSSN { get; set; }

        [JsonProperty("insuredmiddleinitial")]
        public string InsuredMiddleInitial { get; set; }

        [JsonProperty("insurednamesuffix")]
        public string InsuredNameSuffix { get; set; }

        /// <summary>
        /// The full name of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholder")]
        public string InsurancePolicyHolder { get; set; }

        /// <summary>
        /// The name of current CCM enrollment status.
        /// </summary>
        [JsonProperty("ccmstatusname")]
        public string CcmStatusName { get; set; }

        /// <summary>
        /// The second address line of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholderaddress2")]
        public string InsurancePolicyHolderAddress2 { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Date of the injury. Required for auto insurance, legal, and worker's
        /// comp case policies.
        /// </summary>
        [JsonProperty("caseinjurydate")]
        public string CaseInjuryDate { get; set; }

        /// <summary>
        /// The first name of the insurance policy holder. Except for self-pay, required for new policies.
        /// </summary>
        [JsonProperty("insurancepolicyholderfirstname")]
        public string InsurancePolicyHolderFirstName { get; set; }

        /// <summary>
        /// Date the insurance expires.
        /// </summary>
        [JsonProperty("expirationdate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The last name of the insurance policy holder. Except for self-pay, required for new policies.
        /// </summary>
        [JsonProperty("insurancepolicyholderlastname")]
        public string InsurancePolicyHolderLastName { get; set; }

        /// <summary>
        /// The date in which the insurance was marked cancelled.
        /// </summary>
        [JsonProperty("cancelled")]
        public string Cancelled { get; set; }

        /// <summary>
        /// The sex of the insurance policy holder. Except for self-pay, required for new policies.
        /// </summary>
        [JsonProperty("insurancepolicyholdersex")]
        public SexEnum? InsurancePolicyHolderSex { get; set; }

        /// <summary>
        /// 1 = primary, 2 = secondary, 3 = tertiary, etc. Must have a primary before a secondary and
        /// a secondary before a tertiary, etc.
        /// </summary>
        [JsonProperty("sequencenumber")]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - First name of the adjuster on this case policy. Only available for
        /// auto insurance or worker's comp case policies.
        /// </summary>
        [JsonProperty("adjusterfirstname")]
        public string AdjusterFirstName { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Boolean field indicating if another party was responsible for this accident.
        /// </summary>
        [JsonProperty("anotherpartyresponsible")]
        public bool? AnotherPartyResponsible { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - A description of the injury. Only available for auto insurance and
        /// worker's comp case policies.
        /// </summary>
        [JsonProperty("descriptionofinjury")]
        public string DescriptionOfInjury { get; set; }

        /// <summary>
        /// The source of the current status. Athena is our eligibility engine.
        /// </summary>
        [JsonProperty("eligibilityreason")]
        public string EligibilityReason { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - See documentation for ICD9CODES.
        /// </summary>
        [JsonProperty("icd10codes")]
        public string ICD10Codes { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - A list of ICD9 accepted diagnosis codes. Only available for worker's
        /// comp case policies.
        /// </summary>
        [JsonProperty("icd9codes")]
        public string ICD9Codes { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - The auto insurance claim number or the worker's comp claim number.
        /// </summary>
        [JsonProperty("insuranceclaimnumber")]
        public string InsuranceClaimNumber { get; set; }

        /// <summary>
        /// The athena insurance policy ID.
        /// </summary>
        [JsonProperty("insuranceid")]
        public int? InsuranceId { get; set; }

        /// <summary>
        /// Superpackagename of the specific insurance package.
        /// </summary>
        [JsonProperty("insuranceplandisplayname")]
        public string InsurancePlanDisplayName { get; set; }

        /// <summary>
        /// The city of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholdercity")]
        public string InsurancePolicyHolderCity { get; set; }

        /// <summary>
        /// The country code (3 letter) of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholdercountrycode")]
        public string InsurancePolicyHolderCountryCode { get; set; }

        /// <summary>
        /// The ISO 3166 country code of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholdercountryiso3166")]
        public string InsurancePolicyHolderCountryISO3166 { get; set; }

        /// <summary>
        /// The DOB of the insurance policy holder (mm/dd/yyyy).
        /// </summary>
        [JsonProperty("insurancepolicyholderdob")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? InsurancePolicyHolderDateOfBirth { get; set; }

        /// <summary>
        /// The middle name of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholdermiddlename")]
        public string InsurancePolicyHolderMiddleName { get; set; }

        /// <summary>
        /// The state of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholderstate")]
        public string InsurancePolicyHolderState { get; set; }

        /// <summary>
        /// The zip of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholderzip")]
        public string InsurancePolicyHolderZip { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Boolean field indicating whether this case policy is related to
        /// another accident. Only available for worker's comp case policies.
        /// </summary>
        [JsonProperty("relatedtootheraccident")]
        public bool? RelatedToOtherAccident { get; set; }

        /// <summary>
        /// The insurance group number. This is sometimes present on an insurance card.
        /// </summary>
        [JsonProperty("policynumber")]
        public string PolicyNumber { get; set; }

        /// <summary>
        /// If the patient is on a sliding fee plan, this is the ID of that plan. See /slidingfeeplans.
        /// </summary>
        [JsonProperty("slidingfeeplanid")]
        public int? SlidingFeePlanId { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Fax for the adjuster on this case policy. Only available for auto
        /// insurance or worker's comp case policies.
        /// </summary>
        [JsonProperty("adjusterfax")]
        public string AdjusterFax { get; set; }

        /// <summary>
        /// This patient's relationship to the policy holder (text).
        /// </summary>
        [JsonProperty("relationshiptoinsured")]
        public string RelationshipToInsured { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Two-letter state abbreviation for the state this injury was reported
        /// in. Only available for worker's comp case policies.
        /// </summary>
        [JsonProperty("stateofreportedinjury")]
        public string StateOfReportedInjury { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Boolean field indicating whether this case policy is related to an
        /// auto accident.
        /// </summary>
        [JsonProperty("relatedtoautoaccident")]
        public bool? RelatedToAutoAccident { get; set; }

        /// <summary>
        /// The message, usually from our engine, of the eligibility check.
        /// </summary>
        [JsonProperty("eligibilitymessage")]
        public string EligibilityMessage { get; set; }

        /// <summary>
        /// The insurance policy ID number (as presented on the insurance card itself).
        /// </summary>
        [JsonProperty("insuranceidnumber")]
        public string InsuranceIdNumber { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Phone number/other contact info for the adjuster on this case policy.
        /// Only available for auto insurance or worker's comp case policies.
        /// </summary>
        [JsonProperty("adjusterphone")]
        public string AdjusterPhone { get; set; }

        /// <summary>
        /// Address 1 for the AthenaNet insurance Package.
        /// </summary>
        [JsonProperty("insurancepackageaddress1")]
        public string InsurancePackageAddress1 { get; set; }

        /// <summary>
        /// The first address line of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholderaddress1")]
        public string InsurancePolicyHolderAddress1 { get; set; }

        /// <summary>
        /// Status ID of current CCM enrollment.
        /// </summary>
        [JsonProperty("ccmstatusid")]
        public int? CcmStatusId { get; set; }

        /// <summary>
        /// The coinsurance percentage for this insurance. If you've just POSTed a new insurance you
        /// will have to wait for the auto eligbility check before this field populates.
        /// </summary>
        [JsonProperty("coinsurancepercent")]
        public decimal? CoinsurancePercent { get; set; }

        /// <summary>
        /// The suffix of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholdersuffix")]
        public string InsurancePolicyHolderSuffix { get; set; }

        /// <summary>
        /// The national provider id of the primary care physician associated with the insurance.
        /// </summary>
        [JsonProperty("insuredpcpnpi")]
        public int? InsuredPrimaryCarePhysicianNationalProviderId { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Text field for describing the injured body part. Only available for
        /// auto insurance and worker's comp case policies.
        /// </summary>
        [JsonProperty("injuredbodypart")]
        public string InjuredBodyPart { get; set; }

        /// <summary>
        /// Date the eligibility was last checked.
        /// </summary>
        [JsonProperty("eligibilitylastchecked")]
        public string EligibilityLastChecked { get; set; }

        [JsonProperty("insuredpcp")]
        public string InsuredPrimaryCarePhysician { get; set; }

        /// <summary>
        /// Address 2 for the AthenaNet insurance Package.
        /// </summary>
        [JsonProperty("insurancepackageaddress2")]
        public string InsurancePackageAddress2 { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Two-letter abbreviation for the state in which the auto accident took
        /// place. Only meaningful for auto insurance case policies.
        /// </summary>
        [JsonProperty("autoaccidentstate")]
        public string AutoAccidentState { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Last name of the adjuster on this case policy. Only available for
        /// auto insurance or worker's comp case policies.
        /// </summary>
        [JsonProperty("adjusterlastname")]
        public string AdjusterLastName { get; set; }

        /// <summary>
        /// Details about the copays for this insurance package. If you've just POSTed a new
        /// insurance you will have to wait for the auto eligibility check before these populate.
        /// </summary>
        [JsonProperty("copays")]
        public Copay[] Copays { get; set; }

        /// <summary>
        /// Zip code of the AthenaNet insurance package
        /// </summary>
        [JsonProperty("insurancepackagezip")]
        public string InsurancePackageZip { get; set; }

        /// <summary>
        /// City for the AthenaNet insurance Package.
        /// </summary>
        [JsonProperty("insurancepackagecity")]
        public string InsurancePackageCity { get; set; }

        /// <summary>
        /// The SSN of the insurance policy holder.
        /// </summary>
        [JsonProperty("insurancepolicyholderssn")]
        public string InsurancePolicyHolderSSN { get; set; }

        /// <summary>
        /// Type of insurance. E.g., Medicare Part B, Group Policy, HMO, etc.
        /// </summary>
        [JsonProperty("insurancetype")]
        public string InsuranceType { get; set; }

        /// <summary>
        /// Insurance category / company. E.g., United Healthcare, BCBS-MA, etc.
        /// </summary>
        [JsonProperty("ircname")]
        public string InsuranceCompanyName { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - The name of this type of case policy.
        /// </summary>
        [JsonProperty("casepolicytypename")]
        public string CasePolicyTypeName { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Phone number for the repricer. Only available for worker's comp case policies.
        /// </summary>
        [JsonProperty("repricerphone")]
        public string RepricerPhone { get; set; }

        /// <summary>
        /// State of the AthenaNet insurance package.
        /// </summary>
        [JsonProperty("insurancepackagestate")]
        public string InsurancePackageState { get; set; }

        /// <summary>
        /// Name of the specific insurance package.
        /// </summary>
        [JsonProperty("insuranceplanname")]
        public string InsurancePlanName { get; set; }

        /// <summary>
        /// The athenaNet insurance package ID.
        /// </summary>
        [JsonProperty("insurancepackageid")]
        public string InsurancePackageId { get; set; }

        /// <summary>
        /// Current eligibility status of this insurance package.
        /// </summary>
        [JsonProperty("eligibilitystatus")]
        public string EligibilityStatus { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Boolean field indicating whether this case policy is related to the
        /// patient's employer.
        /// </summary>
        [JsonProperty("relatedtoemployment")]
        public bool? RelatedToEmployment { get; set; }

        /// <summary>
        /// The phone number for the insurance company. Note: This defaults to the insurance package
        /// phone number. If this is set, it will override it. Likewise if blanked out, it will go
        /// back to default.
        /// </summary>
        [JsonProperty("insurancephone")]
        public string InsurancePhone { get; set; }

        /// <summary>
        /// This patient's relationship to the policy holder (as an ID). See the mapping.
        /// </summary>
        [JsonProperty("relationshiptoinsuredid")]
        public int? RelationshipToInsuredId { get; set; }

        /// <summary>
        /// CASE POLICY FIELD - Name for the repricer. Only available for worker's comp case policies.
        /// </summary>
        [JsonProperty("repricername")]
        public string RepricerName { get; set; }

        /// <summary>
        /// The ID of the entity type for this insurance.
        /// </summary>
        [JsonProperty("insuredentitytypeid")]
        public int? InsuredEntityTypeId { get; set; }

        /// <summary>
        /// Date the insurance was issued.
        /// </summary>
        [JsonProperty("issuedate")]
        public string IssueDate { get; set; }

        /// <summary>
        /// The employer ID associated with the patient's insurance.
        /// </summary>
        [JsonProperty("employerid")]
        public string EmployerId { get; set; }

        public class Copay
        {
            /// <summary>
            /// What the copay amount applies to.
            /// </summary>
            [JsonProperty("copaytype")]
            public string CopayType { get; set; }

            /// <summary>
            /// The amount of the copay.
            /// </summary>
            [JsonProperty("copayamount")]
            public decimal? CopayAmount { get; set; }
        }
    }
}
