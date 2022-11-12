using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SectionPostVideo : ControlPublishFields
    {
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("ناو")]
        public string? Title { get; set; }
        [DisplayName("سۆشیاڵ")]
        [ForeignKey("SectionPostSocialVideo")]
        public int Id_SectionPostSocialVideo { get; set; }
        public SectionPostSocialVideo? SectionPostSocialVideo { get; set; }
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("ویدیۆ")]
        public string? VideoAddress { get; set; }
        [DisplayName("پۆست")]
        [ForeignKey("SectionPostStep")]
        public int Id_SectionPostStep { get; set; }
        public SectionPostStep? SectionPostStep { get; set; }
        
        //Constructors
        public SectionPostVideo()
        {
                
        }
        public SectionPostVideo(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, string? title, string? videoAddress, int id_SectionPostStep) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Title = title;
            VideoAddress = videoAddress;
            Id_SectionPostStep = id_SectionPostStep;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostVideo(bool ActivatedNotTimabled, string? email,string? tagsName, string? title, string? videoAddress, int id_SectionPostStep) : base(ActivatedNotTimabled,email,tagsName)
        {
            Title = title;
            VideoAddress = videoAddress;
            Id_SectionPostStep = id_SectionPostStep;
        }
    }
}
