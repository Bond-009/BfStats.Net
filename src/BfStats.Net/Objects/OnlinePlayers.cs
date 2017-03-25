using Newtonsoft.Json;

namespace BfStats
{
    public class OnlinePlayers
    {
        [JsonProperty("pc")]
        public Playercount PC { get; set; }
        [JsonProperty("ps3")]
        public Playercount PS3 { get; set; }
        [JsonProperty("xbox")]
        public Playercount XBox { get; set; }
        [JsonProperty("xone")]
        public Playercount XOne { get; set; }
        [JsonProperty("ps4")]
        public Playercount PS4 { get; set; }
    }
}
