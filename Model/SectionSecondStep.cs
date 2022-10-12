using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Model
{
    public class SectionSecondStep : ControlPublishFields
    {
        [DisplayName("ناو")]
        public string? Name { get; set; }
        [DisplayName("لەبارەی")]
        public string? Description { get; set; }
        [DisplayName("ناوی سەردەستە")]
        [ForeignKey("SectionFirstStep")]
        public int Id_SectionFirstStep { get; set; }
        public SectionFirstStep? SectionFirstStep { get; set; }
        public ICollection<SectionThirdStep>? SectionThirdSteps { get; set; }

        //Constructors
        public SectionSecondStep()
        {

        }
        public SectionSecondStep(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime startTime, DateTime endTime, DateTime createDate, string? name, string? description, int id_SectionFirstStep, SectionFirstStep? sectionFirstStep, ICollection<SectionThirdStep>? sectionThirdSteps) : base(id, active, timable, startDate, endDate, startTime, endTime, createDate)
        {
            Name = name;
            Description = description;
            Id_SectionFirstStep = id_SectionFirstStep;
            SectionFirstStep = sectionFirstStep;
            SectionThirdSteps = sectionThirdSteps;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionSecondStep(bool ActivatedNotTimabled, string? name, string? description, int id_SectionFirstStep, SectionFirstStep? sectionFirstStep, ICollection<SectionThirdStep>? sectionThirdSteps) : base(ActivatedNotTimabled)
        {
            Name = name;
            Description = description;
            Id_SectionFirstStep = id_SectionFirstStep;
            SectionFirstStep = sectionFirstStep;
            SectionThirdSteps = sectionThirdSteps;
        }
    }
}
