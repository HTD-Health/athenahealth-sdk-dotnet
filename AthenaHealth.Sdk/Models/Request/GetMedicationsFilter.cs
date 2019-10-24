// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetMedicationsFilter
    {
        /// <summary>
        /// The athenanet department ID
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Historical or Active or Denied. Will return a list of a patient's active or historical or
        /// denied medications.
        /// </summary>
        [JsonProperty(PropertyName = "medicationtype")]
        public string MedicationType { get; set; }

        /// <summary>
        /// Shows the list of NDC numbers related to the medication.
        /// </summary>
        [JsonProperty(PropertyName = "showndc")]
        public bool? ShowNDC { get; set; }

        /// <summary>
        /// Include pending medications associated with approved future orders. These medications
        /// have not yet been submitted.
        /// </summary>
        [JsonProperty(PropertyName = "showpend")]
        public bool? ShowPending { get; set; }

        /// <summary>
        /// Shows the list of RxNorm Identifiers related to the medication. The list may contain both
        /// branded and generic identifiers.
        /// </summary>
        [JsonProperty(PropertyName = "showrxnorm")]
        public bool? ShowRxNorm { get; set; }


    }
}
