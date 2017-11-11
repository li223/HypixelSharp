using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace HypixelSharp.Objects
{
    public sealed class HypixelGuild
    {
        /// <summary>
        /// Guild's ID
        /// </summary>
        [JsonProperty("_id")]
        public string ID { get; internal set; }
        /// <summary>
        /// Guild's Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; internal set; }
        /// <summary>
        /// Current amount of Guild Coins
        /// </summary>
        [JsonProperty("coins")]
        public string Coins { get; internal set; }
        /// <summary>
        /// Guild Member Size
        /// </summary>
        [JsonProperty("memberSizeLevel")]
        public string MemberSizeLevel { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bankSizeLevel")]
        public string BankSizeLevel { get; internal set; }
        /// <summary>
        /// Overall amount of coins earned
        /// </summary>
        [JsonProperty("coinsEver")]
        public string TotalCoins { get; internal set; }
        /// <summary>
        /// Epoch time (in miliseconds) of when the guild was created
        /// </summary>
        [JsonProperty("created")]
        public long Created { get; internal set; }
        /// <summary>
        /// List of the guild's members
        /// </summary>
        [JsonProperty("members")]
        public List<HypixelGuildMember> Members { get; internal set; }
        /// <summary>
        /// Number of VIP's in the Guild
        /// </summary>
        [JsonProperty("vipCount")]
        public string VipCount { get; internal set; }
        /// <summary>
        /// Number of MVP's in the Guild
        /// </summary>
        [JsonProperty("mvpCount")]
        public string MvpCount { get; internal set; }
        [JsonProperty("canMotd")]
        public bool CanMotd { get; internal set; }
        [JsonProperty("banner")]
        public Banner Banner { get; internal set; }
        [JsonProperty("canParty")]
        public bool CanParty { get; internal set; }
        [JsonProperty("canTag")]
        public bool CanTag { get; internal set; }
        [JsonProperty("publiclyListed")]
        public bool IsPubliclyListed { get; internal set; }
        [JsonProperty("joinable")]
        public bool IsJoinable { get; internal set; }
        /// <summary>
        /// Guild's tag
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; internal set; }
        /// <summary>
        /// Daily Coins Earned
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JToken> DailyCoins { get; internal set; }
    }
    public sealed class HypixelGuildMember
    {
        /// <summary>
        /// Members user ID
        /// </summary>
        [JsonProperty("uuid")]
        public string ID { get; internal set; }
        /// <summary>
        /// Members guild rank
        /// </summary>
        [JsonProperty("rank")]
        public string Rank { get; internal set; }
        /// <summary>
        /// Epoch time (in miliseconds) of when the user joined
        /// </summary>
        [JsonProperty("joined")]
        public long Joined { get; internal set; }
        /// <summary>
        /// Daily coins earned by this member
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JToken> DailyCoins { get; internal set; }
    }
    public sealed class Banner
    {
        [JsonProperty("Base")]
        public int Base { get; internal set; }
        [JsonProperty("Patterns")]
        public List<GuildPattern> Patterns { get; internal set; }
    }
    public sealed class GuildPattern
    {
        [JsonProperty("Pattern")]
        public string Pattern { get; internal set; }
        [JsonProperty("Color")]
        public int Color { get; internal set; }
    }
}