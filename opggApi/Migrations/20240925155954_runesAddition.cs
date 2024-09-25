using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace opggApi.Migrations
{
    /// <inheritdoc />
    public partial class runesAddition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune3",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune3Stat0",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune3Stat1",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrimaryRune3Stat2",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryRune3",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune3Stat0",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune3Stat1",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PrimaryRune3Stat2",
                table: "Participants");
        }
    }
}
