using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class SectionLanguage : ControlPublishFields
    {
        [Required(ErrorMessage ="پێویستە پڕ کرێتەوە")]
        [DisplayName("ناو")]
        public string? Name { get; set; }
        [DisplayName("ناونیشان")]
        public string? Title { get; set; }
        [DisplayName("لەبارەی")]
        public string? Description { get; set; }

        public ICollection<SectionFirstStep>? SectionFirstSteps { get; set; }
        //Constructors
        public SectionLanguage()
        {

        }
        public SectionLanguage(int id, bool active, bool timable, DateTime? startDate, DateTime? endDate, DateTime createDate, string? email, string? tagsName, string? name,string title, string? description) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Name = name;
            Description = description;
            Title= title;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionLanguage(bool ActivatedNotTimabled, string? email, string? tagsName, string? name, string title, string? description) : base(ActivatedNotTimabled, email, tagsName)
        {
            Name = name;
            Description = description;
            Title= title;
        }
    }
}
