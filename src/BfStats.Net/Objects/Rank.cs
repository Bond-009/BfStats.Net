using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace BfStats
{
    public class Rank
    {
        [JsonProperty("nr")]
        [JsonRequired]
        public int Number { get; set; }
        [JsonProperty("imgLarge")]
        [JsonRequiredAttribute()]
        public string ImageLarge { get; set; }
        [JsonProperty("img")]
        [JsonRequired]
        public string Image { get; set; }
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }
        [JsonProperty("needed")]
        [JsonRequired]
        public int Needed { get; set; }
        [JsonProperty("next")]
        public Rank Next { get; set; }
        // TODO: Add more info
    }
}