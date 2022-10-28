using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Model
{
    public class SectionPostCommentStep : ControlPublishFields
    {

        [DisplayName("کۆمێنت")]
        public string? Comment { get; set; }
        [DisplayName("ناوی پۆست")]
        [ForeignKey("SectionPostStep")]
        public int Id_SectionPostStep { get; set; }
        public SectionPostStep? SectionPostStep { get; set; }
        public ICollection<SectionPostAnswerStep>? SectionPostAnswerSteps { get; set; }
        //Constructors
        public SectionPostCommentStep()
        {

        }
        public SectionPostCommentStep(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, string? comment, int id_SectionPostStep, SectionPostStep? sectionPostStep) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Comment = comment;
            Id_SectionPostStep = id_SectionPostStep;
            SectionPostStep = sectionPostStep;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostCommentStep(bool ActivatedNotTimabled, string? email,string? tagsName, string? comment, int id_SectionPostStep, SectionPostStep? sectionPostStep) : base(ActivatedNotTimabled,email,tagsName)
        {
            Comment = comment;
            Id_SectionPostStep = id_SectionPostStep;
            SectionPostStep = sectionPostStep;
        }
    }
}
