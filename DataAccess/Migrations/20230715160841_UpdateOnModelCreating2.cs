using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class UpdateOnModelCreating2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "WebsiteThemControls",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "SectionName", "StartDate", "TagsName", "Timable" },
                values: new object[] { 27, true, new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3911), "NejatRahmani68@gmail.com", new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3913), "AdminPanel", new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3912), "AdminPanel", false });

            migrationBuilder.InsertData(
                table: "WebsiteThemControls",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "SectionName", "StartDate", "TagsName", "Timable" },
                values: new object[] { 28, true, new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3916), "NejatRahmani68@gmail.com", new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3918), "AdminPanelArmy", new DateTime(2023, 7, 15, 18, 8, 41, 351, DateTimeKind.Local).AddTicks(3917), "AdminPanelArmy", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 28);

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "8a5480e8-7b9c-46b0-9761-cea48efa0e71");

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
    }
}
