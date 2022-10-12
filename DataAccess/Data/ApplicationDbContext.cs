using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public  DbSet<WebsiteActiveTimeControl> WebsiteActiveTimeControls { get; set; }
        public  DbSet<WebsiteThemControl> WebsiteThemControls { get; set; }
        public  DbSet<SectionFirstStep> SectionFirstSteps { get; set; }
        public  DbSet<SectionSecondStep> SectionSecondSteps { get; set; }
        public  DbSet<SectionThirdStep> SectionThirdSteps { get; set; }
        public  DbSet<SectionPostStep> SectionPostSteps { get; set; }
        public  DbSet<SectionPostImage> SectionPostImages { get; set; }
        public  DbSet<SectionPostSocialVideo> SectionPostSocialVideos { get; set; }
        public  DbSet<SectionPostType> SectionPostTypes { get; set; }
        public  DbSet<SectionPostCommentStep> SectionPostCommentSteps { get; set; }
        public  DbSet<SectionPostAnswerStep> SectionPostAnswerSteps { get; set; }

    }
}