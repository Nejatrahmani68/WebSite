using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class UpdatePostFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileSize",
                table: "SectionPostFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "SectionPostFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "04290e25-7236-4378-9964-fedfe57c6448");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "76fd1c4b-2e24-4c11-acc7-eff473f516cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7ddbfb8e-8876-40e6-807c-ae328b088911");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7c094cf3-04b4-4b89-858f-309f5a08e4fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "a79b0716-bf7a-4359-9620-dd518f6f58ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "bf43f66b-1ad1-436a-be4c-153e5ce097ee");

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5639), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5652), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5656), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5661), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5526), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5539), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5552), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5562), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5568), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5345), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5353), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5711), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5761), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5768), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5773), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5778), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5783), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5788), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5792), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5797), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5802), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5807), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5811), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5816), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5821), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5827), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5831), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5841), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5845), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5851), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5855), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5864), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5869), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5874), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5878), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5883), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5888), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5892), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5897), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5902), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5906), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5911), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5916), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5925), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5929), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5934), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5938), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5936) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "SectionPostFiles");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "SectionPostFiles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2a763415-38e1-48a3-9465-d16345450769");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "807be8c7-63dc-49e8-9241-b3e41735771a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "14eed651-6d5a-4240-963c-1dc05aeb81f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "44af2401-fce7-4e94-81be-978c160d1dfa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "6d99e406-2ee3-4fee-a558-03cfebe64777");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "7c9b3941-5772-4a76-b72a-075b99044c77");

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8360), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8366), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8372), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8377), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8384), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8389), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8295), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8302), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8308), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8314), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8320), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8326), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8098), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8107), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8423), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8429), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8435), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8446), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8451), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8457), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8463), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8468), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8474), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8485), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8491), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8496), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8502), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8508), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8513), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8519), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8525), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8536), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8541), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8547), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8552), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8558), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8564), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8575), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8581), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8586), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8592), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8597), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8603), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8609), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8615), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8626), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8631), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8629) });
        }
    }
}
