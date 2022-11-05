using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Model
{
    public class SectionPostStep : ControlPublishFields
    {
        [DisplayName("جۆری پۆست")]
        [ForeignKey("SectionPostType")]
        public int Id_SectionPostType { get; set; }
        public SectionPostType? SectionPostType { get; set; }
        [DisplayName("ناوی سەردەستە")]
        [ForeignKey("SectionThirdStep")]
        public int Id_SectionThirdStep { get; set; }
        public SectionThirdStep? SectionThirdStep { get; set; }
        [DisplayName("ناو")]
        public string? Title { get; set; }
        [DisplayName("کورتەباس")]
        public string? ShortDescription { get; set; }
        [DisplayName("لەبارەی")]
        public string? FullDescription { get; set; }
        [DisplayName("دیتراو")]
        public int ViewsNumber { get; set; }
        public ICollection<SectionPostImage>? SectionPostImages { get; set; }
        public ICollection<SectionPostVideo>? SectionPostVideos { get; set; }
        public ICollection<SectionPostCommentStep>? SectionPostCommentSteps { get; set; }
        //Constructors
        public SectionPostStep()
        {

        }
        public SectionPostStep(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, int id_SectionPostType, SectionPostType? sectionPostType, int id_SectionThirdStep, SectionThirdStep? sectionThirdStep, string? title, string? shortDescription, string? fullDescription) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Id_SectionPostType = id_SectionPostType;
            SectionPostType = sectionPostType;
            Id_SectionThirdStep = id_SectionThirdStep;
            SectionThirdStep = sectionThirdStep;
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
        public SectionPostStep(bool ActivatedNotTimabled, string? email,string? tagsName, int id_SectionPostType, SectionPostType? sectionPostType, int id_SectionThirdStep, SectionThirdStep? sectionThirdStep, string? title, string? shortDescription, string? fullDescription) : base(ActivatedNotTimabled,email,tagsName)
        {
            Id_SectionPostType = id_SectionPostType;
            SectionPostType = sectionPostType;
            Id_SectionThirdStep = id_SectionThirdStep;
            SectionThirdStep = sectionThirdStep;
            Title = title;
            ShortDescription = shortDescription;
            FullDescription = fullDescription;
        }
    }
}
