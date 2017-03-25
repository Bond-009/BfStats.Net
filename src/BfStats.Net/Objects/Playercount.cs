using Newtonsoft.Json;

namespace BfStats
{
    public class Playercount
    {
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("peak24")]
        public int Peak24 { get; set; }
    }
}
