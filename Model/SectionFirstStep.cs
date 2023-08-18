using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SectionFirstStep : ControlPublishFields
    {
        [DisplayName("زمان")]
        [ForeignKey("SectionLanguage")]
        public int? Id_LanguageStep { get; set; }
        public SectionLanguage? SectionLanguage { get; set; }
        [Required(ErrorMessage ="پێویستە پڕ کرێتەوە")]
        [DisplayName("ناو")]
        public string? Name { get; set; }
        [DisplayName("لەبارەی")]
        public string? Description { get; set; }
        public ICollection<SectionSecondStep>? SectionSecondSteps { get; set; }

        //Constructors
        public SectionFirstStep()
        {

        }
        public SectionFirstStep(int id, bool active, bool timable, DateTime? startDate, DateTime? endDate, DateTime createDate, string? email, string? tagsName, string? name, string? description, int id_LanguageStep) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Name = name;
            Description = description;
            Id_LanguageStep = id_LanguageStep;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionFirstStep(bool ActivatedNotTimabled, string? email, string? tagsName, string? name, string? description, int id_LanguageStep) : base(ActivatedNotTimabled, email, tagsName)
        {
            Name = name;
            Description = description;
            Id_LanguageStep = id_LanguageStep;
        }
    }
}
