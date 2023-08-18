using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class AddFileModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostFile_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SectionPostFile",
                table: "SectionPostFile");

            migrationBuilder.RenameTable(
                name: "SectionPostFile",
                newName: "SectionPostFiles");

            migrationBuilder.RenameIndex(
                name: "IX_SectionPostFile_Id_SectionPostStep",
                table: "SectionPostFiles",
                newName: "IX_SectionPostFiles_Id_SectionPostStep");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SectionPostFiles",
                table: "SectionPostFiles",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2a763415-38e1-48a3-9465-d16345450769");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "807be8c7-63dc-49e8-9241-b3e41735771a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "14eed651-6d5a-4240-963c-1dc05aeb81f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "44af2401-fce7-4e94-81be-978c160d1dfa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "6d99e406-2ee3-4fee-a558-03cfebe64777");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "7c9b3941-5772-4a76-b72a-075b99044c77");

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8360), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8366), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8372), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8377), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8384), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8389), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8295), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8302), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8308), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8314), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.InsertData(
                table: "SectionPostTypes",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "StartDate", "TagsName", "Timable", "Title" },
                values: new object[] { 3, true, new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8320), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8326), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8323), "فایل", false, "File" });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8098), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8107), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8423), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8429), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8435), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8446), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8451), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8457), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8463), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8468), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8474), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8485), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8491), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8496), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8502), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8508), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8513), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8519), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8525), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8536), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8541), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8547), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8552), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8558), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8564), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8575), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8581), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8586), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8592), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8597), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8603), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8609), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8615), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8626), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8631), new DateTime(2022, 11, 27, 15, 42, 9, 719, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostFiles_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostFiles",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostFiles_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SectionPostFiles",
                table: "SectionPostFiles");

            migrationBuilder.DeleteData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "SectionPostFiles",
                newName: "SectionPostFile");

            migrationBuilder.RenameIndex(
                name: "IX_SectionPostFiles_Id_SectionPostStep",
                table: "SectionPostFile",
                newName: "IX_SectionPostFile_Id_SectionPostStep");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SectionPostFile",
                table: "SectionPostFile",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostFile_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostFile",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
