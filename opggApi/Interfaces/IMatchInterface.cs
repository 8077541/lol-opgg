using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opggApi.Dtos.Matches;

namespace opggApi.Interfaces
{
    public interface IMatchInterface
    {
        Task<List<string>> GetMatchIds(string puuid);
        Task<MatchDto> GetMatch(string matchId);
    }
}
