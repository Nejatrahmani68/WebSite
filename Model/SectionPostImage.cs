using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SectionPostImage:ControlPublishFields
    {
        [DisplayName("ناو")]
        public string? Title { get; set; }
        [DisplayName("ناوی وێنە")]
        public string? PictureAddress { get; set; }
        [DisplayName("پۆست")]
        [ForeignKey("SectionPostStep")]
        public int Id_SectionPostStep { get; set; }
        public SectionPostStep? SectionPostStep { get; set; }
        //Constructors
        public SectionPostImage()
        {
                
        }
        public SectionPostImage(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, string? title, string? pictureAddress, int id_SectionPostStep) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Title = title;
            PictureAddress = pictureAddress;
            Id_SectionPostStep = id_SectionPostStep;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostImage(bool ActivatedNotTimabled, string? email,string? tagsName, string? title, string? pictureAddress, int id_SectionPostStep) : base(ActivatedNotTimabled,email,tagsName)
        {
            Title = title;
            PictureAddress = pictureAddress;
            Id_SectionPostStep = id_SectionPostStep;
        }
    }
}
