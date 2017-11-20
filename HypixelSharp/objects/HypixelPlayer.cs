using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HypixelSharp;
using System.Net.Http;

namespace HypixelSharp.Objects
{
    public sealed class HypixelPlayer
    {
        [JsonProperty("_id")]
        public string ID { get; internal set; }

        /// <summary>
        /// Player's achievements
        /// </summary>
        [JsonProperty("achievements")]
        public Dictionary<string, string> Achievements { get; internal set; }

        /// <summary>
        /// Player's one time achievements
        /// </summary>
        [JsonProperty("achievementsOneTime")]
        public List<string> OneTimeAchievements { get; internal set; }

        /// <summary>
        /// Player Display Name
        /// </summary>
        [JsonProperty("displayname")]
        public string DisplayName { get; internal set; }

        /// <summary>
        /// Epoch time (in miliseconds) of when the player first logged in
        /// </summary>
        [JsonProperty("firstLogin")]
        public long FirstLogin { get; internal set; }

        //todo friend Requests

        /// <summary>
        /// Player's Karma
        /// </summary>
        [JsonProperty("karma")]
        public int Karma { get; internal set; }

        /// <summary>
        /// Player's known aliases
        /// </summary>
        [JsonProperty("knownAliases")]
        public List<string> Aliases { get; internal set; }

        /// <summary>
        /// Player's Lesser known aliases
        /// </summary>
        [JsonProperty("knownAliasesLower")]
        public List<string> AliasesLower { get; internal set; }

        /// <summary>
        /// Epoch time (in miliseconds) of when the player last logged in
        /// </summary>
        [JsonProperty("lastLogin")]
        public long LastLogin { get; internal set; }

        /// <summary>
        /// Most recent Minecraft Version the player is using
        /// </summary>
        [JsonProperty("mostRecentMinecraftVersion")]
        public int MinecraftVersion { get; internal set; }

        /// <summary>
        /// Player's network exp
        /// </summary>
        [JsonProperty("networkExp")]
        public int NetworkExp { get; internal set; }

        [JsonProperty("newClock")]
        public string NewClock { get; internal set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [JsonProperty("playername")]
        public string PlayerName { get; internal set; }

        //todo player quests

        /// <summary>
        /// Player's global settings
        /// </summary>
        [JsonProperty("settings")]
        public Settings Settings { get; internal set; }

        //todo stats

        [JsonProperty("timePlaying")]
        public int TimePlayed { get; internal set; }

        /// <summary>
        /// Player's user ID
        /// </summary>
        [JsonProperty("uuid")]
        public string UUID { get; internal set; }

        /// <summary>
        /// Player's vanity tokens
        /// </summary>
        [JsonProperty("vanityTokens")]
        public int VanityTokens { get; internal set; }

        /// <summary>
        /// Player's network level
        /// </summary>
        [JsonProperty("networkLevel")]
        public int NetworkLevel { get; internal set; }

        /// <summary>
        /// Player's completed parkours
        /// </summary>
        [JsonProperty("parkourCompletions")]
        public Dictionary<string, List<ParkourTimes>> ParkourCompletions { get; internal set; }

        /// <summary>
        /// Player's particle quality level
        /// </summary>
        [JsonProperty("particleQuality")]
        public string ParticleQuality { get; internal set; }

        [JsonProperty("lastEugeneMessage")]
        public long LastEugeneMessage { get; internal set; }
        [JsonProperty("eugene")]
        public Eugene Eugene { get; internal set; }

        [JsonProperty("last_survey")]
        public long LastSurvey { get; internal set; }

        [JsonProperty("mcVersionRp")]
        public string McVersionRp { get; internal set; }

        /// <summary>
        /// Player's pet conusumables
        /// </summary>
        [JsonProperty("petConsumables")]
        public Dictionary<string, int> PetConsumables { get; internal set; }

        [JsonProperty("housingMeta")]
        public HousingMetadata HousingMeta { get; internal set; }

        [JsonProperty("voting")]
        public Dictionary<string, long> Voting { get; internal set; }

        //todo friend request uuids

        [JsonProperty("newMainTutorial")]
        public bool NewMainTutorial { get; internal set; }

        [JsonProperty("channel")]
        public string Channel { get; internal set; }

        [JsonProperty("newPackageRank")]
        public string NewPackageRank { get; internal set; }

        [JsonProperty("petStats")]
        public Dictionary<string, PetStats> Pets { get; internal set; }

        [JsonProperty("petJourneyTimestamp")]
        public long PetJourneyTimestamp { get; internal set; }

        [JsonProperty("mostRecentlyTippedUuid")]
        public string MostRecentlyTippedUser { get; internal set; }

        [JsonProperty("socialMedia")]
        public Dictionary<string, string> SocialMedia { get; internal set; }

        [JsonProperty("specialtyCooldowns")]
        public Dictionary<string, bool> SpecialtyCooldowns { get; internal set; }

        [JsonProperty("outfit")]
        public Dictionary<string, string> Outfit { get; internal set; }

        [JsonProperty("lastAdsenseGenerateTime")]
        public long LastAdsenseGenerateTime { get; internal set; }

        [JsonProperty("lastClaimedReward")]
        public string LastClaimedReward { get; internal set; }

        [JsonProperty("totalRewards")]
        public int TotalRewards { get; internal set; }

        [JsonProperty("totalDailyRewards")]
        public int TotalDailyRewards { get; internal set; }

        [JsonProperty("rewardStreak")]
        public int RewardStreak { get; internal set; }

        [JsonProperty("rewardScore")]
        public int RewardScore { get; internal set; }

        [JsonProperty("rewardHighScore")]
        public int RewardHighScore { get; internal set; }

        [JsonProperty("spec_speed")]
        public int SpecSpeed { get; internal set; }

        [JsonProperty("currentCloak")]
        public string CurrentCloak { get; internal set; }

        [JsonProperty("adsense_tokens")]
        public decimal AdsenseTokens { get; internal set; }

        [JsonProperty("vanityFirstConvertedBox")]
        public long VanityFirstConvertedBox { get; internal set; }

        [JsonProperty("vanityConvertedBoxToday")]
        public int VanityConvertedBoxToday { get; internal set; }

        [JsonProperty("flashingSalePopup")]
        public long FlashingSalePopup { get; internal set; }

        [JsonProperty("flashingSalePoppedUp")]
        public int FlashingSalePoppedUp { get; internal set; }

        [JsonProperty("flashingSaleOpens")]
        public long FlashingSaleOpens { get; internal set; }

        [JsonProperty("flashingSaleClicks")]
        public long FlashingSaleClicks { get; internal set; }

        [JsonProperty("mostRecentGameType")]
        public string MostRecentGameType { get; internal set; }

        [JsonProperty("currentGadget")]
        public string CurrentGadget { get; internal set; }

        [JsonIgnore]
        public Session Session { get; internal set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtensionData { get; internal set; }
    }
    public sealed class Active
    {
        [JsonProperty("started")]
        public long Started { get; internal set; }

        [JsonProperty("objectives")]
        public string Objectives { get; internal set; }
    }
    public sealed class Settings
    {
        [JsonProperty("playerVisibility")]
        public bool PlayerVisible { get; internal set; }

        [JsonProperty("chatVisibility")]
        public bool ChatVisible { get; internal set; }
    }
    public sealed class ParkourTimes
    {
        [JsonProperty("timeStart")]
        public long TimeStart { get; internal set; }

        [JsonProperty("timeTook")]
        public int TimeTaken { get; internal set; }
    }
    public sealed class Eugene
    {
        [JsonProperty("dailyTwoKExp")]
        public long DailyTwoKExp { get; internal set; }

        [JsonProperty("weekly_booster")]
        public long WeeklyBooster { get; internal set; }
    }
    public sealed class HousingMetadata
    {
        [JsonProperty("allowedBlocks")]
        public List<string> AllowedBlocks { get; internal set; }

        [JsonProperty("packages")]
        public List<string> Packages { get; internal set; }

        [JsonProperty("tutorialStep")]
        public string TutorialStep { get; internal set; }

        [JsonProperty("playerSettings")]
        public Dictionary<object, string> PlayerSetting { get; internal set; }

        [JsonProperty("playlist")]
        public string Playlist { get; internal set; }
    }
    public sealed class PetStats
    {
        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("EXERCISE")]
        public PetStatusValues Exercise { get; internal set; }

        [JsonProperty("HUNGER")]
        public PetStatusValues Hunger { get; internal set; }

        [JsonProperty("THIRST")]
        public PetStatusValues Thirst { get; internal set; }

        [JsonProperty("experience")]
        public int Experience { get; internal set; }
    }
    public sealed class PetStatusValues
    {
        [JsonProperty("value")]
        public int Value { get; internal set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; internal set; }
    }
    public sealed class Session
    {
        [JsonProperty("gameType")]
        public string GameType { get; internal set; }

        [JsonProperty("server")]
        public string Server { get; internal set; }

        [JsonProperty("players")]
        public List<string> Players { get; internal set; }
    }
}
