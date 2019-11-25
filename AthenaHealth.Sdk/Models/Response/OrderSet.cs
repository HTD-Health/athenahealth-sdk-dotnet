using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class OrderSetResponse : IPagingResponse<OrderSet>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("ordersets")]
        public OrderSet[] Items { get; set; }
    }

    public class OrderSet
    {
        /// <summary>
        /// Some order sets cannot be used during an encounter because some of the orders have
        /// become invalid. If that is the case, an error message will be returned along with the
        /// order set name and ID. If there is an error, a diagnoses array will not be returned.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// An array of diagnosis objects attached to this order set.
        /// </summary>
        [JsonProperty("diagnoses")]
        public Diagnose[] Diagnoses { get; set; }

        /// <summary>
        /// Name of the order set. This is set by the practice/user.
        /// </summary>
        [JsonProperty("ordersetname")]
        public string Name { get; set; }

        /// <summary>
        /// ID of the order set.
        /// </summary>
        [JsonProperty("ordersetid")]
        public int? Id { get; set; }

        public class Diagnose
        {
            /// <summary>
            /// The SNOMED code of this diagnosis.
            /// </summary>
            [JsonProperty("snomedcode")]
            public string SnomedCode { get; set; }

            /// <summary>
            /// Description of the diagnosis.
            /// </summary>
            [JsonProperty("diagnosisdescription")]
            public string Description { get; set; }

            /// <summary>
            /// An array of order requests for a diagnosis that are a part of this order set.
            /// </summary>
            [JsonProperty("orderrequests")]
            public OrderRequest[] OrderRequests { get; set; }

            /// <summary>
            /// The ICD10 code of this diagnosis.
            /// </summary>
            [JsonProperty("snomedicd10code")]
            public string SnomedIcd10Code { get; set; }

            public class OrderRequest
            {
                /// <summary>
                /// Order type ID of this order request.
                /// </summary>
                [JsonProperty("ordertypeid")]
                public string OrderTypeId { get; set; }

                /// <summary>
                /// ID of the clinical provider.
                /// </summary>
                [JsonProperty("clinicalproviderid")]
                public string ClinicalProviderId { get; set; }

                /// <summary>
                /// Name of this order request.
                /// </summary>
                [JsonProperty("ordername")]
                public string OrderName { get; set; }

                /// <summary>
                /// Name of the clinical provider.
                /// </summary>
                [JsonProperty("clinicalprovidername")]
                public string ClinicalProviderName { get; set; }
            }
        }
    }
}
