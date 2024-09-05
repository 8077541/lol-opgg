using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using opggApi.Dtos;
using opggApi.Models;

namespace opggApi.Mappers
{
    public class ProfileMapper
    {
        public static Profile DtoToProfile(
            AccountDto accountDto,
            SummonerDto summonerDto,
            List<LeagueEntryDto> leagueEntryDtos
        )
        {
            return new Profile
            {
                Puuid = summonerDto.Puuid,
                SummonerId = summonerDto.Id,
                AccountId = summonerDto.AccountId,
                GameName = accountDto.GameName,
                TagLine = accountDto.TagLine,
                ProfileIconId = summonerDto.ProfileIconId,
                SummonerLevel = summonerDto.SummonerLevel,
                Rankeds = EntryDtoToRankeds(leagueEntryDtos),
            };
        }

        public static List<LeagueRankeds> EntryDtoToRankeds(List<LeagueEntryDto> leagueEntryDto)
        {
            var result = new List<LeagueRankeds> { };
            foreach (var entry in leagueEntryDto)
            {
                result.Add(
                    new LeagueRankeds
                    {
                        QueueType = entry.QueueType,
                        Tier = entry.Tier,
                        Rank = entry.Rank,
                        LeaguePoints = entry.LeaguePoints,
                        Wins = entry.Wins,
                        Losses = entry.Losses,
                        HotStreak = entry.HotStreak,
                    }
                );
            }
            return result;
        }
    }
}
