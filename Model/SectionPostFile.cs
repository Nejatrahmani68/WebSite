using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class SectionPostFile : ControlPublishFields
    {
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("ناو")]
        public string? Title { get; set; }
        [DisplayName("فایل")]
        public string? FileAddress { get; set; }
        [DisplayName("قەبارەی فایل")]
        public string? FileSize { get; set; }
        [DisplayName("جۆری فایل")]
        public string? FileType { get; set; }
        [DisplayName("پۆست")]
        [ForeignKey("SectionPostStep")]
        public int? Id_SectionPostStep { get; set; }
        public SectionPostStep? SectionPostStep { get; set; }
        //Constructors
        public SectionPostFile()
        {
                
        }
        public SectionPostFile(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, string? title, string? fileAddress, int id_SectionPostStep) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Title = title;
            FileAddress = fileAddress;
            Id_SectionPostStep = id_SectionPostStep;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostFile(bool ActivatedNotTimabled, string? email,string? tagsName, string? title, string? fileAddress, int id_SectionPostStep) : base(ActivatedNotTimabled,email,tagsName)
        {
            Title = title;
            FileAddress = fileAddress;
            Id_SectionPostStep = id_SectionPostStep;
        }
    }
}
