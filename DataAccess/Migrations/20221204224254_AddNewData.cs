using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class AddNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreateDate", "EndDate", "StartDate", "TagsName" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5476), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5482), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5479), "Farsi" });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate", "TagsName" },
                values: new object[] { new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5491), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5496), new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5493), "English" });

            migrationBuilder.InsertData(
                table: "SectionLanguages",
                columns: new[] { "Id", "Active", "CreateDate", "Description", "Email", "EndDate", "Name", "StartDate", "TagsName", "Timable" },
                values: new object[] { 3, true, new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5502), "", "NejatRahmani68@gmail.com", new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5507), "ku-Arab", new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5504), "Kurdish", false });

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

            migrationBuilder.InsertData(
                table: "WebsiteThemControls",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "SectionName", "StartDate", "TagsName", "Timable" },
                values: new object[,]
                {
                    { 22, true, new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5913), "NejatRahmani68@gmail.com", new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5919), "LogIn", new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5916), "LogIn", false },
                    { 23, true, new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5925), "NejatRahmani68@gmail.com", new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5930), "Language", new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5927), "Language", false },
                    { 24, true, new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5936), "NejatRahmani68@gmail.com", new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5941), "FooterCategories", new DateTime(2022, 12, 4, 23, 42, 54, 101, DateTimeKind.Local).AddTicks(5939), "FooterCategories", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "262eae75-5b7e-4e3d-a690-998e42cb2268");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8f37758f-a7cf-40b2-927c-71836ac715b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "d70491f6-7896-4e62-b3c8-094f8df63b42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "ae60cc2b-000f-424b-81a0-ecb143c992af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "18b334ab-2a45-4de1-b3db-220444c1c0bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "45a4fa11-6c6f-425c-b6aa-5071a77023fd");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate", "TagsName" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3583), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3587), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3585), "Kurdish" });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate", "TagsName" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3592), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3596), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3594), "فەیسبوک" });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3674), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3678), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3683), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3687), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3692), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3695), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3624), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3627), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3632), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3636), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3640), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3644), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3440), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3719), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3723), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3728), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3731), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3736), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3739), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3744), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3747), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3752), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3755), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3760), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3764), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3768), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3772), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3776), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3780), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3784), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3788), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3792), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3796), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3800), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3806), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3810), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3814), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3818), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3822), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3826), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3834), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3838), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3842), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3846), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3850), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3853), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3861), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3866), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3869), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3873), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3877), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3881), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3885), new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3883) });
        }
    }
}
