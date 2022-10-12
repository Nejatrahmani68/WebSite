using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Model
{
    public class SectionFirstStep:ControlPublishFields
    {
        [DisplayName("ناو")]
        public string? Name { get; set; }
        [DisplayName("لەبارەی")]
        public string? Description { get; set; }
        public ICollection<SectionSecondStep>? SectionSecondSteps { get; set; }

        //Constructors
        public SectionFirstStep()
        {

        }
        public SectionFirstStep(int id, bool active, bool timable, DateTime? startDate, DateTime? endDate, DateTime? startTime, DateTime? endTime, DateTime createDate, string? name, string? description, ICollection<SectionSecondStep>? sectionSecondSteps) : base(id, active, timable, startDate, endDate, startTime, endTime, createDate)
        {
            Name = name;
            Description = description;
            SectionSecondSteps = sectionSecondSteps;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionFirstStep(bool ActivatedNotTimabled, string? name, string? description, ICollection<SectionSecondStep>? sectionSecondSteps) : base(ActivatedNotTimabled)
        {
            Name = name;
            Description = description;
            SectionSecondSteps = sectionSecondSteps;
        }
    }
}
