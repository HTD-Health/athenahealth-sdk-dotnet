using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPatientsFilter : IPagingFilter
    {
        /// <summary>
        /// If present, the date on which a patient died.
        /// </summary>
        [JsonProperty("deceaseddate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? DeceasedDate { get; set; }

        /// <summary>
        /// The expiration date of the patient's driver's license.
        /// </summary>
        [JsonProperty("driverslicenseexpirationdate")]
        public string DriversLicenseExpirationDate { get; set; }

        /// <summary>
        /// (Max length: 25)
        /// </summary>
        [JsonProperty("driverslicensenumber")]
        public string DriversLicenseNumber { get; set; }

        /// <summary>
        /// (Max length: 30)
        /// </summary>
        [JsonProperty("driverslicensestateid")]
        public string DriversLicenseStateId { get; set; }

        /// <summary>
        /// Ethnicity of the patient, using the 2.16.840.1.113883.5.50 codeset. See
        /// http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
        /// "declined" to indicate that the patient declined to answer.
        /// </summary>
        [JsonProperty("ethnicitycode")]
        public string EthnicityCode { get; set; }

        /// <summary>
        /// The patient race hierarchical code
        /// </summary>
        [JsonProperty("hierarchicalcode")]
        public string HierarchicalCode { get; set; }

        /// <summary>
        /// If the patient is homebound, this is true.
        /// </summary>
        [JsonProperty("homebound")]
        public string Homebound { get; set; }

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
        /// Occupation of the patient, using the US Census occupation code (code system
        /// 2.16.840.1.113883.6.240). "other" can be used as well.
        /// </summary>
        [JsonProperty("occupationcode")]
        public string OccupationCode { get; set; }

        /// <summary>
        /// When true, current patient balances will not be calculated and the "balances" parameters
        /// will be omitted, speeding up the /patients endpoint.
        /// </summary>
        [JsonProperty("omitbalances")]
        public bool? OmitBalances { get; set; }

        /// <summary>
        /// When true, the default NCPDPID for patients will not be determined (and
        /// "defaultpharmacyncpdpid' will be omitted), speeding up the /patients endpoint.
        /// </summary>
        [JsonProperty("omitdefaultpharmacy")]
        public bool? OmitDefaultPharmacy { get; set; }

        /// <summary>
        /// When true, current patient photo information will not be determined (and "patientphoto"
        /// and "patientphotourl" will be omitted), speeding up the /patients endpoint.
        /// </summary>
        [JsonProperty("omitphotoinformation")]
        public bool? OmitPhotoInformation { get; set; }

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
        /// The patient race, using the 2.16.840.1.113883.5.104 codeset. See
        /// http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
        /// "declined" to indicate that the patient declined to answer. Multiple values or a
        /// tab-seperated list of codes is acceptable for multiple races for input. The first race
        /// will be considered "primary". Note: you must update all values at once if you update any.
        /// </summary>
        [JsonProperty("race")]
        public string Race { get; set; }

        /// <summary>
        /// When true, 2015 Ed. CEHRT compliant strings will be returned for describing gender
        /// identity and sexual orientation.
        /// </summary>
        [JsonProperty("show2015edcehrtvalues")]
        public bool? Show2015EdCehrtValues { get; set; }

        /// <summary>
        /// The "status" of the patient, one of active, inactive, prospective, or deleted.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Patient's first name (Max length: 35)
        /// </summary>
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// Patient's middle name (Max length: 25)
        /// </summary>
        [JsonProperty("middlename")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Patient's last name (Max length: 60)
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// Patient's name suffix (Max length: 10)
        /// </summary>
        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// The patient's preferred name (i.e. nickname). (Max length: 35)
        /// </summary>
        [JsonProperty("preferredname")]
        public string PreferredName { get; set; }

        /// <summary>
        /// Patient's address - 1st line (Max length: 100)
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Patient's address - 2nd line (Max length: 100)
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// Patient's city (Max length: 30)
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Patient's state (2 letter abbreviation) (Max length: 10)
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Patient's zip. Matching occurs on first 5 characters. (Max length: 10)
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Patient's country code (ISO 3166-1)
        /// </summary>
        [JsonProperty("countrycode3166")]
        public string CountryCode3166 { get; set; }

        /// <summary>
        /// The patient's home phone number. Invalid numbers in a GET/PUT will be ignored. Patient
        /// phone numbers and other data may change, and one phone number may be associated with
        /// multiple patients. You are responsible for taking additional steps to verify patient
        /// identity and for using this data in accordance with applicable law, including HIPAA.
        /// Invalid numbers in a POST will be ignored, possibly resulting in an error. (Max length: 20)
        /// </summary>
        [JsonProperty("homephone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// The patient's mobile phone number. On input, 'declined' can be used to indicate no
        /// number. (Alternatively, hasmobile can also be set to false. "declined" simply does this
        /// for you.) Invalid numbers in a GET/PUT will be ignored. Patient phone numbers and other
        /// data may change, and one phone number may be associated with multiple patients. You are
        /// responsible for taking additional steps to verify patient identity and for using this
        /// data in accordance with applicable law, including HIPAA. Invalid numbers in a POST will
        /// be ignored, possibly resulting in an error. (Max length: 20)
        /// </summary>
        [JsonProperty("mobilephone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Set to false if a client has declined a phone number. (Max length: 1)
        /// </summary>
        [JsonProperty("hasmobile")]
        public string HasMobile { get; set; }

        /// <summary>
        /// The patient's work phone number. Generally not used to contact a patient. Invalid numbers
        /// in a GET/PUT will be ignored. Patient phone numbers and other data may change, and one
        /// phone number may be associated with multiple patients. You are responsible for taking
        /// additional steps to verify patient identity and for using this data in accordance with
        /// applicable law, including HIPAA. Invalid numbers in a POST will be ignored, possibly
        /// resulting in an error. (Max length: 20)
        /// </summary>
        [JsonProperty("workphone")]
        public string WorkPhone { get; set; }

        /// <summary>
        /// Any phone number for the patient. Patient phone numbers and other data may change, and
        /// one phone number may be associated with multiple patients. You are responsible for taking
        /// additional steps to verify patient identity and for using this data in accordance with
        /// applicable law, including HIPAA.
        /// </summary>
        [JsonProperty("anyphone")]
        public string AnyPhone { get; set; }

        /// <summary>
        /// Patient's email address. 'declined' can be used to indicate just that. (Max length: 50)
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Patient's sex (M/F)
        /// </summary>
        [JsonProperty("sex")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public SexEnum? Sex { get; set; }

        /// <summary>
        /// Patient's DOB (mm/dd/yyyy)
        /// </summary>
        [JsonProperty("dob")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Marital Status (D=Divorced, M=Married, S=Single, U=Unknown, W=Widowed, X=Separated, P=Partner)
        /// </summary>
        [JsonProperty("maritalstatus")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public MaritalStatusEnum? MaritalStatus { get; set; }

        /// <summary>
        /// (Max length: 13)
        /// </summary>
        [JsonProperty("ssn")]
        public string SSN { get; set; }

        /// <summary>
        /// The MU-required field for "preferred contact method". This is not used by any automated systems.
        /// </summary>
        [JsonProperty("contactpreference")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public ContactPreferenceEnum? ContactPreference { get; set; }

        /// <summary>
        /// The name of the (emergency) person to contact about the patient. The contactname,
        /// contactrelationship, contacthomephone, and contactmobilephone fields are all related to
        /// the emergency contact for the patient. They are NOT related to the contractpreference_*
        /// fields. (Max length: 50)
        /// </summary>
        [JsonProperty("contactname")]
        public string ContactName { get; set; }

        /// <summary>
        /// Emergency contact relationship (one of SPOUSE, PARENT, CHILD, SIBLING, FRIEND, COUSIN,
        /// GUARDIAN, OTHER)
        /// </summary>
        [JsonProperty("contactrelationship")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public RelationshipEnum? ContactRelationship { get; set; }

        /// <summary>
        /// Emergency contact home phone. Invalid numbers in a GET/PUT will be ignored. Patient phone
        /// numbers and other data may change, and one phone number may be associated with multiple
        /// patients. You are responsible for taking additional steps to verify patient identity and
        /// for using this data in accordance with applicable law, including HIPAA. Invalid numbers
        /// in a POST will be ignored, possibly resulting in an error. (Max length: 20)
        /// </summary>
        [JsonProperty("contacthomephone")]
        public string ContactHomePhone { get; set; }

        /// <summary>
        /// Emergency contact mobile phone. Invalid numbers in a GET/PUT will be ignored. Patient
        /// phone numbers and other data may change, and one phone number may be associated with
        /// multiple patients. You are responsible for taking additional steps to verify patient
        /// identity and for using this data in accordance with applicable law, including HIPAA.
        /// Invalid numbers in a POST will be ignored, possibly resulting in an error. (Max length: 20)
        /// </summary>
        [JsonProperty("contactmobilephone")]
        public string ContactMobilePhone { get; set; }

        /// <summary>
        /// The full name of the next of kin. (Max length: 50)
        /// </summary>
        [JsonProperty("nextkinname")]
        public string NextKinName { get; set; }

        /// <summary>
        /// The next of kin relationship (one of SPOUSE, PARENT, CHILD, SIBLING, FRIEND, COUSIN,
        /// GUARDIAN, OTHER)
        /// </summary>
        [JsonProperty("nextkinrelationship")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public RelationshipEnum? NextKinRelationship { get; set; }

        /// <summary>
        /// The next of kin phone number. Invalid numbers in a GET/PUT will be ignored. Patient phone
        /// numbers and other data may change, and one phone number may be associated with multiple
        /// patients. You are responsible for taking additional steps to verify patient identity and
        /// for using this data in accordance with applicable law, including HIPAA. Invalid numbers
        /// in a POST will be ignored, possibly resulting in an error. (Max length: 20)
        /// </summary>
        [JsonProperty("nextkinphone")]
        public string NextKinPhone { get; set; }

        /// <summary>
        /// The first name of the patient's guardian. (Max length: 35)
        /// </summary>
        [JsonProperty("guardianfirstname")]
        public string GuardianGirstName { get; set; }

        /// <summary>
        /// The middle name of the patient's guardian. (Max length: 25)
        /// </summary>
        [JsonProperty("guardianmiddlename")]
        public string GuardianMiddleName { get; set; }

        /// <summary>
        /// The last name of the patient's guardian. (Max length: 60)
        /// </summary>
        [JsonProperty("guardianlastname")]
        public string GuardianLastName { get; set; }

        /// <summary>
        /// The suffix of the patient's guardian. (Max length: 10)
        /// </summary>
        [JsonProperty("guardiansuffix")]
        public string GuardianSuffix { get; set; }

        /// <summary>
        /// Guarantor's first name (Max length: 35)
        /// </summary>
        [JsonProperty("guarantorfirstname")]
        public string GuarantorFirstName { get; set; }

        /// <summary>
        /// Guarantor's middle name (Max length: 25)
        /// </summary>
        [JsonProperty("guarantormiddlename")]
        public string GuarantorMiddleName { get; set; }

        /// <summary>
        /// Guarantor's last name (Max length: 60)
        /// </summary>
        [JsonProperty("guarantorlastname")]
        public string GuarantorLastName { get; set; }

        /// <summary>
        /// Guarantor's name suffix (Max length: 10)
        /// </summary>
        [JsonProperty("guarantorsuffix")]
        public string GuarantorSuffix { get; set; }

        /// <summary>
        /// Guarantor's address (Max length: 100)
        /// </summary>
        [JsonProperty("guarantoraddress1")]
        public string GuarantorAddress1 { get; set; }

        /// <summary>
        /// Guarantor's address - line 2 (Max length: 100)
        /// </summary>
        [JsonProperty("guarantoraddress2")]
        public string GuarantorAddress2 { get; set; }

        /// <summary>
        /// Guarantor's city (Max length: 30)
        /// </summary>
        [JsonProperty("guarantorcity")]
        public string GuarantorCity { get; set; }

        /// <summary>
        /// Guarantor's state (2 letter abbreviation) (Max length: 10)
        /// </summary>
        [JsonProperty("guarantorstate")]
        public string GuarantorState { get; set; }

        /// <summary>
        /// Guarantor's zip (Max length: 10)
        /// </summary>
        [JsonProperty("guarantorzip")]
        public string GuarantorZip { get; set; }

        /// <summary>
        /// Guarantor's country code (ISO 3166-1)
        /// </summary>
        [JsonProperty("guarantorcountrycode3166")]
        public string GuarantorCountryCode3166 { get; set; } = "US";

        /// <summary>
        /// Guarantor's DOB (mm/dd/yyyy)
        /// </summary>
        [JsonProperty("guarantordob")]
        public string GuarantorDateOfBirth { get; set; }

        /// <summary>
        /// Guarantor's email address (Max length: 50)
        /// </summary>
        [JsonProperty("guarantoremail")]
        public string GuarantorEmail { get; set; }

        /// <summary>
        /// Guarantor's phone number. Invalid numbers in a GET/PUT will be ignored. Patient phone
        /// numbers and other data may change, and one phone number may be associated with multiple
        /// patients. You are responsible for taking additional steps to verify patient identity and
        /// for using this data in accordance with applicable law, including HIPAA. Invalid numbers
        /// in a POST will be ignored, possibly resulting in an error. (Max length: 20)
        /// </summary>
        [JsonProperty("guarantorphone")]
        public string GuarantorPhone { get; set; }

        /// <summary>
        /// Guarantor's SSN (Max length: 13)
        /// </summary>
        [JsonProperty("guarantorssn")]
        public string GuarantorSSN { get; set; }

        /// <summary>
        /// The guarantor's relationship to the patient
        /// </summary>
        [JsonProperty("guarantorrelationshiptopatient")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public GuarantorRelationshipToPatientEnum? GuarantorRelationshipToPatient { get; set; }

        /// <summary>
        /// Date the patient was registered.
        /// </summary>
        [JsonProperty("registrationdate")]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// Primary (registration) department ID. A special value of -1 can be used to search for
        /// cases where, due to an unusual import or other reasons, the registration department is
        /// not set.
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// The patient's employer's ID (from /employers call)
        /// </summary>
        [JsonProperty("employerid")]
        public string EmployerId { get; set; }

        /// <summary>
        /// The patient's employer's phone number. Normally, this is set by setting employerid.
        /// However, setting this value can be used to override this on an individual patient.
        /// Invalid numbers in a GET/PUT will be ignored. Patient phone numbers and other data may
        /// change, and one phone number may be associated with multiple patients. You are
        /// responsible for taking additional steps to verify patient identity and for using this
        /// data in accordance with applicable law, including HIPAA. Invalid numbers in a POST will
        /// be ignored, possibly resulting in an error. (Max length: 20)
        /// </summary>
        [JsonProperty("employerphone")]
        public string EmployerPhone { get; set; }

        /// <summary>
        /// The guaranror's employer's ID (from /employers call)
        /// </summary>
        [JsonProperty("guarantoremployerid")]
        public string GuarantorEmployerId { get; set; }

        /// <summary>
        /// This flag is set if the patient has been given access to the portal. This may be set by
        /// the API user if a patient has been given access to the portal "by providing a preprinted
        /// brochure or flyer showing the URL where patients can access their Patient Care
        /// Summaries." The practiceinfo endpoint can provide the portal URL. While technically
        /// allowed, it would be very unusual to set this to false via the API. (Max length: 1)
        /// </summary>
        [JsonProperty("portalaccessgiven")]
        public string PortalAccessGiven { get; set; }

        /// <summary>
        /// Set to true if a patient wishes to get e-statements instead of paper statements. Should
        /// only be set for patients with an email address and clients with athenaCommunicator. The
        /// language we use in the portal is, "Future billing statements will be sent to you securely
        /// via your Patient Portal account. You will receive an email notice when new statements are
        /// available." This language is not required, but it is given as a suggestion. (Max length: 1)
        /// </summary>
        [JsonProperty("onlinestatementonly")]
        public string OnlineStatementOnly { get; set; }

        /// <summary>
        /// The flag is used to record the consent of a patient to receive automated calls per FCC
        /// requirements. The requested legal language is 'Entry of any telephone contact number
        /// constitutes written consent to receive any automated, prerecorded, and artificial voice
        /// telephone calls initiated by the Practice. To alter or revoke this consent, visit the
        /// Patient Portal "Contact Preferences" page.'
        /// </summary>
        [JsonProperty("consenttocall")]
        public bool? ConsentToCall { get; set; }

        /// <summary>
        /// The flag is used to record the consent of a patient to receive text messages per FCC
        /// requirements. In order for this to be true, a valid mobile phone number must be set and
        /// the practice setting "Hide SMS Opt-in option" must be set to Off.
        /// </summary>
        [JsonProperty("consenttotext")]
        public bool? ConsentToText { get; set; }

        /// <summary>
        /// The referral / "how did you hear about us" ID.
        /// </summary>
        [JsonProperty("referralsourceid")]
        public string ReferralSourceId { get; set; }

        /// <summary>
        /// The patient's preference for care summary delivery. (Max length: 50)
        /// </summary>
        [JsonProperty("caresummarydeliverypreference")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public CareSummaryDeliveryPreferenceEnum? CareSummaryDeliveryPreference { get; set; }

        /// <summary>
        /// The NCPDP ID of the patient's preferred pharmacy. See http://www.ncpdp.org/ for details.
        /// Note: if updating this field, please make sure to have a CLINICALORDERTYPEGROUPID field
        /// as well.
        /// </summary>
        [JsonProperty("defaultpharmacyncpdpid")]
        public string DefaultPharmacyNcpdpId { get; set; }

        /// <summary>
        /// The clinical order type group of the clinical provider (Prescription: 10, Lab: 11,
        /// Vaccinations: 16).
        /// </summary>
        [JsonProperty("clinicalordertypegroupid")]
        public string ClinicalOrderTypeGroupId { get; set; }

        /// <summary>
        /// The ID of the mobile carrier, from /mobilecarriers or the list below.
        /// </summary>
        [JsonProperty("mobilecarrierid")]
        public string MobileCarrierId { get; set; }

        /// <summary>
        /// Notes associated with this patient. (Max length: 4000)
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Patient's poverty level (% of the Federal Poverty Level), as calculated from family size,
        /// income per pay period, pay period, and state. Typically only valued if client has Federal
        /// Poverty Level fields turned on.
        /// </summary>
        [JsonProperty("povertylevelcalculated")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public PovertyLevelCalculatedEnum? PovertyLevelCalculated { get; set; }

        /// <summary>
        /// Patient's family size (used for determining poverty level). Only settable if client has
        /// Federal Poverty Level fields turned on.
        /// </summary>
        [JsonProperty("povertylevelfamilysize")]
        public string PovertyLevelFamilySize { get; set; }

        /// <summary>
        /// Indicates if the patient delcines to provide "povertylevelfamilysize". Should be set to
        /// Yes if the patient declines.
        /// </summary>
        [JsonProperty("povertylevelfamilysizedeclined")]
        public bool? PovertyLevelFamilySizeDeclined { get; set; }

        /// <summary>
        /// Patient's income per specified pay period (used for determining poverty level). Only
        /// settable if client has Federal Poverty Level fields turned on.
        /// </summary>
        [JsonProperty("povertylevelincomeperpayperiod")]
        public string PovertyLevelIncomePerPayPeriod { get; set; }

        /// <summary>
        /// Indicates whether or not the patient declines to provide an income level.
        /// </summary>
        [JsonProperty("povertylevelincomerangedeclined")]
        public bool? PovertyLevelIncomeRangeDeclined { get; set; }

        /// <summary>
        /// Indicates if the patient delcines to provide "povertylevelincomeperpayperiod". Should be
        /// set to Yes if the patient declines.
        /// </summary>
        [JsonProperty("povertylevelincomedeclined")]
        public bool? PovertyLevelIncomeDeclined { get; set; }

        /// <summary>
        /// Patient's pay period (used for determining poverty level). Only settable if client has
        /// Federal Poverty Level fields turned on.
        /// </summary>
        [JsonProperty("povertylevelincomepayperiod")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public PovertyLevelIncomePayPeriodEnum? PovertyLevelIncomePayPeriod { get; set; }

        /// <summary>
        /// Used to identify this patient as an agricultural worker. Only settable if client has
        /// Social Determinant fields turned on.
        /// </summary>
        [JsonProperty("agriculturalworker")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public YesNoDeclinedEnum? AgriculturalWorker { get; set; }

        /// <summary>
        /// For patients that are agricultural workers, identifies the type of worker. Only settable
        /// if client has Social Determinant fields turned on.
        /// </summary>
        [JsonProperty("agriculturalworkertype")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public AgriculturalWorkerTypeEnum? AgriculturalWorkerType { get; set; }

        /// <summary>
        /// Used to identify this patient as homeless. Only settable if client has Social Determinant
        /// fields turned on.
        /// </summary>
        [JsonProperty("homeless")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public YesNoDeclinedEnum? Homeless { get; set; }

        /// <summary>
        /// For patients that are homeless, provides more detail regarding the patient's homeless
        /// situation. Only settable if client has Social Determinant fields turned on. The
        /// 'Permanent Supportive Housing' option may only be used if the client has the
        /// HCOGF_UDS_2019 rollout toggle turned on (it will be ignored otherwise).
        /// </summary>
        [JsonProperty("homelesstype")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public HomelessTypeEnum? HomelessType { get; set; }

        /// <summary>
        /// Used to identify this patient as a veteran. Only settable if client has Social
        /// Determinant fields turned on.
        /// </summary>
        [JsonProperty("veteran")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public YesNoDeclinedEnum? Veteran { get; set; }

        /// <summary>
        /// Used to identify this patient as school-based health center patient. Only settable if
        /// client has Social Determinant fields turned on.
        /// </summary>
        [JsonProperty("schoolbasedhealthcenter")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public YesNoDeclinedEnum? SchoolBasedHealthCenter { get; set; }

        /// <summary>
        /// Used to identify this patient as living in public housing. Only settable if client has
        /// Social Determinant fields turned on.
        /// </summary>
        [JsonProperty("publichousing")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public YesNoDeclinedEnum? PublicHousing { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "announcement"
        /// communications delivered via email. Note that this will not be present if the practice or
        /// patient has not set it.For completeness, turning email off is supported via the API, but
        /// it is discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty("contactpreference_announcement_email")]
        public bool? ContactPreferenceAnnouncementEmail { get; set; }

        /// <summary>
        /// Used to identify patients with appointments scheduled within the upcoming input hours
        /// (maximum 24). Also includes results from the previous 2 hours.
        /// </summary>
        [JsonProperty("upcomingappointmenthours")]
        public string UpcomingAppointmentHours { get; set; }

        /// <summary>
        /// The ID of the provider associated with the upcoming appointment.
        /// </summary>
        [JsonProperty("appointmentproviderid")]
        public string AppointmentProviderId { get; set; }

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
        /// The ID of the department associated with the upcoming appointment.
        /// </summary>
        [JsonProperty("appointmentdepartmentid")]
        public string AppointmentDepartmentId { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "announcement"
        /// communications delivered via phone. Note that this will not be present if the practice or
        /// patient has not set it.
        /// </summary>
        [JsonProperty("contactpreference_announcement_phone")]
        public bool? ContactPreferenceAnnouncementPhone { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "appointment"
        /// communications delivered via email. Note that this will not be present if the practice or
        /// patient has not set it.For completeness, turning email off is supported via the API, but
        /// it is discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty("contactpreference_appointment_email")]
        public bool? ContactPreferenceAppointmentEmail { get; set; }

        /// <summary>
        /// Set to true to allow ability to find patients with record restrictions and blocked
        /// patients. This should only be used when there is no reflection to the patient at all that
        /// a match was found or not found. When COLCR_RETURN_CONFIDENTIALITY_CODE is ON, will also
        /// add the confidentialitycode flag to the output for the patient.
        /// </summary>
        [JsonProperty("ignorerestrictions")]
        public bool? IgnoreRestrictions { get; set; }

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
        /// If set, the patient has indicated a preference to get or not get "appointment"
        /// communications delivered via phone. Note that this will not be present if the practice or
        /// patient has not set it.
        /// </summary>
        [JsonProperty("contactpreference_appointment_phone")]
        public bool? ContactPreferenceAppointmentPhone { get; set; }

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
        /// delivered via SMS. Note that this will not be present if the practice or patient has not
        /// set it.For SMS, there is specific terms of service language that must be used when
        /// displaying this as an option to be turned on. Turning on must be an action by the
        /// patient, not a practice user.
        /// </summary>
        [JsonProperty("contactpreference_billing_sms")]
        public bool? ContactPreferenceBillingSms { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "billing" communications
        /// delivered via phone. Note that this will not be present if the practice or patient has
        /// not set it.
        /// </summary>
        [JsonProperty("contactpreference_billing_phone")]
        public bool? ContactPreferenceBillingPhone { get; set; }

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
        /// delivered via SMS. Note that this will not be present if the practice or patient has not
        /// set it.For SMS, there is specific terms of service language that must be used when
        /// displaying this as an option to be turned on. Turning on must be an action by the
        /// patient, not a practice user.
        /// </summary>
        [JsonProperty("contactpreference_lab_sms")]
        public bool? ContactPreferenceLabSms { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "lab" communications
        /// delivered via phone. Note that this will not be present if the practice or patient has
        /// not set it.
        /// </summary>
        [JsonProperty("contactpreference_lab_phone")]
        public bool? ContactPreferenceLabPhone { get; set; }

        /// <summary>
        /// Number of entries to return (default 10, max 1000). Please note that this endpoint has a
        /// different default and max than normal.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }
    }
}
