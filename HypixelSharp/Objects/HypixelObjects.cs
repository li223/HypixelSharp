using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

//Effort
#pragma warning disable CS1591
namespace HypixelSharp.Objects
{
    public sealed class HypixelPlayer
    {
        /// <summary>
        /// Player's Id
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; private set; }

        /// <summary>
        /// Player's achievements
        /// </summary>
        [JsonProperty("achievements")]
        public Dictionary<string, string> Achievements { get; private set; }

        /// <summary>
        /// Player's one time achievements
        /// </summary>
        [JsonProperty("achievementsOneTime")]
        public List<string> OneTimeAchievements { get; private set; }

        /// <summary>
        /// Player Display Name
        /// </summary>
        [JsonProperty("displayname")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Epoch time (in miliseconds) of when the player first logged in
        /// </summary>
        [JsonProperty("firstLogin")]
        public long FirstLogin { get; private set; }

        //todo friend Requests

        /// <summary>
        /// Player's Karma
        /// </summary>
        [JsonProperty("karma")]
        public decimal Karma { get; private set; }

        /// <summary>
        /// Player's known aliases
        /// </summary>
        [JsonProperty("knownAliases")]
        public List<string> Aliases { get; private set; }

        /// <summary>
        /// Player's lower cased aliases
        /// </summary>
        [JsonProperty("knownAliasesLower")]
        public List<string> AliasesLower { get; private set; }

        /// <summary>
        /// Epoch time (in miliseconds) of when the player last logged in
        /// </summary>
        [JsonProperty("lastLogin")]
        public long LastLogin { get; private set; }

        /// <summary>
        /// Most recent Minecraft Version the player is using
        /// </summary>
        [JsonProperty("mostRecentMinecraftVersion")]
        public int MinecraftVersion { get; private set; }

        [JsonProperty("mostRecentlyThanked")]
        public string RecentlyThankedUsername { get; private set; }

        [JsonProperty("mostRecentlyThankedUuid")]
        public string RecentlyThankedUUID { get; private set; }

        [JsonProperty("mostRecentlyTipped")]
        public string RecentlyTippedUsername { get; private set; }

        [JsonProperty("mostRecentlyTippedUuid")]
        public string RecentlyTippedUUID { get; private set; }

        /// <summary>
        /// Player's network exp
        /// </summary>
        [JsonProperty("networkExp")]
        public decimal NetworkExp { get; private set; }

        [JsonProperty("newClock")]
        public string NewClock { get; private set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [JsonProperty("playername")]
        public string PlayerName { get; private set; }

        [JsonProperty("newPackageRank")]
        public string NewPackageRank { get; private set; }

        [JsonProperty("notifications")]
        public bool NotificationsEnabled { get; private set; }

        [JsonProperty("packageRank")]
        public string PackageRank { get; private set; }
        //todo player quests

        /// <summary>
        /// Player's global settings
        /// </summary>
        [JsonProperty("settings")]
        public Settings Settings { get; private set; }

        [JsonProperty("stats")]
        public Stats Stats { get; private set; }

        [JsonProperty("timePlaying")]
        public int TimePlayed { get; private set; }

        /// <summary>
        /// Player's user ID
        /// </summary>
        [JsonProperty("uuid")]
        public string UUID { get; private set; }

        /// <summary>
        /// Player's vanity tokens
        /// </summary>
        [JsonProperty("vanityTokens")]
        public int VanityTokens { get; private set; }

        /// <summary>
        /// Player's network level
        /// </summary>
        [JsonProperty("networkLevel")]
        public int NetworkLevel { get; private set; }

        /// <summary>
        /// Player's completed parkours
        /// </summary>
        [JsonProperty("parkourCompletions")]
        public Dictionary<string, List<ParkourTimes>> ParkourCompletions { get; private set; }

        /// <summary>
        /// Player's particle quality level
        /// </summary>
        [JsonProperty("particleQuality")]
        public string ParticleQuality { get; private set; }

        [JsonProperty("lastEugeneMessage")]
        public long LastEugeneMessage { get; private set; }

        /// <summary>
        /// The reward system, better known as "The Delivery Man"
        /// </summary>
        [JsonProperty("eugene")]
        public Eugene Eugene { get; private set; }

        [JsonProperty("last_survey")]
        public long LastSurvey { get; private set; }

        [JsonProperty("mcVersionRp")]
        public string McVersionRp { get; private set; }

        /// <summary>
        /// Player's pet conusumables
        /// </summary>
        [JsonProperty("petConsumables")]
        public Dictionary<string, int> PetConsumables { get; private set; }

        [JsonProperty("housingMeta")]
        public HousingMetadata HousingMeta { get; private set; }

        [JsonProperty("voting")]
        public Dictionary<string, long> Voting { get; private set; }

        //todo friend request uuids

        [JsonProperty("newMainTutorial")]
        public bool NewMainTutorial { get; private set; }

        [JsonProperty("channel")]
        public string Channel { get; private set; }

        [JsonProperty("petStats")]
        public Dictionary<string, PetStats> Pets { get; private set; }

        [JsonProperty("petJourneyTimestamp")]
        public long PetJourneyTimestamp { get; private set; }

        [JsonProperty("socialMedia")]
        public SocialMediaLinks SocialMedia { get; private set; }

        [JsonProperty("specialtyCooldowns")]
        public Dictionary<string, bool> SpecialtyCooldowns { get; private set; }

        [JsonProperty("outfit")]
        public Dictionary<string, string> Outfit { get; private set; }

        [JsonProperty("lastAdsenseGenerateTime")]
        public long LastAdsenseGenerateTime { get; private set; }

        [JsonProperty("lastClaimedReward")]
        public string LastClaimedReward { get; private set; }

        [JsonProperty("totalRewards")]
        public int TotalRewards { get; private set; }

        [JsonProperty("totalDailyRewards")]
        public int TotalDailyRewards { get; private set; }

        [JsonProperty("rewardStreak")]
        public int RewardStreak { get; private set; }

        [JsonProperty("rewardScore")]
        public int RewardScore { get; private set; }

        [JsonProperty("rewardHighScore")]
        public int RewardHighScore { get; private set; }

        /// <summary>
        /// Spectator flying speed
        /// </summary>
        [JsonProperty("spec_speed")]
        public int SpecSpeed { get; private set; }

        [JsonProperty("currentCloak")]
        public string CurrentCloak { get; private set; }

        [JsonProperty("adsense_tokens")]
        public decimal AdsenseTokens { get; private set; }

        [JsonProperty("vanityFirstConvertedBox")]
        public long VanityFirstConvertedBox { get; private set; }

        [JsonProperty("vanityConvertedBoxToday")]
        public int VanityConvertedBoxToday { get; private set; }

        [JsonProperty("flashingSalePopup")]
        public long FlashingSalePopup { get; private set; }

        [JsonProperty("flashingSalePoppedUp")]
        public int FlashingSalePoppedUp { get; private set; }

        [JsonProperty("flashingSaleOpens")]
        public long FlashingSaleOpens { get; private set; }

        [JsonProperty("flashingSaleClicks")]
        public long FlashingSaleClicks { get; private set; }

        [JsonProperty("mostRecentGameType")]
        public string MostRecentGameType { get; private set; }

        [JsonProperty("currentGadget")]
        public string CurrentGadget { get; private set; }
        
        [JsonProperty("quickjoin_timestamp")]
        public ulong QuickjoinTimestamp { get; private set; }

        [JsonProperty("quickjoin_uses")]
        public ulong QuickjoinUses { get; private set; }

        [JsonIgnore]
        public Session? Session { get; internal set; }

        [JsonExtensionData]
        public Dictionary<string, JToken> ExtensionData { get; private set; }
    }
    public struct Active
    {
        [JsonProperty("started")]
        public long Started { get; private set; }

        [JsonProperty("objectives")]
        public string Objectives { get; private set; }
    }

    public struct Settings
    {
        [JsonProperty("playerVisibility")]
        public bool PlayerVisible { get; private set; }

        [JsonProperty("chatVisibility")]
        public bool ChatVisible { get; private set; }
    }

    public struct ParkourTimes
    {
        [JsonProperty("timeStart")]
        public long TimeStart { get; private set; }

        [JsonProperty("timeTook")]
        public int TimeTaken { get; private set; }
    }

    public struct Eugene
    {
        [JsonProperty("dailyTwoKExp")]
        public long DailyTwoKExp { get; private set; }

        [JsonProperty("weekly_booster")]
        public long WeeklyBooster { get; private set; }
    }

    public struct HousingMetadata
    {
        /// <summary>
        /// Blocks available to build with
        /// </summary>
        [JsonProperty("allowedBlocks")]
        public List<string> AllowedBlocks { get; private set; }

        /// <summary>
        /// Themes a player has unlocked
        /// </summary>
        [JsonProperty("packages")]
        public List<string> Packages { get; private set; }

        [JsonProperty("tutorialStep")]
        public string TutorialStep { get; private set; }

        /// <summary>
        /// Player settings
        /// </summary>
        [JsonProperty("playerSettings")]
        public Dictionary<object, string> PlayerSetting { get; private set; }

        /// <summary>
        /// Song Playlist
        /// </summary>
        [JsonProperty("playlist")]
        public string Playlist { get; private set; }
    }

    public struct PetStats
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("EXERCISE")]
        public PetStatusValues Exercise { get; private set; }

        [JsonProperty("HUNGER")]
        public PetStatusValues Hunger { get; private set; }

        [JsonProperty("THIRST")]
        public PetStatusValues Thirst { get; private set; }

        [JsonProperty("experience")]
        public int Experience { get; private set; }
    }

    public struct PetStatusValues
    {
        [JsonProperty("value")]
        public int Value { get; private set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; private set; }
    }

    public struct Session
    {
        [JsonProperty("gameType")]
        public string GameType { get; private set; }

        [JsonProperty("server")]
        public string Server { get; private set; }

        [JsonProperty("players")]
        public List<string> Players { get; private set; }
    }

    public struct SocialMediaLinks
    {
        [JsonProperty("YOUTUBE")]
        public string YouTube { get; private set; }
        [JsonProperty("INSTAGRAM")]
        public string Instagram { get; private set; }
        [JsonProperty("TWITCH")]
        public string Twitch { get; private set; }
        [JsonProperty("link")]
        public Dictionary<string, string> Links { get; private set; }
    }
}
