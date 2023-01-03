using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class AddTitleLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "SectionLanguages",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "WebsiteThemControls",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "SectionName", "StartDate", "TagsName", "Timable" },
                values: new object[] { 25, true, new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2087), "NejatRahmani68@gmail.com", new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2092), "NavBarSticky", new DateTime(2022, 12, 7, 2, 0, 9, 470, DateTimeKind.Local).AddTicks(2089), "NavBarSticky", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DropColumn(
                name: "Title",
                table: "SectionLanguages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9c2343fe-12e7-4648-95e6-a6445f2bb9d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c328cdb9-4f12-4d9f-bc55-d8a91c28add4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "8f03ecd7-5e8e-4dcf-9e6b-d32325c24e16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7dfb7746-cc7f-4e29-8e01-be24ef81209c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "1afb63e5-117d-43e5-9e58-59527ba74930");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "fb7b8b8c-1fd2-42ce-90b3-9925965d85dd");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5476), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5482), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5491), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5496), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5502), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5507), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5603), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5608), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5616), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5621), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5627), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5633), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5542), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5548), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5554), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5559), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5565), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5288), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5298), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5665), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5677), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5683), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5689), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5694), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5705), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5711), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5716), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5722), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5728), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5733), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5739), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5755), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5761), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5767), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5772), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5778), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5784), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5795), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5801), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5806), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5812), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5818), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5823), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5829), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5834), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5846), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5851), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5857), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5862), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5868), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5873), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5879), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5884), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5890), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5896), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5902), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5907), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5913), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5919), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5925), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5936), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5941), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5939) });
        }
    }
}
