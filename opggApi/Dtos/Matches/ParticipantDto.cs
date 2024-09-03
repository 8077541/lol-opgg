using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opggApi.Dtos.Matches
{
    public class ParticipantDto
    {
        public int AllInPings { get; set; }
        public int AssistMePings { get; set; }

        public int Assits { get; set; }

        public int BaronKills { get; set; }
        public int BountyLevel { get; set; }
        public int ChampExperience { get; set; }
        public int ChampLevel { get; set; }
        public int ChampionId { get; set; }
        public string ChampionName { get; set; } = string.Empty;
        public int CommandPings { get; set; }
        public int ChampionTransform { get; set; }
        public int ConsumablesPurchased { get; set; }
        public ChallengesDto? Challenges { get; set; }
        public int DamageDealtToBuildings { get; set; }
        public int DamageDealtToObjectives { get; set; }
        public int DamageDealtToTurrets { get; set; }
        public int DamageSelfMitigated { get; set; }
        public int Deaths { get; set; }
        public int DetectorWardsPlaced { get; set; }
        public int DoubleKills { get; set; }
        public int DragonKills { get; set; }
        public bool EligibleForProgression { get; set; }

        public int EnemyMissingPings { get; set; }
        public int EnemyVisionPings { get; set; }
        public bool FirstBloodAssist { get; set; }
        public bool FirstBloodKill { get; set; }
        public bool FirstTowerAssist { get; set; }
        public bool FirstTowerKill { get; set; }
        public bool GameEndedInEarlySurrender { get; set; }
        public bool GameEndedInSurrender { get; set; }
        public int HoldPings { get; set; }
        public int GetBackPings { get; set; }
        public int GoldEarned { get; set; }
        public int GoldSpent { get; set; }
        public string IndividualPosition { get; set; } = string.Empty;
        public int InhibitorKills { get; set; }
        public int InhibitorTakedowns { get; set; }
        public int InhibitorsLost { get; set; }
        public int Item0 { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; }
        public int ItemsPurchased { get; set; }
        public int KillingSprees { get; set; }
        public int Kills { get; set; }
        public string? Lane { get; set; }
        public int LargestCriticalStrike { get; set; }
        public int LargestKillingSpree { get; set; }
        public int LargestMultiKill { get; set; }
        public int LongestTimeSpentLiving { get; set; }
        public int MagicDamageDealt { get; set; }
        public int MagicDamageDealtToChampions { get; set; }
        public int MagicDamageTaken { get; set; }
        public MissionsDto? Missions { get; set; }
        public int NeutralMinionsKilled { get; set; }
        public int NeedVisionPings { get; set; }
        public int NexusKills { get; set; }
        public int NexusTakedowns { get; set; }
        public int NexusLost { get; set; }
        public int ObjectivesStolen { get; set; }
        public int ObjectivesStolenAssists { get; set; }
        public int OnMyWayPings { get; set; }
        public int ParticipantId { get; set; }
        public int PlayerScore0 { get; set; }
        public int PlayerScore1 { get; set; }
        public int PlayerScore2 { get; set; }
        public int PlayerScore3 { get; set; }
        public int PlayerScore4 { get; set; }
        public int PlayerScore5 { get; set; }
        public int PlayerScore6 { get; set; }
        public int PlayerScore7 { get; set; }
        public int PlayerScore8 { get; set; }
        public int PlayerScore9 { get; set; }
        public int PlayerScore10 { get; set; }
        public int PlayerScore11 { get; set; }
        public int PentaKills { get; set; }

        public PerksDto? Perks { get; set; }

        public int PhysicalDamageDealt { get; set; }
        public int PhysicalDamageDealtToChampions { get; set; }

        public int PhysicalDamageTaken { get; set; }
        public int Placement { get; set; }
        public int PlayerAugment1 { get; set; }
        public int PlayerAugment2 { get; set; }
        public int PlayerAugment3 { get; set; }
        public int PlayerAugment4 { get; set; }
        public int PlayerSubteamId { get; set; }
        public int PushPings { get; set; }
        public int ProfileIcon { get; set; }
        public string Puuid { get; set; } = string.Empty;

        public int QuadraKills { get; set; }
        public string RiotIdGameName { get; set; } = string.Empty;
        public string RiotIdName { get; set; } = string.Empty;

        public string RiotIdTagline { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;
        public int SightWardsBoughtInGame { get; set; }
        public int Spell1Casts { get; set; }
        public int Spell2Casts { get; set; }
        public int Spell3Casts { get; set; }
        public int Spell4Casts { get; set; }

        public int SubteamPlacement { get; set; }
        public int Summoner1Casts { get; set; }
        public int Summoner1Id { get; set; }
        public int Summoner2Casts { get; set; }

        public int Summoner2Id { get; set; }
        public string SummonerId { get; set; } = string.Empty;

        public int SummonerLevel { get; set; }
        public string SummonerName { get; set; } = string.Empty;

        public bool TeamEarlySurrendered { get; set; }
        public int TeamId { get; set; }
        public string TeamPosition { get; set; } = string.Empty;
        public int TimeCCingOthers { get; set; }
        public int TimePlayed { get; set; }
        public int TotalAllyJungleMinionsKilled { get; set; }
        public int TotalDamageDealt { get; set; }
        public int TotalDamageDealtToChampions { get; set; }
        public int TotalDamageShieldedOnTeammates { get; set; }

        public int TotalDamageTaken { get; set; }
        public int TotalEnemyJungleMinionsKilled { get; set; }
        public int TotalHeal { get; set; }
        public int TotalHealsOnTeammates { get; set; }
        public int TotalMinionsKilled { get; set; }
        public int TotalTimeCCDealt { get; set; }
        public int TotalTimeSpentDead { get; set; }
        public int TotalUnisHealed { get; set; }
        public int TripleKills { get; set; }
        public int TrueDamageDealt { get; set; }
        public int TrueDamageDealtToChampions { get; set; }
        public int TrueDamageTaken { get; set; }
        public int TurretKills { get; set; }
        public int TurretTakedowns { get; set; }
        public int TurretsLost { get; set; }
        public int UnrealKills { get; set; }
        public int VisionScore { get; set; }
        public int VisionClearedPings { get; set; }
        public int VisionWardsBoughtInGame { get; set; }
        public int WardsKilled { get; set; }
        public int WardsPlace { get; set; }
        public bool Win { get; set; }
    }
}
