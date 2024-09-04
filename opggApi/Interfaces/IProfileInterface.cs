using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opggApi.Dtos;
using opggApi.Models;

namespace opggApi.Interfaces
{
    public interface IProfileInterface
    {
        Task<AccountDto> GetPuuid(string gameName, string tagLine);
        Task<SummonerDto> GetSummoner(AccountDto account);
        Task<List<LeagueEntryDto>> GetRankeds(SummonerDto summoner);
    }
}
