using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BfStats.BfH
{
    public class BfHStatsClient : IDisposable
    {
        HttpClient httpclient = new HttpClient();
        const string BaseURL = "http://api.bfhstats.com/api";

        /// <summary>
        /// Returns currently in Battlefield Hardline logged in players.
        /// </summary>
        /// <returns>Currently in Battlefield Hardline logged in players.</returns>
        public async Task<OnlinePlayers> GetOnlinePlayers()
        {
            return await await Task.Factory.StartNew(async () =>
                JsonConvert.DeserializeObject<OnlinePlayers>(
                    await GetStringAsync(Endpoints.OnlinePlayers)));
        }

        /// <summary>
        /// Returns data about a player.
        /// </summary>
        /// <returns>Returns data about a player.</returns>
        public async Task<PlayerInfo> GetPlayerInfo(Platform platform, string name)
        {
            return await await Task.Factory.StartNew(async () =>
                JsonConvert.DeserializeObject<PlayerInfo>(
                    await GetStringAsync(Endpoints.PlayerInfo, 
                        new Dictionary<string, string>()
                        {
                            { "plat", platform.ToString() },
                            { "name", name }
                        }
            )));
        }

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used.
        /// </summary>
        public void Dispose()
        {
            httpclient.Dispose();
        }

        private async Task<string> GetStringAsync(string endpoint, Dictionary<string, string> parameters = null)
        {
            if (parameters == null) { parameters = new Dictionary<string, string>(); }
            parameters.Add("output", "json");

            return await httpclient.GetStringAsync(
                BaseURL + endpoint + "?" + string.Join("&", parameters.Select(x => x.Key + "=" + x.Value)));
        }
    }
}
