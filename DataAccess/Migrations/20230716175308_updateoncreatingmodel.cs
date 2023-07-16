using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class updateoncreatingmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3d6dc1f2-d99b-461d-afcd-ae935b6c0b23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6ae3b037-bf3f-4b4c-aaad-cc06e91b0d78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "44c435e3-0dd7-4284-b5c6-b392651fc17c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "99157fc6-729e-448c-9934-bf9ab75ead29");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "97b7ad4c-ec50-47fe-a452-863be689057e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "ee6020aa-9b63-408c-a484-dabcabb042de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "1eabb3c5-f2e6-4d8b-b4fb-1904c6d678b9");

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "SectionLanguages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6629), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6632), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6728), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6733), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6736), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6739), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6649), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6652), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6658), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6762), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6765), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6768), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6773), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6778), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6781), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6784), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6786), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6789), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6792), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6794), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6797), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6802), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6807), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6816), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6827), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6830), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6838), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6843), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6846), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6848), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6851), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6854), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6859), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6864), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6870), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6872), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6875), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6878), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6883), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6886), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6889), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6891), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6894), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6896), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6899), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6902), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6904), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6907), new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.InsertData(
                table: "WebsiteThemControls",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "SectionName", "StartDate", "TagsName", "Timable" },
                values: new object[,]
                {
                    { 30, true, new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6910), "NejatRahmani68@gmail.com", new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6912), "HeaderTitle", new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6911), "HeaderTitle", false },
                    { 31, true, new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6915), "NejatRahmani68@gmail.com", new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6917), "AboutUs", new DateTime(2023, 7, 16, 19, 53, 8, 223, DateTimeKind.Local).AddTicks(6916), "AboutUs", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 31);

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

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9970), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9972), new DateTime(2023, 7, 15, 18, 20, 27, 723, DateTimeKind.Local).AddTicks(9971) });
        }
    }
}
