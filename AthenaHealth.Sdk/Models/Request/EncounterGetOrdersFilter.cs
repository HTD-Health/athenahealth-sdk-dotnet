namespace AthenaHealth.Sdk.Models.Request
{
    public class EncounterGetOrdersFilter
    {
        /// <summary>
        /// If set, this will allow getting orders for a discharge encounter type.
        /// </summary>
        public bool AllowDischargeType { get; set; }

        /// <summary>
        /// If set, this will show the information about the provider receiving the order.
        /// </summary>
        public bool ShowClinicalProvider { get; set; }

        /// <summary>
        /// If set, include orders that were declined.
        /// </summary>
        public bool ShowDeclinedOrders { get; set; }

        /// <summary>
        /// If set, translate the order information to relevant external vocabularies, where available.
        /// Examples are medications to RxNorm and NDC, vaccines to CVX and MVX, labs to LOINC, etc. Mappings are not exhaustive.
        /// </summary>
        public bool ShowExternalCodes { get; set; }
    }
}