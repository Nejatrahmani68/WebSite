using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    public partial class ImplementDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SectionFirstSteps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionFirstSteps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionPostImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionPostImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionPostSocialVideos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionPostSocialVideos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionPostTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionPostTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebsiteActiveTimeControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteActiveTimeControls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebsiteThemControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteThemControls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionSecondSteps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_SectionFirstStep = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionSecondSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionSecondSteps_SectionFirstSteps_Id_SectionFirstStep",
                        column: x => x.Id_SectionFirstStep,
                        principalTable: "SectionFirstSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionThirdSteps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_SectionSecondStep = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionThirdSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionThirdSteps_SectionSecondSteps_Id_SectionSecondStep",
                        column: x => x.Id_SectionSecondStep,
                        principalTable: "SectionSecondSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionPostSteps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_SectionPostType = table.Column<int>(type: "int", nullable: false),
                    Id_SectionThirdStep = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_SectionPostImage = table.Column<int>(type: "int", nullable: false),
                    Id_SectionPostSocialVideo = table.Column<int>(type: "int", nullable: false),
                    VideoAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionPostSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionPostSteps_SectionPostImages_Id_SectionPostImage",
                        column: x => x.Id_SectionPostImage,
                        principalTable: "SectionPostImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionPostSteps_SectionPostSocialVideos_Id_SectionPostSocialVideo",
                        column: x => x.Id_SectionPostSocialVideo,
                        principalTable: "SectionPostSocialVideos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionPostSteps_SectionPostTypes_Id_SectionPostType",
                        column: x => x.Id_SectionPostType,
                        principalTable: "SectionPostTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionPostSteps_SectionThirdSteps_Id_SectionThirdStep",
                        column: x => x.Id_SectionThirdStep,
                        principalTable: "SectionThirdSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionPostCommentStep",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_SectionPostStep = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionPostCommentStep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionPostCommentStep_SectionPostSteps_Id_SectionPostStep",
                        column: x => x.Id_SectionPostStep,
                        principalTable: "SectionPostSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SectionPostAnswerStep",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_SectionPostCommentStep = table.Column<int>(type: "int", nullable: false),
                    SectionPostStepId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Timable = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionPostAnswerStep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionPostAnswerStep_SectionPostCommentStep_Id_SectionPostCommentStep",
                        column: x => x.Id_SectionPostCommentStep,
                        principalTable: "SectionPostCommentStep",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionPostAnswerStep_SectionPostSteps_SectionPostStepId",
                        column: x => x.SectionPostStepId,
                        principalTable: "SectionPostSteps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostAnswerStep_Id_SectionPostCommentStep",
                table: "SectionPostAnswerStep",
                column: "Id_SectionPostCommentStep");

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostAnswerStep_SectionPostStepId",
                table: "SectionPostAnswerStep",
                column: "SectionPostStepId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostCommentStep_Id_SectionPostStep",
                table: "SectionPostCommentStep",
                column: "Id_SectionPostStep");

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostSteps_Id_SectionPostImage",
                table: "SectionPostSteps",
                column: "Id_SectionPostImage");

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostSteps_Id_SectionPostSocialVideo",
                table: "SectionPostSteps",
                column: "Id_SectionPostSocialVideo");

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostSteps_Id_SectionPostType",
                table: "SectionPostSteps",
                column: "Id_SectionPostType");

            migrationBuilder.CreateIndex(
                name: "IX_SectionPostSteps_Id_SectionThirdStep",
                table: "SectionPostSteps",
                column: "Id_SectionThirdStep");

            migrationBuilder.CreateIndex(
                name: "IX_SectionSecondSteps_Id_SectionFirstStep",
                table: "SectionSecondSteps",
                column: "Id_SectionFirstStep");

            migrationBuilder.CreateIndex(
                name: "IX_SectionThirdSteps_Id_SectionSecondStep",
                table: "SectionThirdSteps",
                column: "Id_SectionSecondStep");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionPostAnswerStep");

            migrationBuilder.DropTable(
                name: "WebsiteActiveTimeControls");

            migrationBuilder.DropTable(
                name: "WebsiteThemControls");

            migrationBuilder.DropTable(
                name: "SectionPostCommentStep");

            migrationBuilder.DropTable(
                name: "SectionPostSteps");

            migrationBuilder.DropTable(
                name: "SectionPostImages");

            migrationBuilder.DropTable(
                name: "SectionPostSocialVideos");

            migrationBuilder.DropTable(
                name: "SectionPostTypes");

            migrationBuilder.DropTable(
                name: "SectionThirdSteps");

            migrationBuilder.DropTable(
                name: "SectionSecondSteps");

            migrationBuilder.DropTable(
                name: "SectionFirstSteps");
        }
    }
}
