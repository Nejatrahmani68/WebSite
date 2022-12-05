using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SectionPostStep : ControlPublishFields
    {
        [DisplayName("جۆری پۆست")]
        [ForeignKey("SectionPostType")]
        public int? Id_SectionPostType { get; set; }
        public SectionPostType? SectionPostType { get; set; }
        [DisplayName("ناوی سەردەستە")]
        [ForeignKey("SectionThirdStep")]
        public int? Id_SectionThirdStep { get; set; }
        public SectionThirdStep? SectionThirdStep { get; set; }
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("ناو")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("کورتەباس")]
        public string? ShortDescription { get; set; }
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("لەبارەی")]
        public string? FullDescription { get; set; }
        [DisplayName("دیتراو")]
        public int ViewsNumber { get; set; } = 1;
        public ICollection<SectionPostImage>? SectionPostImages { get; set; }
        public ICollection<SectionPostVideo>? SectionPostVideos { get; set; }
        public ICollection<SectionPostFile>? SectionPostFiles { get; set; }
        public ICollection<SectionPostCommentStep>? SectionPostCommentSteps { get; set; }
        //Constructors
        public SectionPostStep()
        {

        }
        public SectionPostStep(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, int id_SectionPostType, int id_SectionThirdStep, string? title, string? shortDescription, string? fullDescription) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Id_SectionPostType = id_SectionPostType;
            Id_SectionThirdStep = id_SectionThirdStep;
            Title = title;
            ShortDescription = shortDescription;
            FullDescription = fullDescription;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostStep(bool ActivatedNotTimabled, string? email,string? tagsName, int id_SectionPostType, int id_SectionThirdStep, string? title, string? shortDescription, string? fullDescription) : base(ActivatedNotTimabled,email,tagsName)
        {
            Id_SectionPostType = id_SectionPostType;
            Id_SectionThirdStep = id_SectionThirdStep;
            Title = title;
            ShortDescription = shortDescription;
            FullDescription = fullDescription;
        }
    }
}
