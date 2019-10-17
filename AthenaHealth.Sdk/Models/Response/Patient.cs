using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class Patient
    {
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
        public ClaimBalanceDetailsModel[] ClaimBalanceDetails { get; set; }

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
        public string DeceasedDate { get; set; }

        /// <summary>
        /// The first appointment for this patient, excluding cancelled or no-show appointments.
        /// (mm/dd/yyyy h24:mi)
        /// </summary>
        [JsonProperty("firstappointment")]
        public string FirstAppointment { get; set; }

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
        public PortalstatusModel PortalStatus { get; set; }

        /// <summary>
        /// The "status" of the patient, one of active, inactive, prospective, or deleted.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

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
        public BalanceModel[] Balances { get; set; }

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
        public InsuranceModel[] Insurances { get; set; }

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
        public string RegistrationDate { get; set; }

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
        public AllPatientStatusModel[] AllPatientStatuses { get; set; }

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
        /// Please remember to never disclose this ID to patients since it may result in inadvertant
        /// disclosure that a patient exists in a practice already.
        /// </summary>
        [JsonProperty("patientid")]
        public int? PatientId { get; set; }

        /// <summary>
        /// Patient's DOB (mm/dd/yyyy)
        /// </summary>
        [JsonProperty("dob")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Same as /patients/{patientid}/customfields call, but without the department ID. Depending
        /// on setup, and only in large practices, the custom field values may or may not be the same
        /// between departments. If this is a concern, using the /patients/{patientid}/customfields
        /// call is preferred. Only for a single patient when showcustomfields is set to true.
        /// </summary>
        [JsonProperty("customfields")]
        public CustomFieldModel[] CustomFields { get; set; }

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
        /// Patient's sex (M/F)
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
        public string ContactHomephone { get; set; }

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
        public string GuarantorDateOfBirth { get; set; }

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

        public class CustomFieldModel
        {
            /// <summary>
            /// Corresponds to the /customfields customfieldid.
            /// </summary>
            [JsonProperty("customfieldid")]
            public int? CustomFieldId { get; set; }

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

        public class PortalstatusModel
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
            public string PortalRegistrationDate { get; set; }

            /// <summary>
            /// The last login date.
            /// </summary>
            [JsonProperty("lastlogindate")]
            public string LastLoginDate { get; set; }

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

        public class InsuranceModel
        {
            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("insuredcountrycode")]
            public string InsuredCountryCode { get; set; }

            [JsonProperty("insuredcity")]
            public string InsuredCity { get; set; }

            [JsonProperty("insureddob")]
            public string InsuredDateOfBirth { get; set; }

            [JsonProperty("insuredaddress")]
            public string InsuredAddress { get; set; }

            [JsonProperty("insuredzip")]
            public string InsuredZip { get; set; }

            [JsonProperty("insuredsex")]
            public string InsuredSex { get; set; }

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
            /// CASE POLICY FIELD - Date of the injury. Required for auto insurance, legal, and
            /// worker's comp case policies.
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
            public string ExpirationDate { get; set; }

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
            public string InsurancePolicyHolderSex { get; set; }

            /// <summary>
            /// 1 = primary, 2 = secondary, 3 = tertiary, etc. Must have a primary before a secondary
            /// and a secondary before a tertiary, etc.
            /// </summary>
            [JsonProperty("sequencenumber")]
            public int? SequenceNumber { get; set; }

            /// <summary>
            /// CASE POLICY FIELD - First name of the adjuster on this case policy. Only available
            /// for auto insurance or worker's comp case policies.
            /// </summary>
            [JsonProperty("adjusterfirstname")]
            public string AdjusterFirstName { get; set; }

            /// <summary>
            /// CASE POLICY FIELD - Boolean field indicating if another party was responsible for
            /// this accident.
            /// </summary>
            [JsonProperty("anotherpartyresponsible")]
            public bool? AnotherPartyResponsible { get; set; }

            /// <summary>
            /// CASE POLICY FIELD - A description of the injury. Only available for auto insurance
            /// and worker's comp case policies.
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
            /// CASE POLICY FIELD - A list of ICD9 accepted diagnosis codes. Only available for
            /// worker's comp case policies.
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
            public string InsurancePolicyHolderDateOfBirth { get; set; }

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
            /// CASE POLICY FIELD - Two-letter state abbreviation for the state this injury was
            /// reported in. Only available for worker's comp case policies.
            /// </summary>
            [JsonProperty("stateofreportedinjury")]
            public string StateOfReportedInjury { get; set; }

            /// <summary>
            /// CASE POLICY FIELD - Boolean field indicating whether this case policy is related to
            /// an auto accident.
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
            /// CASE POLICY FIELD - Phone number/other contact info for the adjuster on this case
            /// policy. Only available for auto insurance or worker's comp case policies.
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
            /// The coinsurance percentage for this insurance. If you've just POSTed a new insurance
            /// you will have to wait for the auto eligbility check before this field populates.
            /// </summary>
            [JsonProperty("coinsurancepercent")]
            public decimal? CoinsurancePercent { get; set; }

            /// <summary>
            /// The suffix of the insurance policy holder.
            /// </summary>
            [JsonProperty("insurancepolicyholdersuffix")]
            public string InsurancePolicyHolderSuffix { get; set; }

            /// <summary>
            /// The national provider id of the primary care physcian assicated with the insurance.
            /// </summary>
            [JsonProperty("insuredpcpnpi")]
            public int? InsuredPrimaryCarePhisicanNationalProviderId { get; set; }

            /// <summary>
            /// CASE POLICY FIELD - Text field for describing the injured body part. Only available
            /// for auto insurance and worker's comp case policies.
            /// </summary>
            [JsonProperty("injuredbodypart")]
            public string InjuredBodyPart { get; set; }

            /// <summary>
            /// Date the eligibility was last checked.
            /// </summary>
            [JsonProperty("eligibilitylastchecked")]
            public string EligibilityLastChecked { get; set; }

            [JsonProperty("insuredpcp")]
            public string InsuredPrimaryCarePhisican { get; set; }

            /// <summary>
            /// Address 2 for the AthenaNet insurance Package.
            /// </summary>
            [JsonProperty("insurancepackageaddress2")]
            public string InsurancePackageAddress2 { get; set; }

            /// <summary>
            /// CASE POLICY FIELD - Two-letter abbreviation for the state in which the auto accident
            /// took place. Only meaningful for auto insurance case policies.
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
            /// insurance you will have to wait for the auto eligbility check before these populate.
            /// </summary>
            [JsonProperty("copays")]
            public CopayModel[] Copays { get; set; }

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
            /// CASE POLICY FIELD - Phone number for the repricer. Only available for worker's comp
            /// case policies.
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
            /// CASE POLICY FIELD - Boolean field indicating whether this case policy is related to
            /// the patient's employer.
            /// </summary>
            [JsonProperty("relatedtoemployment")]
            public bool? RelatedToEmployment { get; set; }

            /// <summary>
            /// The phone number for the insurance company. Note: This defaults to the insurance
            /// package phone number. If this is set, it will override it. Likewise if blanked out,
            /// it will go back to default.
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

            public class CopayModel
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

        public class BalanceModel
        {
            /// <summary>
            /// Balance for this provider group.
            /// </summary>
            [JsonProperty("balance")]
            public string Balance { get; set; }

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
            public ContractModel[] Contracts { get; set; }

            public class ContractModel
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

        public class AllPatientStatusModel
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

        public class ClaimBalanceDetailsModel
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
            public ClaimDetailsModel[] ClaimDetails { get; set; }

            public class ClaimDetailsModel
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
                public string ServiceDate { get; set; }

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
                public ChargeLevelDetailModel[] ChargeLevelDetail { get; set; }

                public class ChargeLevelDetailModel
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
                    public string ServiceDate { get; set; }

                    /// <summary>
                    /// Detailed information on transactions associated with the charge.
                    /// </summary>
                    [JsonProperty("transactions")]
                    public TransactionModel[] Transactions { get; set; }

                    public class TransactionModel
                    {
                        /// <summary>
                        /// The date of the transaction.
                        /// </summary>
                        [JsonProperty("date")]
                        public string Date { get; set; }

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
