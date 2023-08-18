﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebsitePresentation.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221012185047_ChangeDbContext")]
    partial class ChangeDbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Model.SectionFirstStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SectionFirstSteps");
                });

            modelBuilder.Entity("Model.SectionPostAnswerStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_SectionPostCommentStep")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id_SectionPostCommentStep");

                    b.ToTable("SectionPostAnswerSteps");
                });

            modelBuilder.Entity("Model.SectionPostCommentStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_SectionPostStep")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id_SectionPostStep");

                    b.ToTable("SectionPostCommentSteps");
                });

            modelBuilder.Entity("Model.SectionPostImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PictureAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SectionPostImages");
                });

            modelBuilder.Entity("Model.SectionPostSocialVideo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SectionPostSocialVideos");
                });

            modelBuilder.Entity("Model.SectionPostStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_SectionPostImage")
                        .HasColumnType("int");

                    b.Property<int>("Id_SectionPostSocialVideo")
                        .HasColumnType("int");

                    b.Property<int>("Id_SectionPostType")
                        .HasColumnType("int");

                    b.Property<int>("Id_SectionThirdStep")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id_SectionPostImage");

                    b.HasIndex("Id_SectionPostSocialVideo");

                    b.HasIndex("Id_SectionPostType");

                    b.HasIndex("Id_SectionThirdStep");

                    b.ToTable("SectionPostSteps");
                });

            modelBuilder.Entity("Model.SectionPostType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SectionPostTypes");
                });

            modelBuilder.Entity("Model.SectionSecondStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_SectionFirstStep")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id_SectionFirstStep");

                    b.ToTable("SectionSecondSteps");
                });

            modelBuilder.Entity("Model.SectionThirdStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_SectionSecondStep")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id_SectionSecondStep");

                    b.ToTable("SectionThirdSteps");
                });

            modelBuilder.Entity("Model.WebsiteActiveTimeControl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.Property<string>("WebsiteTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WebsiteActiveTimeControls");
                });

            modelBuilder.Entity("Model.WebsiteThemControl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SectionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Timable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("WebsiteThemControls");
                });

            modelBuilder.Entity("Model.SectionPostAnswerStep", b =>
                {
                    b.HasOne("Model.SectionPostCommentStep", "SectionPostCommentStep")
                        .WithMany("SectionPostAnswerSteps")
                        .HasForeignKey("Id_SectionPostCommentStep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SectionPostCommentStep");
                });

            modelBuilder.Entity("Model.SectionPostCommentStep", b =>
                {
                    b.HasOne("Model.SectionPostStep", "SectionPostStep")
                        .WithMany("SectionPostCommentSteps")
                        .HasForeignKey("Id_SectionPostStep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SectionPostStep");
                });

            modelBuilder.Entity("Model.SectionPostStep", b =>
                {
                    b.HasOne("Model.SectionPostImage", "SectionPostImage")
                        .WithMany("SectionPostSteps")
                        .HasForeignKey("Id_SectionPostImage")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.SectionPostSocialVideo", "SectionPostSocialVideo")
                        .WithMany("SectionPostSteps")
                        .HasForeignKey("Id_SectionPostSocialVideo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.SectionPostType", "SectionPostType")
                        .WithMany("SectionPostSteps")
                        .HasForeignKey("Id_SectionPostType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.SectionThirdStep", "SectionThirdStep")
                        .WithMany("SectionPostSteps")
                        .HasForeignKey("Id_SectionThirdStep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SectionPostImage");

                    b.Navigation("SectionPostSocialVideo");

                    b.Navigation("SectionPostType");

                    b.Navigation("SectionThirdStep");
                });

            modelBuilder.Entity("Model.SectionSecondStep", b =>
                {
                    b.HasOne("Model.SectionFirstStep", "SectionFirstStep")
                        .WithMany("SectionSecondSteps")
                        .HasForeignKey("Id_SectionFirstStep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SectionFirstStep");
                });

            modelBuilder.Entity("Model.SectionThirdStep", b =>
                {
                    b.HasOne("Model.SectionSecondStep", "SectionSecondStep")
                        .WithMany("SectionThirdSteps")
                        .HasForeignKey("Id_SectionSecondStep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SectionSecondStep");
                });

            modelBuilder.Entity("Model.SectionFirstStep", b =>
                {
                    b.Navigation("SectionSecondSteps");
                });

            modelBuilder.Entity("Model.SectionPostCommentStep", b =>
                {
                    b.Navigation("SectionPostAnswerSteps");
                });

            modelBuilder.Entity("Model.SectionPostImage", b =>
                {
                    b.Navigation("SectionPostSteps");
                });

            modelBuilder.Entity("Model.SectionPostSocialVideo", b =>
                {
                    b.Navigation("SectionPostSteps");
                });

            modelBuilder.Entity("Model.SectionPostStep", b =>
                {
                    b.Navigation("SectionPostCommentSteps");
                });

            modelBuilder.Entity("Model.SectionPostType", b =>
                {
                    b.Navigation("SectionPostSteps");
                });

            modelBuilder.Entity("Model.SectionSecondStep", b =>
                {
                    b.Navigation("SectionThirdSteps");
                });

            modelBuilder.Entity("Model.SectionThirdStep", b =>
                {
                    b.Navigation("SectionPostSteps");
                });
#pragma warning restore 612, 618
        }
    }
}
