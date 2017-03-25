using Newtonsoft.Json;

namespace BfStats
{
    public class Playercount
    {
        [JsonRequired]
        public string Label { get; set; }
        [JsonRequired]
        public int Count { get; set; }
        [JsonRequired]
        public int Peak24 { get; set; }
    }
}
