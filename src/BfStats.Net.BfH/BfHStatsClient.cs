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
        bool UseHttpPost;

        public BfHStatsClient(bool useHttpPost = true)
        {
            this.UseHttpPost = useHttpPost;
            httpclient.BaseAddress = new Uri("http://api.bfhstats.com");
        }

        /// <summary>
        /// Returns currently in Battlefield Hardline logged in players.
        /// </summary>
        /// <returns>Currently in Battlefield Hardline logged in players.</returns>
        public async Task<OnlinePlayers> GetOnlinePlayersAsync()
        {
            return await await Task.Factory.StartNew(async () =>
                JsonConvert.DeserializeObject<OnlinePlayers>(
                    await GetStringAsync(Endpoints.OnlinePlayers)));
        }

        /// <summary>
        /// Returns data about a player.
        /// </summary>
        /// <returns>Returns data about a player.</returns>
        public async Task<PlayerInfo> GetPlayerInfoAsync(Platform platform, string name)
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

            if (UseHttpPost)
            {
                return await (await httpclient.PostAsync(endpoint,
                    new FormUrlEncodedContent(parameters.ToList())))
                        .EnsureSuccessStatusCode()
                        .Content.ReadAsStringAsync();
            }
            else
            {
                return await httpclient.GetStringAsync(
                    endpoint + "?" + string.Join("&", parameters.Select(x => x.Key + "=" + x.Value)));
            }
        }
    }
}
