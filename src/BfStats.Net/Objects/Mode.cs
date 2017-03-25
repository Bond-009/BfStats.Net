using Newtonsoft.Json;

namespace BfStats
{
    public class Mode
    {
        [JsonRequired]
        public string ID { get; set; }
        [JsonRequired]
        public int Score { get; set; }
        [JsonRequired]
        public string Name { get; set; }
    }
}
