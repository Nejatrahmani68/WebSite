using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
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
               { Id = 1, Name = "fa-IR", Description = "", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "Farsi" },
               new SectionLanguage
               { Id = 2, Name = "en-US", Description = "", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "English" },
               new SectionLanguage
               { Id = 3, Name = "ku-Arab", Description = "", Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "Kurdish" });

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
                { Id = 26, Active = true, CreateDate = DateTime.Now, Email = "NejatRahmani68@gmail.com", Timable = false, StartDate = DateTime.Now, EndDate = DateTime.Now, TagsName = "SlideShow", SectionName = "SlideShow" });

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
            { Id = "6", Name = "FullWriter", NormalizedName = "FULLWRITER" });
        }
    }
}