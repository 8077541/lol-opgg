using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opggApi.Dtos;

namespace opggApi.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Puuid { get; set; } = string.Empty;
        public string SummonerId { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public string GameName { get; set; } = string.Empty;
        public string TagLine { get; set; } = string.Empty;
        public int ProfileIconId { get; set; }
        public long SummonerLevel { get; set; }
        public List<LeagueRankeds>? Rankeds { get; set; }
        public List<string>? LastMatches { get; set; }
    }
}
