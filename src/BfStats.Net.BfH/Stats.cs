using Newtonsoft.Json;

namespace BfStats.BfH
{
    public class Stats : Stats<Kits>
    {
        [JsonRequired]
        public double KDRatio { get; set; }
        [JsonRequired]
        public double Accuracy { get; set; }
    }
}
