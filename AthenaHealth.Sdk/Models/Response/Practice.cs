using System;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class PracticeResponse
    {
        [JsonProperty("totalcount")]
        public int Total { get; set; }

        [JsonProperty("practiceinfo")]
        public Practice[] Practices { get; set; }
    }

    public class Practice
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("golivedate")]
        public DateTime GoLiveDate { get; set; }

        [JsonProperty("experiencemode")]
        public string ExperienceMode { get; set; }

        [JsonProperty("practiceid")]
        public string PracticeId { get; set; }

        [JsonProperty("iscoordinatorsender")]
        public bool IsCoordinatorSender { get; set; }

        [JsonProperty("hasclinicals")]
        public bool HasClinicals { get; set; }

        [JsonProperty("hascommunicator")]
        public bool HasCommunicator { get; set; }

        [JsonProperty("iscoordinatorreceiver")]
        public bool IsCoordinatorReceiver { get; set; }

        [JsonProperty("hascollector")]
        public bool HasCollector { get; set; }
    }
}
