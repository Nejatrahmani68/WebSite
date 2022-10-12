using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SectionThirdStep : ControlPublishFields
    {
        [DisplayName("ناو")]
        public string? Name { get; set; }
        [DisplayName("لەبارەی")]
        public string? Description { get; set; }
        [DisplayName("ناوی سەردەستە")]
        [ForeignKey("SectionSecondStep")]
        public int Id_SectionSecondStep { get; set; }
        public SectionSecondStep? SectionSecondStep { get; set; }
        public ICollection<SectionPostStep>? SectionPostSteps { get; set; }

        //Constructors
        public SectionThirdStep()
        {

        }
        public SectionThirdStep(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime startTime, DateTime endTime, DateTime createDate, string? name, string? description, int id_SectionSecondStep, SectionSecondStep? sectionSecondStep, ICollection<SectionPostStep>? sectionPostSteps) : base(id, active, timable, startDate, endDate, startTime, endTime, createDate)
        {
            Name = name;
            Description = description;
            Id_SectionSecondStep = id_SectionSecondStep;
            SectionSecondStep = sectionSecondStep;
            SectionPostSteps = sectionPostSteps;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>  
        public SectionThirdStep(bool ActivatedNotTimabled, string? name, string? description, int id_SectionSecondStep, SectionSecondStep? sectionSecondStep, ICollection<SectionPostStep>? sectionPostSteps) : base(ActivatedNotTimabled)
        {
            Name = name;
            Description = description;
            Id_SectionSecondStep = id_SectionSecondStep;
            SectionSecondStep = sectionSecondStep;
            SectionPostSteps = sectionPostSteps;
        }
    }
}
