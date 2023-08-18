using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class AddFileModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.CreateTable(
                name: "SectionPostFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_SectionPostStep = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TagsName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionPostFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionPostFile_SectionPostSteps_Id_SectionPostStep",
                        column: x => x.Id_SectionPostStep,
                        principalTable: "SectionPostSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "623f6767-6d00-42d2-8191-35160d46556f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "515e934c-64a7-4010-96cf-de95abdc90ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "739c371c-b349-41e5-bf79-11d930034337");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "2bbe05d0-fabb-4f50-920a-ad3cd9a50291");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "49079709-01a5-4d8a-8e59-8906a37ee021");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "c82c87f3-bf10-4332-8cf2-9b049f5633f5");

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2858), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2863), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2883), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2889), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2794), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2800), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2807), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2812), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2588), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2599), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2924), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2945), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2952), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2958), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2965), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2976), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2982), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2988), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2994), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3005), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3011), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3017), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3023), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3029), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3035), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3040), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3046), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3052), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3058), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3063), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3075), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3087), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3093), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3099), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3105), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3117), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3122), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3128), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3134), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3145), new DateTime(2022, 11, 27, 15, 38, 7, 39, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostFile_Id_SectionPostStep",
                table: "SectionPostFile",
                column: "Id_SectionPostStep");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionPostFile");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "12f1e5f7-3ada-4b32-b567-36121c1288a1", "nejatrahmani68@gmail.com", true, false, null, "NEJATRAHMANI68@GMAIL.COM", "NEJATRAHMANI68", "AQAAAAEAACcQAAAAEKKhMm7G+AeXU9x9ADvYCx+QL+pvjoSEeoUQu5MDdOdFVCW50/zmP7Lzaz9ccskrkQ==", "009647821765944", true, "4c21ffdb-b566-4274-8e4d-c75447b8f942", false, "nejatrahmani68" });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(746), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(752), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(760), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(766), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(773), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(779), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(683), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(690), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(699), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(706), new DateTime(2022, 11, 27, 15, 17, 59, 159, DateTimeKind.Local).AddTicks(703) });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }
    }
}
