using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class Patient
    {
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "emailexists")]
        public bool EmailExists { get; set; }
        
        [JsonProperty(PropertyName = "occupationcode")]
        public string OccupationCode { get; set; }
        
        [JsonProperty(PropertyName = "departmentid")]
        public int DepartmentId { get; set; }
        
        [JsonProperty(PropertyName = "homephone")]
        public string HomePhone { get; set; }
        
        [JsonProperty(PropertyName = "homebound")]
        public bool HomeBound { get; set; }
        
        [JsonProperty(PropertyName = "guarantorstate")]
        public string GuarantorState { get; set; }
        
        [JsonProperty(PropertyName = "portalaccessgiven")]
        public bool PortalAccessGiven { get; set; }
        
        [JsonProperty(PropertyName = "driverslicense")]
        public bool DriversLicense { get; set; }
        
        [JsonProperty(PropertyName = "workphone")]
        public string WorkPhone { get; set; }
        
        [JsonProperty(PropertyName = "ethnicitycode")]
        public string EthnicityCode { get; set; }
        
        [JsonProperty(PropertyName = "industrycode")]
        public string IndustryCode { get; set; }
        
        [JsonProperty(PropertyName = "contacthomephone")]
        public string ContactHomePhone { get; set; }
        
        [JsonProperty(PropertyName = "contactrelationship")]
        public string ContactRelationship { get; set; }
        
        [JsonProperty(PropertyName = "contactname")]
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
        
        [JsonProperty(PropertyName = "firstappointment")]
        public string FirstAppointment { get; set; }
        
        [JsonProperty(PropertyName = "lastappointment")]
        public string LastAppointment { get; set; }
        
        [JsonProperty(PropertyName = "patientphotourl")]
        public string PatientPhotoUrl { get; set; }
        
        [JsonProperty(PropertyName = "mobilecarrierid")]
        public int MobileCarrierId { get; set; }
        
        [JsonProperty(PropertyName = "guarantorssn")]
        public string GuarantorSsn { get; set; }
        
        [JsonProperty(PropertyName = "guarantordob")]
        public string GuarantorDob { get; set; }
        
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }
        
        [JsonProperty(PropertyName = "guarantoraddresssameaspatient")]
        public bool GuarantorAddressSameAsPatient { get; set; }
        
        [JsonProperty(PropertyName = "employerphone")]
        public string EmployerPhone { get; set; }
        
        [JsonProperty(PropertyName = "contactmobilephone")]
        public string ContactMobilePhone { get; set; }
        
        [JsonProperty(PropertyName = "contactpreference")]
        public string ContactPreference { get; set; }
        
        [JsonProperty(PropertyName = "nextkinphone")]
        public string NextKinPhone { get; set; }
        
        [JsonProperty(PropertyName = "nextkinrelationship")]
        public string NextKinRelationship { get; set; }
        
        [JsonProperty(PropertyName = "nextkinname")]
        public string NextKinName { get; set; }
        
        [JsonProperty(PropertyName = "portaltermsonfile")]
        public bool PortalTermsOnFile { get; set; }
        
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        [JsonProperty(PropertyName = "lastname")]
        public string Lastname { get; set; }
        
        [JsonProperty(PropertyName = "guarantorfirstname")]
        public string GuarantorFirstName { get; set; }
        
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        
        [JsonProperty(PropertyName = "ssn")]
        public string Ssn { get; set; }
        
        [JsonProperty(PropertyName = "guarantoremail")]
        public string GuarantorEmail { get; set; }
        
        [JsonProperty(PropertyName = "guarantorcity")]
        public string GuarantorCity { get; set; }
        
        [JsonProperty(PropertyName = "guarantorzip")]
        public string GuarantorZip { get; set; }
        
        [JsonProperty(PropertyName = "privacyinformationverified")]
        public bool PrivacyInformationVerified { get; set; }
        
        [JsonProperty(PropertyName = "primarydepartmentid")]
        public int PrimaryDepartmentId { get; set; }
        
        [JsonProperty(PropertyName = "balances")]
        public ICollection<Balance> Balances { get; set; }
        
        [JsonProperty(PropertyName = "race")]
        public IList<string> Race { get; set; }
        
        [JsonProperty(PropertyName = "racename")]
        public string RaceName { get; set; }
        
        [JsonProperty(PropertyName = "language6392code")]
        public string Language6392Code { get; set; }
        
        [JsonProperty(PropertyName = "primaryproviderid")]
        public int PrimaryProviderId { get; set; }
        
        [JsonProperty(PropertyName = "povertylevelincomedeclined")]
        public bool PovertyLevelIncomeDeclined { get; set; }
        
        [JsonProperty(PropertyName = "povertylevelfamilysizedeclined")]
        public bool PovertyLevelFamilySizeDeclined { get; set; }
        
        [JsonProperty(PropertyName = "patientphoto")]
        public bool PatientPhoto { get; set; }
        
        [JsonProperty(PropertyName = "caresummarydeliverypreference")]
        public string CareSummaryDeliveryPreference { get; set; }
        
        [JsonProperty(PropertyName = "guarantorlastname")]
        public string GuarantorLastName { get; set; }
        
        [JsonProperty(PropertyName = "suffix")]
        public string Suffix { get; set; }
        
        [JsonProperty(PropertyName = "firstname")]
        public string FirstName { get; set; }
        
        [JsonProperty(PropertyName = "middlename")]
        public string MiddleName { get; set; }
        
        [JsonProperty(PropertyName = "preferredname")]
        public string PreferredName { get; set; }
        
        [JsonProperty(PropertyName = "maritalstatus")]
        public string MaritalStatus { get; set; }
        
        [JsonProperty(PropertyName = "maritalstatusname")]
        public string MaritalStatusName { get; set; }
        
        [JsonProperty(PropertyName = "sex")]
        public string Sex { get; set; }
        
        [JsonProperty(PropertyName = "hasmobile")]
        public bool HasMobile { get; set; }
        
        [JsonProperty(PropertyName = "mobilephone")]
        public string MobilePhone { get; set; }
        
        [JsonProperty(PropertyName = "onlinestatementonly")]
        public bool OnlineStatementOnly { get; set; }
        
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }
        
        [JsonProperty(PropertyName = "guarantorcountrycode")]
        public string GuarantorCountryCode { get; set; }
        
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        
        [JsonProperty(PropertyName = "patientid")]
        public int PatientId { get; set; }
        
        [JsonProperty(PropertyName = "referralsourceid")]
        public int ReferralSourceId { get; set; }
        
        [JsonProperty(PropertyName = "dob")]
        public string Dob { get; set; }
        
        [JsonProperty(PropertyName = "guarantorrelationshiptopatient")]
        public int GuarantorRelationshipToPatient { get; set; }
        
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }
        
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }
        
        [JsonProperty(PropertyName = "guarantorphone")]
        public string GuarantorPhone { get; set; }
        
        [JsonProperty(PropertyName = "countrycode")]
        public string CountryCode { get; set; }
        
        [JsonProperty(PropertyName = "guarantoraddress1")]
        public string GuarantorAddress1 { get; set; }
        
        [JsonProperty(PropertyName = "guarantoraddress2")]
        public string GuarantorAddress2 { get; set; }
        
        [JsonProperty(PropertyName = "consenttocall")]
        public bool ConsentToCall { get; set; }
        
        [JsonProperty(PropertyName = "consenttotext")]
        public bool ConsentToText { get; set; }
        
        [JsonProperty(PropertyName = "countrycode3166")]
        public string CountryCode3166 { get; set; }
        
        [JsonProperty(PropertyName = "guarantorcountrycode3166")]
        public string GuarantorCountryCode3166 { get; set; }
        
        [JsonProperty(PropertyName = "lastemail")]
        public string LastEmail { get; set; }
        
        [JsonProperty(PropertyName = "employerid")]
        public int EmployerId { get; set; }
        
        [JsonProperty(PropertyName = "employercity")]
        public string EmployerCity { get; set; }
        
        [JsonProperty(PropertyName = "employerstate")]
        public string EmployerState { get; set; }
        
        [JsonProperty(PropertyName = "employerzip")]
        public string EmployerZip { get; set; }

        [JsonProperty(PropertyName = "guarantorsuffix")]
        public string GuarantorSuffix { get; set; }
        
        [JsonProperty(PropertyName = "guarantoremployerid")]
        public int GuarantorEmployerId { get; set; }
        
        [JsonProperty(PropertyName = "employername")]
        public string EmployerName { get; set; }
        
        [JsonProperty(PropertyName = "employeraddress")]
        public string EmployerAddress { get; set; }


        public string Fullname => $"{FirstName} {MiddleName} {Lastname}";
    }
}

