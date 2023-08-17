using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class updateroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f0fb04b5-f3bf-4a05-a9ee-df944436b70f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f4b0a0db-0759-45b1-8145-eb970adb083e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "293e56d0-9ca7-49fb-8545-9698c7856195");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "0958175f-b0b8-490d-848a-85853e3c042b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "1ffd4054-15a1-453a-a322-a8db122f31ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "0ebc169e-4233-49f5-933f-249fc1431db0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "33f56ccf-9b28-46f5-86dc-72fee35f1431");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8", "d3b7338b-ce43-46e8-b83c-80aa465fbeb6", "ArmyAdminRegister", "ARMYADMINREGISTER" },
                    { "9", "2a1f9d45-e56c-4862-8bc9-0874c701e878", "ArmyAdminBotControl", "ARMYADMINBOTCONTROL" }
                });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(467), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(470), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(482), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(485), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(545), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(548), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(551), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(554), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(557), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(559), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(506), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(509), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(513), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(516), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(349), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(578), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(581), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(584), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(587), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(590), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(592), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(595), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(598), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(601), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(603), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(606), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(609), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(612), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(614), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(617), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(620), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(622), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(625), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(628), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(631), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(633), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(636), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(639), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(641), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(644), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(647), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(650), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(652), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(655), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(658), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(661), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(663), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(666), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(669), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(671), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(674), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(677), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(680), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(682), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(685), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(688), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(690), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(693), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(696), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(699), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(701), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(704), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(707), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(709), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(712), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(716), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(718), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(721), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(724), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(727), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(729), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(732), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(735), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(737), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(740), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(743), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(745), new DateTime(2023, 7, 18, 17, 11, 5, 794, DateTimeKind.Local).AddTicks(744) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "412d373f-f4a0-4b17-81a6-8bd343957664");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "eb8a3201-9608-45c6-bd79-d99047a96677");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0a818b0b-c484-4591-b2e3-9e11e569c4df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "a1e5201f-4f16-41d4-9bf6-53b8f4df51bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "3d3110a1-532b-4638-a254-8e86d9500744");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "4a496b0b-adf8-40b0-8117-61d6b2c7e5f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "6ac151ea-2199-44b2-a37d-6cad9ec678ba");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3147), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3150), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3153), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3156), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3159), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3162), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3221), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3224), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3226), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3232), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3182), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3188), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3190), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3193), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3034), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3301), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3304), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3307), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3309), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3315), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3317), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3320), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3325), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3328), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3331), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3336), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3339), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3341), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3344), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3347), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3350), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3352), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3355), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3358), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3360), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3363), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3366), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3368), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3371), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3373), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3376), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3379), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3382), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3384), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3387), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3389), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3393), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3395), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3398), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3401), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3404), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3406), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3409), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3412), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3417), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3422), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3427), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3430), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3433), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3438), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3441), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3443), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3449), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3451), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3457), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3462), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3465), new DateTime(2023, 7, 16, 22, 22, 9, 191, DateTimeKind.Local).AddTicks(3463) });
        }
    }
}
