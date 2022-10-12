using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [DisplayName("وێنە")]
        [ForeignKey("SectionPostImage")]
        public int Id_SectionPostImage { get; set; }
        public SectionPostImage? SectionPostImage { get; set; }
        [DisplayName("سۆشیاڵ")]
        [ForeignKey("SectionPostSocialVideo")]
        public int Id_SectionPostSocialVideo { get; set; }
        public SectionPostSocialVideo? SectionPostSocialVideo { get; set; }
        [DisplayName("ویدیۆ ئادرەس")]
        public string? VideoAddress { get; set; }
        public ICollection<SectionPostCommentStep>? SectionPostCommentSteps { get; set; }
        //Constructors
        public SectionPostStep()
        {

        }
        public SectionPostStep(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime startTime, DateTime endTime, DateTime createDate, int id_SectionPostType, SectionPostType? sectionPostType, int id_SectionThirdStep, SectionThirdStep? sectionThirdStep, string? title, string? shortDescription, string? fullDescription, int id_SectionPostImage, SectionPostImage? sectionPostImage, int id_SectionPostSocialVideo, SectionPostSocialVideo? sectionPostSocialVideo, string? videoAddress, ICollection<SectionPostCommentStep>? sectionPostCommentSteps) : base(id, active, timable, startDate, endDate, startTime, endTime, createDate)
        {
            Id_SectionPostType = id_SectionPostType;
            SectionPostType = sectionPostType;
            Id_SectionThirdStep = id_SectionThirdStep;
            SectionThirdStep = sectionThirdStep;
            Title = title;
            ShortDescription = shortDescription;
            FullDescription = fullDescription;
            Id_SectionPostImage = id_SectionPostImage;
            SectionPostImage = sectionPostImage;
            Id_SectionPostSocialVideo = id_SectionPostSocialVideo;
            SectionPostSocialVideo = sectionPostSocialVideo;
            VideoAddress = videoAddress;
            SectionPostCommentSteps = sectionPostCommentSteps;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostStep(bool ActivatedNotTimabled, int id_SectionPostType, SectionPostType? sectionPostType, int id_SectionThirdStep, SectionThirdStep? sectionThirdStep, string? title, string? shortDescription, string? fullDescription, int id_SectionPostImage, SectionPostImage? sectionPostImage, int id_SectionPostSocialVideo, SectionPostSocialVideo? sectionPostSocialVideo, string? videoAddress, ICollection<SectionPostCommentStep>? sectionPostCommentSteps) : base(ActivatedNotTimabled)
        {
            Id_SectionPostType = id_SectionPostType;
            SectionPostType = sectionPostType;
            Id_SectionThirdStep = id_SectionThirdStep;
            SectionThirdStep = sectionThirdStep;
            Title = title;
            ShortDescription = shortDescription;
            FullDescription = fullDescription;
            Id_SectionPostImage = id_SectionPostImage;
            SectionPostImage = sectionPostImage;
            Id_SectionPostSocialVideo = id_SectionPostSocialVideo;
            SectionPostSocialVideo = sectionPostSocialVideo;
            VideoAddress = videoAddress;
            SectionPostCommentSteps = sectionPostCommentSteps;
        }
    }
}
