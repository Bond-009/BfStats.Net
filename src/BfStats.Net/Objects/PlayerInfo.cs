using Newtonsoft.Json;

namespace BfStats
{
    public class PlayerInfo
    {
        [JsonProperty("player")]
        public Player Player { get; set; }
        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }
}