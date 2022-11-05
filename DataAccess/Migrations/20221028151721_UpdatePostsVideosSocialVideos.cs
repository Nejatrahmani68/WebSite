using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class UpdatePostsVideosSocialVideos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostSteps_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostSteps");

            migrationBuilder.DropIndex(
                name: "IX_SectionPostSteps_Id_SectionPostSocialVideo",
                table: "SectionPostSteps");

            migrationBuilder.DropColumn(
                name: "Id_SectionPostSocialVideo",
                table: "SectionPostSteps");

            migrationBuilder.DropColumn(
                name: "VideoAddress",
                table: "SectionPostSteps");

            migrationBuilder.AddColumn<int>(
                name: "Id_SectionPostSocialVideo",
                table: "SectionPostVideo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostVideo_Id_SectionPostSocialVideo",
                table: "SectionPostVideo",
                column: "Id_SectionPostSocialVideo");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideo_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideo",
                column: "Id_SectionPostSocialVideo",
                principalTable: "SectionPostSocialVideos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideo_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideo");

            migrationBuilder.DropIndex(
                name: "IX_SectionPostVideo_Id_SectionPostSocialVideo",
                table: "SectionPostVideo");

            migrationBuilder.DropColumn(
                name: "Id_SectionPostSocialVideo",
                table: "SectionPostVideo");

            migrationBuilder.AddColumn<int>(
                name: "Id_SectionPostSocialVideo",
                table: "SectionPostSteps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VideoAddress",
                table: "SectionPostSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostSteps_Id_SectionPostSocialVideo",
                table: "SectionPostSteps",
                column: "Id_SectionPostSocialVideo");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostSteps_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostSteps",
                column: "Id_SectionPostSocialVideo",
                principalTable: "SectionPostSocialVideos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
