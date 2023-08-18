using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class SeedDataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "55467a47-5e7e-472c-b8a2-a6977deec46c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6c33c75c-554a-4a50-9f3e-2533eb457500");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1a291ef7-134f-4ae0-8fce-d0976794223f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "120c4398-0d15-41f5-aea5-cf4ca5d1a685");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "d5b724d7-e285-4a37-ad5b-170108af5758");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "5219747d-5d53-44fb-86bd-64d29c795e33");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12f1e5f7-3ada-4b32-b567-36121c1288a1", "AQAAAAEAACcQAAAAEKKhMm7G+AeXU9x9ADvYCx+QL+pvjoSEeoUQu5MDdOdFVCW50/zmP7Lzaz9ccskrkQ==", "4c21ffdb-b566-4274-8e4d-c75447b8f942" });

            migrationBuilder.InsertData(
                table: "SectionPostSocialVideos",
                columns: new[] { "Id", "Active", "Address", "CreateDate", "Email", "EndDate", "StartDate", "TagsName", "Timable", "Title" },
                values: new object[,]
                {
                    { 1, true, "", new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(746), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(752), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(749), "یوتیوب", false, "Youtube" },
                    { 2, true, "", new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(760), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(766), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(763), "فەیسبوک", false, "FaceBook" },
                    { 3, true, "", new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(773), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(779), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(776), "تێلێگرام", false, "Telegram" }
                });

            migrationBuilder.InsertData(
                table: "SectionPostTypes",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "StartDate", "TagsName", "Timable", "Title" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(683), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(690), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(687), "نوسراوە", false, "Article" },
                    { 2, true, new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(699), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(706), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(703), "ویدیۆ", false, "Video" }
                });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(461), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(472), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(813), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(819), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(827), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(833), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(841), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(847), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(854), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(860), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(867), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(873), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(880), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(886), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(893), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(899), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(906), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(912), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(919), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(925), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(932), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(938), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(945), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(951), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(958), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(964), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(971), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(977), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(984), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(990), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1053), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1059), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1066), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1072), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1079), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1085), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1092), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1098), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1105), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1111), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(1108) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1e1c93ca-228d-4a06-bba7-322eb32f7195");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c0526c9a-6122-4f56-ade5-f342f6164fd1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7c493ebf-afbd-4b8b-9d24-09dffd0f6ad5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "c2a1e623-e630-498d-8a83-04f7569275e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "f89533cc-f9c9-41c6-aabc-c99829e0126b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "95dda468-c061-4a24-89d2-dff37888e004");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b54873bc-f189-4927-8a1e-0ac6b5eabd2d", "80a514245aadb1114e85d4d7d3e578b32783559bb5a33a17d29095e454800dcf", "9e461725-2731-4a15-b97e-bfaef43952e6" });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8761), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8902), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8906), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8917), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8921), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8925), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8929), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8934), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8938), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8942), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8946), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8954), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8959), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8963), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8967), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8971), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8975), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8979), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8984), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8988), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8992), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8996), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9001), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9005), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9009), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9013), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9017), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9021), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9026), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9034), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9038), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9042), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9046), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9051), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9055), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9059), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9063), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9061) });
        }
    }
}
