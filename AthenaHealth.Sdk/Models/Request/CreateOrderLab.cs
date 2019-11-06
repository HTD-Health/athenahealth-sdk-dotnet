using System;
using System.ComponentModel.DataAnnotations;
using AthenaHealth.Sdk.Clients.Interfaces;
using Newtonsoft.Json;

// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class CreateOrderLab
    {
        public CreateOrderLab(int orderTypeId, string diagnosisSnomedCode)
        {
            OrderTypeId = orderTypeId;
            DiagnosisSnomedCode = diagnosisSnomedCode;
        }

        public CreateOrderLab(string loinc, string diagnosisSnomedCode)
        {
            Loinc = loinc;
            DiagnosisSnomedCode = diagnosisSnomedCode;
        }

        /// <summary>
        /// The SNOMED code for diagnosis this order is for.
        /// </summary>
        [JsonProperty("diagnosissnomedcode")]
        [Required]
        public string DiagnosisSnomedCode { get; set; }

        /// <summary>
        /// The LOINC of the lab you wish to order.
        /// Either this or <see cref="OrderTypeId"/> can be used, but not both.
        /// </summary>
        [JsonProperty("loinc")]
        public string Loinc { get; set; }

        /// <summary>
        /// The athena ID of the lab to order. Get the IDs using <see cref="IDictionaryClient.SearchOrderTypesByName"/>
        /// Either this or <see cref="Loinc"/> can be used, but not both.
        /// </summary>
        [JsonProperty("ordertypeid")]
        public int? OrderTypeId { get; set; }

        /// <summary>
        /// The athena ID of the lab you want to send the order to. Get a localized list using /chart/configuration/facilities.
        /// </summary>
        [JsonProperty("facilityid")]
        public int? FacilityId { get; set; }

        /// <summary>
        /// A note to send to the lab.
        /// </summary>
        [JsonProperty("facilitynote")]
        public string FacilityNote { get; set; }

        /// <summary>
        /// The date the order should be sent. Defaults to today.
        /// </summary>
        [JsonProperty("futuresubmitdate")]
        public DateTime? FutureSubmitDate { get; set; }

        /// <summary>
        /// If true, then the order should be sent STAT.
        /// </summary>
        [JsonProperty("highpriority")]
        public bool HighPriority { get; set; }

        /// <summary>
        /// An internal note for the provider or staff.
        /// </summary>
        [JsonProperty("providernote")]
        public string ProviderNote { get; set; }
    }
}