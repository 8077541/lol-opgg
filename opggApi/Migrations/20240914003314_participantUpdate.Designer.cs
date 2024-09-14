﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using opggApi.Data;

#nullable disable

namespace opggApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240914003314_participantUpdate")]
    partial class participantUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("opggApi.Models.MatchLoL", b =>
                {
                    b.Property<string>("MatchId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("GameCreation")
                        .HasColumnType("bigint");

                    b.Property<long>("GameDuration")
                        .HasColumnType("bigint");

                    b.Property<long>("GameEndTimeStamp")
                        .HasColumnType("bigint");

                    b.Property<long>("GameId")
                        .HasColumnType("bigint");

                    b.Property<string>("GameMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("GameStartTimeStamp")
                        .HasColumnType("bigint");

                    b.Property<string>("GameType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MapId")
                        .HasColumnType("int");

                    b.Property<string>("PlatformId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QueueId")
                        .HasColumnType("int");

                    b.HasKey("MatchId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("opggApi.Models.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("ChampLevel")
                        .HasColumnType("int");

                    b.Property<int>("ChampionId")
                        .HasColumnType("int");

                    b.Property<string>("ChampionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DamageDealtToObjectives")
                        .HasColumnType("int");

                    b.Property<int>("DamageDealtToTurrets")
                        .HasColumnType("int");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<int>("GoldEarned")
                        .HasColumnType("int");

                    b.Property<int>("GoldSpent")
                        .HasColumnType("int");

                    b.Property<string>("IndividualPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Item0")
                        .HasColumnType("int");

                    b.Property<int>("Item1")
                        .HasColumnType("int");

                    b.Property<int>("Item2")
                        .HasColumnType("int");

                    b.Property<int>("Item3")
                        .HasColumnType("int");

                    b.Property<int>("Item4")
                        .HasColumnType("int");

                    b.Property<int>("Item5")
                        .HasColumnType("int");

                    b.Property<int>("Item6")
                        .HasColumnType("int");

                    b.Property<float>("Kda")
                        .HasColumnType("real");

                    b.Property<int>("Kills")
                        .HasColumnType("int");

                    b.Property<string>("Lane")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LargestMultiKill")
                        .HasColumnType("int");

                    b.Property<int>("MagicDamageDealt")
                        .HasColumnType("int");

                    b.Property<int>("MagicDamageDealtToChampions")
                        .HasColumnType("int");

                    b.Property<int>("MagicDamageTaken")
                        .HasColumnType("int");

                    b.Property<string>("MatchLoLMatchId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int>("PhysicalDamageDealt")
                        .HasColumnType("int");

                    b.Property<int>("PhysicalDamageDealtToChampions")
                        .HasColumnType("int");

                    b.Property<int>("PhysicalDamageTaken")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune0")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune0Stat0")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune0Stat1")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune0Stat2")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune1")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune1Stat0")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune1Stat1")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune1Stat2")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune2")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune2Stat0")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune2Stat1")
                        .HasColumnType("int");

                    b.Property<int>("PrimaryRune2Stat2")
                        .HasColumnType("int");

                    b.Property<string>("Puuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RiotIdGameName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RiotIdTagLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SecondaryRune0")
                        .HasColumnType("int");

                    b.Property<int>("SecondaryRune0Stat0")
                        .HasColumnType("int");

                    b.Property<int>("SecondaryRune0Stat1")
                        .HasColumnType("int");

                    b.Property<int>("SecondaryRune0Stat2")
                        .HasColumnType("int");

                    b.Property<int>("SecondaryRune1")
                        .HasColumnType("int");

                    b.Property<int>("SecondaryRune1Stat0")
                        .HasColumnType("int");

                    b.Property<int>("SecondaryRune1Stat1")
                        .HasColumnType("int");

                    b.Property<int>("SecondaryRune1Stat2")
                        .HasColumnType("int");

                    b.Property<int>("Spell1Casts")
                        .HasColumnType("int");

                    b.Property<int>("Spell2Casts")
                        .HasColumnType("int");

                    b.Property<int>("Spell3Casts")
                        .HasColumnType("int");

                    b.Property<int>("Spell4Casts")
                        .HasColumnType("int");

                    b.Property<int>("StatRune0")
                        .HasColumnType("int");

                    b.Property<int>("StatRune1")
                        .HasColumnType("int");

                    b.Property<int>("StatRune2")
                        .HasColumnType("int");

                    b.Property<int>("TotalDamageDealt")
                        .HasColumnType("int");

                    b.Property<int>("TotalDamageDealtToChampions")
                        .HasColumnType("int");

                    b.Property<int>("TotalDamageTaken")
                        .HasColumnType("int");

                    b.Property<int>("TotalMinionsKilled")
                        .HasColumnType("int");

                    b.Property<int>("TrueDamageDealt")
                        .HasColumnType("int");

                    b.Property<int>("TrueDamageDealtToChampions")
                        .HasColumnType("int");

                    b.Property<int>("TrueDamageTaken")
                        .HasColumnType("int");

                    b.Property<int>("VisionScore")
                        .HasColumnType("int");

                    b.Property<bool>("Win")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MatchLoLMatchId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("opggApi.Models.Profile", b =>
                {
                    b.Property<string>("Puuid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FlexHotStreak")
                        .HasColumnType("bit");

                    b.Property<int>("FlexLeaguePoints")
                        .HasColumnType("int");

                    b.Property<int>("FlexLosses")
                        .HasColumnType("int");

                    b.Property<string>("FlexRank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlexTier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlexWins")
                        .HasColumnType("int");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileIconId")
                        .HasColumnType("int");

                    b.Property<bool>("SoloHotStreak")
                        .HasColumnType("bit");

                    b.Property<int>("SoloLeaguePoints")
                        .HasColumnType("int");

                    b.Property<int>("SoloLosses")
                        .HasColumnType("int");

                    b.Property<string>("SoloRank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoloTier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoloWins")
                        .HasColumnType("int");

                    b.Property<string>("SummonerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SummonerLevel")
                        .HasColumnType("bigint");

                    b.Property<string>("TagLine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Puuid");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("opggApi.Models.Participant", b =>
                {
                    b.HasOne("opggApi.Models.MatchLoL", null)
                        .WithMany("Participants")
                        .HasForeignKey("MatchLoLMatchId");
                });

            modelBuilder.Entity("opggApi.Models.MatchLoL", b =>
                {
                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}
