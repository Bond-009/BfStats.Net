using Newtonsoft.Json;

namespace BfStats.BfH
{
    public class PlayerInfo : BfStats.PlayerInfo<BfStats.Stats<Kits>, Kits>
    {
        public override BfStats.Stats<Kits> Stats { get; set; }

    }
}
