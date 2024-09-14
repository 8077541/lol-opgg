using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace opggApi.Migrations
{
    /// <inheritdoc />
    public partial class participantUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune0",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune0Stat0",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune0Stat1",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune0Stat2",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune1",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune1Stat0",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune1Stat1",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune1Stat2",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune2",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune2Stat0",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune2Stat1",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune2Stat2",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryRune0",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryRune0Stat0",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryRune0Stat1",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryRune0Stat2",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryRune1",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryRune1Stat0",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryRune1Stat1",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryRune1Stat2",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatRune0",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatRune1",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatRune2",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryRune0",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune0Stat0",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune0Stat1",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune0Stat2",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune1",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune1Stat0",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune1Stat1",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune1Stat2",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune2",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune2Stat0",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune2Stat1",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune2Stat2",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "SecondaryRune0",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "SecondaryRune0Stat0",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "SecondaryRune0Stat1",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "SecondaryRune0Stat2",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "SecondaryRune1",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "SecondaryRune1Stat0",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "SecondaryRune1Stat1",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "SecondaryRune1Stat2",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "StatRune0",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "StatRune1",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "StatRune2",
                table: "Participants");
        }
    }
}
