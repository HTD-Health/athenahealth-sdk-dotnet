using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class EncounterOrder
    {
        /// <summary>
        /// The order (aka document) ID for this order.
        /// </summary>
        [JsonProperty("orderid")]
        public int Id { get; set; }

        /// <summary>
        /// The status the document is in (PEND, CLOSED, SUBMIT, SUBMITTED, etc).
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        /// <summary>
        /// List of Diagnosis related to this order.
        /// </summary>
        [JsonProperty("diagnosislist")]
        public OrderRelatedDiagnosis[] DiagnosisList { get; set; }

        /// <summary>
        /// If true, this order is here just as a record, and does not need to actually go out.
        /// </summary>
        [JsonProperty("documentationonly")]
        public bool DocumentationOnly { get; set; }

        /// <summary>
        /// The human-readable description of this document class, including sub class (prescription - new vs. prescription - renewal).
        /// </summary>
        [JsonProperty("classdescription")]
        public string ClassDescription { get; set; }

        /// <summary>
        /// The athena ID for this type of order. Can be used to create another order of this type.
        /// </summary>
        [JsonProperty("ordertypeid")]
        public int? OrderTypeId { get; set; }

        /// <summary>
        /// The type of this order (Lab, Vaccine, etc.)
        /// </summary>
        [JsonProperty("ordertype")]
        public string OrderType { get; set; }

        /// <summary>
        /// The timestamp when the order was created.
        /// </summary>
        [JsonProperty("dateordered")]
        public string DateOrdered { get; set; }

        /// <summary>
        /// Department ID of the provider.
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// A human readable description for this order.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The username of the ordering provider, which is different than the ordering user -- who may be an intake nurse for example.
        /// </summary>
        [JsonProperty("orderingprovider")]
        public string OrderingProvider { get; set; }

        /// <summary>
        /// The primary class of this order -- PRESCRIPTION, VACCINE, LAB, IMAGING, PATIENTINFO, etc.
        /// </summary>
        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("externalcodes")]
        public IcdCode[] ExternalCodes { get; set; }

        [JsonProperty("questions")]
        public OrderQuestion[] Questions { get; set; }

        /// <summary>
        /// Details about the provider the order is sent to.
        /// </summary>
        [JsonProperty("clinicalprovider")]
        public string ClinicalProvider { get; set; }

        /// <summary>
        /// ID of the clinical provider
        /// </summary>
        [JsonProperty("clinicalproviderid")]
        public int? ClinicalProviderId { get; set; }

        /// <summary>
        /// Gives the location of the clinical specimen collected if any.
        /// </summary>
        [JsonProperty("specimencollectionsite")]
        public string SpecimenCollectionSite { get; set; }
    }

    public class OrderQuestion
    {
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }
    }
}