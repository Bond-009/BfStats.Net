using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace BfStats
{
    public class Player
    {
        [JsonProperty("id")]
        [JsonRequired]
        public uint ID { get; set; }
        [JsonProperty("game")]
        [JsonRequired]
        public string Game { get; set; }
        [JsonProperty("plat")]
        [JsonRequired]
        public string Platform { get; set; }
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }
        [JsonProperty("tag")]
        [JsonRequired]
        public string Tag { get; set; }
        /*[JsonProperty("dateCheck")]
        [JsonRequired]
        public DateTime DateCheck { get; set; }
        [JsonProperty("dateUpdate")]
        [JsonRequired]
        public DateTime DateUpdate { get; set; }
        [JsonProperty("dateCreate")]
        [JsonRequired]
        public DateTime DateCreate { get; set; }
        [JsonProperty("dateStreak")]
        [JsonRequired]
        public DateTime DateStreak { get; set; }
        [JsonProperty("lastDay")]
        [JsonRequired]
        public DateTime LastDay { get; set; }*/
        [JsonProperty("country")]
        [JsonRequired]
        public string Country { get; set; }
        [JsonProperty("countryName")]
        [JsonRequired]
        public string CountryName { get; set; }
        [JsonProperty("score")]
        [JsonRequired]
        public int Score { get; set; }
        /*
        [JsonProperty("timePlayed")]
        [JsonRequired]
        public DateTime TimePlayed { get; set; }*/
        [JsonProperty("uId")]
        [JsonRequired]
        public ulong UserID { get; set; }
        [JsonProperty("uName")]
        [JsonRequired]
        public string UserName { get; set; }
        // TODO: Add more info
    }
}
