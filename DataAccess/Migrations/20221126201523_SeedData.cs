using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "1e1c93ca-228d-4a06-bba7-322eb32f7195", "Administrator", "ADMINISTRATOR" },
                    { "2", "c0526c9a-6122-4f56-ade5-f342f6164fd1", "Admin", "ADMIN" },
                    { "3", "7c493ebf-afbd-4b8b-9d24-09dffd0f6ad5", "Add", "ADD" },
                    { "4", "c2a1e623-e630-498d-8a83-04f7569275e1", "Edit", "EDIT" },
                    { "5", "f89533cc-f9c9-41c6-aabc-c99829e0126b", "Delete", "DELETE" },
                    { "6", "95dda468-c061-4a24-89d2-dff37888e004", "FullWriter", "FULLWRITER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "b54873bc-f189-4927-8a1e-0ac6b5eabd2d", "nejatrahmani68@gmail.com", true, false, null, "NEJATRAHMANI68@GMAIL.COM", "NEJATRAHMANI68", "80a514245aadb1114e85d4d7d3e578b32783559bb5a33a17d29095e454800dcf", "009647821765944", true, "9e461725-2731-4a15-b97e-bfaef43952e6", false, "nejatrahmani68" });

            migrationBuilder.InsertData(
                table: "WebsiteActiveTimeControls",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "StartDate", "TagsName", "Timable", "WebsiteTitle" },
                values: new object[] { 1, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8750), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8761), new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8753), "وێب سایت", false, "ناوی وێب سایت" });

            migrationBuilder.InsertData(
                table: "WebsiteThemControls",
                columns: new[] { "Id", "Active", "CreateDate", "Email", "EndDate", "SectionName", "StartDate", "TagsName", "Timable" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8902), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8906), "RightSection", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8904), "RightSection", false },
                    { 2, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8917), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8921), "Header", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8919), "Header", false },
                    { 3, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8925), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8929), "HeaderLeft", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8927), "HeaderLeft", false },
                    { 4, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8934), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8938), "HeaderCenter", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8936), "HeaderCenter", false },
                    { 5, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8942), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8946), "HeaderRight", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8944), "HeaderRight", false },
                    { 6, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8950), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8954), "Search", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8952), "Search", false },
                    { 7, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8959), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8963), "Marquee", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8961), "Marquee", false },
                    { 8, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8967), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8971), "LeftSection", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8969), "LeftSection", false },
                    { 9, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8975), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8979), "Footer", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8977), "Footer", false },
                    { 10, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8984), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8988), "News", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8986), "News", false },
                    { 11, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8992), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8996), "SectionVideo", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(8994), "SectionVideo", false },
                    { 12, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9001), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9005), "SectionArticle", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9003), "SectionArticle", false },
                    { 13, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9009), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9013), "MostViewd", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9011), "MostViewd", false },
                    { 14, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9017), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9021), "ThirdStepCategories", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9019), "ThirdStepCategories", false },
                    { 15, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9026), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9030), "ViewSubCategoryPosts", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9028), "ViewSubCategoryPosts", false },
                    { 16, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9034), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9038), "ViewPost", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9036), "ViewPost", false },
                    { 17, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9042), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9046), "RelatedPost", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9045), "RelatedPost", false },
                    { 18, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9051), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9055), "ViewComment", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9053), "ViewComment", false },
                    { 19, true, new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9059), "NejatRahmani68@gmail.com", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9063), "InsertComment", new DateTime(2022, 11, 26, 21, 15, 23, 107, DateTimeKind.Local).AddTicks(9061), "InsertComment", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "WebsiteActiveTimeControls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WebsiteThemControls",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
