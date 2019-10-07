using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class Balance
    {
        [JsonProperty(PropertyName = "balance")]
        public int Value { get; set; }

        [JsonProperty(PropertyName = "departmentlist")]
        public string DepartmentList { get; set; }
        
        [JsonProperty(PropertyName = "providergroupid")]
        public int ProviderGroupId { get; set; }

        [JsonProperty(PropertyName = "cleanbalance")]
        public bool CleanBalance { get; set; }
    }
}
