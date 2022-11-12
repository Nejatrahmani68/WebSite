using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SectionThirdStep : ControlPublishFields
    {
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
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
        public SectionThirdStep(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, string? name, string? description, int id_SectionSecondStep) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Name = name;
            Description = description;
            Id_SectionSecondStep = id_SectionSecondStep;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>  
        public SectionThirdStep(bool ActivatedNotTimabled, string? email,string? tagsName, string? name, string? description, int id_SectionSecondStep) : base(ActivatedNotTimabled,email,tagsName)
        {
            Name = name;
            Description = description;
            Id_SectionSecondStep = id_SectionSecondStep;
        }
    }
}
