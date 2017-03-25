using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace BfStats
{
    public class Stats
    {
        [JsonProperty("skill")]
        [JsonRequired]
        public int Skill { get; set; }
        [JsonProperty("elo")]
        [JsonRequired]
        public int Elo { get; set; }
        [JsonProperty("rank")]
        [JsonRequired]
        public int Rank { get; set; }
        /*[JsonProperty("timePlayed")]
        [JsonRequired]
        public DateTime Timeplayed { get; set; }*/
        [JsonProperty("kills")]
        [JsonRequired]
        public int Kills { get; set; }
        [JsonProperty("deaths")]
        [JsonRequired]
        public int Deaths { get; set; }
        [JsonProperty("headshots")]
        [JsonRequired]
        public int Headshots { get; set; }
        [JsonProperty("shotsFired")]
        [JsonRequired]
        public int ShotsFired { get; set; }
        [JsonProperty("shotsHit")]
        [JsonRequired]
        public int ShotsHit { get; set; }
        [JsonProperty("suppressionAssists")]
        [JsonRequired]
        public int SuppressionAssists { get; set; }
        [JsonProperty("avengerKills")]
        [JsonRequired]
        public int AvengerKills { get; set; }
        [JsonProperty("saviorKills")]
        [JsonRequired]
        public int SaviorKills { get; set; }
        [JsonProperty("nemesisKills")]
        [JsonRequired]
        public int NemesisKills { get; set; }
        [JsonProperty("numRounds")]
        [JsonRequired]
        public int Rounds { get; set; }
        [JsonProperty("numLosses")]
        [JsonRequired]
        public int Losses { get; set; }
        [JsonProperty("numWins")]
        [JsonRequired]
        public int Wins { get; set; }
        [JsonProperty("killStreakBonus")]
        [JsonRequired]
        public int KillStreakBonus { get; set; }
        [JsonProperty("nemesisStreak")]
        [JsonRequired]
        public int NemesisStreak { get; set; }
        [JsonProperty("mcomDefendKills")]
        [JsonRequired]
        public int McomDefendKills { get; set; }
        [JsonProperty("resupplies")]
        [JsonRequired]
        public int Resupplies { get; set; }
        [JsonProperty("repairs")]
        [JsonRequired]
        public int Repairs { get; set; }
        [JsonProperty("heals")]
        [JsonRequired]
        public int Heals { get; set; }
        [JsonProperty("revives")]
        [JsonRequired]
        public int Revives { get; set; }
        [JsonProperty("longestHeadShot")]
        [JsonRequired]
        public double LongestHeadShot { get; set; }
        [JsonProperty("longestWinStreak")]
        [JsonRequired]
        public int LongestWinStreak { get; set; }
        [JsonProperty("flagDefend")]
        [JsonRequired]
        public int FlagDefend { get; set; }
        [JsonProperty("flagCaptures")]
        [JsonRequired]
        public int FlagCaptures { get; set; }
        [JsonProperty("killAssists")]
        [JsonRequired]
        public int KillAssists { get; set; }
        [JsonProperty("vehiclesDestroyed")]
        [JsonRequired]
        public int VehiclesDestroyed { get; set; }
        [JsonProperty("vehicleDamage")]
        [JsonRequired]
        public int VehicleDamage { get; set; }
        [JsonProperty("dogtagsTaken")]
        [JsonRequired]
        public int DogtagsTaken { get; set; }
        [JsonProperty("streak")]
        [JsonRequired]
        public int Streak { get; set; }
        [JsonProperty("bestStreak")]
        [JsonRequired]
        public int BestStreak { get; set; }
        // TODO: Add more info
    }
}
