using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class SetPrivacyInformationResponse : StatusResponse
    {
        [JsonProperty("patientid")]
        public int PatientId { get; set; }
    }
}
