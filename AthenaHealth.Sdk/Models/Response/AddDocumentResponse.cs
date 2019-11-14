using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class AddDocumentResponse
    {
        [JsonProperty("documentid")]
        public int? DocumentId { get; set; }
    }
}
