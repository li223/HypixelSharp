using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypixelSharp.Objects
{
    public sealed class WatchdogStats
    {
        /// <summary>
        /// Number of bans made by watchdog within the last minute
        /// </summary>
        [JsonProperty("watchdog_lastMinute")]
        public int BansLastMinute { get; internal set; }
        /// <summary>
        /// Total number of bans made by staff today
        /// </summary>
        [JsonProperty("staff_rollingDaily")]
        public int StaffRollingDaily { get; internal set; }
        /// <summary>
        /// Total number of bans made by watchdog
        /// </summary>
        [JsonProperty("watchdog_total")]
        public int TotalWatchdogBans { get; internal set; }
        /// <summary>
        /// Total number of bans made by watchdog today
        /// </summary>
        [JsonProperty("watchdog_rollingDaily")]
        public int WatchdogRollingDaily { get; internal set; }
        /// <summary>
        /// Total number of bans made by staff
        /// </summary>
        [JsonProperty("staff_total")]
        public int TotalStaffBans { get; internal set; }
    }
    public sealed class APIKey
    {
        [JsonProperty("key")]
        public string ApiKey { get; internal set; }
        [JsonProperty("ownerUuid")]
        public string OwnerID { get; internal set; }
        [JsonProperty("totalQueries")]
        public long TotalQueries { get; internal set; }
        [JsonProperty("queriesInPastMin")]
        public int QueriesPastMinute { get; internal set; }
    }
}
