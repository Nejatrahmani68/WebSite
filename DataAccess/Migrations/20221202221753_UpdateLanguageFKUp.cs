using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class UpdateLanguageFKUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostAnswerSteps_SectionPostCommentSteps_Id_SectionPostCommentStep",
                table: "SectionPostAnswerSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostCommentSteps_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostCommentSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostFiles_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostImages_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostImages");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostSteps_SectionPostTypes_Id_SectionPostType",
                table: "SectionPostSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostSteps_SectionThirdSteps_Id_SectionThirdStep",
                table: "SectionPostSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideos_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideos");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideos_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostVideos");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionSecondSteps_SectionFirstSteps_Id_SectionFirstStep",
                table: "SectionSecondSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionThirdSteps_SectionSecondSteps_Id_SectionSecondStep",
                table: "SectionThirdSteps");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionSecondStep",
                table: "SectionThirdSteps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionFirstStep",
                table: "SectionSecondSteps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostStep",
                table: "SectionPostVideos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostSocialVideo",
                table: "SectionPostVideos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionThirdStep",
                table: "SectionPostSteps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostType",
                table: "SectionPostSteps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostStep",
                table: "SectionPostImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostStep",
                table: "SectionPostFiles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostStep",
                table: "SectionPostCommentSteps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostCommentStep",
                table: "SectionPostAnswerSteps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id_LanguageStep",
                table: "SectionFirstSteps",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SectionLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_SectionLanguages", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "SectionLanguages",
                columns: new[] { "Id", "Active", "CreateDate", "Description", "Email", "EndDate", "Name", "StartDate", "TagsName", "Timable" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3583), "", "NejatRahmani68@gmail.com", new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3587), "fa-IR", new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3585), "Kurdish", false },
                    { 2, true, new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3592), "", "NejatRahmani68@gmail.com", new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3596), "en-US", new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3594), "فەیسبوک", false }
                });

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

            migrationBuilder.InsertData(
                table: "WebsiteThemControls",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "SectionName", "StartDate", "TagsName", "Timable" },
                values: new object[,]
                {
                    { 20, true, new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3873), "NejatRahmani68@gmail.com", new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3877), "SectionFile", new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3875), "SectionFile", false },
                    { 21, true, new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3881), "NejatRahmani68@gmail.com", new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3885), "ViewFile", new DateTime(2022, 12, 2, 23, 17, 52, 854, DateTimeKind.Local).AddTicks(3883), "ViewFile", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SectionFirstSteps_Id_LanguageStep",
                table: "SectionFirstSteps",
                column: "Id_LanguageStep");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionFirstSteps_SectionLanguages_Id_LanguageStep",
                table: "SectionFirstSteps",
                column: "Id_LanguageStep",
                principalTable: "SectionLanguages",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostAnswerSteps_SectionPostCommentSteps_Id_SectionPostCommentStep",
                table: "SectionPostAnswerSteps",
                column: "Id_SectionPostCommentStep",
                principalTable: "SectionPostCommentSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostCommentSteps_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostCommentSteps",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostFiles_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostFiles",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostImages_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostImages",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostSteps_SectionPostTypes_Id_SectionPostType",
                table: "SectionPostSteps",
                column: "Id_SectionPostType",
                principalTable: "SectionPostTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostSteps_SectionThirdSteps_Id_SectionThirdStep",
                table: "SectionPostSteps",
                column: "Id_SectionThirdStep",
                principalTable: "SectionThirdSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideos_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideos",
                column: "Id_SectionPostSocialVideo",
                principalTable: "SectionPostSocialVideos",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideos_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostVideos",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionSecondSteps_SectionFirstSteps_Id_SectionFirstStep",
                table: "SectionSecondSteps",
                column: "Id_SectionFirstStep",
                principalTable: "SectionFirstSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionThirdSteps_SectionSecondSteps_Id_SectionSecondStep",
                table: "SectionThirdSteps",
                column: "Id_SectionSecondStep",
                principalTable: "SectionSecondSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionFirstSteps_SectionLanguages_Id_LanguageStep",
                table: "SectionFirstSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostAnswerSteps_SectionPostCommentSteps_Id_SectionPostCommentStep",
                table: "SectionPostAnswerSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostCommentSteps_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostCommentSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostFiles_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostImages_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostImages");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostSteps_SectionPostTypes_Id_SectionPostType",
                table: "SectionPostSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostSteps_SectionThirdSteps_Id_SectionThirdStep",
                table: "SectionPostSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideos_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideos");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionPostVideos_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostVideos");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionSecondSteps_SectionFirstSteps_Id_SectionFirstStep",
                table: "SectionSecondSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionThirdSteps_SectionSecondSteps_Id_SectionSecondStep",
                table: "SectionThirdSteps");

            migrationBuilder.DropTable(
                name: "SectionLanguages");

            migrationBuilder.DropIndex(
                name: "IX_SectionFirstSteps_Id_LanguageStep",
                table: "SectionFirstSteps");

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DropColumn(
                name: "Id_LanguageStep",
                table: "SectionFirstSteps");

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionSecondStep",
                table: "SectionThirdSteps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionFirstStep",
                table: "SectionSecondSteps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostStep",
                table: "SectionPostVideos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostSocialVideo",
                table: "SectionPostVideos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionThirdStep",
                table: "SectionPostSteps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostType",
                table: "SectionPostSteps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostStep",
                table: "SectionPostImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostStep",
                table: "SectionPostFiles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostStep",
                table: "SectionPostCommentSteps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_SectionPostCommentStep",
                table: "SectionPostAnswerSteps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "04290e25-7236-4378-9964-fedfe57c6448");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "76fd1c4b-2e24-4c11-acc7-eff473f516cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7ddbfb8e-8876-40e6-807c-ae328b088911");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7c094cf3-04b4-4b89-858f-309f5a08e4fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "a79b0716-bf7a-4359-9620-dd518f6f58ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "bf43f66b-1ad1-436a-be4c-153e5ce097ee");

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5639), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5645), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5652), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5656), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "SectionPostSocialVideos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5661), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5526), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5539), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5552), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5562), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "SectionPostTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5568), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5345), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5353), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5711), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5761), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5768), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5773), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5778), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5783), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5788), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5792), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5797), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5802), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5807), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5811), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5816), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5821), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5827), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5831), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5841), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5845), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5851), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5855), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5864), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5869), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5874), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5878), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5883), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5888), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5892), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5897), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5902), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5906), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5911), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5916), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5925), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5929), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5934), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5938), new DateTime(2022, 11, 30, 22, 54, 55, 454, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostAnswerSteps_SectionPostCommentSteps_Id_SectionPostCommentStep",
                table: "SectionPostAnswerSteps",
                column: "Id_SectionPostCommentStep",
                principalTable: "SectionPostCommentSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostCommentSteps_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostCommentSteps",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostFiles_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostFiles",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostImages_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostImages",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostSteps_SectionPostTypes_Id_SectionPostType",
                table: "SectionPostSteps",
                column: "Id_SectionPostType",
                principalTable: "SectionPostTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostSteps_SectionThirdSteps_Id_SectionThirdStep",
                table: "SectionPostSteps",
                column: "Id_SectionThirdStep",
                principalTable: "SectionThirdSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideos_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                table: "SectionPostVideos",
                column: "Id_SectionPostSocialVideo",
                principalTable: "SectionPostSocialVideos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionPostVideos_SectionPostSteps_Id_SectionPostStep",
                table: "SectionPostVideos",
                column: "Id_SectionPostStep",
                principalTable: "SectionPostSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionSecondSteps_SectionFirstSteps_Id_SectionFirstStep",
                table: "SectionSecondSteps",
                column: "Id_SectionFirstStep",
                principalTable: "SectionFirstSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectionThirdSteps_SectionSecondSteps_Id_SectionSecondStep",
                table: "SectionThirdSteps",
                column: "Id_SectionSecondStep",
                principalTable: "SectionSecondSteps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
