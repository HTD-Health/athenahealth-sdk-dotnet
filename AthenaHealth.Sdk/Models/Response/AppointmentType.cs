using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class AppointmentTypeResponse : IPagingResponse<AppointmentType>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("appointmenttypes")]
        public AppointmentType[] Items { get; set; }
    }

    public class AppointmentType
    {
        /// <summary>
        /// The appointment type ID.
        /// </summary>
        [JsonProperty("appointmenttypeid")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the appointment type.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// ID of the provider.
        /// </summary>
        [JsonProperty("providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// Expected duration of the appointment in minutes.
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// If true, this type is a "generic" type able to be filled with other types of appointments.
        /// </summary>
        [JsonProperty("generic")]
        public bool Generic { get; set; }

        /// <summary>
        /// The short name code of the appointment type.
        /// </summary>
        [JsonProperty("shortname")]
        public string ShortName { get; set; }

        /// <summary>
        /// If true, this type is a patient-facing type.
        /// </summary>
        [JsonProperty("patient")]
        public bool Patient { get; set; }

        /// <summary>
        /// Patient friendly appointment type name. Defaults to regular name.
        /// </summary>
        [JsonProperty("patientdisplayname")]
        public string PatientDisplayName { get; set; }

        /// <summary>
        /// If true, this type is a "template-only" type, and must be filled with a different appointment type upon booking.
        /// </summary>
        [JsonProperty("templatetypeonly")]
        public bool TemplateTypeOnly { get; set; }

        /// <summary>
        /// ID of the department.
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// The minimum number of hours before an appointment that a patient can schedule or cancel for a specific practice. Note that this data is valued in hours.
        /// </summary>
        [JsonProperty("block schedule")]
        public int? BlockSchedule { get; set; }

        /// <summary>
        /// If true, then this appointments of this type will generated an encounter when checked in, with certain conditions. It's rather complex, but the rendering provider on the appointment must also have the create encounter feature set, the department must have athena Clinicals enabled, and other rarer and less visible settings.
        /// </summary>
        [JsonProperty("createencounteroncheckin")]
        public bool CreateEncounterOnCheckIn { get; set; }
    }
}
