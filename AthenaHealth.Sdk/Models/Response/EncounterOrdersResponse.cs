using Newtonsoft.Json;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable IdentifierTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class EncounterOrdersResponse
    {
        /// <summary>
        /// The matching ICD9 or ICD10 codes for this diagnosis, where available.
        /// </summary>
        [JsonProperty(PropertyName = "diagnosisicd")]
        public IcdCode[] DiagnosisIcd { get; set; }

        /// <summary>
        /// List of orders for this diagnosis.
        /// </summary>
        [JsonProperty(PropertyName = "orders")]
        public Order[] Orders { get; set; }

        /// <summary>
        /// The SNOMED code for this diagnosis. 0 means No Diagnosis.
        /// </summary>
        [JsonProperty(PropertyName = "diagnosissnomed")]
        public int? DiagnosisSnomed { get; set; }

        /// <summary>
        /// The name of the diagnosis
        /// </summary>
        [JsonProperty(PropertyName = "diagnosis")]
        public string Diagnosis { get; set; }
    }

    public class Order
    {
        /// <summary>
        /// The order (aka document) ID for this order.
        /// </summary>
        [JsonProperty(PropertyName = "orderid")]
        public int Id { get; set; }

        /// <summary>
        /// List of codes indicating why the order was not given. If this field is not present, the order was not declined.
        /// If the array is empty, no reason has been chosen.
        /// </summary>
        [JsonProperty(PropertyName = "declinedreason")]
        public IcdCode[] DeclinedReason { get; set; }

        /// <summary>
        /// List of codes indicating why the order was contraindicated (for vaccines only).
        /// If this field is not present, the order does not contain a contraindication reason.
        /// </summary>
        [JsonProperty(PropertyName = "contraindicationreason")]
        public IcdCode[] ContraIndicationReason { get; set; }

        /// <summary>
        /// List of Diagnosis related to this order.
        /// </summary>
        [JsonProperty(PropertyName = "diagnosislist")]
        public OrderRelatedDiagnosis[] DiagnosisList { get; set; }

        /// <summary>
        /// Gives the location of the clinical specimen collected if any.
        /// </summary>
        [JsonProperty(PropertyName = "specimencollectionsite")]
        public string SpecimenCollectionSite { get; set; }

        /// <summary>
        /// When available, contains how this order maps to external vocabularies like LOINC, CVX, SNOMED, RXNORM, etc.
        /// CodeSet contains name of the external vocabulary.
        /// Currently LOINC (for labs and some imaging orders), CVX (for vaccines), RXNORM and NDC (for prescriptions and some DMEs).
        /// </summary>
        [JsonProperty(PropertyName = "externalcodes")]
        public IcdCode[] ExternalCodes { get; set; }

        /// <summary>
        /// The username of the person who created the order.
        /// </summary>
        [JsonProperty(PropertyName = "createduser")]
        public string CreatedUser { get; set; }

        /// <summary>
        /// The username of the person who last modified the order.
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifiedby")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// The date this order was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifieddatetime")]
        public string LastModifiedDateTime { get; set; }

        /// <summary>
        /// The user-facing description of the reason the order was not given.
        /// </summary>
        [JsonProperty(PropertyName = "declinedreasontext")]
        public string DeclinedReasonText { get; set; }

        /// <summary>
        /// A human readable description for this order.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Department ID of the provider.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// The primary class of this order -- PRESCRIPTION, VACCINE, LAB, IMAGING, PATIENTINFO, etc.
        /// </summary>
        [JsonProperty(PropertyName = "class")]
        public string Class { get; set; }

        /// <summary>
        /// The human-readable description of this document class, including sub class (prescription - new vs. prescription - renewal).
        /// </summary>
        [JsonProperty(PropertyName = "classdescription")]
        public string ClassDescription { get; set; }

        /// <summary>
        /// The athena ID for this type of order. Can be used to create another order of this type.
        /// </summary>
        [JsonProperty(PropertyName = "ordertypeid")]
        public int? OrderTypeId { get; set; }

        /// <summary>
        /// The type of this order (Lab, Vaccine, etc.)
        /// </summary>
        [JsonProperty(PropertyName = "ordertype")]
        public string OrderType { get; set; }

        /// <summary>
        /// The timestamp when the order was created.
        /// </summary>
        [JsonProperty(PropertyName = "dateordered")]
        public string DateOrdered { get; set; }

        /// <summary>
        /// The username of the ordering provider, which is different than the ordering user -- who may be an intake nurse for example.
        /// </summary>
        [JsonProperty(PropertyName = "orderingprovider")]
        public string OrderingProvider { get; set; }

        /// <summary>
        /// ID of the ordering provider.
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The username of the user who this order task is currently assigned to for further processing as needed.
        /// </summary>
        [JsonProperty(PropertyName = "assigneduser")]
        public string AssignedUser { get; set; }

        /// <summary>
        /// Priority of a order.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// The status the document is in (PEND, CLOSED, SUBMIT, SUBMITTED, etc).
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// If true, this order is here just as a record, and does not need to actually go out.
        /// </summary>
        [JsonProperty(PropertyName = "documentationonly")]
        public bool DocumentationOnly { get; set; }

        /// <summary>
        /// The dosage quantity value.
        /// </summary>
        [JsonProperty(PropertyName = "quantityvalue")]
        public string QuantityValue { get; set; }

        /// <summary>
        /// The number of refills allowed.
        /// </summary>
        [JsonProperty(PropertyName = "refills")]
        public string Refills { get; set; }

        /// <summary>
        /// Name of the clinical provider.
        /// </summary>
        [JsonProperty(PropertyName = "clinicalprovidername")]
        public string ClinicalProviderName { get; set; }

        /// <summary>
        /// ID of the clinical provider
        /// </summary>
        [JsonProperty(PropertyName = "clinicalproviderid")]
        public int? ClinicalProviderId { get; set; }

        /// <summary>
        /// The date this order will be submitted.
        /// </summary>
        [JsonProperty(PropertyName = "futuresubmitdate")]
        public string FutureSubmitDate { get; set; }

        /// <summary>
        /// Details about the provider the order is sent to.
        /// </summary>
        [JsonProperty(PropertyName = "clinicalprovider")]
        public ClinicalProvider ClinicalProvider { get; set; }

        /// <summary>
        /// The National Drug Code for the order
        /// </summary>
        [JsonProperty(PropertyName = "ndc")]
        public string Ndc { get; set; }

    }

    public class OrderRelatedDiagnosis
    {
        [JsonProperty(PropertyName = "diagnosiscode")]
        public IcdCode DiagnosisCode { get; set; }

        /// <summary>
        /// ICD equivalent Codes for the SNOMED Code.
        /// </summary>
        [JsonProperty(PropertyName = "snomedicdcodes")]
        public SnomedIcdCode[] SnomedIcdCodes { get; set; }
    }

    /// <summary>
    /// ICD equivalent Codes for the SNOMED Code.
    /// </summary>
    public class SnomedIcdCode
    {
        /// <summary>
        /// Unstripped Diagnosis Code.
        /// </summary>
        [JsonProperty("unstrippeddiagnosiscode")]
        public string Ndc { get; set; }

        /// <summary>
        /// Code set the ICD10 code belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "codeset")]
        public string CodeSet { get; set; }

        /// <summary>
        /// ICD 10 Code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Brief description for this code.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }


    public class ClinicalProvider
    {
        /// <summary>
        /// ID for the provider
        /// </summary>
        [JsonProperty(PropertyName = "clinicalproviderid")]
        public string Id { get; set; }

        /// <summary>
        /// First part of provider address
        /// </summary>
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// City of the provider
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Second part of provider address
        /// </summary>
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// Fax number for the provider
        /// </summary>
        [JsonProperty(PropertyName = "faxphonenumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Name of the provider
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Phone number for the provider
        /// </summary>
        [JsonProperty(PropertyName = "phonenumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// State the provider resides
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Zip code for the provider
        /// </summary>
        [JsonProperty(PropertyName = "zip")]
        public int? Zip { get; set; }

        /// <summary>
        /// The CLIA number of the clinical provider on file.
        /// </summary>
        [JsonProperty(PropertyName = "clianumber")]
        public string CliaNumber { get; set; }
    }

}