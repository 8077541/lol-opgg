using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opggApi.Dtos.Matches;
using opggApi.Models;

namespace opggApi.Interfaces
{
    public interface IMatchInterface
    {
        Task<List<string>> GetMatchIds(string puuid);
        Task<MatchDto> GetMatch(string matchId);
        Task<MatchLoL> AddMatchToDb(MatchLoL match);
        Task<MatchLoL> GetMatchFromDb(string match);
    }
}
