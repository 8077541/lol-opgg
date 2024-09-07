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
        public static Profile DtoToProfile(AccountDto accountDto, SummonerDto summonerDto)
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
            };
        }

        public static Profile LeagueEntryToProfile(
            Profile profile,
            List<LeagueEntryDto> leagueEntryDtos
        )
        {
            foreach (var leagueEntryDto in leagueEntryDtos)
            {
                if (leagueEntryDto.QueueType == "RANKED_SOLO_5x5")
                {
                    profile.SoloTier = leagueEntryDto.Tier;
                    profile.SoloRank = leagueEntryDto.Rank;
                    profile.SoloLeaguePoints = leagueEntryDto.LeaguePoints;
                    profile.SoloWins = leagueEntryDto.Wins;
                    profile.SoloLosses = leagueEntryDto.Losses;
                    profile.SoloHotStreak = leagueEntryDto.HotStreak;
                }
                else if (leagueEntryDto.QueueType == "RANKED_FLEX_SR")
                {
                    profile.FlexTier = leagueEntryDto.Tier;
                    profile.FlexRank = leagueEntryDto.Rank;
                    profile.FlexLeaguePoints = leagueEntryDto.LeaguePoints;
                    profile.FlexWins = leagueEntryDto.Wins;
                    profile.FlexLosses = leagueEntryDto.Losses;
                    profile.FlexHotStreak = leagueEntryDto.HotStreak;
                }
            }
            return profile;
        }
    }
}
