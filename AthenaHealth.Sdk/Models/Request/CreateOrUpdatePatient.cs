using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public abstract class CreateOrUpdatePatient
    {
        /// <summary>
        /// Primary (registration) department ID.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Patient's DOB (mm/dd/yyyy)
        /// </summary>
        [JsonProperty(PropertyName = "dob")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// (Max length: 35)
        /// </summary>
        [JsonProperty(PropertyName = "firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// (Max length: 60)
        /// </summary>
        [JsonProperty(PropertyName = "lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// (Max length: 100)
        /// </summary>
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// (Max length: 100)
        /// </summary>
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "agriculturalworker")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public YesNoDeclinedEnum? AgriculturalWorker { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "agriculturalworkertype")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public AgriculturalWorkerTypeEnum? AgriculturalWorkerType { get; set; }

        /// <summary>
        /// Alternate first name that differs from legal name.
        /// </summary>
        [JsonProperty(PropertyName = "altfirstname")]
        public string AltFirstName { get; set; }

        /// <summary>
        /// Sex that this patient was assigned at birth.
        /// </summary>
        [JsonProperty(PropertyName = "assignedsexatbirth")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public SexEnum? AssignedSexAtBirth { get; set; }

        /// <summary>
        /// (Max length: 50)
        /// </summary>
        [JsonProperty(PropertyName = "caresummarydeliverypreference")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public CareSummaryDeliveryPreferenceEnum? CareSummaryDeliveryPreference { get; set; }

        /// <summary>
        /// (Max length: 30)
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// The clinical order type group of the clinical provider (Prescription: 10, Lab: 11,
        /// Vaccinations: 16).
        /// </summary>
        [JsonProperty(PropertyName = "clinicalordertypegroupid")]
        public string ClinicalOrderTypeGroupId { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "consenttocall")]
        public bool? ConsentToCall { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "consenttotext")]
        public bool? ConsentToText { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "contacthomephone")]
        public string ContactHomePhone { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "contactmobilephone")]
        public string ContactMobilePhone { get; set; }

        /// <summary>
        /// (Max length: 50)
        /// </summary>
        [JsonProperty(PropertyName = "contactname")]
        public string ContactName { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public ContactPreferenceEnum? ContactPreference { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "announcement"
        /// communications delivered via email. Note that this will not be present if the practice or
        /// patient has not set it.For completeness, turning email off is supported via the API, but
        /// it is discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_announcement_email")]
        public bool? ContactPreferenceAnnouncementEmail { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "announcement"
        /// communications delivered via phone. Note that this will not be present if the practice or
        /// patient has not set it.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_announcement_phone")]
        public bool? ContactPreferenceAnnouncementPhone { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "announcement"
        /// communications delivered via SMS. Note that this will not be present if the practice or
        /// patient has not set it.For SMS, there is specific terms of service language that must be
        /// used when displaying this as an option to be turned on. Turning on must be an action by
        /// the patient, not a practice user.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_announcement_sms")]
        public bool? ContactPreferenceAnnouncementSms { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "appointment"
        /// communications delivered via email. Note that this will not be present if the practice or
        /// patient has not set it.For completeness, turning email off is supported via the API, but
        /// it is discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_appointment_email")]
        public bool? ContactPreferenceAppointmentEemail { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "appointment"
        /// communications delivered via phone. Note that this will not be present if the practice or
        /// patient has not set it.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_appointment_phone")]
        public bool? ContactPreferenceAppointmentPhone { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "appointment"
        /// communications delivered via SMS. Note that this will not be present if the practice or
        /// patient has not set it.For SMS, there is specific terms of service language that must be
        /// used when displaying this as an option to be turned on. Turning on must be an action by
        /// the patient, not a practice user.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_appointment_sms")]
        public bool? ContactPreferenceAppointmentSms { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "billing" communications
        /// delivered via email. Note that this will not be present if the practice or patient has
        /// not set it.For completeness, turning email off is supported via the API, but it is
        /// discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_billing_email")]
        public bool? ContactPreferenceBillingEmail { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "billing" communications
        /// delivered via phone. Note that this will not be present if the practice or patient has
        /// not set it.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_billing_phone")]
        public bool? ContactPreferenceBillingPhone { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "billing" communications
        /// delivered via SMS. Note that this will not be present if the practice or patient has not
        /// set it.For SMS, there is specific terms of service language that must be used when
        /// displaying this as an option to be turned on. Turning on must be an action by the
        /// patient, not a practice user.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_billing_sms")]
        public bool? ContactPreferenceBillingSms { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "lab" communications
        /// delivered via email. Note that this will not be present if the practice or patient has
        /// not set it.For completeness, turning email off is supported via the API, but it is
        /// discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_lab_email")]
        public bool? ContactPreferenceLabEmail { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "lab" communications
        /// delivered via phone. Note that this will not be present if the practice or patient has
        /// not set it.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_lab_phone")]
        public bool? ContactPreferenceLabPhone { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "lab" communications
        /// delivered via SMS. Note that this will not be present if the practice or patient has not
        /// set it.For SMS, there is specific terms of service language that must be used when
        /// displaying this as an option to be turned on. Turning on must be an action by the
        /// patient, not a practice user.
        /// </summary>
        [JsonProperty(PropertyName = "contactpreference_lab_sms")]
        public bool? ContactPreferenceLabSms { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty(PropertyName = "contactrelationship")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public RelationshipEnum? ContactRelationship { get; set; }

        /// <summary>
        /// Patient's country code (ISO 3166-1)
        /// </summary>
        [JsonProperty(PropertyName = "countrycode3166")]
        public string CountryCode3166 { get; set; }

        /// <summary>
        /// If present, the date on which a patient died.
        /// </summary>
        [JsonProperty(PropertyName = "deceaseddate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? DeceasedDate { get; set; }

        /// <summary>
        /// The NCPDP ID of the patient's preferred pharmacy. See http://www.ncpdp.org/ for details.
        /// Note: if updating this field, please make sure to have a CLINICALORDERTYPEGROUPID field
        /// as well.
        /// </summary>
        [JsonProperty(PropertyName = "defaultpharmacyncpdpid")]
        public string DefaultPharmacyNcpdpId { get; set; }

        /// <summary>
        /// Warning! This patient will not receive any communication from the practice if this field
        /// is set to true. This field should only be used if you are absolutely certain that's what
        /// you want to do.
        /// </summary>
        [JsonProperty(PropertyName = "donotcallyn")]
        public bool? DoNotCall { get; set; }

        /// <summary>
        /// The expiration date of the patient's driver's license.
        /// </summary>
        [JsonProperty(PropertyName = "driverslicenseexpirationdate")]
        public string DriversLicenseExpirationDate { get; set; }

        /// <summary>
        /// The number of the patient's driver's license
        /// </summary>
        [JsonProperty(PropertyName = "driverslicensenumber")]
        public string DriversLicenseNumber { get; set; }

        /// <summary>
        /// The state of the patient's driver's license. This is in the form of a 2 letter state code.
        /// </summary>
        [JsonProperty(PropertyName = "driverslicensestateid")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public DriversLicenseStateEnum? DriversLicenseStateId { get; set; }

        /// <summary>
        /// (Max length: 50)
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// The patient's employer's ID (from /employers call)
        /// </summary>
        [JsonProperty(PropertyName = "employerid")]
        public int? EmployerId { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "employerphone")]
        public string EmployerPhone { get; set; }

        /// <summary>
        /// Ethnicity of the patient, using the 2.16.840.1.113883.5.50 codeset. See
        /// http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
        /// "declined" to indicate that the patient declined to answer.
        /// </summary>
        [JsonProperty(PropertyName = "ethnicitycode")]
        public string EthnicityCode { get; set; }

        /// <summary>
        /// Gender with which this patient identifies. To see the available options for this input,
        /// please see GET /configuration/patients/genderidentity
        /// </summary>
        [JsonProperty(PropertyName = "genderidentity")]
        public string GenderIdentity { get; set; }

        /// <summary>
        /// Only valid when used in conjunction with a gender identity choice that allows the patient
        /// to describe their identity (if it doesn't conform to any other choice).
        /// </summary>
        [JsonProperty(PropertyName = "genderidentityother")]
        public string GenderIdentityOther { get; set; }

        /// <summary>
        /// (Max length: 100)
        /// </summary>
        [JsonProperty(PropertyName = "guarantoraddress1")]
        public string GuarantorAddress1 { get; set; }

        /// <summary>
        /// (Max length: 100)
        /// </summary>
        [JsonProperty(PropertyName = "guarantoraddress2")]
        public string GuarantorAddress2 { get; set; }

        /// <summary>
        /// If set, the address of the guarantor is the same as the patient.
        /// </summary>
        [JsonProperty(PropertyName = "guarantoraddresssameaspatient")]
        public bool? GuarantorAddressSameAsPatient { get; set; }

        /// <summary>
        /// (Max length: 30)
        /// </summary>
        [JsonProperty(PropertyName = "guarantorcity")]
        public string GuarantorCity { get; set; }

        /// <summary>
        /// Guarantor's country code (ISO 3166-1)
        /// </summary>
        [JsonProperty(PropertyName = "guarantorcountrycode3166")]
        public string GuarantorCountryCode3166 { get; set; }

        /// <summary>
        /// Guarantor's DOB (mm/dd/yyyy)
        /// </summary>
        [JsonProperty(PropertyName = "guarantordob")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? GuarantorDateOfBirth { get; set; }

        /// <summary>
        /// (Max length: 50)
        /// </summary>
        [JsonProperty(PropertyName = "guarantoremail")]
        public string GuarantorEmail { get; set; }

        /// <summary>
        /// The guaranror's employer's ID (from /employers call)
        /// </summary>
        [JsonProperty(PropertyName = "guarantoremployerid")]
        public int? GuarantorEmployerId { get; set; }

        /// <summary>
        /// (Max length: 35)
        /// </summary>
        [JsonProperty(PropertyName = "guarantorfirstname")]
        public string GuarantorFirstName { get; set; }

        /// <summary>
        /// (Max length: 60)
        /// </summary>
        [JsonProperty(PropertyName = "guarantorlastname")]
        public string GuarantorLastName { get; set; }

        /// <summary>
        /// (Max length: 25)
        /// </summary>
        [JsonProperty(PropertyName = "guarantormiddlename")]
        public string GuarantorMiddleName { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "guarantorphone")]
        public string GuarantorPhone { get; set; }

        /// <summary>
        /// The guarantor's relationship to the patient
        /// </summary>
        [JsonProperty(PropertyName = "guarantorrelationshiptopatient")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public GuarantorRelationshipToPatientEnum? GuarantorRelationshipToPatient { get; set; }

        /// <summary>
        /// (Max length: 13)
        /// </summary>
        [JsonProperty(PropertyName = "guarantorssn")]
        public string GuarantorSsn { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty(PropertyName = "guarantorstate")]
        public string GuarantorState { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty(PropertyName = "guarantorsuffix")]
        public string GuarantorSuffix { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty(PropertyName = "guarantorzip")]
        public string GuarantorZip { get; set; }

        /// <summary>
        /// (Max length: 35)
        /// </summary>
        [JsonProperty(PropertyName = "guardianfirstname")]
        public string GuardianFirstName { get; set; }

        /// <summary>
        /// (Max length: 60)
        /// </summary>
        [JsonProperty(PropertyName = "guardianlastname")]
        public string GuardianLastName { get; set; }

        /// <summary>
        /// (Max length: 25)
        /// </summary>
        [JsonProperty(PropertyName = "guardianmiddlename")]
        public string GuardianMiddleName { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty(PropertyName = "guardiansuffix")]
        public string GuardianSuffix { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "hasmobileyn")]
        public bool? HasMobile { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "homeboundyn")]
        public bool? Homebound { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "homeless")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public YesNoDeclinedEnum? Homeless { get; set; }

        /// <summary>
        /// (Max length: 30)
        /// </summary>
        [JsonProperty(PropertyName = "homelesstype")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public HomelessTypeEnum? HomelessType { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "homephone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// Set to true to allow ability to find patients with record restrictions and blocked
        /// patients. This should only be used when there is no reflection to the patient at all that
        /// a match was found or not found.
        /// </summary>
        [JsonProperty(PropertyName = "ignorerestrictions")]
        public bool? IgnoreRestrictions { get; set; }

        /// <summary>
        /// Industry of the patient, using the US Census industry code (code system
        /// 2.16.840.1.113883.6.310). "other" can be used as well.
        /// </summary>
        [JsonProperty(PropertyName = "industrycode")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// Language of the patient, using the ISO 639.2 code.
        /// (http://www.loc.gov/standards/iso639-2/php/code_list.php; "T" or terminology code)
        /// Special case: use "declined" to indicate that the patient declined to answer.
        /// </summary>
        [JsonProperty(PropertyName = "language6392code")]
        public string Language6392Code { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "maritalstatus")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public MaritalStatusEnum? MaritalStatus { get; set; }

        /// <summary>
        /// (Max length: 25)
        /// </summary>
        [JsonProperty(PropertyName = "middlename")]
        public string MiddleName { get; set; }

        /// <summary>
        /// The ID of the mobile carrier, from /mobilecarriers or the list below.
        /// </summary>
        [JsonProperty(PropertyName = "mobilecarrierid")]
        public string MobileCarrierId { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "mobilephone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// (Max length: 50)
        /// </summary>
        [JsonProperty(PropertyName = "nextkinname")]
        public string NextKinName { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "nextkinphone")]
        public string NextKinPhone { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty(PropertyName = "nextkinrelationship")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public RelationshipEnum? NextKinRelationship { get; set; }

        /// <summary>
        /// (Max length: 4000)
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Occupation of the patient, using the US Census occupation code (code system
        /// 2.16.840.1.113883.6.240). "other" can be used as well.
        /// </summary>
        [JsonProperty(PropertyName = "occupationcode")]
        public string OccupationCode { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "onlinestatementonlyyn")]
        public bool? OnlineStatementOnly { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "portalaccessgiven")]
        public bool? PortalAccessGiven { get; set; }

        /// <summary>
        /// Patient's poverty level (% of the Federal Poverty Level), as calculated from family size,
        /// income per pay period, pay period, and state. Typically only valued if client has Federal
        /// Poverty Level fields turned on.
        /// </summary>
        [JsonProperty(PropertyName = "povertylevelcalculated")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public PovertyLevelCalculatedEnum? PovertyLevelCalculated { get; set; }

        /// <summary>
        /// Patient's family size (used for determining poverty level). Only settable if client has
        /// Federal Poverty Level fields turned on.
        /// </summary>
        [JsonProperty(PropertyName = "povertylevelfamilysize")]
        public int? PovertyLevelFamilysize { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "povertylevelfamilysizedeclined")]
        public bool? PovertyLevelFamilySizeDeclined { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "povertylevelincomedeclined")]
        public bool? PovertyLevelIncomeDeclined { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "povertylevelincomepayperiod")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public PovertyLevelIncomePayPeriodEnum? PovertyLevelIncomePayPeriod { get; set; }

        /// <summary>
        /// Patient's income per specified pay period (used for determining poverty level). Only
        /// settable if client has Federal Poverty Level fields turned on.
        /// </summary>
        [JsonProperty(PropertyName = "povertylevelincomeperpayperiod")]
        public int? PovertyLevelIncomePerPayPeriod { get; set; }

        /// <summary>
        /// Indicates whether or not the patient declines to provide an income level (povertylevelcalculated).
        /// </summary>
        [JsonProperty(PropertyName = "povertylevelincomerangedeclined")]
        public bool? PovertyLevelIncomeRangeDeclined { get; set; }

        /// <summary>
        /// (Max length: 35)
        /// </summary>
        [JsonProperty(PropertyName = "preferredname")]
        public string PreferredName { get; set; }

        /// <summary>
        /// Pronoun this patient uses.
        /// </summary>
        [JsonProperty(PropertyName = "preferredpronouns")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public PreferredPronounsEnum? PreferredPronouns { get; set; }

        /// <summary>
        /// The patient's "current" department. This field is not always set by the practice.
        /// </summary>
        [JsonProperty(PropertyName = "primarydepartmentid")]
        public string PrimaryDepartmentId { get; set; }

        /// <summary>
        /// The "primary" provider for this patient, if set.
        /// </summary>
        [JsonProperty(PropertyName = "primaryproviderid")]
        public string PrimaryProviderId { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "publichousing")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public YesNoDeclinedEnum? PublicHousing { get; set; }

        /// <summary>
        /// The patient race, using the 2.16.840.1.113883.5.104 codeset. See
        /// http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
        /// "declined" to indicate that the patient declined to answer. Multiple values or a
        /// tab-seperated list of codes is acceptable for multiple races for input. The first race
        /// will be considered "primary". Note: you must update all values at once if you update any.
        /// </summary>
        [JsonProperty(PropertyName = "race")]
        public string Race { get; set; }

        /// <summary>
        /// The referral / "how did you hear about us" ID.
        /// </summary>
        [JsonProperty(PropertyName = "referralsourceid")]
        public string ReferralSourceId { get; set; }

        /// <summary>
        /// (Max length: 100)
        /// </summary>
        [JsonProperty(PropertyName = "referralsourceother")]
        public string ReferralSourceOther { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "schoolbasedhealthcenter")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public YesNoDeclinedEnum? SchoolBasedHealthCenter { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "sex")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public SexEnum? Sex { get; set; }

        /// <summary>
        /// Sexual orientation of this patient.
        /// </summary>
        [JsonProperty(PropertyName = "sexualorientation")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public SexualOrientationEnum? SexualOrientation { get; set; }

        /// <summary>
        /// Only valid when used in conjunction with a sexual orientation choice that allows the
        /// patient to describe their orientation (if it doesn't conform to any other choice).
        /// </summary>
        [JsonProperty(PropertyName = "sexualorientationother")]
        public string SexualOrientationOther { get; set; }

        /// <summary>
        /// (Max length: 13)
        /// </summary>
        [JsonProperty(PropertyName = "ssn")]
        public string Ssn { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty(PropertyName = "suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty(PropertyName = "veteran")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public YesNoDeclinedEnum? Veteran { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty(PropertyName = "workphone")]
        public string WorkPhone { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }
    }
}
