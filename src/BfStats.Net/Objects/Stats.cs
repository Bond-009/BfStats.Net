using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BfStats
{
    public class Stats<T> where T : IKits
    {
        [JsonRequired]
        public int Skill { get; set; }
        [JsonRequired]
        public int Elo { get; set; }
        [JsonRequired]
        public int Rank { get; set; }
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan Timeplayed { get; set; }
        [JsonRequired]
        public int Kills { get; set; }
        [JsonRequired]
        public int Deaths { get; set; }
        [JsonRequired]
        public int Headshots { get; set; }
        [JsonRequired]
        public int ShotsFired { get; set; }
        [JsonRequired]
        public int ShotsHit { get; set; }
        [JsonRequired]
        public int SuppressionAssists { get; set; }
        [JsonRequired]
        public int AvengerKills { get; set; }
        [JsonRequired]
        public int SaviorKills { get; set; }
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
        [JsonRequired]
        public int KillStreakBonus { get; set; }
        [JsonRequired]
        public int NemesisStreak { get; set; }
        [JsonRequired]
        public int McomDefendKills { get; set; }
        [JsonRequired]
        public int Resupplies { get; set; }
        [JsonRequired]
        public int Repairs { get; set; }
        [JsonRequired]
        public int Heals { get; set; }
        [JsonRequired]
        public int Revives { get; set; }
        [JsonRequired]
        public double LongestHeadShot { get; set; }
        [JsonRequired]
        public int LongestWinStreak { get; set; }
        [JsonProperty("flagDefend")]
        [JsonRequired]
        public int FlagDefends { get; set; }
        [JsonRequired]
        public int FlagCaptures { get; set; }
        [JsonRequired]
        public int KillAssists { get; set; }
        [JsonRequired]
        public int VehiclesDestroyed { get; set; }
        [JsonRequired]
        public int VehicleDamage { get; set; }
        [JsonRequired]
        public int DogtagsTaken { get; set; }
        [JsonRequired]
        public int Streak { get; set; }
        [JsonRequired]
        public int BestStreak { get; set; }
        [JsonRequired]
        public List<Mode> Modes { get; set; }
        // TODO: Add more info
        [JsonRequired]
        public T Kits { get; set; }
        Extra Extra { get; set; }
    }
}
