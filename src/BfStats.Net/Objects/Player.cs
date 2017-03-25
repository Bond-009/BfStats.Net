using Newtonsoft.Json;
using System;

namespace BfStats
{
    public class Player
    {
        [JsonRequired]
        public uint ID { get; set; }
        [JsonRequired]
        public string Game { get; set; }
        [JsonProperty("plat")]
        [JsonRequired]
        public Platform Platform { get; set; }
        [JsonRequired]
        public string Name { get; set; }
        [JsonRequired]
        public string Tag { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonRequired]
        public DateTime DateCheck { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonRequired]
        public DateTime DateUpdate { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonRequired]
        public DateTime DateCreate { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonRequired]
        public DateTime DateStreak { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonRequired]
        public DateTime LastDay { get; set; }
        /// <summary>
        /// Country. null if not set
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Country name. null if not set
        /// </summary>
        public string CountryName { get; set; }
        [JsonProperty("score")]
        [JsonRequired]
        public int Score { get; set; }
        
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan TimePlayed { get; set; }
        [JsonProperty("uId")]
        [JsonRequired]
        public ulong UserID { get; set; }
        [JsonProperty("uName")]
        [JsonRequired]
        public string UserName { get; set; }
        /// <summary>
        /// null if not set
        /// </summary>
        [JsonProperty("uGava")]
        public string UserGava { get; set; }
        [JsonProperty("udCreate")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonRequired]
        public DateTime UserCreationDate { get; set; }
        [JsonRequired]
        public string Privacy { get; set; }
        [JsonProperty("blPlayer")]
        [JsonRequired]
        public string BattlelogPlayer { get; set; }
        [JsonProperty("blUser")]
        [JsonRequired]
        public string BattlelogUser { get; set; }
        [JsonRequired]
        public bool Editable { get; set; }
        [JsonRequired]
        public bool Viewable { get; set; }
        [JsonRequired]
        public bool Adminable { get; set; }
        [JsonRequired]
        public bool Linked { get; set; }
    }
}
