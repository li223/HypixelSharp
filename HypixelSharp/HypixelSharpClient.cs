using HypixelSharp.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace HypixelSharp
{
    /// <summary>
    /// Main Clinet
    /// </summary>
    public class HypixelSharpClient
    {
        //Remaining, Reset
        private KeyValuePair<int, int> _limits = new KeyValuePair<int, int>();
        private SemaphoreSlim _semaphore = new SemaphoreSlim(2, 2);
        private HttpClient _http = new HttpClient();
        private readonly string _baserequest = "https://api.hypixel.net";
        private string _apikey { get; set; }

        /// <summary>
        /// Client Ctor
        /// </summary>
        /// <param name="apikey">Your apikey, use /api command while in-game to get your key</param>
        public HypixelSharpClient(string apikey) => this._apikey = apikey;

        /// <summary>
        /// Get a guild's info
        /// </summary>
        /// <param name="guildname"></param>
        /// <returns></returns>
        public async Task<HypixelGuild?> GetGuildAsync(string guildname)
        {
            try
            {
                await _semaphore.WaitAsync();
                if (_limits.Key <= 0) await Task.Delay(_limits.Value);
                var response = await _http.GetAsync(new Uri($"{_baserequest}/findGuild?key={_apikey}&byName={guildname}"));
                _limits = new KeyValuePair<int, int>(int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").First()), int.Parse(response.Headers.GetValues("X-RateLimit-Reset").First()));
                var GuildID = JObject.Parse(await response.Content.ReadAsStringAsync()).SelectToken("guild").ToString();
                if (GuildID != null)
                {
                    if (_limits.Key <= 0) await Task.Delay(_limits.Value);
                    response = await _http.GetAsync(new Uri($"{_baserequest}/guild?key={_apikey}&id={GuildID}"));
                    _limits = new KeyValuePair<int, int>(int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").First()), int.Parse(response.Headers.GetValues("X-RateLimit-Reset").First()));
                    var GuildData = JObject.Parse(await response.Content.ReadAsStringAsync()).SelectToken("guild").ToString();
                    var Guild = JsonConvert.DeserializeObject<HypixelGuild>(GuildData);
                    return Guild;
                }
                else return null;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <summary>
        /// Get ban stats from Watchdog
        /// </summary>
        /// <returns>WatchdogStats Object</returns>
        public async Task<WatchdogStats> GetWatchdogStatsAsync()
        {
            try
            {
                await _semaphore.WaitAsync();
                if (_limits.Key <= 0) await Task.Delay(_limits.Value);
                var response = await _http.GetAsync(new Uri($"{ _baserequest }/watchdogstats?key={ _apikey}"));
                _limits = new KeyValuePair<int, int>(int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").First()), int.Parse(response.Headers.GetValues("X-RateLimit-Reset").First()));
                var stats = JsonConvert.DeserializeObject<WatchdogStats>(await response.Content.ReadAsStringAsync());
                return stats;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <summary>
        /// Get a player's info
        /// </summary>
        /// <param name="uuid">Their UUID</param>
        /// <returns>HypixelPlayer Object</returns>
        public async Task<HypixelPlayer> GetPlayerAsync(string uuid)
        {
            try
            {
                await _semaphore.WaitAsync();
                if (_limits.Key <= 0) await Task.Delay(_limits.Value);
                var response = await _http.GetAsync(new Uri($"{_baserequest}/player?key={_apikey}&uuid={uuid}"));
                _limits = new KeyValuePair<int, int>(int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").First()), int.Parse(response.Headers.GetValues("X-RateLimit-Reset").First()));
                var playerjdata = JObject.Parse(await response.Content.ReadAsStringAsync()).SelectToken("player").ToString();
                var playerobj = JsonConvert.DeserializeObject<HypixelPlayer>(playerjdata);
                if (playerobj != null)
                {
                    if (_limits.Key <= 0) await Task.Delay(_limits.Value);
                    response = await _http.GetAsync(new Uri($"{_baserequest}/session?key={_apikey}&uuid={uuid}"));
                    _limits = new KeyValuePair<int, int>(int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").First()), int.Parse(response.Headers.GetValues("X-RateLimit-Reset").First()));
                    var sessionjdata = JObject.Parse(await response.Content.ReadAsStringAsync()).SelectToken("session").ToString();
                    var session = JsonConvert.DeserializeObject<Session>(sessionjdata);
                    playerobj.Session = session;
                    return playerobj;
                }
                else return null;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <summary>
        /// Get a player's info
        /// </summary>
        /// <param name="name">Their username</param>
        /// <returns>HypixelPlayer Object</returns>
        public async Task<HypixelPlayer> GetPlayerbyNameAsync(string name)
        {
            try
            {
                await _semaphore.WaitAsync();
                if (_limits.Key <= 0) await Task.Delay(_limits.Value);
                var response = await _http.GetAsync(new Uri($"{_baserequest}/player?key={_apikey}&name={name}"));
                _limits = new KeyValuePair<int, int>(int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").First()), int.Parse(response.Headers.GetValues("X-RateLimit-Reset").First()));
                var playerjdata = JObject.Parse(await response.Content.ReadAsStringAsync()).SelectToken("player").ToString();
                var playerobj = JsonConvert.DeserializeObject<HypixelPlayer>(playerjdata);
                if (playerobj != null)
                {
                    if (_limits.Key <= 0) await Task.Delay(_limits.Value);
                    response = await _http.GetAsync(new Uri($"{_baserequest}/session?key={_apikey}&uuid={playerobj.UUID}"));
                    _limits = new KeyValuePair<int, int>(int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").First()), int.Parse(response.Headers.GetValues("X-RateLimit-Reset").First()));
                    var sessionjdata = JObject.Parse(await response.Content.ReadAsStringAsync()).SelectToken("session").ToString();
                    var session = JsonConvert.DeserializeObject<Session?>(sessionjdata);
                    playerobj.Session = session;
                    return playerobj;
                }
                else return null;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <summary>
        /// Get basic info about the current api key
        /// </summary>
        /// <returns>APIKey Object</returns>
        public async Task<APIKey> GetKeyInfoAsync()
        {
            try
            {
                await _semaphore.WaitAsync();
                if (_limits.Key <= 0) await Task.Delay(_limits.Value);
                var response = await _http.GetAsync(new Uri($"{_baserequest}/key?key={_apikey}"));
                _limits = new KeyValuePair<int, int>(int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").First()), int.Parse(response.Headers.GetValues("X-RateLimit-Reset").First()));
                var keyinfo = JsonConvert.DeserializeObject<APIKey>(JObject.Parse(await response.Content.ReadAsStringAsync()).SelectToken("record").ToString());
                return keyinfo;
            }
            finally
            {
                _semaphore.Release();
            }
        }
    }
}
