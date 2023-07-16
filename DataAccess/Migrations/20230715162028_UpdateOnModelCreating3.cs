using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class UpdateOnModelCreating3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "aa6c7940-b38e-4df9-bc05-a7ab621f6782");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "975caa96-ab4e-4143-a6a3-c183e565de28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "91c13f8f-03e3-48a5-9eff-33e6a83d45a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "08c1468e-7de2-402f-b56a-f19185d031d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "c9ede106-64c6-4cf1-b8a4-f1087aa27d81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "e1cad87c-7332-4d2c-8dc6-974de1a468d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "20537bfa-4579-4460-b2d6-0717a7f849a6");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9721), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9725), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9727), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9730), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9733), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9788), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9790), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9793), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9799), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9801), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9751), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9754), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9758), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9760), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9763), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9554), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9559), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9820), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9822), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9825), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9831), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9833), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9836), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9839), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9841), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9844), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9849), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9852), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9855), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9857), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9860), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9863), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9865), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9868), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9871), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9873), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9876), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9881), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9894), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9897), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9900), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9908), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9913), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9916), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9918), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9921), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9924), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9926), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9929), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9934), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9937), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9939), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9942), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9945), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9950), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9953), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.InsertData(
                table: "WebsiteThemControls",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "SectionName", "StartDate", "TagsName", "Timable" },
                values: new object[] { 29, true, new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9970), "NejatRahmani68@gmail.com", new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9972), "MenuBar", new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9971), "MenuBar", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "64d357f3-5912-47c3-b3e8-b2b4e5a58bf8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ce41a5eb-398e-45bd-9bcc-5c4d2fc0ab23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "5e549cb7-cc36-4a0b-b6f2-4167912d8e96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "554176b3-2e48-47de-8bd8-f33974f1db2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "1fec3f46-f17f-4e73-89b5-bcf2c6e61433");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "ea7b8988-10f3-41db-b9a9-b901fb005a18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "9b5505af-e102-4e19-9312-cd9737849765");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3680), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3683), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3686), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3689), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3692), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3694), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3743), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3745), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3749), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3751), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3754), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3711), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3714), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3717), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3720), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3723), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3725), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3563), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3567), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3773), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3776), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3779), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3781), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3784), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3787), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3789), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3792), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3795), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3798), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3800), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3803), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3806), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3808), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3811), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3813), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3816), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3819), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3821), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3824), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3826), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3829), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3832), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3834), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3837), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3839), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3842), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3845), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3847), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3850), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3853), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3855), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3858), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3860), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3863), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3866), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3869), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3871), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3874), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3876), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3879), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3882), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3884), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3887), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3890), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3892), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3895), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3897), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3900), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3903), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3905), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3908), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3911), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3913), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3916), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3918), new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3917) });
        }
    }
}
