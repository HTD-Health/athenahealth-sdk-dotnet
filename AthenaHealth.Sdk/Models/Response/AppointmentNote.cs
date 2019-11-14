using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class AppointmentNotesResponse : IPagingResponse<AppointmentNote>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("notes")]
        public AppointmentNote[] Items { get; set; }
    }

    public class AppointmentNote
    {
        /// <summary>
        /// The ID for this note, for use with DELETE and PUT calls.
        /// </summary>
        [JsonProperty("noteid")]
        public string Id { get; set; }

        /// <summary>
        /// The text of the note itself.
        /// </summary>
        [JsonProperty("notetext")]
        public string Text { get; set; }

        /// <summary>
        /// Determines if an appointment note displays on the homepage schedule view.
        /// </summary>
        [JsonProperty("displayonschedule")]
        public bool DisplayOnSchedule { get; set; }

        /// <summary>
        /// The time this note was created (mm/dd/yyyy hh24:mi:ss).
        /// </summary>
        [JsonProperty("created")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The time this note was updated (mm/dd/yyyy hh24:mi:ss), if the note has been updated.
        /// </summary>
        [JsonProperty("lastmodified")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// The time this note was deleted (mm/dd/yyyy hh24:mi:ss). Not present if not deleted.
        /// </summary>
        [JsonProperty("deleted")]
        public string DeletedAt { get; set; }

        /// <summary>
        /// The user that created this note.
        /// </summary>
        [JsonProperty("createdby")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// If the note has been modified, the username who last modified this note.
        /// </summary>
        [JsonProperty("lastmodifiedby")]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// If deleted, the username who deleted this note.
        /// </summary>
        [JsonProperty("deletedby")]
        public string DeletedBy { get; set; }
    }
}
