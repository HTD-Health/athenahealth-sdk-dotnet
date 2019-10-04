using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class Patient
    {
        public string Email { get; set; }

        public bool EmailExists { get; set; }

        public string OccupationCode { get; set; }

        public int DepartmentId { get; set; }

        public string HomePhone { get; set; }

        public bool HomeBound { get; set; }

        public string GuarantorState { get; set; }

        public bool PortalAccessGiven { get; set; }

        public bool DriversLicense { get; set; }

        public string WorkPhone { get; set; }

        public string EthnicityCode { get; set; }

        public string IndustryCode { get; set; }

        public string ContactHomePhone { get; set; }

        public string ContactRelationship { get; set; }

        public string ContactName { get; set; }

        [JsonProperty(PropertyName = "contactpreference_appointment_sms")]
        public bool ContactPreferenceAppointmentSms { get; set; }

        [JsonProperty(PropertyName = "contactpreference_appointment_email")]
        public bool ContactPreferenceAppointmentEmail { get; set; }

        [JsonProperty(PropertyName = "contactpreference_billing_phone")]
        public bool ContactPreferenceBillingPhone { get; set; }

        [JsonProperty(PropertyName = "contactpreference_announcement_phone")]
        public bool ContactPreferenceAnnouncementPhone { get; set; }
        
        [JsonProperty(PropertyName = "contactpreference_lab_sms")]
        public bool ContactPreferenceLabSms { get; set; }

        [JsonProperty(PropertyName = "contactpreference_lab_phone")]
        public bool ContactPreferenceLabPhone { get; set; }

        [JsonProperty(PropertyName = "contactpreference_lab_email")]
        public bool ContactPreferenceLabEmail { get; set; }

        [JsonProperty(PropertyName = "contactpreference_announcement_sms")]
        public bool ContactPreferenceAnnouncementSms { get; set; }

        [JsonProperty(PropertyName = "contactpreference_announcement_email")]
        public bool ContactPreferenceAnnouncementEmail { get; set; }

        [JsonProperty(PropertyName = "contactpreference_appointment_phone")]
        public bool ContactPreferenceAppointmentPhone { get; set; }

        [JsonProperty(PropertyName = "contactpreference_billing_sms")]
        public bool ContactPreferenceBillingSms { get; set; }

        [JsonProperty(PropertyName = "contactpreference_billing_email")]
        public bool ContactPreferenceBillingEmail { get; set; }

        public string FirstAppointment { get; set; }

        public string LastAppointment { get; set; }

        public string PatientPhotoUrl { get; set; }

        public int MobileCarrierId { get; set; }

        public string GuarantorSsn { get; set; }

        public string GuarantorDob { get; set; }

        public string Zip { get; set; }

        public bool GuarantorAddressSameAsPatient { get; set; }

        public string EmployerPhone { get; set; }

        public string ContactMobilePhone { get; set; }

        public string ContactPreference { get; set; }

        public string NextKinPhone { get; set; }

        public string NextKinRelationship { get; set; }

        public string NextKinName { get; set; }

        public bool PortalTermsOnFile { get; set; }

        public string Status { get; set; }

        public string Lastname { get; set; }

        public string GuarantorFirstName { get; set; }

        public string City { get; set; }

        public string Ssn { get; set; }

        public string GuarantorEmail { get; set; }

        public string GuarantorCity { get; set; }

        public string GuarantorZip { get; set; }

        public bool PrivacyInformationVerified { get; set; }

        public int PrimaryDepartmentId { get; set; }

        public ICollection<Balance> Balances { get; set; }

        public string Race { get; set; }

        public string RaceName { get; set; }

        public string Language6392Code { get; set; }

        public int PrimaryProviderId { get; set; }

        public bool PovertyLevelIncomeDeclined { get; set; }

        public bool PovertyLevelFamilySizeDeclined { get; set; }

        public bool PatientPhoto { get; set; }

        public bool CareSummaryDeliveryPreference { get; set; }

        public bool GuarantorLastName { get; set; }

        public string Suffix { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string PreferredName { get; set; }

        public string MaritalStatus { get; set; }

        public string MaritalStatusName { get; set; }

        public string Sex { get; set; }

        public bool HasMobile { get; set; }

        public string MobilePhone { get; set; }

        public bool OnlineStatementOnly { get; set; }

        public string Notes { get; set; }

        public string GuarantorCountryCode { get; set; }

        public string State { get; set; }

        public int PatientId { get; set; }

        public int ReferralSourceId { get; set; }

        public string Dob { get; set; }

        public int GuarantorRelationshipToPatient { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string GuarantorPhone { get; set; }

        public string CountryCode { get; set; }

        public string GuarantorAddress1 { get; set; }

        public string GuarantorAddress2 { get; set; }

        public bool ConsentToCall { get; set; }

        public bool ConsentToText { get; set; }

        public string CountryCode3166 { get; set; }

        public string GuarantorCountryCode3166 { get; set; }

        public string LastEmail { get; set; }

        public int EmployerId { get; set; }

        public string EmployerCity { get; set; }

        public string EmployerState { get; set; }

        public string EmployerZip { get; set; }

        public string GuarantorSuffix { get; set; }

        public int GuarantorEmployerId { get; set; }

        public string EmployerName { get; set; }

        public string EmployerAddress { get; set; }


        public string Fullname => $"{FirstName} {MiddleName} {Lastname}";
    }
}

