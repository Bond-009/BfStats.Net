using Newtonsoft.Json;

namespace BfStats
{
    public abstract class PlayerInfo<T, U>
        where T : Stats<U>
        where U : IKits
    {
        [JsonProperty("player")]
        [JsonRequired]
        public Player Player { get; set; }
        [JsonProperty("stats")]
        [JsonRequired]
        public abstract T Stats { get; set; }
    }
}
