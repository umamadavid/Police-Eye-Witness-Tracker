using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Police_Eye_Witness_Tracker.Migrations
{
    public partial class AddEyeWitnessReportToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EyeWitnessReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NatureofIncidence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationofIncidence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncidenceReportNarration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EyeWitnessReports", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EyeWitnessReports");
        }
    }
}
