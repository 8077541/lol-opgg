using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using opggApi.Dtos.Matches;
using opggApi.Models;

namespace opggApi.Mappers
{
    public class MatchMapper
    {
        public static MatchLoL MatchDtoToMatch(MatchDto matchDto)
        {
            return new MatchLoL
            {
                MatchId = matchDto.Metadata.MatchId,
                GameCreation = matchDto.Info.GameCreation,
                GameDuration = matchDto.Info.GameDuration,
                GameStartTimeStamp = matchDto.Info.GameStartTimestamp,
                GameEndTimeStamp = matchDto.Info.GameEndTimestamp,
                GameId = matchDto.Info.GameId,
                GameMode = matchDto.Info.GameMode,
                GameName = matchDto.Info.GameName,
                GameType = matchDto.Info.GameType,
                GameVersion = matchDto.Info.GameVersion,
                MapId = matchDto.Info.MapId,
                PlatformId = matchDto.Info.PlatformId,
                QueueId = matchDto.Info.QueueId,
                Participants = ParticipantDtoToParticipant(matchDto.Info.Participants),
            };
        }

        public static List<Participant> ParticipantDtoToParticipant(
            List<ParticipantDto> participantDto
        )
        {
            var result = new List<Participant> { };
            foreach (var participant in participantDto)
            {
                result.Add(
                    new Participant
                    {
                        Assists = participant.Assists,
                        ChampLevel = participant.ChampLevel,
                        ChampionId = participant.ChampionId,
                        ChampionName = participant.ChampionName,
                        DamageDealtToTurrets = participant.DamageDealtToTurrets,
                        DamageDealtToObjectives = participant.DamageDealtToObjectives,
                        Deaths = participant.Deaths,
                        GoldEarned = participant.GoldEarned,
                        GoldSpent = participant.GoldSpent,
                        IndividualPosition = participant.IndividualPosition,
                        Kills = participant.Kills,
                        Lane = participant.Lane,
                        Item0 = participant.Item0,
                        Item1 = participant.Item1,
                        Item2 = participant.Item2,
                        Item3 = participant.Item3,
                        Item4 = participant.Item4,
                        Item5 = participant.Item5,
                        Item6 = participant.Item6,
                        MagicDamageDealt = participant.MagicDamageDealt,
                        MagicDamageDealtToChampions = participant.MagicDamageDealtToChampions,
                        MagicDamageTaken = participant.MagicDamageTaken,
                        PhysicalDamageDealt = participant.PhysicalDamageDealt,
                        PhysicalDamageDealtToChampions = participant.PhysicalDamageDealtToChampions,
                        PhysicalDamageTaken = participant.PhysicalDamageTaken,
                        Puuid = participant.Puuid,
                        RiotIdGameName = participant.RiotIdGameName,
                        RiotIdTagLine = participant.RiotIdTagline,
                        TotalDamageDealt = participant.TotalDamageDealt,
                        TotalDamageDealtToChampions = participant.TotalDamageDealtToChampions,
                        TotalDamageTaken = participant.TotalDamageTaken,
                        TotalMinionsKilled = participant.TotalMinionsKilled,
                        TrueDamageDealt = participant.TrueDamageDealt,
                        TrueDamageDealtToChampions = participant.TrueDamageDealtToChampions,
                        TrueDamageTaken = participant.TrueDamageTaken,
                        Spell1Casts = participant.Spell1Casts,
                        Spell2Casts = participant.Spell2Casts,
                        Spell3Casts = participant.Spell3Casts,
                        Spell4Casts = participant.Spell4Casts,
                        Kda = participant.Challenges.Kda,
                        VisionScore = participant.VisionScore,
                        LargestMultiKill = participant.LargestMultiKill,
                        ParticipantId = participant.ParticipantId,
                        Win = participant.Win,
                    }
                );
            }
            return result;
        }
    }
}
