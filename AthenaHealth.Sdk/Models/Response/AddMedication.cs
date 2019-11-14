using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class AddMedication
    {
        /// <summary>
        /// The athenanet department ID
        /// </summary>
        [Required]
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The athena medication ID
        /// </summary>
        [Required]
        [JsonProperty("medicationid")]
        public int MedicationId { get; set; }

        /// <summary>
        /// Set whether the medication is hidden in the UI.
        /// </summary>
        [JsonProperty("hidden")]
        public bool IsHidden { get; set; }

        /// <summary>
        /// A patient-facing note
        /// </summary>
        [JsonProperty("patientnote")]
        public string PatientNote { get; set; }

        /// <summary>
        /// An internal note
        /// </summary>
        [JsonProperty("providernote")]
        public string ProviderNote { get; set; }

        /// <summary>
        /// Start date for this medication
        /// </summary>
        [JsonProperty("startdate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Stop date for this medication
        /// </summary>
        [JsonProperty("stopdate")]
        public DateTime? StopDate { get; set; }

        /// <summary>
        /// The reason the medication was stopped. If set, it it recommended but not required that a stop date is also set.
        /// </summary>
        [JsonProperty("stopreason")]
        public string StopReason { get; set; }

        /// <summary>
        /// Can only be used to update historical (entered, downloaded, etc) medications. Will override a structured sig if there is one.
        /// </summary>
        [JsonProperty("unstructuredsig")]
        public string UnstructuredSig { get; set; }

        public AddMedication(int departmentId, int medicationId)
        {
            DepartmentId = departmentId;
            MedicationId = medicationId;
        }
    }
}
