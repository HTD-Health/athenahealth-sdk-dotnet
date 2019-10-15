namespace AthenaHealth.Sdk.Models.Request
{
    public class BaseLimitFilter
    {
        /// <summary>
        /// Number of entries to return (default 1500, max 5000)
        /// </summary>
        public int Limit { get; set; } = 1500;

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int Offset { get; set; } = 0;
    }
}
