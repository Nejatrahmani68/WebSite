using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class UpdatePostImagesForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostSteps_SectionPostImages_Id_SectionPostImage",
                table: "SectionPostSteps");

            migrationBuilder.DropIndex(
                name: "IX_SectionPostSteps_Id_SectionPostImage",
                table: "SectionPostSteps");

            migrationBuilder.DropColumn(
                name: "Id_SectionPostImage",
                table: "SectionPostSteps");

            migrationBuilder.AddColumn<int>(
                name: "Id_SectionPostStep",
                table: "SectionPostImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostImages_Id_SectionPostStep",
                table: "SectionPostImages",
                column: "Id_SectionPostStep");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostImages_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostImages",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostImages_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostImages");

            migrationBuilder.DropIndex(
                name: "IX_SectionPostImages_Id_SectionPostStep",
                table: "SectionPostImages");

            migrationBuilder.DropColumn(
                name: "Id_SectionPostStep",
                table: "SectionPostImages");

            migrationBuilder.AddColumn<int>(
                name: "Id_SectionPostImage",
                table: "SectionPostSteps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostSteps_Id_SectionPostImage",
                table: "SectionPostSteps",
                column: "Id_SectionPostImage");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostSteps_SectionPostImages_Id_SectionPostImage",
                table: "SectionPostSteps",
                column: "Id_SectionPostImage",
                principalTable: "SectionPostImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
