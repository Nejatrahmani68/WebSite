using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class updatePostClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_armyMembersAccounts_ArmyMembers_Id_ArmyMembers",
                table: "armyMembersAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_armyMembersAccounts_armySocialsNames_Id_ArmySocialsName",
                table: "armyMembersAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideos_armySocialsNames_ArmySocialsNameId",
                table: "SectionPostVideos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_armySocialsNames",
                table: "armySocialsNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_armyMembersAccounts",
                table: "armyMembersAccounts");

            migrationBuilder.RenameTable(
                name: "armySocialsNames",
                newName: "ArmySocialsNames");

            migrationBuilder.RenameTable(
                name: "armyMembersAccounts",
                newName: "ArmyMembersAccounts");

            migrationBuilder.RenameIndex(
                name: "IX_armyMembersAccounts_Id_ArmySocialsName",
                table: "ArmyMembersAccounts",
                newName: "IX_ArmyMembersAccounts_Id_ArmySocialsName");

            migrationBuilder.RenameIndex(
                name: "IX_armyMembersAccounts_Id_ArmyMembers",
                table: "ArmyMembersAccounts",
                newName: "IX_ArmyMembersAccounts_Id_ArmyMembers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArmySocialsNames",
                table: "ArmySocialsNames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArmyMembersAccounts",
                table: "ArmyMembersAccounts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ArmyPostDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Like = table.Column<bool>(type: "bit", nullable: false),
                    ShareAsPost = table.Column<bool>(type: "bit", nullable: false),
                    ShareAsStory = table.Column<bool>(type: "bit", nullable: false),
                    Twit = table.Column<bool>(type: "bit", nullable: false),
                    Save = table.Column<bool>(type: "bit", nullable: false),
                    CommentPssitive = table.Column<bool>(type: "bit", nullable: false),
                    CommentNegetive = table.Column<bool>(type: "bit", nullable: false),
                    Block = table.Column<bool>(type: "bit", nullable: false),
                    Report = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_ArmyPostDetails", x => x.Id);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ArmyMembersAccounts_ArmyMembers_Id_ArmyMembers",
                table: "ArmyMembersAccounts",
                column: "Id_ArmyMembers",
                principalTable: "ArmyMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_ArmyMembersAccounts_ArmySocialsNames_Id_ArmySocialsName",
                table: "ArmyMembersAccounts",
                column: "Id_ArmySocialsName",
                principalTable: "ArmySocialsNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideos_ArmySocialsNames_ArmySocialsNameId",
                table: "SectionPostVideos",
                column: "ArmySocialsNameId",
                principalTable: "ArmySocialsNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArmyMembersAccounts_ArmyMembers_Id_ArmyMembers",
                table: "ArmyMembersAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_ArmyMembersAccounts_ArmySocialsNames_Id_ArmySocialsName",
                table: "ArmyMembersAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideos_ArmySocialsNames_ArmySocialsNameId",
                table: "SectionPostVideos");

            migrationBuilder.DropTable(
                name: "ArmyPostDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArmySocialsNames",
                table: "ArmySocialsNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArmyMembersAccounts",
                table: "ArmyMembersAccounts");

            migrationBuilder.RenameTable(
                name: "ArmySocialsNames",
                newName: "armySocialsNames");

            migrationBuilder.RenameTable(
                name: "ArmyMembersAccounts",
                newName: "armyMembersAccounts");

            migrationBuilder.RenameIndex(
                name: "IX_ArmyMembersAccounts_Id_ArmySocialsName",
                table: "armyMembersAccounts",
                newName: "IX_armyMembersAccounts_Id_ArmySocialsName");

            migrationBuilder.RenameIndex(
                name: "IX_ArmyMembersAccounts_Id_ArmyMembers",
                table: "armyMembersAccounts",
                newName: "IX_armyMembersAccounts_Id_ArmyMembers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_armySocialsNames",
                table: "armySocialsNames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_armyMembersAccounts",
                table: "armyMembersAccounts",
                column: "Id");

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
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7821), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7823), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7827), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7829), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7832), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7835), new DateTime(2023, 7, 16, 20, 37, 13, 491, DateTimeKind.Local).AddTicks(7834) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_armyMembersAccounts_ArmyMembers_Id_ArmyMembers",
                table: "armyMembersAccounts",
                column: "Id_ArmyMembers",
                principalTable: "ArmyMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_armyMembersAccounts_armySocialsNames_Id_ArmySocialsName",
                table: "armyMembersAccounts",
                column: "Id_ArmySocialsName",
                principalTable: "armySocialsNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideos_armySocialsNames_ArmySocialsNameId",
                table: "SectionPostVideos",
                column: "ArmySocialsNameId",
                principalTable: "armySocialsNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
