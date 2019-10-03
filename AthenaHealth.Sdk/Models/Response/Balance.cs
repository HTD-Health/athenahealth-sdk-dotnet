using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class Balance
    {
        [JsonProperty(PropertyName = "balance")]
        public int Value { get; set; }
        public string DepartmentList { get; set; }
        public int ProviderGroupId { get; set; }
        public bool CleanBalance { get; set; }
    }
}
