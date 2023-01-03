using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class AddWriterNameToPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WriterName",
                table: "SectionPostSteps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2e2d86e6-bd3f-48c5-ab13-48d9fff8809b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "554d8bbb-f311-414a-bea7-31d03af401e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6df6a3da-a960-4988-a1b4-054c8ec296b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "03055b82-0a92-4a84-8c01-a281e42f5a69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "a25e517d-c14b-4470-98d7-290ef8500795");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "984b0a1c-bf7d-4833-b313-c2720beef5eb");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7749), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7759), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7772), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7783), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7796), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7806), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8018), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8027), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8040), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8049), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8060), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8070), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7892), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7902), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7915), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7924), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7934), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7948), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7338), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7354), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8140), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8148), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8159), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8168), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8178), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8186), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8198), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8208), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8220), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8231), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8242), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8251), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8263), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8273), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8286), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8296), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8306), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8316), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8326), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8335), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8346), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8356), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8366), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8375), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8386), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8395), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8406), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8415), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8426), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8435), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8446), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8455), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8465), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8475), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8485), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8494), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8505), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8514), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8524), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8533), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8544), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8554), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8564), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8573), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8584), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8593), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8604), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8613), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8624), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8633), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.InsertData(
                table: "WebsiteThemControls",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "SectionName", "StartDate", "TagsName", "Timable" },
                values: new object[] { 26, true, new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8644), "NejatRahmani68@gmail.com", new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8653), "SlideShow", new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8649), "SlideShow", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DropColumn(
                name: "WriterName",
                table: "SectionPostSteps");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "23f8c198-6288-41b7-acf5-8111c4bfe7b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "06336fd7-d9a7-4ac3-8710-2225bf4afa77");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2de67e56-6937-4234-8b6d-e36f7f9993c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "090ed6e7-660f-4219-8da3-5e1d14132c36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "4c615c49-de40-4cbd-baf1-499552a8b3f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "e81a14f8-b946-497a-bfb2-aed8240e2621");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1585), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1591), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1597), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1603), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1608), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1614), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1718), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1724), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1730), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1735), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1741), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1746), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1654), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1659), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1667), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1672), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1678), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1684), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1407), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1417), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1779), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1785), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1791), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1796), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1802), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1808), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1814), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1819), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1825), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1830), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1836), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1842), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1847), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1853), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1859), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1864), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1870), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1875), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1882), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1887), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1893), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1899), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1904), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1910), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1916), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1921), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1927), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1939), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1944), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1955), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1961), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1966), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1972), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1977), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1983), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1989), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1994), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2000), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2006), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2011), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2018), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2023), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2029), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2035), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2041), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2046), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2087), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2092), new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2089) });
        }
    }
}
