using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opggApi.Dtos.Matches
{
    public class ChallengesDto
    {
        public int TwelveAssistsStreakCount { get; set; }
        public int BaronBuffGoldAdvantageOverThreshold { get; set; }
        public float ControlWardTimeCoverageInRiverOrEnemyHalf { get; set; }

        public int EarliestBaron { get; set; }
        public int EarliestDragonTakedown { get; set; }
        public int EarliestElderDragon { get; set; }
        public int EarlyLaningPhaseGoldExpAdvantage { get; set; }
        public int FasterSupportQuestCompletion { get; set; }
        public int FastestLegendary { get; set; }
        public int HadAfkTeammate { get; set; }
        public int HighestChampionDamageDealt { get; set; }
        public int HighestCrowdControlScore { get; set; }
        public int HighestWardKills { get; set; }
        public int JunglerKillsEarlyJungle { get; set; }
        public int KillsOnLanersEarlyJungleAsJungler { get; set; }
        public int LaningPhaseGoldExpAdvantage { get; set; }
        public int LegendaryCount { get; set; }
        public float MaxCsAdvantageOnLaneOpponent { get; set; }
        public int MaxLevelLeadLaneOpponent { get; set; }
        public int MostWardsDestroyedOneSweeper { get; set; }
        public int MythicItemUsed { get; set; }
        public int PlayedChampSelectPosition { get; set; }
        public int SoloTurretsLateGame { get; set; }
        public int TakedownsFirst25Minutes { get; set; }
        public int TeleportTakedowns { get; set; }
        public int ThirdInhibitorTakedown { get; set; }
        public int ThreeWardsOneSweeperCount { get; set; }
        public float VisionScoreAdvantageLaneOpponent { get; set; }
        public int InfernalScalePickup { get; set; }
        public int FistBumpParticipation { get; set; }
        public int VoidMonsterKill { get; set; }
        public int AbilityUses { get; set; }
        public int AcesBefore15Minutes { get; set; }
        public float AlliedJungleMonsterKills { get; set; }
        public int BaronTakedowns { get; set; }
        public int BlastConeOppositeOpponentCount { get; set; }
        public int BountyGold { get; set; }
        public int BuffsStolen { get; set; }
        public int CompleteSupportQuestInTime { get; set; }
        public int ControlWardsPlaced { get; set; }
        public float DamagePerMinute { get; set; }
        public float DamageTakenOnTeamPercentage { get; set; }
        public int DancedWithRiftHerald { get; set; }
        public int DeathsByEnemyChamps { get; set; }
        public int DodgeSkillShotsSmallWindow { get; set; }
        public int DoubleAces { get; set; }
        public int DragonTakedowns { get; set; }
        public List<int>? LegendaryItemsUsed { get; set; }
        public float EffectiveHealAndShielding { get; set; }
        public int ElderDragonKillsWithOpposingSoul { get; set; }
        public int ElderDragonMultikills { get; set; }
        public int EnemyCHampionImmobilizations { get; set; }
        public float EnemyJungleMonsterKills { get; set; }
        public int EpicMonsterKillsNearEnemyJungler { get; set; }
        public int EpicMonsterKillsWithin30SecondsOfSpawn { get; set; }
        public int EpicMonsterSteals { get; set; }
        public int EpicMonsterStolenWithoutSmite { get; set; }
        public int FirstTurretKilled { get; set; }
        public float FIrstTurredKilledTime { get; set; }
        public int FlawlessAces { get; set; }
        public int FullTeamTakedown { get; set; }
        public float GameLength { get; set; }
        public int GetTakedownsInAllLanesEarlyJungleAsLaner { get; set; }
        public float GoldPerMinute { get; set; }
        public int HadOpenNexus { get; set; }
        public int ImmobilizeAndKillWithAlly { get; set; }

        public int InitialBuffCount { get; set; }
        public int InitialCrabCount { get; set; }
        public float JungleCsBefore10Minutes { get; set; }
        public int JunglerTakedownsNearDamagedEpicMonster { get; set; }
        public float Kda { get; set; }
        public int KillAfterHiddenWithAlly { get; set; }
        public int KilledChampTookFullDamageSurvived { get; set; }
        public int KillingSprees { get; set; }
        public float KillParticipation { get; set; }
        public int KillsNearEnemyTurret { get; set; }
        public int KillsOnOtherLanesEarlyJungleAsLaner { get; set; }
        public int KillsOnRecentlyHealedByAramPack { get; set; }
        public int KillsUnderOwnTurret { get; set; }
        public int KillsWithHelpFromEpicMosnter { get; set; }
        public int KnockEnemyIntoTeamAndKill { get; set; }
        public int KTurretsDestroyedBeforePlatesFall { get; set; }
        public int LandSkillShotsEarlyGame { get; set; }
        public int LaneMinionsFirst10Minutes { get; set; }
        public int LostAnInhibitor { get; set; }
        public int MaxKillDeficit { get; set; }
        public int MejaisFullStackInTime { get; set; }
        public float MoreEnemyJungleThanOpponent { get; set; }
        public int MultiKillOneSpell { get; set; }
        public int Multikills { get; set; }
        public int MultikillsAfterAggressiveFlash { get; set; }
        public int MultiTurretRiftHeraldCount { get; set; }
        public int OuterTurretExecutesBefore10Minutes { get; set; }
        public int OutnumberedKills { get; set; }
        public int OutnumberedNexusKills { get; set; }
        public int PerfectDragonSoulsTaken { get; set; }
        public int PerfectGame { get; set; }
        public int PickKillWithAlly { get; set; }
        public int PoroExplosions { get; set; }
        public int QuickCleanse { get; set; }
        public int QuickFirstTurret { get; set; }
        public int QuickSoloKills { get; set; }
        public int RiftHeraldTakedowns { get; set; }
        public int SaveAllyFromDeath { get; set; }
        public int ScuttleCrabKills { get; set; }
        public float ShortestTimeToAceFromFirstTakedown { get; set; }
        public int SkillshotsDodged { get; set; }
        public int SkillshotsHit { get; set; }
        public int SnowballsHit { get; set; }
        public int SoloBaronKills { get; set; }
        public int Swarm_DefeatAatrox { get; set; }
        public int Swarm_DefeatBriar { get; set; }
        public int Swarm_DefeatMiniBosses { get; set; }
        public int Swarm_EvolveWeapon { get; set; }
        public int Swarm_Have3Passives { get; set; }
        public int Swarm_KillEnemy { get; set; }
        public float Swarm_PickupGold { get; set; }
        public int Swarm_ReachLevel50 { get; set; }
        public int Swarm_Survive15Min { get; set; }
        public int Swarm_WinWith5EvolvedWeapons { get; set; }
        public int SoloKills { get; set; }
        public int StealthWardsPlaced { get; set; }
        public int SurvivedSingleDigitHpCount { get; set; }
        public int SurvivedThreeImmobilizesInFight { get; set; }
        public int TakedownsOnFirstTurret { get; set; }
        public int Takedowns { get; set; }
        public int TakedownsAfterGainingLevelAdvantage { get; set; }
        public int TakedownsBeforeJungleMinionSpawn { get; set; }
        public int TakedownsFirstXMinutes { get; set; }
        public int TakedownsInAlcove { get; set; }
        public int TakedownsInEnemyFountain { get; set; }
        public int TeamBaronKills { get; set; }
        public float TeamDamagePercentage { get; set; }
        public int TeamElderDragonKills { get; set; }
        public int TeamRiftHeraldKills { get; set; }
        public int TookLargeDamageSurvived { get; set; }
        public int TurretPlatesTaken { get; set; }
        public int TurretsTakenWithRiftHerald { get; set; }
        public int TurretTakedowns { get; set; }
        public int TwentyMinionsIn3SecondsCount { get; set; }
        public int TwoWardsOneSweeeperCount { get; set; }
        public int UnseenRecalls { get; set; }
        public float VisionScorePerMinute { get; set; }
        public int WardsGuarded { get; set; }
        public int WardTakedowns { get; set; }
        public int WardTakedownsBefore20Minutes { get; set; }
    }
}
