using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarManagement.Database.EFCore.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfrenceRomes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfrenceRomes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seminars",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    LengthOfTIME = table.Column<int>(nullable: false),
                    ConfrenceRomeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seminars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seminars_ConfrenceRomes_ConfrenceRomeId",
                        column: x => x.ConfrenceRomeId,
                        principalTable: "ConfrenceRomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lecturs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Topic = table.Column<string>(nullable: true),
                    Lecturer = table.Column<string>(nullable: true),
                    StartAt = table.Column<DateTime>(nullable: false),
                    EndAt = table.Column<DateTime>(nullable: false),
                    SeminarId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lecturs_Seminars_SeminarId",
                        column: x => x.SeminarId,
                        principalTable: "Seminars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lecturs_SeminarId",
                table: "Lecturs",
                column: "SeminarId");

            migrationBuilder.CreateIndex(
                name: "IX_Seminars_ConfrenceRomeId",
                table: "Seminars",
                column: "ConfrenceRomeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lecturs");

            migrationBuilder.DropTable(
                name: "Seminars");

            migrationBuilder.DropTable(
                name: "ConfrenceRomes");
        }
    }
}
