using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class UpdateEmailandTagNamesandAdminTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "WebsiteThemControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "WebsiteThemControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "WebsiteActiveTimeControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "WebsiteActiveTimeControls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SectionThirdSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "SectionThirdSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SectionSecondSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "SectionSecondSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SectionPostTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "SectionPostTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SectionPostSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "SectionPostSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SectionPostSocialVideos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "SectionPostSocialVideos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SectionPostImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "SectionPostImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SectionPostCommentSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "SectionPostCommentSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SectionPostAnswerSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "SectionPostAnswerSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SectionFirstSteps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagsName",
                table: "SectionFirstSteps",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "WebsiteThemControls");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "WebsiteThemControls");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "WebsiteActiveTimeControls");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "WebsiteActiveTimeControls");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SectionThirdSteps");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "SectionThirdSteps");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SectionSecondSteps");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "SectionSecondSteps");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SectionPostTypes");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "SectionPostTypes");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SectionPostSteps");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "SectionPostSteps");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SectionPostSocialVideos");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "SectionPostSocialVideos");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SectionPostImages");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "SectionPostImages");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SectionPostCommentSteps");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "SectionPostCommentSteps");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SectionPostAnswerSteps");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "SectionPostAnswerSteps");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SectionFirstSteps");

            migrationBuilder.DropColumn(
                name: "TagsName",
                table: "SectionFirstSteps");
        }
    }
}
