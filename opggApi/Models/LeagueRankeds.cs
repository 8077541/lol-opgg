using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opggApi.Models
{
    public class LeagueRankeds
    {
        public string LeagueID { get; set; } = string.Empty;
        public string SummonerId { get; set; } = string.Empty;

        public string QueueType { get; set; } = string.Empty;

        public string Tier { get; set; } = string.Empty;

        public string Rank { get; set; } = string.Empty;

        public int LeaguePoints { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }
        public bool HotStreak { get; set; }
    }
}
