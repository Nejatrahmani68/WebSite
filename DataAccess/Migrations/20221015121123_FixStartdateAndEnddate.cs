using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class FixStartdateAndEnddate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "WebsiteThemControls");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "WebsiteThemControls");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "WebsiteActiveTimeControls");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "WebsiteActiveTimeControls");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "SectionThirdSteps");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "SectionThirdSteps");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "SectionSecondSteps");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "SectionSecondSteps");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "SectionPostTypes");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "SectionPostTypes");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "SectionPostSteps");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "SectionPostSteps");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "SectionPostSocialVideos");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "SectionPostSocialVideos");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "SectionPostImages");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "SectionPostImages");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "SectionPostCommentSteps");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "SectionPostCommentSteps");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "SectionPostAnswerSteps");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "SectionPostAnswerSteps");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "SectionFirstSteps");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "SectionFirstSteps");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "WebsiteThemControls",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "WebsiteThemControls",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "WebsiteActiveTimeControls",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "WebsiteActiveTimeControls",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "SectionThirdSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "SectionThirdSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "SectionSecondSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "SectionSecondSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "SectionPostTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "SectionPostTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "SectionPostSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "SectionPostSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "SectionPostSocialVideos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "SectionPostSocialVideos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "SectionPostImages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "SectionPostImages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "SectionPostCommentSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "SectionPostCommentSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "SectionPostAnswerSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "SectionPostAnswerSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "SectionFirstSteps",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "SectionFirstSteps",
                type: "datetime2",
                nullable: true);
        }
    }
}
