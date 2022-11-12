using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SectionPostType : ControlPublishFields
    {
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("ناو")]
        public string? Title { get; set; }
        public ICollection<SectionPostStep>? SectionPostSteps { get; set; }

        //Constructors
        public SectionPostType()
        {

        }
        public SectionPostType(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, string? title) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Title = title;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostType(bool ActivatedNotTimabled, string? email,string? tagsName, string? title) : base(ActivatedNotTimabled,email,tagsName)
        {
            Title = title;
        }
    }
}
