using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opggApi.Models
{
    public class Summoner
    {

        public string AccountId { get; set; } = string.Empty;
        public int ProfileIconId { get; set; }
        public long RevisionDate { get; set; }
        public string SummonerId { get; set; } = string.Empty;
        public string Puuid { get; set; } = string.Empty;
        public long SummonerLevel { get; set; }
    }
}