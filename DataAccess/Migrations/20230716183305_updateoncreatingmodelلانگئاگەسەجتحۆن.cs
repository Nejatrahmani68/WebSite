using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class updateoncreatingmodelلانگئاگەسەجتحۆن : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2b6dcd5a-f917-4b78-aa78-3e27896c3db4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "fb999c46-0267-49f5-9b9f-8839815a823b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a553fdfe-c52c-48ad-aed7-e31a91909e38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7185d398-1d99-47f0-add1-b3119e0fbd4c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "b8be6209-02df-4336-9f56-d2874965d7e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "5edcd4c7-2343-44be-9f3d-9d3c19292d49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "b697d6e0-7f5a-43e4-8efb-5aae65ebd95f");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5305), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5308), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5306), "فارسی" });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5312), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5313), "انگلیسی" });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5318), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5319), "کوردی" });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5371), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5373), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5377), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5379), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5382), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5385), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5338), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5341), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5344), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5347), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5352), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5196), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5402), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5404), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5407), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5410), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5413), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5416), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5421), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5424), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5427), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5432), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5438), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5443), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5446), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5449), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5496), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5499), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5502), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5505), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5507), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5513), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5519), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5521), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5524), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5533), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5535), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5538), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5541), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5547), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5549), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5555), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5558), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5561), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5564), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5566), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5569), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5572), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5583), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5586), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5589), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5592), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5594), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5597), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5603), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5611), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5614), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5615) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3d6dc1f2-d99b-461d-afcd-ae935b6c0b23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6ae3b037-bf3f-4b4c-aaad-cc06e91b0d78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "44c435e3-0dd7-4284-b5c6-b392651fc17c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "99157fc6-729e-448c-9934-bf9ab75ead29");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "97b7ad4c-ec50-47fe-a452-863be689057e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "ee6020aa-9b63-408c-a484-dabcabb042de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "1eabb3c5-f2e6-4d8b-b4fb-1904c6d678b9");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6619), null });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6625), null });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6629), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6632), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6631), null });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6728), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6733), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6736), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6739), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6649), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6652), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6658), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6762), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6765), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6768), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6773), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6778), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6781), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6784), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6786), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6789), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6792), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6794), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6797), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6802), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6807), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6816), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6827), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6830), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6838), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6843), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6846), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6848), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6851), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6854), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6859), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6864), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6875), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6878), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6883), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6886), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6889), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6891), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6894), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6896), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6899), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6902), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6904), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6907), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6912), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6915), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6917), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6916) });
        }
    }
}
