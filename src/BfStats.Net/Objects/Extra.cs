using Newtonsoft.Json;

namespace BfStats
{
    public class Extra
    {
        /// <summary>
        /// Kill/Death ratio
        /// </summary>
        [JsonProperty("kdr")]
        [JsonRequired]
        public double KDR { get; set; }
        /// <summary>
        /// Win/loss ratio
        /// </summary>
        [JsonProperty("wlr")]
        [JsonRequired]
        public double WLR { get; set; }
        /// <summary>
        /// Score/Min
        /// </summary>
        [JsonProperty("spm")]
        [JsonRequired]
        public string ScorePerMinute { get; set; }
        /// <summary>
        /// General Score/Min
        /// </summary>
        [JsonProperty("gspm")]
        [JsonRequired]
        public string GeneralScorePerMinute { get; set; }
        [JsonProperty("kpm")]
        [JsonRequired]
        public string KillsPerMinute { get; set; }
        // TODO: Add more info
    }
}
