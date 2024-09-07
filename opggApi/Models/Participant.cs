using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opggApi.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public int Assists { get; set; }
        public int ChampLevel { get; set; }
        public int ChampionId { get; set; }
        public string? ChampionName { get; set; }

        public int DamageDealtToTurrets { get; set; }
        public int DamageDealtToObjectives { get; set; }
        public int Deaths { get; set; }
        public int GoldEarned { get; set; }
        public int GoldSpent { get; set; }
        public string? IndividualPosition { get; set; }
        public int Kills { get; set; }
        public string? Lane { get; set; }
        public int Item0 { get; set; }
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public int Item4 { get; set; }
        public int Item5 { get; set; }
        public int Item6 { get; set; }
        public int MagicDamageDealt { get; set; }
        public int MagicDamageDealtToChampions { get; set; }
        public int MagicDamageTaken { get; set; }
        public int PhysicalDamageDealt { get; set; }
        public int PhysicalDamageDealtToChampions { get; set; }
        public int PhysicalDamageTaken { get; set; }
        public string? Puuid { get; set; }
        public string? RiotIdGameName { get; set; }
        public string? RiotIdTagLine { get; set; }
        public int TotalDamageDealt { get; set; }
        public int TotalDamageDealtToChampions { get; set; }
        public int TotalDamageTaken { get; set; }
        public int TotalMinionsKilled { get; set; }
        public int TrueDamageDealt { get; set; }
        public int TrueDamageDealtToChampions { get; set; }
        public int TrueDamageTaken { get; set; }
        public int Spell1Casts { get; set; }
        public int Spell2Casts { get; set; }
        public int Spell3Casts { get; set; }
        public int Spell4Casts { get; set; }

        public float Kda { get; set; }

        public int VisionScore { get; set; }
        public int LargestMultiKill { get; set; }

        public int ParticipantId { get; set; }
        public bool Win { get; set; }
    }
}
