using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class UpdateOnModelCreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2e6dba15-ba68-45d9-9927-a364ac142c9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ce3f885e-c9d6-45c3-8727-47714c62e0cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "ad7ce7f9-4259-4405-8fd8-e91bdcfa5403");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7f05a264-a9d2-4457-94aa-59c1e4fa0493");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "bf7b87c6-b60f-4820-86dd-9bd3ff17aaeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "cd0f5d52-1321-4376-b354-092ddbf6d08b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7", "8a5480e8-7b9c-46b0-9761-cea48efa0e71", "ArmyAdmin", "ARMYADMIN" });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2645), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2655), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2657), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2745), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2748), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2756), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2674), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2676), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2693), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2698), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2701), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2542), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2777), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2785), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2788), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2793), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2796), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2807), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2812), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2833), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2838), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2846), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2852), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2865), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2868), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2875), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2883), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2889), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2891), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2894), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2899), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2907), new DateTime(2023, 7, 15, 17, 24, 2, 984, DateTimeKind.Local).AddTicks(2905) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7");

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
        }
    }
}
