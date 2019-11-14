using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class OrderLab
    {
        /// <summary>
        /// The ID of the document created.
        /// </summary>
        [JsonProperty("documentid")]
        [Required]
        public int DocumentId { get; set; }

        [OnError]
        internal void OnError(StreamingContext context, ErrorContext errorContext)
        {
            if (errorContext.Member is string property)
            {
                if (property == "success" || property == "errormessage") // Not needed.
                    errorContext.Handled = true;
            }
        }
    }
}
