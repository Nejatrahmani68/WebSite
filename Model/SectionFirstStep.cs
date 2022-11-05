using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Model
{
    public class SectionFirstStep : ControlPublishFields
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
        public SectionFirstStep(int id, bool active, bool timable, DateTime? startDate, DateTime? endDate, DateTime createDate, string? email, string? tagsName, string? name, string? description) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Name = name;
            Description = description;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionFirstStep(bool ActivatedNotTimabled, string? email, string? tagsName, string? name, string? description) : base(ActivatedNotTimabled, email, tagsName)
        {
            Name = name;
            Description = description;
        }
    }
}
