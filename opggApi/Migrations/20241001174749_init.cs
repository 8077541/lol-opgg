﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace opggApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameCreation = table.Column<long>(type: "bigint", nullable: false),
                    GameDuration = table.Column<long>(type: "bigint", nullable: false),
                    GameStartTimeStamp = table.Column<long>(type: "bigint", nullable: false),
                    GameEndTimeStamp = table.Column<long>(type: "bigint", nullable: false),
                    GameId = table.Column<long>(type: "bigint", nullable: false),
                    GameMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MapId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QueueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Puuid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SummonerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TagLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileIconId = table.Column<int>(type: "int", nullable: false),
                    SummonerLevel = table.Column<long>(type: "bigint", nullable: false),
                    SoloTier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoloRank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoloLeaguePoints = table.Column<int>(type: "int", nullable: false),
                    SoloWins = table.Column<int>(type: "int", nullable: false),
                    SoloLosses = table.Column<int>(type: "int", nullable: false),
                    SoloHotStreak = table.Column<bool>(type: "bit", nullable: false),
                    FlexTier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlexRank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlexLeaguePoints = table.Column<int>(type: "int", nullable: false),
                    FlexWins = table.Column<int>(type: "int", nullable: false),
                    FlexLosses = table.Column<int>(type: "int", nullable: false),
                    FlexHotStreak = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Puuid);
                });

            migrationBuilder.CreateTable(
                name: "Runes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    RuneId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assists = table.Column<int>(type: "int", nullable: false),
                    ChampLevel = table.Column<int>(type: "int", nullable: false),
                    ChampionId = table.Column<int>(type: "int", nullable: false),
                    ChampionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageDealtToTurrets = table.Column<int>(type: "int", nullable: false),
                    DamageDealtToObjectives = table.Column<int>(type: "int", nullable: false),
                    Deaths = table.Column<int>(type: "int", nullable: false),
                    GoldEarned = table.Column<int>(type: "int", nullable: false),
                    GoldSpent = table.Column<int>(type: "int", nullable: false),
                    IndividualPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kills = table.Column<int>(type: "int", nullable: false),
                    Lane = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item0 = table.Column<int>(type: "int", nullable: false),
                    Item1 = table.Column<int>(type: "int", nullable: false),
                    Item2 = table.Column<int>(type: "int", nullable: false),
                    Item3 = table.Column<int>(type: "int", nullable: false),
                    Item4 = table.Column<int>(type: "int", nullable: false),
                    Item5 = table.Column<int>(type: "int", nullable: false),
                    Item6 = table.Column<int>(type: "int", nullable: false),
                    MagicDamageDealt = table.Column<int>(type: "int", nullable: false),
                    MagicDamageDealtToChampions = table.Column<int>(type: "int", nullable: false),
                    MagicDamageTaken = table.Column<int>(type: "int", nullable: false),
                    PhysicalDamageDealt = table.Column<int>(type: "int", nullable: false),
                    PhysicalDamageDealtToChampions = table.Column<int>(type: "int", nullable: false),
                    PhysicalDamageTaken = table.Column<int>(type: "int", nullable: false),
                    Puuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiotIdGameName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiotIdTagLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalDamageDealt = table.Column<int>(type: "int", nullable: false),
                    TotalDamageDealtToChampions = table.Column<int>(type: "int", nullable: false),
                    TotalDamageTaken = table.Column<int>(type: "int", nullable: false),
                    TotalMinionsKilled = table.Column<int>(type: "int", nullable: false),
                    TrueDamageDealt = table.Column<int>(type: "int", nullable: false),
                    TrueDamageDealtToChampions = table.Column<int>(type: "int", nullable: false),
                    TrueDamageTaken = table.Column<int>(type: "int", nullable: false),
                    Spell1Casts = table.Column<int>(type: "int", nullable: false),
                    Spell2Casts = table.Column<int>(type: "int", nullable: false),
                    Spell3Casts = table.Column<int>(type: "int", nullable: false),
                    Spell4Casts = table.Column<int>(type: "int", nullable: false),
                    Kda = table.Column<float>(type: "real", nullable: false),
                    VisionScore = table.Column<int>(type: "int", nullable: false),
                    LargestMultiKill = table.Column<int>(type: "int", nullable: false),
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    Win = table.Column<bool>(type: "bit", nullable: false),
                    StatRune0 = table.Column<int>(type: "int", nullable: false),
                    StatRune1 = table.Column<int>(type: "int", nullable: false),
                    StatRune2 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune0 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune0Stat0 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune0Stat1 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune0Stat2 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune1 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune1Stat0 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune1Stat1 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune1Stat2 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune2 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune2Stat0 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune2Stat1 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune2Stat2 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune3 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune3Stat0 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune3Stat1 = table.Column<int>(type: "int", nullable: false),
                    PrimaryRune3Stat2 = table.Column<int>(type: "int", nullable: false),
                    SecondaryRune0 = table.Column<int>(type: "int", nullable: false),
                    SecondaryRune0Stat0 = table.Column<int>(type: "int", nullable: false),
                    SecondaryRune0Stat1 = table.Column<int>(type: "int", nullable: false),
                    SecondaryRune0Stat2 = table.Column<int>(type: "int", nullable: false),
                    SecondaryRune1 = table.Column<int>(type: "int", nullable: false),
                    SecondaryRune1Stat0 = table.Column<int>(type: "int", nullable: false),
                    SecondaryRune1Stat1 = table.Column<int>(type: "int", nullable: false),
                    SecondaryRune1Stat2 = table.Column<int>(type: "int", nullable: false),
                    MatchLoLMatchId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_Matches_MatchLoLMatchId",
                        column: x => x.MatchLoLMatchId,
                        principalTable: "Matches",
                        principalColumn: "MatchId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_MatchLoLMatchId",
                table: "Participants",
                column: "MatchLoLMatchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Runes");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
