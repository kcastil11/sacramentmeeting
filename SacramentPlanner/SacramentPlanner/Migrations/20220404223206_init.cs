using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeakerSubjects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBishopric = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpeningSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentHymn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConductingLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusicalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingPrayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Program");
        }
    }
}
