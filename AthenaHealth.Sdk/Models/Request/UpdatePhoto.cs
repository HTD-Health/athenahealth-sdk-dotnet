using Newtonsoft.Json;
using System.IO;

namespace AthenaHealth.Sdk.Models.Request
{
    public class UpdatePhoto
    {
        /// <summary>
        /// The department ID associated with this upload.
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Base64 encoded image, or, if multipart/form-data, unencoded image. This image may be
        /// scaled down after submission. PUT is not recommended when using multipart/form-data.
        /// Since POST and PUT have identical functionality, POST is recommended.
        /// </summary>
        [JsonProperty("image")]
        public FileInfo Image { get; set; }

        public UpdatePhoto(FileInfo image)
        {
            Image = image;
        }
    }
}
