using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

// ReSharper disable StringLiteralTypo

// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class MedicationSetting
    {
        /// <summary>
        /// The athenanet department ID.
        /// </summary>
        [Required]
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Set the "None Reported" checkbox indicating that no medications were reported for this patient.
        /// </summary>
        [JsonProperty("nomedicationsreported")]
        public bool NoMedicationReported { get; set; }

        /// <summary>
        /// The section-wide note for medications.
        /// </summary>
        [JsonProperty("sectionnote")]
        public string SectionNote { get; set; }

        public MedicationSetting(int departmentId)
        {
            DepartmentId = departmentId;
        }

        public MedicationSetting(int departmentId, string sectionNote) : this(departmentId)
        {
            SectionNote = sectionNote;
        }

        public MedicationSetting(int departmentId, bool noMedicationReported) : this(departmentId)
        {
            NoMedicationReported = noMedicationReported;
        }

        public MedicationSetting(int departmentId, string sectionNote, bool noMedicationReported) : this(departmentId, sectionNote)
        {
            NoMedicationReported = noMedicationReported;
        }
    }
}
