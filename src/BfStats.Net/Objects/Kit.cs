using Newtonsoft.Json;
using System;

namespace BfStats
{
    public class Kit
    {
        [JsonRequired]
        public string ID { get; set; }
        [JsonRequired]
        public int Score { get; set; }
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Time { get; set; }
        [JsonRequired]
        public int Stars { get; set; }
        [JsonProperty("spm")]
        [JsonRequired]
        public double ScorePerMinute { get; set; }
        [JsonRequired]
        public string Name { get; set; }
    }
}
