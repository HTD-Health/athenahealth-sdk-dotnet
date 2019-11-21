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
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Patient's DOB (mm/dd/yyyy)
        /// </summary>
        [JsonProperty("dob")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// (Max length: 35)
        /// </summary>
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// (Max length: 60)
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// (Max length: 100)
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// (Max length: 100)
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("agriculturalworker")]
        [JsonConverter(typeof(EnumConverter))]
        public YesNoDeclinedEnum? AgriculturalWorker { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("agriculturalworkertype")]
        [JsonConverter(typeof(EnumConverter))]
        public AgriculturalWorkerTypeEnum? AgriculturalWorkerType { get; set; }

        /// <summary>
        /// Alternate first name that differs from legal name.
        /// </summary>
        [JsonProperty("altfirstname")]
        public string AltFirstName { get; set; }

        /// <summary>
        /// Sex that this patient was assigned at birth.
        /// </summary>
        [JsonProperty("assignedsexatbirth")]
        [JsonConverter(typeof(EnumConverter))]
        public SexEnum? AssignedSexAtBirth { get; set; }

        /// <summary>
        /// (Max length: 50)
        /// </summary>
        [JsonProperty("caresummarydeliverypreference")]
        [JsonConverter(typeof(EnumConverter))]
        public CareSummaryDeliveryPreferenceEnum? CareSummaryDeliveryPreference { get; set; }

        /// <summary>
        /// (Max length: 30)
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The clinical order type group of the clinical provider (Prescription: 10, Lab: 11,
        /// Vaccinations: 16).
        /// </summary>
        [JsonProperty("clinicalordertypegroupid")]
        public string ClinicalOrderTypeGroupId { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("consenttocall")]
        public bool? ConsentToCall { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("consenttotext")]
        public bool? ConsentToText { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("contacthomephone")]
        public string ContactHomePhone { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("contactmobilephone")]
        public string ContactMobilePhone { get; set; }

        /// <summary>
        /// (Max length: 50)
        /// </summary>
        [JsonProperty("contactname")]
        public string ContactName { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("contactpreference")]
        [JsonConverter(typeof(EnumConverter))]
        public ContactPreferenceEnum? ContactPreference { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "announcement"
        /// communications delivered via email. Note that this will not be present if the practice or
        /// patient has not set it.For completeness, turning email off is supported via the API, but
        /// it is discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty("contactpreference_announcement_email")]
        public bool? ContactPreferenceAnnouncementEmail { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "announcement"
        /// communications delivered via phone. Note that this will not be present if the practice or
        /// patient has not set it.
        /// </summary>
        [JsonProperty("contactpreference_announcement_phone")]
        public bool? ContactPreferenceAnnouncementPhone { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "announcement"
        /// communications delivered via SMS. Note that this will not be present if the practice or
        /// patient has not set it.For SMS, there is specific terms of service language that must be
        /// used when displaying this as an option to be turned on. Turning on must be an action by
        /// the patient, not a practice user.
        /// </summary>
        [JsonProperty("contactpreference_announcement_sms")]
        public bool? ContactPreferenceAnnouncementSms { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "appointment"
        /// communications delivered via email. Note that this will not be present if the practice or
        /// patient has not set it.For completeness, turning email off is supported via the API, but
        /// it is discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty("contactpreference_appointment_email")]
        public bool? ContactPreferenceAppointmentEemail { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "appointment"
        /// communications delivered via phone. Note that this will not be present if the practice or
        /// patient has not set it.
        /// </summary>
        [JsonProperty("contactpreference_appointment_phone")]
        public bool? ContactPreferenceAppointmentPhone { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "appointment"
        /// communications delivered via SMS. Note that this will not be present if the practice or
        /// patient has not set it.For SMS, there is specific terms of service language that must be
        /// used when displaying this as an option to be turned on. Turning on must be an action by
        /// the patient, not a practice user.
        /// </summary>
        [JsonProperty("contactpreference_appointment_sms")]
        public bool? ContactPreferenceAppointmentSms { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "billing" communications
        /// delivered via email. Note that this will not be present if the practice or patient has
        /// not set it.For completeness, turning email off is supported via the API, but it is
        /// discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty("contactpreference_billing_email")]
        public bool? ContactPreferenceBillingEmail { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "billing" communications
        /// delivered via phone. Note that this will not be present if the practice or patient has
        /// not set it.
        /// </summary>
        [JsonProperty("contactpreference_billing_phone")]
        public bool? ContactPreferenceBillingPhone { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "billing" communications
        /// delivered via SMS. Note that this will not be present if the practice or patient has not
        /// set it.For SMS, there is specific terms of service language that must be used when
        /// displaying this as an option to be turned on. Turning on must be an action by the
        /// patient, not a practice user.
        /// </summary>
        [JsonProperty("contactpreference_billing_sms")]
        public bool? ContactPreferenceBillingSms { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "lab" communications
        /// delivered via email. Note that this will not be present if the practice or patient has
        /// not set it.For completeness, turning email off is supported via the API, but it is
        /// discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty("contactpreference_lab_email")]
        public bool? ContactPreferenceLabEmail { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "lab" communications
        /// delivered via phone. Note that this will not be present if the practice or patient has
        /// not set it.
        /// </summary>
        [JsonProperty("contactpreference_lab_phone")]
        public bool? ContactPreferenceLabPhone { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "lab" communications
        /// delivered via SMS. Note that this will not be present if the practice or patient has not
        /// set it.For SMS, there is specific terms of service language that must be used when
        /// displaying this as an option to be turned on. Turning on must be an action by the
        /// patient, not a practice user.
        /// </summary>
        [JsonProperty("contactpreference_lab_sms")]
        public bool? ContactPreferenceLabSms { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty("contactrelationship")]
        [JsonConverter(typeof(EnumConverter))]
        public RelationshipEnum? ContactRelationship { get; set; }

        /// <summary>
        /// Patient's country code (ISO 3166-1)
        /// </summary>
        [JsonProperty("countrycode3166")]
        public string CountryCode3166 { get; set; }

        /// <summary>
        /// If present, the date on which a patient died.
        /// </summary>
        [JsonProperty("deceaseddate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? DeceasedDate { get; set; }

        /// <summary>
        /// The NCPDP ID of the patient's preferred pharmacy. See http://www.ncpdp.org/ for details.
        /// Note: if updating this field, please make sure to have a CLINICALORDERTYPEGROUPID field
        /// as well.
        /// </summary>
        [JsonProperty("defaultpharmacyncpdpid")]
        public string DefaultPharmacyNcpdpId { get; set; }

        /// <summary>
        /// Warning! This patient will not receive any communication from the practice if this field
        /// is set to true. This field should only be used if you are absolutely certain that's what
        /// you want to do.
        /// </summary>
        [JsonProperty("donotcallyn")]
        public bool? DoNotCall { get; set; }

        /// <summary>
        /// The expiration date of the patient's driver's license.
        /// </summary>
        [JsonProperty("driverslicenseexpirationdate")]
        public string DriversLicenseExpirationDate { get; set; }

        /// <summary>
        /// The number of the patient's driver's license
        /// </summary>
        [JsonProperty("driverslicensenumber")]
        public string DriversLicenseNumber { get; set; }

        /// <summary>
        /// The state of the patient's driver's license. This is in the form of a 2 letter state code.
        /// </summary>
        [JsonProperty("driverslicensestateid")]
        [JsonConverter(typeof(EnumConverter))]
        public DriversLicenseStateEnum? DriversLicenseStateId { get; set; }

        /// <summary>
        /// (Max length: 50)
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The patient's employer's ID (from /employers call)
        /// </summary>
        [JsonProperty("employerid")]
        public int? EmployerId { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("employerphone")]
        public string EmployerPhone { get; set; }

        /// <summary>
        /// Ethnicity of the patient, using the 2.16.840.1.113883.5.50 codeset. See
        /// http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
        /// "declined" to indicate that the patient declined to answer.
        /// </summary>
        [JsonProperty("ethnicitycode")]
        public string EthnicityCode { get; set; }

        /// <summary>
        /// Gender with which this patient identifies. To see the available options for this input,
        /// please see GET /configuration/patients/genderidentity
        /// </summary>
        [JsonProperty("genderidentity")]
        public string GenderIdentity { get; set; }

        /// <summary>
        /// Only valid when used in conjunction with a gender identity choice that allows the patient
        /// to describe their identity (if it doesn't conform to any other choice).
        /// </summary>
        [JsonProperty("genderidentityother")]
        public string GenderIdentityOther { get; set; }

        /// <summary>
        /// (Max length: 100)
        /// </summary>
        [JsonProperty("guarantoraddress1")]
        public string GuarantorAddress1 { get; set; }

        /// <summary>
        /// (Max length: 100)
        /// </summary>
        [JsonProperty("guarantoraddress2")]
        public string GuarantorAddress2 { get; set; }

        /// <summary>
        /// If set, the address of the guarantor is the same as the patient.
        /// </summary>
        [JsonProperty("guarantoraddresssameaspatient")]
        public bool? GuarantorAddressSameAsPatient { get; set; }

        /// <summary>
        /// (Max length: 30)
        /// </summary>
        [JsonProperty("guarantorcity")]
        public string GuarantorCity { get; set; }

        /// <summary>
        /// Guarantor's country code (ISO 3166-1)
        /// </summary>
        [JsonProperty("guarantorcountrycode3166")]
        public string GuarantorCountryCode3166 { get; set; }

        /// <summary>
        /// Guarantor's DOB (mm/dd/yyyy)
        /// </summary>
        [JsonProperty("guarantordob")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? GuarantorDateOfBirth { get; set; }

        /// <summary>
        /// (Max length: 50)
        /// </summary>
        [JsonProperty("guarantoremail")]
        public string GuarantorEmail { get; set; }

        /// <summary>
        /// The guaranror's employer's ID (from /employers call)
        /// </summary>
        [JsonProperty("guarantoremployerid")]
        public int? GuarantorEmployerId { get; set; }

        /// <summary>
        /// (Max length: 35)
        /// </summary>
        [JsonProperty("guarantorfirstname")]
        public string GuarantorFirstName { get; set; }

        /// <summary>
        /// (Max length: 60)
        /// </summary>
        [JsonProperty("guarantorlastname")]
        public string GuarantorLastName { get; set; }

        /// <summary>
        /// (Max length: 25)
        /// </summary>
        [JsonProperty("guarantormiddlename")]
        public string GuarantorMiddleName { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("guarantorphone")]
        public string GuarantorPhone { get; set; }

        /// <summary>
        /// The guarantor's relationship to the patient
        /// </summary>
        [JsonProperty("guarantorrelationshiptopatient")]
        [JsonConverter(typeof(EnumConverter))]
        public GuarantorRelationshipToPatientEnum? GuarantorRelationshipToPatient { get; set; }

        /// <summary>
        /// (Max length: 13)
        /// </summary>
        [JsonProperty("guarantorssn")]
        public string GuarantorSsn { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty("guarantorstate")]
        public string GuarantorState { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty("guarantorsuffix")]
        public string GuarantorSuffix { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty("guarantorzip")]
        public string GuarantorZip { get; set; }

        /// <summary>
        /// (Max length: 35)
        /// </summary>
        [JsonProperty("guardianfirstname")]
        public string GuardianFirstName { get; set; }

        /// <summary>
        /// (Max length: 60)
        /// </summary>
        [JsonProperty("guardianlastname")]
        public string GuardianLastName { get; set; }

        /// <summary>
        /// (Max length: 25)
        /// </summary>
        [JsonProperty("guardianmiddlename")]
        public string GuardianMiddleName { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty("guardiansuffix")]
        public string GuardianSuffix { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("hasmobileyn")]
        public bool? HasMobile { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("homeboundyn")]
        public bool? Homebound { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("homeless")]
        [JsonConverter(typeof(EnumConverter))]
        public YesNoDeclinedEnum? Homeless { get; set; }

        /// <summary>
        /// (Max length: 30)
        /// </summary>
        [JsonProperty("homelesstype")]
        [JsonConverter(typeof(EnumConverter))]
        public HomelessTypeEnum? HomelessType { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("homephone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// Set to true to allow ability to find patients with record restrictions and blocked
        /// patients. This should only be used when there is no reflection to the patient at all that
        /// a match was found or not found.
        /// </summary>
        [JsonProperty("ignorerestrictions")]
        public bool? IgnoreRestrictions { get; set; }

        /// <summary>
        /// Industry of the patient, using the US Census industry code (code system
        /// 2.16.840.1.113883.6.310). "other" can be used as well.
        /// </summary>
        [JsonProperty("industrycode")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// Language of the patient, using the ISO 639.2 code.
        /// (http://www.loc.gov/standards/iso639-2/php/code_list.php; "T" or terminology code)
        /// Special case: use "declined" to indicate that the patient declined to answer.
        /// </summary>
        [JsonProperty("language6392code")]
        public string Language6392Code { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("maritalstatus")]
        [JsonConverter(typeof(EnumConverter))]
        public MaritalStatusEnum? MaritalStatus { get; set; }

        /// <summary>
        /// (Max length: 25)
        /// </summary>
        [JsonProperty("middlename")]
        public string MiddleName { get; set; }

        /// <summary>
        /// The ID of the mobile carrier, from /mobilecarriers or the list below.
        /// </summary>
        [JsonProperty("mobilecarrierid")]
        public string MobileCarrierId { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("mobilephone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// (Max length: 50)
        /// </summary>
        [JsonProperty("nextkinname")]
        public string NextKinName { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("nextkinphone")]
        public string NextKinPhone { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty("nextkinrelationship")]
        [JsonConverter(typeof(EnumConverter))]
        public RelationshipEnum? NextKinRelationship { get; set; }

        /// <summary>
        /// (Max length: 4000)
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Occupation of the patient, using the US Census occupation code (code system
        /// 2.16.840.1.113883.6.240). "other" can be used as well.
        /// </summary>
        [JsonProperty("occupationcode")]
        public string OccupationCode { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("onlinestatementonlyyn")]
        public bool? OnlineStatementOnly { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("portalaccessgiven")]
        public bool? PortalAccessGiven { get; set; }

        /// <summary>
        /// Patient's poverty level (% of the Federal Poverty Level), as calculated from family size,
        /// income per pay period, pay period, and state. Typically only valued if client has Federal
        /// Poverty Level fields turned on.
        /// </summary>
        [JsonProperty("povertylevelcalculated")]
        [JsonConverter(typeof(EnumConverter))]
        public PovertyLevelCalculatedEnum? PovertyLevelCalculated { get; set; }

        /// <summary>
        /// Patient's family size (used for determining poverty level). Only settable if client has
        /// Federal Poverty Level fields turned on.
        /// </summary>
        [JsonProperty("povertylevelfamilysize")]
        public int? PovertyLevelFamilysize { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("povertylevelfamilysizedeclined")]
        public bool? PovertyLevelFamilySizeDeclined { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("povertylevelincomedeclined")]
        public bool? PovertyLevelIncomeDeclined { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("povertylevelincomepayperiod")]
        [JsonConverter(typeof(EnumConverter))]
        public PovertyLevelIncomePayPeriodEnum? PovertyLevelIncomePayPeriod { get; set; }

        /// <summary>
        /// Patient's income per specified pay period (used for determining poverty level). Only
        /// settable if client has Federal Poverty Level fields turned on.
        /// </summary>
        [JsonProperty("povertylevelincomeperpayperiod")]
        public int? PovertyLevelIncomePerPayPeriod { get; set; }

        /// <summary>
        /// Indicates whether or not the patient declines to provide an income level (povertylevelcalculated).
        /// </summary>
        [JsonProperty("povertylevelincomerangedeclined")]
        public bool? PovertyLevelIncomeRangeDeclined { get; set; }

        /// <summary>
        /// (Max length: 35)
        /// </summary>
        [JsonProperty("preferredname")]
        public string PreferredName { get; set; }

        /// <summary>
        /// Pronoun this patient uses.
        /// </summary>
        [JsonProperty("preferredpronouns")]
        [JsonConverter(typeof(EnumConverter))]
        public PreferredPronounsEnum? PreferredPronouns { get; set; }

        /// <summary>
        /// The patient's "current" department. This field is not always set by the practice.
        /// </summary>
        [JsonProperty("primarydepartmentid")]
        public string PrimaryDepartmentId { get; set; }

        /// <summary>
        /// The "primary" provider for this patient, if set.
        /// </summary>
        [JsonProperty("primaryproviderid")]
        public string PrimaryProviderId { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("publichousing")]
        [JsonConverter(typeof(EnumConverter))]
        public YesNoDeclinedEnum? PublicHousing { get; set; }

        /// <summary>
        /// The patient race, using the 2.16.840.1.113883.5.104 codeset. See
        /// http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
        /// "declined" to indicate that the patient declined to answer. Multiple values or a
        /// tab-seperated list of codes is acceptable for multiple races for input. The first race
        /// will be considered "primary". Note: you must update all values at once if you update any.
        /// </summary>
        [JsonProperty("race")]
        public string Race { get; set; }

        /// <summary>
        /// The referral / "how did you hear about us" ID.
        /// </summary>
        [JsonProperty("referralsourceid")]
        public string ReferralSourceId { get; set; }

        /// <summary>
        /// (Max length: 100)
        /// </summary>
        [JsonProperty("referralsourceother")]
        public string ReferralSourceOther { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("schoolbasedhealthcenter")]
        [JsonConverter(typeof(EnumConverter))]
        public YesNoDeclinedEnum? SchoolBasedHealthCenter { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("sex")]
        [JsonConverter(typeof(EnumConverter))]
        public SexEnum? Sex { get; set; }

        /// <summary>
        /// Sexual orientation of this patient.
        /// </summary>
        [JsonProperty("sexualorientation")]
        [JsonConverter(typeof(EnumConverter))]
        public SexualOrientationEnum? SexualOrientation { get; set; }

        /// <summary>
        /// Only valid when used in conjunction with a sexual orientation choice that allows the
        /// patient to describe their orientation (if it doesn't conform to any other choice).
        /// </summary>
        [JsonProperty("sexualorientationother")]
        public string SexualOrientationOther { get; set; }

        /// <summary>
        /// (Max length: 13)
        /// </summary>
        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(EnumConverter))]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// (Max length: 1)
        /// </summary>
        [JsonProperty("veteran")]
        [JsonConverter(typeof(EnumConverter))]
        public YesNoDeclinedEnum? Veteran { get; set; }

        /// <summary>
        /// (Max length: 20)
        /// </summary>
        [JsonProperty("workphone")]
        public string WorkPhone { get; set; }

        /// <summary>
        /// (Max length: 10)
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}
