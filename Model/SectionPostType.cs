using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SectionPostType : ControlPublishFields
    {
        [DisplayName("ناو")]
        public string? Title { get; set; }
        public ICollection<SectionPostStep>? SectionPostSteps { get; set; }

        //Constructors
        public SectionPostType()
        {

        }
        public SectionPostType(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime startTime, DateTime endTime, DateTime createDate, string? title, ICollection<SectionPostStep>? sectionPostSteps) : base(id, active, timable, startDate, endDate, startTime, endTime, createDate)
        {
            Title = title;
            SectionPostSteps = sectionPostSteps;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostType(bool ActivatedNotTimabled, string? title, ICollection<SectionPostStep>? sectionPostSteps) : base(ActivatedNotTimabled)
        {
            Title = title;
            SectionPostSteps = sectionPostSteps;
        }
    }
}
