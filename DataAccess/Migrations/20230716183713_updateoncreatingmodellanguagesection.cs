using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class updateoncreatingmodellanguagesection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "da915b4e-ce9c-4940-9993-1d09e47a4002");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "db81bb12-6b4c-4132-9610-8ed69bc5c337");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2714118d-2e8d-4ddf-94c3-e5b5f6dceaa1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "3620bd79-71b7-4516-9d46-a21e27276afc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "72652e4d-7883-4f1a-8fab-cbbd3dea87e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "d139c389-113c-4066-b95c-9bc81150d74e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "6fbcec7b-814c-4f0b-97c1-1d3b5e6749bf");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "Name", "StartDate", "TagsName", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7821), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7823), "ku-Arab", new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7822), "Kurdish", "کوردی" });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "Name", "StartDate", "TagsName", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7827), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7829), "fa-IR", new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7828), "Farsi", "فارسی" });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "Name", "StartDate", "TagsName", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7832), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7835), "en-US", new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7834), "English", "English" });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7896), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7899), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7901), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7856), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7858), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7869), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7719), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7918), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7981), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7989), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7991), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7994), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7999), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8002), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8005), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8012), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8015), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8017), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8023), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8025), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8028), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8031), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8036), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8038), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8043), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8046), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8051), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8054), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8056), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8062), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8064), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8067), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8069), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8072), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8075), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8077), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8080), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8083), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8085), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8088), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8090), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8096), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8098), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8101), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8106), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8109), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8111), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8114), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8117), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(8116) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreateDate", "EndDate", "Name", "StartDate", "TagsName", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5305), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5308), "fa-IR", new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5306), "Farsi", "فارسی" });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "Name", "StartDate", "TagsName", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5312), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5315), "en-US", new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5313), "English", "انگلیسی" });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "Name", "StartDate", "TagsName", "Title" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5318), new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5320), "ku-Arab", new DateTime(2023, 7, 16, 20, 33, 5, 583, DateTimeKind.Local).AddTicks(5319), "Kurdish", "کوردی" });

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
    }
}
