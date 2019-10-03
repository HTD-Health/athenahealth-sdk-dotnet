using System;
using System.Collections.Generic;
using System.Text;

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
        public bool ContactPreferenceAppointmentSms { get; set; }
        public bool ContactPreferenceAppointmentEmail { get; set; }
        public bool ContactPreferenceBillingPhone { get; set; }
        public bool ContactPreferenceAnnouncementPhone { get; set; }
        public bool ContactPreferenceLabSms { get; set; }
        public bool ContactPreferenceLabPhone { get; set; }
        public bool ContactPreferenceLabEmail { get; set; }
        public bool ContactPreferenceAnnouncementSms { get; set; }
        public bool ContactPreferenceAnnouncementEmail { get; set; }
        public bool ContactPreferenceAppointmentPhone { get; set; }
        public bool ContactPreferenceBillingSms { get; set; }
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
