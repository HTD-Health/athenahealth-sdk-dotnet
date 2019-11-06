using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AthenaHealth.Sdk.Models.Response
{
    public class UpdateSocialHistoryTemplatesResponse
    {
        /// <summary>
        /// Whether the operation was successfull.
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }

        /// <summary>
        /// On failure, the reason for failure
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Error { get; set; }
    }
}
