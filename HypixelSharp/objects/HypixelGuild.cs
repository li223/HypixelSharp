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
        public string ID { get; private set; }

        /// <summary>
        /// Guild's Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Current amount of Guild Coins
        /// </summary>
        [JsonProperty("coins")]
        public string Coins { get; private set; }

        /// <summary>
        /// Guild Member Size
        /// </summary>
        [JsonProperty("memberSizeLevel")]
        public string MemberSizeLevel { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bankSizeLevel")]
        public string BankSizeLevel { get; private set; }

        /// <summary>
        /// Overall amount of coins earned
        /// </summary>
        [JsonProperty("coinsEver")]
        public string TotalCoins { get; private set; }

        /// <summary>
        /// Epoch time (in miliseconds) of when the guild was created
        /// </summary>
        [JsonProperty("created")]
        public long Created { get; private set; }

        /// <summary>
        /// List of the guild's members
        /// </summary>
        [JsonProperty("members")]
        public List<HypixelGuildMember> Members { get; private set; }

        /// <summary>
        /// Number of VIP's in the Guild
        /// </summary>
        [JsonProperty("vipCount")]
        public string VipCount { get; private set; }

        /// <summary>
        /// Number of MVP's in the Guild
        /// </summary>
        [JsonProperty("mvpCount")]
        public string MvpCount { get; private set; }

        [JsonProperty("canMotd")]
        public bool CanMotd { get; private set; }

        [JsonProperty("banner")]
        public Banner Banner { get; private set; }

        [JsonProperty("canParty")]
        public bool CanParty { get; private set; }

        [JsonProperty("canTag")]
        public bool CanTag { get; private set; }

        [JsonProperty("publiclyListed")]
        public bool IsPubliclyListed { get; private set; }

        [JsonProperty("joinable")]
        public bool IsJoinable { get; private set; }

        /// <summary>
        /// Guild's tag
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; private set; }

        /// <summary>
        /// Daily Coins Earned
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JToken> DailyCoins { get; private set; }
    }
    public sealed class HypixelGuildMember
    {
        /// <summary>
        /// Members user ID
        /// </summary>
        [JsonProperty("uuid")]
        public string UUID { get; private set; }

        /// <summary>
        /// Members guild rank
        /// </summary>
        [JsonProperty("rank")]
        public string Rank { get; private set; }

        /// <summary>
        /// Epoch time (in miliseconds) of when the user joined
        /// </summary>
        [JsonProperty("joined")]
        public long Joined { get; private set; }

        /// <summary>
        /// Daily coins earned by this member
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JToken> DailyCoins { get; private set; }
    }
    public sealed class Banner
    {
        [JsonProperty("Base")]
        public int Base { get; private set; }

        [JsonProperty("Patterns")]
        public List<GuildPattern> Patterns { get; private set; }
    }
    public sealed class GuildPattern
    {
        [JsonProperty("Pattern")]
        public string Pattern { get; private set; }

        [JsonProperty("Color")]
        public int Color { get; private set; }
    }
}