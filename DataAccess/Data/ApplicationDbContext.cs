using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<WebsiteActiveTimeControl>? WebsiteActiveTimeControls { get; set; }
        public DbSet<WebsiteThemControl>? WebsiteThemControls { get; set; }
        public DbSet<SectionFirstStep>? SectionFirstSteps { get; set; }
        public DbSet<SectionSecondStep>? SectionSecondSteps { get; set; }
        public DbSet<SectionThirdStep>? SectionThirdSteps { get; set; }
        public DbSet<SectionPostStep>? SectionPostSteps { get; set; }
        public DbSet<SectionPostImage>? SectionPostImages { get; set; }
        public DbSet<SectionPostSocialVideo>? SectionPostSocialVideos { get; set; }
        public DbSet<SectionPostType>? SectionPostTypes { get; set; }
        public DbSet<SectionPostCommentStep>? SectionPostCommentSteps { get; set; }
        public DbSet<SectionPostAnswerStep>? SectionPostAnswerSteps { get; set; }
        public DbSet<ArmyMembersAccounts>? SectionPostVideos { get; set; }
        public DbSet<SectionPostFile>? SectionPostFiles { get; set; }
        public DbSet<WebsiteAdminsControl>? WebsiteAdminsControls { get; set; }
        public DbSet<SectionLanguage>? SectionLanguages { get; set; }
        public DbSet<ArmyMembers>? ArmyMembers { get; set; }
        public DbSet<ArmyMembersAccount>? armyMembersAccounts { get; set; }
        public DbSet<ArmySocialsName>? armySocialsNames { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.SetNull;
            }
            base.OnModelCreating(builder);

            builder.Entity<WebsiteActiveTimeControl>().HasData(new WebsiteActiveTimeControl
            { Id = 1, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "وێب سایت", WebsiteTitle = "ناوی وێب سایت" });

            builder.Entity<SectionLanguage>().HasData(
                 new SectionLanguage
               { Id = 1, Name = "ku-Arab", Description = "", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "Kurdish", Title = "کوردی" },
               new SectionLanguage
               { Id = 2, Name = "fa-IR", Description = "", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "Farsi",Title="فارسی" },
               new SectionLanguage
               { Id = 3, Name = "en-US", Description = "", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "English", Title = "English" });

            builder.Entity<SectionPostType>().HasData(
                new SectionPostType
                { Id = 1, Title = "Article", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "نوسراوە" },
                new SectionPostType
                { Id = 2, Title = "Video", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "ویدیۆ" },
                new SectionPostType
                { Id = 3, Title = "File", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "فایل" });

            builder.Entity<SectionPostSocialVideo>().HasData(
               new SectionPostSocialVideo
               { Id = 1, Title = "Youtube", Address = "", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "یوتیوب" },
               new SectionPostSocialVideo
               { Id = 2, Title = "FaceBook", Address = "", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "فەیسبوک" },
               new SectionPostSocialVideo
               { Id = 3, Title = "Telegram", Address = "", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "تێلێگرام" });

            builder.Entity<WebsiteThemControl>().HasData(
                new WebsiteThemControl
                { Id = 1, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "RightSection", SectionName = "RightSection" },
                new WebsiteThemControl
                { Id = 2, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "Header", SectionName = "Header" },
                new WebsiteThemControl
                { Id = 3, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "HeaderLeft", SectionName = "HeaderLeft" },
                new WebsiteThemControl
                { Id = 4, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "HeaderCenter", SectionName = "HeaderCenter" },
                new WebsiteThemControl
                { Id = 5, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "HeaderRight", SectionName = "HeaderRight" },
                new WebsiteThemControl
                { Id = 6, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "Search", SectionName = "Search" },
                new WebsiteThemControl
                { Id = 7, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "Marquee", SectionName = "Marquee" },
                new WebsiteThemControl
                { Id = 8, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "LeftSection", SectionName = "LeftSection" },
                new WebsiteThemControl
                { Id = 9, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "Footer", SectionName = "Footer" },
                new WebsiteThemControl
                { Id = 10, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "News", SectionName = "News" },
                new WebsiteThemControl
                { Id = 11, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "SectionVideo", SectionName = "SectionVideo" },
                new WebsiteThemControl
                { Id = 12, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "SectionArticle", SectionName = "SectionArticle" },
                new WebsiteThemControl
                { Id = 13, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "MostViewd", SectionName = "MostViewd" },
                new WebsiteThemControl
                { Id = 14, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "ThirdStepCategories", SectionName = "ThirdStepCategories" },
                new WebsiteThemControl
                { Id = 15, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "ViewSubCategoryPosts", SectionName = "ViewSubCategoryPosts" },
                new WebsiteThemControl
                { Id = 16, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "ViewPost", SectionName = "ViewPost" },
                new WebsiteThemControl
                { Id = 17, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "RelatedPost", SectionName = "RelatedPost" },
                new WebsiteThemControl
                { Id = 18, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "ViewComment", SectionName = "ViewComment" },
                new WebsiteThemControl
                { Id = 19, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "InsertComment", SectionName = "InsertComment" },
                new WebsiteThemControl
                { Id = 20, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "SectionFile", SectionName = "SectionFile" },
                new WebsiteThemControl
                { Id = 21, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "ViewFile", SectionName = "ViewFile" },
                new WebsiteThemControl
                { Id = 22, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "LogIn", SectionName = "LogIn" },
                new WebsiteThemControl
                { Id = 23, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "Language", SectionName = "Language" },
                new WebsiteThemControl
                { Id = 24, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "FooterCategories", SectionName = "FooterCategories" },
                new WebsiteThemControl
                { Id = 25, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "NavBarSticky", SectionName = "NavBarSticky" },
                new WebsiteThemControl
                { Id = 26, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "SlideShow", SectionName = "SlideShow" },
                new WebsiteThemControl
                 { Id = 27, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "AdminPanel", SectionName = "AdminPanel" },
                new WebsiteThemControl
                { Id = 28, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "AdminPanelArmy", SectionName = "AdminPanelArmy" },
                new WebsiteThemControl
                { Id = 29, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "MenuBar", SectionName = "MenuBar" },
                new WebsiteThemControl
                { Id = 30, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "HeaderTitle", SectionName = "HeaderTitle" },
                new WebsiteThemControl
                { Id = 31, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "AboutUs", SectionName = "AboutUs" });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            { Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
            new IdentityRole
            { Id = "2", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole
            { Id = "3", Name = "Add", NormalizedName = "ADD" },
            new IdentityRole
            { Id = "4", Name = "Edit", NormalizedName = "EDIT" },
            new IdentityRole
            { Id = "5", Name = "Delete", NormalizedName = "DELETE" },
            new IdentityRole
            { Id = "6", Name = "FullWriter", NormalizedName = "FULLWRITER" },
             new IdentityRole
             { Id = "7", Name = "ArmyAdmin", NormalizedName = "ARMYADMIN" });


            //builder.Entity<IdentityUser>().HasData(new IdentityUser
            //{ Id = "1", Email = "nejatrahmani68@gmail.com", EmailConfirmed = true, NormalizedEmail = "NEJATRAHMANI68@GMAIL.COM", UserName = "nejatrahmani68", NormalizedUserName = "NEJATRAHMANI68", PhoneNumber = "009647821765944", PhoneNumberConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEKKhMm7G+AeXU9x9ADvYCx+QL+pvjoSEeoUQu5MDdOdFVCW50/zmP7Lzaz9ccskrkQ==" });

            //builder.Entity<IdentityUserRole<string>>().HasData(
            //    new IdentityUserRole<string> { RoleId ="1", UserId ="1" }
            //);
        }
    }
}