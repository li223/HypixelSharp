using HypixelSharp.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HypixelSharp
{
    public class HypixelSharpClient
    {
        private HttpClient _http = new HttpClient();
        private string _baserequest = "https://api.hypixel.net";
        private string _apikey { get; set; }
        public HypixelSharpClient(string apikey) => this._apikey = apikey;
        /// <summary>
        /// Get a guild's info
        /// </summary>
        /// <param name="guildname"></param>
        /// <returns></returns>
        public async Task<HypixelGuild> GetGuildAsync(string guildname)
        {
            var GuildIDRequest = new HttpRequestMessage(HttpMethod.Get, new Uri($@"{_baserequest}/findGuild?key={_apikey}&byName={guildname}"));
            var GuildIDResponse = await _http.SendAsync(GuildIDRequest);
            if (GuildIDResponse.IsSuccessStatusCode)
            {
                var GuildIDData = await GuildIDResponse.Content.ReadAsStringAsync();
                var GuildID = JObject.Parse(GuildIDData).SelectToken("guild").ToString();
                var GuildRequest = new HttpRequestMessage(HttpMethod.Get, new Uri($@"{_baserequest}/guild?key={_apikey}&id={GuildID}"));
                var GuildResponse = await _http.SendAsync(GuildRequest);
                var GuildData = JObject.Parse(await GuildResponse.Content.ReadAsStringAsync()).SelectToken("guild").ToString();
                var Guild = JsonConvert.DeserializeObject<HypixelGuild>(GuildData);
                return Guild;
            }
            else return null;
        }
        /// <summary>
        /// Get ban stats from Watchdog
        /// </summary>
        /// <returns></returns>
        public async Task<WatchdogStats> GetWatchdogStatsAsync()
        {
            var Jdata = await _http.GetStringAsync(new Uri($@"{ _baserequest }/watchdogstats?key={ _apikey}"));
            var stats = JsonConvert.DeserializeObject<WatchdogStats>(Jdata);
            return stats;
        }
        /// <summary>
        /// Get a player's info
        /// </summary>
        /// <param name="uuid"></param>
        /// <returns></returns>
        public async Task<HypixelPlayer> GetPlayerAsync(string uuid)
        {
            var playerdata = await _http.GetStringAsync(new Uri($"{_baserequest}/player?key={_apikey}&uuid={uuid}"));
            var playerjdata = JObject.Parse(playerdata).SelectToken("player").ToString();
            var playerobj = JsonConvert.DeserializeObject<HypixelPlayer>(playerjdata);
            var sessiondata = await _http.GetStringAsync(new Uri($"{_baserequest}/session?key={_apikey}&uuid={uuid}"));
            var sessionjdata = JObject.Parse(sessiondata).SelectToken("session").ToString();
            var session = JsonConvert.DeserializeObject<Session>(sessionjdata);
            playerobj.Session = session;
            return playerobj;
        }
        /// <summary>
        /// Get basic info about the current api key
        /// </summary>
        /// <returns></returns>
        public async Task<APIKey> GetKeyInfoAsync()
        {
            var jdata = await _http.GetStringAsync(new Uri($"{_baserequest}/key?key={_apikey}"));
            var keyinfo = JsonConvert.DeserializeObject<APIKey>(JObject.Parse(jdata).SelectToken("record").ToString());
            return keyinfo;
        }
    }
}
