using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class ImpementDatabaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostAnswerStep_SectionPostSteps_SectionPostStepId",
                table: "SectionPostAnswerStep");

            migrationBuilder.DropIndex(
                name: "IX_SectionPostAnswerStep_SectionPostStepId",
                table: "SectionPostAnswerStep");

            migrationBuilder.DropColumn(
                name: "SectionPostStepId",
                table: "SectionPostAnswerStep");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionPostStepId",
                table: "SectionPostAnswerStep",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostAnswerStep_SectionPostStepId",
                table: "SectionPostAnswerStep",
                column: "SectionPostStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostAnswerStep_SectionPostSteps_SectionPostStepId",
                table: "SectionPostAnswerStep",
                column: "SectionPostStepId",
                principalTable: "SectionPostSteps",
                principalColumn: "Id");
        }
    }
}
