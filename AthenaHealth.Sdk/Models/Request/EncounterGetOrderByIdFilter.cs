namespace AthenaHealth.Sdk.Models.Request
{
    public class EncounterGetOrderByIdFilter
    {
        /// <summary>
        /// BETA FIELD: Some order types like labs and imaging orders have additional pertinant information in a question/answer format.
        /// Setting this will return that data.
        /// </summary>
        public bool ShowQuestions { get; set; }

        /// <summary>
        /// If set, translate the order information to relevant external vocabularies, where available.
        /// Examples are medications to RxNorm and NDC, vaccines to CVX and MVX, labs to LOINC, etc. Mappings are not exhaustive.
        /// </summary>
        public bool ShowExternalCodes { get; set; }
    }
}
