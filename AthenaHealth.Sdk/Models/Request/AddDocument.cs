using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System.IO;

namespace AthenaHealth.Sdk.Models.Request
{
    public class AddDocument
    {
        /// <summary>
        /// Any note to accompany the creation of this document.
        /// </summary>
        [JsonProperty(PropertyName = "actionnote")]
        public string ActionNote { get; set; }

        /// <summary>
        /// The appointment ID associated with this document, for certain document classes. These can
        /// only be uploaded AFTER check-in. The department ID is looked up from the appointment.
        /// (Department ID takes precedence if both are supplied.)
        /// </summary>
        [JsonProperty(PropertyName = "appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// The file that will become the document. PDFs are recommended. Generally, this implies
        /// that this is a multipart/form-data content-type submission. This does NOT work correctly
        /// in I/O Docs. The filename itself is not used by athenaNet, but it is required to be sent.
        /// </summary>
        [JsonProperty(PropertyName = "attachmentcontents")]
        public FileInfo Attachment { get; set; }

        /// <summary>
        /// Documents will, normally, automatically appear in the clinical inbox for providers to
        /// review. In some cases, you might want to force the document to skip the clinical inbox,
        /// and go directly to the patient chart with a "closed" status. For that case, set this to true.
        /// </summary>
        [JsonProperty(PropertyName = "autoclose")]
        public bool? AutoClose { get; set; }

        /// <summary>
        /// The department ID associated with the uploaded document. Except when appointmentid is
        /// supplied, this is required.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The document subclass.
        /// </summary>
        [JsonProperty(PropertyName = "documentsubclass")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public DocumentSubclassEnum DocumentSubclass { get; set; }

        /// <summary>
        /// The 'Internal Note' attached to this document
        /// </summary>
        [JsonProperty(PropertyName = "internalnote")]
        public string InternalNote { get; set; }

        /// <summary>
        /// The provider ID attached to this document. This populates the provider name field.
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        public int? ProviderId { get; set; }

        public AddDocument(int departmentId, FileInfo attachment, DocumentSubclassEnum documentSubclass)
        {
            DepartmentId = departmentId;
            Attachment = attachment;
            DocumentSubclass = documentSubclass;
        }
    }
}
