using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class AddViewNumberPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideo_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideo");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideo_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostVideo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SectionPostVideo",
                table: "SectionPostVideo");

            migrationBuilder.RenameTable(
                name: "SectionPostVideo",
                newName: "SectionPostVideos");

            migrationBuilder.RenameIndex(
                name: "IX_SectionPostVideo_Id_SectionPostStep",
                table: "SectionPostVideos",
                newName: "IX_SectionPostVideos_Id_SectionPostStep");

            migrationBuilder.RenameIndex(
                name: "IX_SectionPostVideo_Id_SectionPostSocialVideo",
                table: "SectionPostVideos",
                newName: "IX_SectionPostVideos_Id_SectionPostSocialVideo");

            migrationBuilder.AddColumn<int>(
                name: "ViewsNumber",
                table: "SectionPostSteps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SectionPostVideos",
                table: "SectionPostVideos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideos_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideos",
                column: "Id_SectionPostSocialVideo",
                principalTable: "SectionPostSocialVideos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideos_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostVideos",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideos_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideos");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideos_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostVideos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SectionPostVideos",
                table: "SectionPostVideos");

            migrationBuilder.DropColumn(
                name: "ViewsNumber",
                table: "SectionPostSteps");

            migrationBuilder.RenameTable(
                name: "SectionPostVideos",
                newName: "SectionPostVideo");

            migrationBuilder.RenameIndex(
                name: "IX_SectionPostVideos_Id_SectionPostStep",
                table: "SectionPostVideo",
                newName: "IX_SectionPostVideo_Id_SectionPostStep");

            migrationBuilder.RenameIndex(
                name: "IX_SectionPostVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideo",
                newName: "IX_SectionPostVideo_Id_SectionPostSocialVideo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SectionPostVideo",
                table: "SectionPostVideo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideo_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideo",
                column: "Id_SectionPostSocialVideo",
                principalTable: "SectionPostSocialVideos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideo_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostVideo",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
