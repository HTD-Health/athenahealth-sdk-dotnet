namespace AthenaHealth.Sdk.Models.Request
{
    public class GetEncounterSummaryFilter
    {
        /// <summary>
        /// Flag to skip many details to make the html smaller.
        /// </summary>
        public bool Mobile { get; set; } = false;

        /// <summary>
        /// Flag to skip encounter amendments.
        /// </summary>
        public bool SkipAmendments { get; set; } = false;
    }
}
