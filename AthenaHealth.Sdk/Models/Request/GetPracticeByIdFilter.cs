namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPracticeFilter
    {
        /// <summary>
        /// Number of entries to return (default 1500, max 5000)
        /// </summary>
        public string Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public string Offset { get; set; }
    }
}
