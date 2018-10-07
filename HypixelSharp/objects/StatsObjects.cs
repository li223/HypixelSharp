using Newtonsoft.Json;
using System;

//Effort
#pragma warning disable CS1591
namespace HypixelSharp
{
    public struct Stats
    {
        [JsonProperty("arcade")]
        public ArcadeStats Arcade { get; private set; }
    }
    public struct ArcadeStats
    {
        [JsonProperty("blood")]
        public bool Blood { get; private set; }

        [JsonProperty("bounty_head")]
        public string BountyHead { get; private set; }

        [JsonProperty("bounty_kills_oneinthequiver")]
        public string BountyKills_OneInTheQuiver { get; private set; }

        [JsonProperty("coins")]
        public float Coins { get; private set; }

        [JsonProperty("deaths_oneinthequiver")]
        public int Deaths_OneInTheQuiver { get; private set; }

        [JsonProperty("deaths_throw_out")]
        public int Deaths_ThrowOut { get; private set; }

        [JsonProperty("headshots_dayone")]
        public int Headshots_Dayone { get; private set; }

        [JsonProperty("kills_dayone")]
        public int Kills_Dayone { get; private set; }

        [JsonProperty("kills_dragonwars2")]
        public int Kills_DragonwarsTwo { get; private set; }

        [JsonProperty("kills_oneinthequiver")]
        public int Kills_OneInTheQuiver { get; private set; }
            
        [JsonProperty("kills_throw_out")]
        public int Kills_ThrowOut { get; private set; }

        [JsonProperty("max_wave")]
        public int MaxWave { get; private set; }

        [JsonProperty("melee_weapon")]
        public string MeleeWeapon { get; private set; }

        [JsonProperty("packages")]
        public string[] Packages { get; private set; }

        [JsonProperty("poop_collected")]
        public int PoopCollected { get; private set; }

        [JsonProperty("stamp_level")]
        public int StampLevel { get; private set; }

        [JsonProperty("time_stamp")]
        public DateTimeOffset Timestamp { get; private set; }

        [JsonProperty("wins_dragonwars2")]
        public int Wins_DragonwarsTwo { get; private set; }

        [JsonProperty("wins_ender")]
        public int Wins_Ender { get; private set; }

        [JsonProperty("wins_oneinthequiver")]
        public int Wins_OneInTheQuiver { get; private set; }

        [JsonProperty("wins_party")]
        public int Wins_Party { get; private set; }

        [JsonProperty("wins_throw_out")]
        public int Wins_ThrowOut { get; private set; }

        [JsonProperty("wins_dayone")]
        public int Wins_Dayone { get; private set; }

        [JsonProperty("sw_kills")]
        public int SW_Kills { get; private set; }

        [JsonProperty("sw_shots_fired")]
        public int SW_ShotsFired { get; private set; }

        [JsonProperty("sw_rebel_kills")]
        public int SW_RebelKills { get; private set; }

        [JsonProperty("sw_weekly_kills_a")]
        public int SW_WeeklyKills_A { get; private set; }

        [JsonProperty("sw_deaths")]
        public int SW_Deaths { get; private set; }

        [JsonProperty("sw_monthly_kills_a")]
        public int SW_MonthlyKills_A { get; private set; }

        [JsonProperty("sw_empire_kills")]
        public int SW_EmpireKills { get; private set; }

        [JsonProperty("sw_weekly_kills_b")]
        public int SW_WeeklyKills_B { get; private set; }

        [JsonProperty("sw_game_wins")]
        public int SW_GameWins { get; private set; }

        [JsonProperty("sw_monthly_kills_b")]
        public int SW_MonthlyKills_B { get; private set; }

        [JsonProperty("hitw_record_q")]
        public int HITW_Record_Q { get; private set; }

        [JsonProperty("hitw_record_f")]
        public int HITW_Record_F { get; private set; }

        [JsonProperty("rounds_hole_in_the_wall")]
        public int Rounds_HoleInTheWall { get; private set; }

        [JsonProperty("wins_hole_in_the_wall")]
        public int Wins_HoleInTheWall { get; private set; }

        [JsonProperty("rounds_santa_says")]
        public int Rounds_SantaSays { get; private set; }

        [JsonProperty("wins_santa_says")]
        public int Wins_SantaSays { get; private set; }

        [JsonProperty("rounds_simon_says")]
        public int Rounds_SimonSays { get; private set; }

        [JsonProperty("monthly_coins_a")]
        public int MonthlyCoins_A { get; private set; }
            
        [JsonProperty("weekly_coins_a")]
        public int WeeklyCoins_A { get; private set; }

        [JsonProperty("wins_party_2")]
        public int Wins_PartyTwo { get; private set; }

        [JsonProperty("music")]
        public bool Music { get; private set; }

        [JsonProperty("wins_simon_says")]
        public int Wins_SimonSays { get; private set; }

        [JsonProperty("monthly_coins_b")]
        public int MonthlyCoins_B { get; private set; }

        [JsonProperty("weekly_coins_b")]
        public int WeeklyCoins_B { get; private set; }

        [JsonProperty("wins_farm_hunt")]
        public int Wins_FarmHunt { get; private set; }

        [JsonProperty("miniwalls_activeKit")]
        public int Miniwalls_ActiveKit { get; private set; }

        [JsonProperty("arrows_hit_mini_walls")]
        public int ArrowsHit_Miniwalls { get; private set; }

        [JsonProperty("final_kills_mini_walls")]
        public int FinalKills_Miniwalls { get; private set; }

        [JsonProperty("kills_mini_walls")]
        public int Kills_Miniwalls { get; private set; }

        [JsonProperty("deaths_mini_walls")]
        public int Deaths_Miniwalls { get; private set; }

        [JsonProperty("arrows_shot_mini_walls")]
        public int ArrowsShot_Miniwalls { get; private set; }

        [JsonProperty("wither_damage_mini_walls")]
        public int WitherDamage_Miniwalls { get; private set; }

        [JsonProperty("wins_mini_walls")]
        public int Wins_Miniwalls { get; private set; }

        [JsonProperty("wither_kills_mini_walls")]
        public int WitherKills_Miniwalls { get; private set; }

        [JsonProperty("wins_grinch")]
        public int Wins_Grinch { get; private set; }

        [JsonProperty("dec2016_achievements")]
        public bool Dec2016_Achievements { get; private set; }

        [JsonProperty("dec2016_achievements2")]
        public bool Dec2016_AchievementsTwo { get; private set; }

    }
}
