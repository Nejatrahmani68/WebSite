using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SectionPostImage:ControlPublishFields
    {
        [DisplayName("ناو")]
        public string? Title { get; set; }
        [DisplayName("وێنە")]
        public string? PictureAddress { get; set; }
        public ICollection<SectionPostStep>? SectionPostSteps { get; set; }

        //Constructors
        public SectionPostImage()
        {
                
        }
        public SectionPostImage(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime startTime, DateTime endTime, DateTime createDate, string? title, string? pictureAddress, ICollection<SectionPostStep>? sectionPostSteps) : base(id, active, timable, startDate, endDate, startTime, endTime, createDate)
        {
            Title = title;
            PictureAddress = pictureAddress;
            SectionPostSteps = sectionPostSteps;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostImage(bool ActivatedNotTimabled, string? title, string? pictureAddress, ICollection<SectionPostStep>? sectionPostSteps) : base(ActivatedNotTimabled)
        {
            Title = title;
            PictureAddress = pictureAddress;
            SectionPostSteps = sectionPostSteps;
        }
    }
}
