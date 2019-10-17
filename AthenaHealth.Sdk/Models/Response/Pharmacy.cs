using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class PharmacyResponse
    {
        [JsonProperty("totalcount")]
        public int Total { get; set; }

        [JsonProperty("pharmacies")]
        public Pharmacy[] Items { get; set; }
    }

    public class Pharmacy
    {
        /// <summary>
        /// The athenaNet clinical provider ID.
        /// </summary>
        [JsonProperty(PropertyName = "clinicalproviderid")]
        public int ClinicalProviderId { get; set; }

        /// <summary>
        /// The pharmacy name
        /// </summary>
        [JsonProperty(PropertyName = "clinicalprovidername")]
        public string ClinicalProviderName { get; set; }

        /// <summary>
        /// Address line 1 of the pharmacy
        /// </summary>
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2 of the pharmacy
        /// </summary>
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City of the pharmacy
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// State of the pharmacy
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Zip code of the pharmacy
        /// </summary>
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Phone number of the pharmacy
        /// </summary>
        [JsonProperty(PropertyName = "phonenumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Fax number of the pharmacy
        /// </summary>
        [JsonProperty(PropertyName = "faxnumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Flag representing if the pharmacy accepts fax
        /// </summary>
        [JsonProperty(PropertyName = "acceptfax")]
        public bool AcceptFax { get; set; }

        /// <summary>
        /// Type of pharmacy (retail, mailorder)
        /// </summary>
        [JsonProperty(PropertyName = "pharmacytype")]
        public string PharmacyType { get; set; }

        /// <summary>
        /// Receiver type
        /// </summary>
        [JsonProperty(PropertyName = "receivertype")]
        public string ReceiverType { get; set; }

        /// <summary>
        /// If flagged true, this is the default pharmacy for the patient
        /// </summary>
        [JsonProperty(PropertyName = "defaultpharmacy")]
        public bool DefaultPharmacy { get; set; }



    }
}