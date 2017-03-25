using Newtonsoft.Json;

namespace BfStats
{
    public class OnlinePlayers
    {
        [JsonRequired]
        public Playercount PC { get; set; }
        [JsonRequired]
        public Playercount PS3 { get; set; }
        [JsonRequired]
        public Playercount Xbox { get; set; }
        [JsonRequired]
        public Playercount XOne { get; set; }
        [JsonRequired]
        public Playercount PS4 { get; set; }
    }
}
