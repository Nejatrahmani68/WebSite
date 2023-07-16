using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class AddArmyClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArmySocialsNameId",
                table: "SectionPostVideos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArmyMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TellNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ArmyMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "armySocialsNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_armySocialsNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "armyMembersAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_ArmySocialsName = table.Column<int>(type: "int", nullable: true),
                    SocialAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_ArmyMembers = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_armyMembersAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_armyMembersAccounts_ArmyMembers_Id_ArmyMembers",
                        column: x => x.Id_ArmyMembers,
                        principalTable: "ArmyMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_armyMembersAccounts_armySocialsNames_Id_ArmySocialsName",
                        column: x => x.Id_ArmySocialsName,
                        principalTable: "armySocialsNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5ef87897-d10c-4a4e-a70e-29d711af49ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6effd0ef-ae91-4b48-be54-8967a8aae864");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0b7d7291-efc7-423d-9e02-417ef8aeec4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "0840e46b-eca0-4116-8df7-6fedb6d8fdf9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "252133a9-bf47-43c8-8e5a-637b34a2dfaa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "d4bd3db1-5f66-4c08-87d9-8e7665201811");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2474), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2480), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2483), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2485), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2533), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2538), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2501), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2503), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2509), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2511), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2514), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2361), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2366), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2579), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2585), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2587), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2590), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2593), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2595), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2598), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2603), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2605), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2608), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2611), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2613), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2616), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2618), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2621), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2626), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2628), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2631), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2633), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2636), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2638), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2641), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2646), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2648), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2651), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2653), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2656), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2661), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2664), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2666), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2669), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2671), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2676), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2679), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2681), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2684), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2689), new DateTime(2023, 7, 15, 14, 7, 26, 177, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostVideos_ArmySocialsNameId",
                table: "SectionPostVideos",
                column: "ArmySocialsNameId");

            migrationBuilder.CreateIndex(
                name: "IX_armyMembersAccounts_Id_ArmyMembers",
                table: "armyMembersAccounts",
                column: "Id_ArmyMembers");

            migrationBuilder.CreateIndex(
                name: "IX_armyMembersAccounts_Id_ArmySocialsName",
                table: "armyMembersAccounts",
                column: "Id_ArmySocialsName");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideos_armySocialsNames_ArmySocialsNameId",
                table: "SectionPostVideos",
                column: "ArmySocialsNameId",
                principalTable: "armySocialsNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideos_armySocialsNames_ArmySocialsNameId",
                table: "SectionPostVideos");

            migrationBuilder.DropTable(
                name: "armyMembersAccounts");

            migrationBuilder.DropTable(
                name: "ArmyMembers");

            migrationBuilder.DropTable(
                name: "armySocialsNames");

            migrationBuilder.DropIndex(
                name: "IX_SectionPostVideos_ArmySocialsNameId",
                table: "SectionPostVideos");

            migrationBuilder.DropColumn(
                name: "ArmySocialsNameId",
                table: "SectionPostVideos");

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

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8644), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8653), new DateTime(2022, 12, 12, 20, 2, 41, 678, DateTimeKind.Local).AddTicks(8649) });
        }
    }
}
