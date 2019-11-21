using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AthenaHealth.Sdk.Models.Response
{
    public class CommunicatorBrandResponse : IPagingResponse<CommunicatorBrand>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("communicatorbrands")]
        public CommunicatorBrand[] Items { get; set; }
    }

    public class CommunicatorBrand
    {
        /// <summary>
        /// Brand identifier
        /// </summary>
        [JsonProperty("communicatorbrandid")]
        public int Id { get; set; }

        /// <summary>
        /// The email address that we mask the from email with.
        /// </summary>
        [JsonProperty("fromemail")]
        public string FromEmail { get; set; }

        /// <summary>
        /// Patient facing name for the Communicator Brand
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// If true, the Communicator Brand has a PIC (limited portal)
        /// </summary>
        [JsonProperty("haspatientinfocenter")]
        public bool? HasPatientInfoCenter { get; set; }

        /// <summary>
        /// If true, the Communicator Brand has a web portal.
        /// </summary>
        [JsonProperty("hasportal")]
        public bool? HasPortal { get; set; }
    }
}
