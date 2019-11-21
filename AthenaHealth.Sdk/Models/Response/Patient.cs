using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientResponse : IPagingResponse<Patient>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("patients")]
        public Patient[] Items { get; set; }
    }

    public class Patient
    {
        /// <summary>
        /// Please remember to never disclose this ID to patients since it may result in inadvertant
        /// disclosure that a patient exists in a practice already.
        /// </summary>
        [JsonProperty("patientid")]
        public int Id { get; set; }

        /// <summary>
        /// The patient race hierarchical code
        /// </summary>
        [JsonProperty("hierarchicalcode")]
        public string HierarchicalCode { get; set; }

        /// <summary>
        /// Warning! This patient will not receive any communication from the practice if this field
        /// is set to true.
        /// </summary>
        [JsonProperty("donotcall")]
        public bool? DoNotCall { get; set; }

        /// <summary>
        /// Pronoun this patient uses.
        /// </summary>
        [JsonProperty("preferredpronouns")]
        public string PreferredPronouns { get; set; }

        /// <summary>
        /// The last appointment for this patient (before today), excluding cancelled or no-show
        /// appointments. (mm/dd/yyyy h24:mi)
        /// </summary>
        [JsonProperty("lastappointment")]
        public string LastAppointment { get; set; }

        /// <summary>
        /// Claim level details on patient balances. (This is only included when SHOWBALANCEDETAILS
        /// is set.)
        /// </summary>
        [JsonProperty("claimbalancedetails")]
        public ClaimBalanceDetail[] ClaimBalanceDetails { get; set; }

        /// <summary>
        /// If the patient is homebound, this is true.
        /// </summary>
        [JsonProperty("homebound")]
        public bool? Homebound { get; set; }

        /// <summary>
        /// Sex that this patient was assigned at birth.
        /// </summary>
        [JsonProperty("assignedsexatbirth")]
        public string AssignedSexAtBirth { get; set; }

        /// <summary>
        /// Alternate first name that differs from legal name.
        /// </summary>
        [JsonProperty("altfirstname")]
        public string AltFirstName { get; set; }

        /// <summary>
        /// Gives the confidentiality code for the patient. Only returned when IGNORERESTRICTIONS is
        /// set to true and COLCR_RETURN_CONFIDENTIALITY_CODE is ON
        /// </summary>
        [JsonProperty("confidentialitycode")]
        public string ConfidentialityCode { get; set; }

        /// <summary>
        /// Ethnicity of the patient, using the 2.16.840.1.113883.5.50 codeset. See
        /// http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
        /// "declined" to indicate that the patient declined to answer.
        /// </summary>
        [JsonProperty("ethnicitycode")]
        public string EthnicityCode { get; set; }

        /// <summary>
        /// Industry of the patient, using the US Census industry code (code system
        /// 2.16.840.1.113883.6.310). "other" can be used as well.
        /// </summary>
        [JsonProperty("industrycode")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// If present, the date on which a patient died.
        /// </summary>
        [JsonProperty("deceaseddate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? DeceasedDate { get; set; }

        /// <summary>
        /// The first appointment for this patient, excluding cancelled or no-show appointments.
        /// (mm/dd/yyyy h24:mi)
        /// </summary>
        [JsonProperty("firstappointment")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm")]
        public DateTime? FirstAppointment { get; set; }

        /// <summary>
        /// The "primary" provider for this patient, if set.
        /// </summary>
        [JsonProperty("primaryproviderid")]
        public int? PrimaryProviderId { get; set; }

        /// <summary>
        /// If a patient does not identify with any prescribed gender identity choice, this field
        /// stores the patient-provided description of gender identity.
        /// </summary>
        [JsonProperty("genderidentityother")]
        public string GenderIdentityOther { get; set; }

        /// <summary>
        /// Patient's email address. 'declined' can be used to indicate just that.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// This flag is set if the patient has been given access to the portal. This may be set by
        /// the API user if a patient has been given access to the portal "by providing a preprinted
        /// brochure or flyer showing the URL where patients can access their Patient Care
        /// Summaries." The practiceinfo endpoint can provide the portal URL. While technically
        /// allowed, it would be very unusual to set this to false via the API.
        /// </summary>
        [JsonProperty("portalaccessgiven")]
        public bool? PortalAccessGiven { get; set; }

        /// <summary>
        /// True if the patient has a driver's license uploaded
        /// </summary>
        [JsonProperty("driverslicense")]
        public bool? DriversLicense { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "billing" communications
        /// delivered via phone. Note that this will not be present if the practice or patient has
        /// not set it.
        /// </summary>
        [JsonProperty("contactpreference_billing_phone")]
        public bool? ContactPreferenceBillingPhone { get; set; }

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
        /// Flag determining whether or not the patient has accepted the Terms and Conditions for the
        /// patient portal.
        /// </summary>
        [JsonProperty("portaltermsonfile")]
        public bool? PortalTermsOnFile { get; set; }

        /// <summary>
        /// Portal status details. See /patients/{patientid}/portalstatus for details.
        /// </summary>
        [JsonProperty("portalstatus")]
        public PortalStatusModel PortalStatus { get; set; }

        /// <summary>
        /// The "status" of the patient, one of active, inactive, prospective, or deleted.
        /// </summary>
        [JsonProperty("status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// This flag is set if the patient's privacy information has been verified. Privacy
        /// information returns True if all of the items referenced in GET
        /// /patients/{patientid}/privacyinformationverified are true. Privacy information returns
        /// false if any of the items referenced in the GET
        /// /patients/{patientid}/privacyinformationverified API are false or expired.
        /// </summary>
        [JsonProperty("privacyinformationverified")]
        public bool? PrivacyInformationVerified { get; set; }

        /// <summary>
        /// The patient's "current" department. This field is not always set by the practice.
        /// </summary>
        [JsonProperty("primarydepartmentid")]
        public int? PrimaryDepartmentId { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "lab" communications
        /// delivered via email. Note that this will not be present if the practice or patient has
        /// not set it.For completeness, turning email off is supported via the API, but it is
        /// discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty("contactpreference_lab_email")]
        public bool? ContactPreferenceLabEmail { get; set; }

        /// <summary>
        /// List of balances owed by the patient, broken down by provider (financial) group.
        /// </summary>
        [JsonProperty("balances")]
        public Balance[] Balances { get; set; }

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
        /// True if email exists. False if patient declined. Null if status is unknown.
        /// </summary>
        [JsonProperty("emailexists")]
        public bool? EmailExists { get; set; }

        /// <summary>
        /// Language of the patient, using the ISO 639.2 code.
        /// (http://www.loc.gov/standards/iso639-2/php/code_list.php; "T" or terminology code)
        /// Special case: use "declined" to indicate that the patient declined to answer.
        /// </summary>
        [JsonProperty("language6392code")]
        public string Language6392Code { get; set; }

        /// <summary>
        /// List of active patient insurance packages. Only shown for a single patient and if
        /// SHOWINSURANCE is set.
        /// </summary>
        [JsonProperty("insurances")]
        public Insurance[] Insurances { get; set; }

        /// <summary>
        /// True if the patient has a photo uploaded
        /// </summary>
        [JsonProperty("patientphoto")]
        public bool? PatientPhoto { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "billing" communications
        /// delivered via email. Note that this will not be present if the practice or patient has
        /// not set it.For completeness, turning email off is supported via the API, but it is
        /// discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty("contactpreference_billing_email")]
        public bool? ContactPreferenceBillingEmail { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "announcement"
        /// communications delivered via email. Note that this will not be present if the practice or
        /// patient has not set it.For completeness, turning email off is supported via the API, but
        /// it is discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty("contactpreference_announcement_email")]
        public bool? ContactPreferenceAnnouncementEmail { get; set; }

        /// <summary>
        /// Date the patient was registered.
        /// </summary>
        [JsonProperty("registrationdate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// Guarantor's country code
        /// </summary>
        [JsonProperty("guarantorcountrycode")]
        public string GuarantorCountryCode { get; set; }

        /// <summary>
        /// Patient's first name
        /// </summary>
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

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
        /// </summary>
        [JsonProperty("allpatientstatuses")]
        public PatientStatus[] AllPatientStatuses { get; set; }

        /// <summary>
        /// The flag is used to record the consent of a patient to receive text messages per FCC
        /// requirements. In order for this to be true, a valid mobile phone number must be set and
        /// the practice setting "Hide SMS Opt-in option" must be set to Off.
        /// </summary>
        [JsonProperty("consenttotext")]
        public bool? ConsentToText { get; set; }

        /// <summary>
        /// Patient's country code (ISO 3166-1)
        /// </summary>
        [JsonProperty("countrycode3166")]
        public string CountryCode3166 { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "lab" communications
        /// delivered via phone. Note that this will not be present if the practice or patient has
        /// not set it.
        /// </summary>
        [JsonProperty("contactpreference_lab_phone")]
        public bool? ContactPreferenceLabPhone { get; set; }

        /// <summary>
        /// Primary (registration) department ID.
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "appointment"
        /// communications delivered via email. Note that this will not be present if the practice or
        /// patient has not set it.For completeness, turning email off is supported via the API, but
        /// it is discouraged. When email is off, patients may not not get messages from the patient portal.
        /// </summary>
        [JsonProperty("contactpreference_appointment_email")]
        public bool? ContactPreferenceAppointmentEmail { get; set; }

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
        /// If set, the patient has indicated a preference to get or not get "announcement"
        /// communications delivered via phone. Note that this will not be present if the practice or
        /// patient has not set it.
        /// </summary>
        [JsonProperty("contactpreference_announcement_phone")]
        public bool? ContactPreferenceAnnouncementPhone { get; set; }

        /// <summary>
        /// The address of the guarantor is the same as the patient.
        /// </summary>
        [JsonProperty("guarantoraddresssameaspatient")]
        public bool? GuarantorAddressSameAsPatient { get; set; }

        /// <summary>
        /// Patient's last name
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// The patient's mobile phone number. On input, 'declined' can be used to indicate no
        /// number. (Alternatively, hasmobile can also be set to false. "declined" simply does this
        /// for you.) Invalid numbers in a GET/PUT will be ignored. Patient phone numbers and other
        /// data may change, and one phone number may be associated with multiple patients. You are
        /// responsible for taking additional steps to verify patient identity and for using this
        /// data in accordance with applicable law, including HIPAA. Invalid numbers in a POST will
        /// be ignored, possibly resulting in an error.
        /// </summary>
        [JsonProperty("mobilephone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Set to false if a client has declined a phone number.
        /// </summary>
        [JsonProperty("hasmobile")]
        public bool? HasMobile { get; set; }

        /// <summary>
        /// If set, the patient has indicated a preference to get or not get "appointment"
        /// communications delivered via phone. Note that this will not be present if the practice or
        /// patient has not set it.
        /// </summary>
        [JsonProperty("contactpreference_appointment_phone")]
        public bool? ContactPreferenceAppointmentPhone { get; set; }

        /// <summary>
        /// Patient's DOB (mm/dd/yyyy)
        /// </summary>
        [JsonProperty("dob")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Same as /patients/{patientid}/customfields call, but without the department ID. Depending
        /// on setup, and only in large practices, the custom field values may or may not be the same
        /// between departments. If this is a concern, using the /patients/{patientid}/customfields
        /// call is preferred. Only for a single patient when showcustomfields is set to true.
        /// </summary>
        [JsonProperty("customfields")]
        public CustomField[] CustomFields { get; set; }

        /// <summary>
        /// The guarantor's relationship to the patient
        /// </summary>
        [JsonProperty("guarantorrelationshiptopatient")]
        public int? GuarantorRelationshipToPatient { get; set; }

        /// <summary>
        /// Given showlocalpatientid is true, comma separated local patient id will be returned, if
        /// patient id is enterprise id else given patient id will be displayed.
        /// </summary>
        [JsonProperty("localpatientid")]
        public string LocalPatientId { get; set; }

        /// <summary>
        /// Patient's country code
        /// </summary>
        [JsonProperty("countrycode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Guarantor's country code (ISO 3166-1)
        /// </summary>
        [JsonProperty("guarantorcountrycode3166")]
        public string GuarantorCountryCode3166 { get; set; }

        /// <summary>
        /// The last email for this patient on file.
        /// </summary>
        [JsonProperty("lastemail")]
        public string LastEmail { get; set; }

        /// <summary> The patient race hierarchical code as specified in Race & Ethnicity - CDC *
        /// (2.16.840.1.113883.1.11.14914) </summary>
        [JsonProperty("racecode")]
        public string RaceCode { get; set; }

        /// <summary>
        /// Sexual orientation of this patient.
        /// </summary>
        [JsonProperty("sexualorientation")]
        public string SexualOrientation { get; set; }

        /// <summary>
        /// Gender with which this patient identifies.
        /// </summary>
        [JsonProperty("genderidentity")]
        public string GenderIdentity { get; set; }

        /// <summary>
        /// Occupation of the patient, using the US Census occupation code (code system
        /// 2.16.840.1.113883.6.240). "other" can be used as well.
        /// </summary>
        [JsonProperty("occupationcode")]
        public string OccupationCode { get; set; }

        /// <summary>
        /// The patient race, using the 2.16.840.1.113883.5.104 codeset. See
        /// http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use
        /// "declined" to indicate that the patient declined to answer. Multiple values or a
        /// tab-seperated list of codes is acceptable for multiple races for input. The first race
        /// will be considered "primary". Note: you must update all values at once if you update any.
        /// </summary>
        [JsonProperty("race")]
        public string[] Race { get; set; }

        /// <summary>
        /// If a patient does not identify with any prescribed sexual orientation choice, this field
        /// stores the patient-provided description of sexual orientation.
        /// </summary>
        [JsonProperty("sexualorientationother")]
        public string SexualOrientationOther { get; set; }

        /// <summary>
        /// Patient's middle name
        /// </summary>
        [JsonProperty("middlename")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Patient's name suffix
        /// </summary>
        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// The patient's preferred name (i.e. nickname).
        /// </summary>
        [JsonProperty("preferredname")]
        public string PreferredName { get; set; }

        /// <summary>
        /// Patient's address - 1st line
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Patient's address - 2nd line
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// Patient's city
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Patient's state (2 letter abbreviation)
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Patient's zip. Matching occurs on first 5 characters.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// The patient's home phone number. Invalid numbers in a GET/PUT will be ignored. Patient
        /// phone numbers and other data may change, and one phone number may be associated with
        /// multiple patients. You are responsible for taking additional steps to verify patient
        /// identity and for using this data in accordance with applicable law, including HIPAA.
        /// Invalid numbers in a POST will be ignored, possibly resulting in an error.
        /// </summary>
        [JsonProperty("homephone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// The patient's work phone number. Generally not used to contact a patient. Invalid numbers
        /// in a GET/PUT will be ignored. Patient phone numbers and other data may change, and one
        /// phone number may be associated with multiple patients. You are responsible for taking
        /// additional steps to verify patient identity and for using this data in accordance with
        /// applicable law, including HIPAA. Invalid numbers in a POST will be ignored, possibly
        /// resulting in an error.
        /// </summary>
        [JsonProperty("workphone")]
        public string WorkPhone { get; set; }

        /// <summary>
        /// The patient's SSN
        /// </summary>
        [JsonProperty("ssn")]
        public string SSN { get; set; }

        /// <summary>
        /// The patient's primary race name. See race for more complete details.
        /// </summary>
        [JsonProperty("racename")]
        public string RaceName { get; set; }

        /// <summary>
        /// Patient's sex (M/F).
        /// </summary>
        [JsonProperty("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// Marital Status (D=Divorced, M=Married, S=Single, U=Unknown, W=Widowed, X=Separated, P=Partner)
        /// </summary>
        [JsonProperty("maritalstatus")]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// The MU-required field for "preferred contact method". This is not used by any automated systems.
        /// </summary>
        [JsonProperty("contactpreference")]
        public string ContactPreference { get; set; }

        /// <summary>
        /// The name of the (emergency) person to contact about the patient. The contactname,
        /// contactrelationship, contacthomephone, and contactmobilephone fields are all related to
        /// the emergency contact for the patient. They are NOT related to the contractpreference_* fields.
        /// </summary>
        [JsonProperty("contactname")]
        public string ContactName { get; set; }

        /// <summary>
        /// Emergency contact relationship (one of SPOUSE, PARENT, CHILD, SIBLING, FRIEND, COUSIN,
        /// GUARDIAN, OTHER)
        /// </summary>
        [JsonProperty("contactrelationship")]
        public string ContactRelationship { get; set; }

        /// <summary>
        /// Emergency contact home phone. Invalid numbers in a GET/PUT will be ignored. Patient phone
        /// numbers and other data may change, and one phone number may be associated with multiple
        /// patients. You are responsible for taking additional steps to verify patient identity and
        /// for using this data in accordance with applicable law, including HIPAA. Invalid numbers
        /// in a POST will be ignored, possibly resulting in an error.
        /// </summary>
        [JsonProperty("contacthomephone")]
        public string ContactHomePhone { get; set; }

        /// <summary>
        /// Emergency contact mobile phone. Invalid numbers in a GET/PUT will be ignored. Patient
        /// phone numbers and other data may change, and one phone number may be associated with
        /// multiple patients. You are responsible for taking additional steps to verify patient
        /// identity and for using this data in accordance with applicable law, including HIPAA.
        /// Invalid numbers in a POST will be ignored, possibly resulting in an error.
        /// </summary>
        [JsonProperty("contactmobilephone")]
        public string ContactMobilePhone { get; set; }

        /// <summary>
        /// The full name of the next of kin.
        /// </summary>
        [JsonProperty("nextkinname")]
        public string NextKinName { get; set; }

        /// <summary>
        /// The next of kin relationship (one of SPOUSE, PARENT, CHILD, SIBLING, FRIEND, COUSIN,
        /// GUARDIAN, OTHER)
        /// </summary>
        [JsonProperty("nextkinrelationship")]
        public string NextKinRelationship { get; set; }

        /// <summary>
        /// The next of kin phone number. Invalid numbers in a GET/PUT will be ignored. Patient phone
        /// numbers and other data may change, and one phone number may be associated with multiple
        /// patients. You are responsible for taking additional steps to verify patient identity and
        /// for using this data in accordance with applicable law, including HIPAA. Invalid numbers
        /// in a POST will be ignored, possibly resulting in an error.
        /// </summary>
        [JsonProperty("nextkinphone")]
        public string NextKinPhone { get; set; }

        /// <summary>
        /// The first name of the patient's guardian.
        /// </summary>
        [JsonProperty("guardianfirstname")]
        public string GuardianFirstName { get; set; }

        /// <summary>
        /// The middle name of the patient's guardian.
        /// </summary>
        [JsonProperty("guardianmiddlename")]
        public string GuardianMiddleName { get; set; }

        /// <summary>
        /// The last name of the patient's guardian.
        /// </summary>
        [JsonProperty("guardianlastname")]
        public string GuardianLastName { get; set; }

        /// <summary>
        /// The suffix of the patient's guardian.
        /// </summary>
        [JsonProperty("guardiansuffix")]
        public string GuardianSuffix { get; set; }

        /// <summary>
        /// Guarantor's first name
        /// </summary>
        [JsonProperty("guarantorfirstname")]
        public string GuarantorFirstName { get; set; }

        /// <summary>
        /// Guarantor's middle name
        /// </summary>
        [JsonProperty("guarantormiddlename")]
        public string GuarantorMiddleName { get; set; }

        /// <summary>
        /// Guarantor's last name
        /// </summary>
        [JsonProperty("guarantorlastname")]
        public string GuarantorLastName { get; set; }

        /// <summary>
        /// Guarantor's name suffix
        /// </summary>
        [JsonProperty("guarantorsuffix")]
        public string GuarantorSuffix { get; set; }

        /// <summary>
        /// Guarantor's address
        /// </summary>
        [JsonProperty("guarantoraddress1")]
        public string GuarantorAddress1 { get; set; }

        /// <summary>
        /// Guarantor's address - line 2
        /// </summary>
        [JsonProperty("guarantoraddress2")]
        public string GuarantorAddress2 { get; set; }

        /// <summary>
        /// Guarantor's city
        /// </summary>
        [JsonProperty("guarantorcity")]
        public string GuarantorCity { get; set; }

        /// <summary>
        /// Guarantor's state (2 letter abbreviation)
        /// </summary>
        [JsonProperty("guarantorstate")]
        public string GuarantorState { get; set; }

        /// <summary>
        /// Guarantor's zip
        /// </summary>
        [JsonProperty("guarantorzip")]
        public string GuarantorZip { get; set; }

        /// <summary>
        /// Guarantor's DOB (mm/dd/yyyy)
        /// </summary>
        [JsonProperty("guarantordob")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? GuarantorDateOfBirth { get; set; }

        /// <summary>
        /// Guarantor's SSN
        /// </summary>
        [JsonProperty("guarantorssn")]
        public string GuarantorSSN { get; set; }

        /// <summary>
        /// Guarantor's email address
        /// </summary>
        [JsonProperty("guarantoremail")]
        public string GuarantorEmail { get; set; }

        /// <summary>
        /// Guarantor's phone number. Invalid numbers in a GET/PUT will be ignored. Patient phone
        /// numbers and other data may change, and one phone number may be associated with multiple
        /// patients. You are responsible for taking additional steps to verify patient identity and
        /// for using this data in accordance with applicable law, including HIPAA. Invalid numbers
        /// in a POST will be ignored, possibly resulting in an error.
        /// </summary>
        [JsonProperty("guarantorphone")]
        public string GuarantorPhone { get; set; }

        /// <summary>
        /// This flag is set if the patient's signature is on file
        /// </summary>
        [JsonProperty("portalsignatureonfile")]
        public bool? PortalSignatureOnFile { get; set; }

        /// <summary>
        /// Medication history consent status. If a practice doesn't have RXHub or Surescripts
        /// enabled, this will be null
        /// </summary>
        [JsonProperty("medicationhistoryconsentverified")]
        public bool MedicationHistoryConsentVerified { get; set; }

        /// <summary>
        /// The long version of the marital status.
        /// </summary>
        [JsonProperty("maritalstatusname")]
        public string MaritalStatusName { get; set; }

        /// <summary>
        /// The patient's employer's ID (from /employers call)
        /// </summary>
        [JsonProperty("employerid")]
        public int? EmployerId { get; set; }

        /// <summary>
        /// The patient's employer's phone number. Normally, this is set by setting employerid.
        /// However, setting this value can be used to override this on an individual patient.
        /// Invalid numbers in a GET/PUT will be ignored. Patient phone numbers and other data may
        /// change, and one phone number may be associated with multiple patients. You are
        /// responsible for taking additional steps to verify patient identity and for using this
        /// data in accordance with applicable law, including HIPAA. Invalid numbers in a POST will
        /// be ignored, possibly resulting in an error.
        /// </summary>
        [JsonProperty("employerphone")]
        public string EmployerPhone { get; set; }

        /// <summary>
        /// The guaranror's employer's ID (from /employers call)
        /// </summary>
        [JsonProperty("guarantoremployerid")]
        public int? GuarantorEmployerId { get; set; }

        /// <summary>
        /// The patient's employer's name.
        /// </summary>
        [JsonProperty("employername")]
        public string EmployerName { get; set; }

        /// <summary>
        /// The patient's employer's address.
        /// </summary>
        [JsonProperty("employeraddress")]
        public string EmployerAddress { get; set; }

        /// <summary>
        /// The patient's employer's city.
        /// </summary>
        [JsonProperty("employercity")]
        public string EmployerCity { get; set; }

        /// <summary>
        /// The patient's employer's state.
        /// </summary>
        [JsonProperty("employerstate")]
        public string EmployerState { get; set; }

        /// <summary>
        /// Set to true if a patient wishes to get e-statements instead of paper statements. Should
        /// only be set for patients with an email address and clients with athenaCommunicator. The
        /// language we use in the portal is, "Future billing statements will be sent to you securely
        /// via your Patient Portal account. You will receive an email notice when new statements are
        /// available." This language is not required, but it is given as a suggestion.
        /// </summary>
        [JsonProperty("onlinestatementonly")]
        public bool? OnlineStateMentOnly { get; set; }

        /// <summary>
        /// The patient's employer's zip.
        /// </summary>
        [JsonProperty("employerzip")]
        public string EmployerZip { get; set; }

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
        /// The referral / "how did you hear about us" ID.
        /// </summary>
        [JsonProperty("referralsourceid")]
        public int? ReferralSourceId { get; set; }

        /// <summary>
        /// If choosing "other" for referral source, this is the text field that can be filled out.
        /// </summary>
        [JsonProperty("referralsourceother")]
        public string ReferralSourceOther { get; set; }

        /// <summary>
        /// The patient's preference for care summary delivery.
        /// </summary>
        [JsonProperty("caresummarydeliverypreference")]
        public string CareSummaryDeliveryPreference { get; set; }

        /// <summary>
        /// The patient's employer's fax.
        /// </summary>
        [JsonProperty("employerfax")]
        public string EmployerFax { get; set; }

        /// <summary>
        /// The NCPDP ID of the patient's preferred pharmacy. See http://www.ncpdp.org/ for details.
        /// Note: if updating this field, please make sure to have a CLINICALORDERTYPEGROUPID field
        /// as well.
        /// </summary>
        [JsonProperty("defaultpharmacyncpdpid")]
        public int? DefaultPharmacyNcpdId { get; set; }

        /// <summary>
        /// The ID of the mobile carrier, from /mobilecarriers or the list below.
        /// </summary>
        [JsonProperty("mobilecarrierid")]
        public int? MobileCarrierId { get; set; }

        /// <summary>
        /// Notes associated with this patient.
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// The number of the patient's driver's license
        /// </summary>
        [JsonProperty("driverslicensenumber")]
        public string DriversLicenseNumber { get; set; }

        /// <summary>
        /// The state of the patient's driver's license. This is in the form of a 2 letter state code.
        /// </summary>
        [JsonProperty("driverslicensestateid")]
        public string DriversLicenseStateId { get; set; }

        /// <summary>
        /// The URL to the patient photo
        /// </summary>
        [JsonProperty("patientphotourl")]
        public string PatientPhotoUrl { get; set; }

        /// <summary>
        /// The expiration date of the patient's driver's license.
        /// </summary>
        [JsonProperty("driverslicenseexpirationdate")]
        public string DriversLicenseExpirationDate { get; set; }

        /// <summary>
        /// Patient's family size (used for determining poverty level). Only settable if client has
        /// Federal Poverty Level fields turned on.
        /// </summary>
        [JsonProperty("povertylevelfamilysize")]
        public string PovertyLevelFamilySize { get; set; }

        /// <summary>
        /// Patient's poverty level (% of the Federal Poverty Level), as calculated from family size,
        /// income per pay period, pay period, and state. Typically only valued if client has Federal
        /// Poverty Level fields turned on.
        /// </summary>
        [JsonProperty("povertylevelcalculated")]
        public decimal? PovertyLevelCalculated { get; set; }

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
        public string PovertyLevelIncomePayPeriod { get; set; }

        /// <summary>
        /// Indicates if the patient declines to provide an income range level. True if the patient declines.
        /// </summary>
        [JsonProperty("povertylevelincomerangedeclined")]
        public bool? PovertyLevelIncomeRangeDeclined { get; set; }

        /// <summary>
        /// Used to identify this patient as an agricultural worker. Only settable if client has
        /// Social Determinant fields turned on.
        /// </summary>
        [JsonProperty("agriculturalworker")]
        public string AgriculturalWorker { get; set; }

        /// <summary>
        /// For patients that are agricultural workers, identifies the type of worker. Only settable
        /// if client has Social Determinant fields turned on.
        /// </summary>
        [JsonProperty("agriculturalworkertype")]
        public string AgriculturalWorkerType { get; set; }

        /// <summary>
        /// Used to identify this patient as homeless. Only settable if client has Social Determinant
        /// fields turned on.
        /// </summary>
        [JsonProperty("homeless")]
        public string Homeless { get; set; }

        /// <summary>
        /// For patients that are homeless, provides more detail regarding the patient's homeless
        /// situation. Only settable if client has Social Determinant fields turned on.
        /// </summary>
        [JsonProperty("homelesstype")]
        public string HomelessType { get; set; }

        /// <summary>
        /// Used to identify this patient as a veteran. Only settable if client has Social
        /// Determinant fields turned on.
        /// </summary>
        [JsonProperty("veteran")]
        public string Veteran { get; set; }

        /// <summary>
        /// Used to identify this patient as school-based health center patient. Only settable if
        /// client has Social Determinant fields turned on.
        /// </summary>
        [JsonProperty("schoolbasedhealthcenter")]
        public string SchoolBasedHealthCenter { get; set; }

        /// <summary>
        /// Used to identify this patient as living in public housing. Only settable if client has
        /// Social Determinant fields turned on.
        /// </summary>
        [JsonProperty("publichousing")]
        public string PublicHousing { get; set; }

        /// <summary>
        /// The URL to the patient's driver's license
        /// </summary>
        [JsonProperty("driverslicenseurl")]
        public string DriversLicenseUrl { get; set; }

        public class CustomField
        {
            /// <summary>
            /// Corresponds to the /customfields customfieldid.
            /// </summary>
            [JsonProperty("customfieldid")]
            public int? Id { get; set; }

            /// <summary>
            /// For a non-select custom field, the value.
            /// </summary>
            [JsonProperty("customfieldvalue")]
            public string CustomFieldValue { get; set; }

            /// <summary>
            /// For a select custom field, the selectid value (from /customfield's selectlist).
            /// </summary>
            [JsonProperty("optionid")]
            public int? OptionId { get; set; }
        }

        public class PortalStatusModel
        {
            /// <summary>
            /// Either "PATIENT" or "FAMILY", the last entity who accessed this patient.
            /// </summary>
            [JsonProperty("lastloginentity")]
            public string LastLoginEntity { get; set; }

            /// <summary>
            /// The date the patient registered for the portal.
            /// </summary>
            [JsonProperty("portalregistrationdate")]
            [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
            public DateTime? PortalRegistrationDate { get; set; }

            /// <summary>
            /// The last login date.
            /// </summary>
            [JsonProperty("lastlogindate")]
            [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
            public DateTime? LastLoginDate { get; set; }

            /// <summary>
            /// The privacy setting for blocking the patient from the portal is set.
            /// </summary>
            [JsonProperty("noportal")]
            public bool? NoPortal { get; set; }

            /// <summary>
            /// The status of the patient. Possible statuses:
            /// <para>REGISTERED: The patient is registered for the portal.</para>
            /// <para>NOTREGISTERED: The patient is not registered for the portal.</para>
            /// <para>FAMILYLOGIN: This patient is set up for a family member to login.</para>
            /// <para>
            /// NOPORTAL: The privacy setting for blocking the patient from the portal is set.
            /// </para>
            /// <para>BLOCKEDFAILEDLOGINS: The patient is blocked because of failed login attempts.</para>
            /// <para>
            /// FAMILYBLOCKEDFAILEDLOGINS: The family member is blocked because of failed login attempts.
            /// </para>
            /// </summary>
            [JsonProperty("status")]
            public string Status { get; set; }

            /// <summary>
            /// Is this patient blocked from the portal due to failed login attempts.
            /// </summary>
            [JsonProperty("blockedfailedlogins")]
            public bool? BlockedFailedLogins { get; set; }

            /// <summary>
            /// Is there a family member registered with access to this patient.
            /// </summary>
            [JsonProperty("familyregistered")]
            public bool? FamilyRegistered { get; set; }

            /// <summary>
            /// Is this patient's family blocked from the portal due to failed login attempts.
            /// </summary>
            [JsonProperty("familyblockedfailedlogins")]
            public bool? FamilyBlockedFailedLogins { get; set; }

            /// <summary>
            /// If this patient is registered or not for the portal.
            /// </summary>
            [JsonProperty("registered")]
            public bool? Registered { get; set; }

            /// <summary>
            /// Has this patient accepted the portal's Terms and Conditions. This is a good indicator
            /// if the patient has actually logged in to the portal or simply is registered without
            /// ever having logged in.
            /// </summary>
            [JsonProperty("termsaccepted")]
            public bool? TermsAccepted { get; set; }

            /// <summary>
            /// Either "FAMILY" or "PATIENT".
            /// </summary>
            [JsonProperty("entitytodisplay")]
            public string EntityToDisplay { get; set; }
        }

        public class Balance
        {
            /// <summary>
            /// Balance for this provider group.
            /// </summary>
            [JsonProperty("balance")]
            public string Value { get; set; }

            /// <summary>
            /// Comma separated list of department IDs that belong to this group
            /// </summary>
            [JsonProperty("departmentlist")]
            public string DepartmentList { get; set; }

            /// <summary>
            /// Athena ID for this financial group.
            /// </summary>
            [JsonProperty("providergroupid")]
            public int? ProviderGroupId { get; set; }

            /// <summary>
            /// Indicates whether the balance is associated with a contract, payment plan, or
            /// collections agency.
            /// </summary>
            [JsonProperty("cleanbalance")]
            public bool? CleanBalance { get; set; }

            /// <summary>
            /// The outstanding amount associated with a collections agency.
            /// </summary>
            [JsonProperty("collectionsbalance")]
            public string CollectionsBalance { get; set; }

            /// <summary>
            /// The outstanding amount associated with a payment plan.
            /// </summary>
            [JsonProperty("paymentplanbalance")]
            public string PaymentPlanBalance { get; set; }

            /// <summary>
            /// Information related to existing credit card contracts.
            /// </summary>
            [JsonProperty("contracts")]
            public Contract[] Contracts { get; set; }

            public class Contract
            {
                /// <summary>
                /// The available balance on this contract.
                /// </summary>
                [JsonProperty("availablebalance")]
                public string AvailableBalance { get; set; }

                /// <summary>
                /// The type of contract. For example, "ONEYEAR,"
                /// </summary>
                [JsonProperty("contractclass")]
                public string ContractClass { get; set; }

                /// <summary>
                /// The maximum allowed amount for this contract.
                /// </summary>
                [JsonProperty("maxamount")]
                public string MaxAmount { get; set; }
            }
        }

        public class PatientStatus
        {
            /// <summary>
            /// The "status" of the patient, one of active, inactive, prospective, or deleted.
            /// </summary>
            [JsonProperty("status")]
            public string Status { get; set; }

            /// <summary>
            /// The "primary" provider for this patient, if set.
            /// </summary>
            [JsonProperty("primaryproviderid")]
            public int? PrimaryProviderId { get; set; }

            /// <summary>
            /// The ID of a department that this patient is registered in.
            /// </summary>
            [JsonProperty("departmentid")]
            public int? DepartmentId { get; set; }
        }

        public class ClaimBalanceDetail
        {
            /// <summary>
            /// The ID of the provider group for the claim.
            /// </summary>
            [JsonProperty("providergroupid")]
            public int? ProviderGroupId { get; set; }

            /// <summary>
            /// Comma separated list of department IDs that belong to this provider group
            /// </summary>
            [JsonProperty("departmentids")]
            public string DepartmentIds { get; set; }

            /// <summary>
            /// Information related to claims for the patient.
            /// </summary>
            [JsonProperty("claimdetails")]
            public ClaimDetail[] ClaimDetails { get; set; }

            public class ClaimDetail
            {
                /// <summary>
                /// Indicates whether the balance is associated with a contract or payment plan.
                /// </summary>
                [JsonProperty("cleanbalance")]
                public bool? CleanBalance { get; set; }

                /// <summary>
                /// The amount billed for the claim.
                /// </summary>
                [JsonProperty("amount")]
                public decimal? Amount { get; set; }

                /// <summary>
                /// The date the service was rendered.
                /// </summary>
                [JsonProperty("servicedate")]
                [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
                public DateTime? ServiceDate { get; set; }

                /// <summary>
                /// The ID of the supervising provider who rendered the service.
                /// </summary>
                [JsonProperty("supervisingproviderid")]
                public int? SupervisingProviderId { get; set; }

                /// <summary>
                /// The ID of the department where the service was rendered.
                /// </summary>
                [JsonProperty("departmentid")]
                public int? DepartmentId { get; set; }

                /// <summary>
                /// The ID of the claim.
                /// </summary>
                [JsonProperty("claimid")]
                public int? ClaimId { get; set; }

                /// <summary>
                /// The outstanding amount owed by the patient.
                /// </summary>
                [JsonProperty("patientbalance")]
                public decimal? PatientBalance { get; set; }

                /// <summary>
                /// Detailed information on charges associated with the claim.
                /// </summary>
                [JsonProperty("chargeleveldetail")]
                public ChargeLevelDetail[] ChargeLevelDetails { get; set; }

                public class ChargeLevelDetail
                {
                    /// <summary>
                    /// The athenaNet ID of the charge.
                    /// </summary>
                    [JsonProperty("id")]
                    public int? Id { get; set; }

                    /// <summary>
                    /// The modifiers for the procedure code.
                    /// </summary>
                    [JsonProperty("procedurecodeothermodifier")]
                    public string ProcedureCodeOtherModifier { get; set; }

                    /// <summary>
                    /// The billed amount for the charge.
                    /// </summary>
                    [JsonProperty("amount")]
                    public decimal? Amount { get; set; }

                    /// <summary>
                    /// Description of the service.
                    /// </summary>
                    [JsonProperty("description")]
                    public string Description { get; set; }

                    /// <summary>
                    /// The CPT code associated with this charge.
                    /// </summary>
                    [JsonProperty("procedurecode")]
                    public string ProcedureCode { get; set; }

                    /// <summary>
                    /// The procedure code that would be submitted as part of the claim.
                    /// </summary>
                    [JsonProperty("procedurecodesubmitted")]
                    public string ProcedureCodeSubmitted { get; set; }

                    /// <summary>
                    /// Date of service for the charge.
                    /// </summary>
                    [JsonProperty("servicedate")]
                    [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
                    public DateTime? ServiceDate { get; set; }

                    /// <summary>
                    /// Detailed information on transactions associated with the charge.
                    /// </summary>
                    [JsonProperty("transactions")]
                    public Transaction[] Transactions { get; set; }

                    public class Transaction
                    {
                        /// <summary>
                        /// The date of the transaction.
                        /// </summary>
                        [JsonProperty("date")]
                        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
                        public DateTime? Date { get; set; }

                        /// <summary>
                        /// The athenaNet ID of the transaction.
                        /// </summary>
                        [JsonProperty("id")]
                        public int? Id { get; set; }

                        /// <summary>
                        /// The amount associated with the transaction.
                        /// </summary>
                        [JsonProperty("amount")]
                        public decimal? Amount { get; set; }

                        /// <summary>
                        /// The type of the transaction. For charge, payment, adjustment, etc.
                        /// </summary>
                        [JsonProperty("type")]
                        public string Type { get; set; }

                        /// <summary>
                        /// The epayment ID of the payment receipt associated with this payment
                        /// transaction. Applicable only for e-payments.
                        /// </summary>
                        [JsonProperty("epaymentid")]
                        public int? EpaymentId { get; set; }

                        /// <summary>
                        /// Information related to the type of transaction. (For example, a co-pay.).
                        /// </summary>
                        [JsonProperty("description")]
                        public string Description { get; set; }

                        /// <summary>
                        /// The party responsible for the parent charge of this transaction. For
                        /// example, '1' (primary), '2' (secondary), or 'p' (patient).
                        /// </summary>
                        [JsonProperty("transfertype")]
                        public string TransferType { get; set; }
                    }
                }
            }
        }
    }
}
