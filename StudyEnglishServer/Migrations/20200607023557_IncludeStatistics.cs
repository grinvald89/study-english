using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyEnglishServer.Migrations
{
    public partial class IncludeStatistics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatisticsId",
                table: "Words",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountShow = table.Column<int>(nullable: false),
                    Correctness = table.Column<float>(nullable: false),
                    DateLastShow = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Words_StatisticsId",
                table: "Words",
                column: "StatisticsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Statistics_StatisticsId",
                table: "Words",
                column: "StatisticsId",
                principalTable: "Statistics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Words_Statistics_StatisticsId",
                table: "Words");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropIndex(
                name: "IX_Words_StatisticsId",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "StatisticsId",
                table: "Words");
        }
    }
}
