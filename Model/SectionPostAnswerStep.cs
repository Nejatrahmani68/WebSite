using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Model
{
    public class SectionPostAnswerStep : ControlPublishFields
    {

        [DisplayName("وڵام")]
        public string? Answer { get; set; }
        [DisplayName("ناوی کۆمێنت")]
        [ForeignKey("SectionPostCommentStep")]
        public int Id_SectionPostCommentStep { get; set; }
        public SectionPostCommentStep? SectionPostCommentStep { get; set; }

        //Constructors
        public SectionPostAnswerStep()
        {

        }
        public SectionPostAnswerStep(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, string? answer, int id_SectionPostCommentStep, SectionPostCommentStep? sectionPostCommentStep) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Answer = answer;
            Id_SectionPostCommentStep = id_SectionPostCommentStep;
            SectionPostCommentStep = sectionPostCommentStep;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostAnswerStep(bool ActivatedNotTimabled, string? email,string? tagsName, string? answer, int id_SectionPostCommentStep, SectionPostCommentStep? sectionPostCommentStep) : base(ActivatedNotTimabled,email,tagsName)
        {
            Answer = answer;
            Id_SectionPostCommentStep = id_SectionPostCommentStep;
            SectionPostCommentStep = sectionPostCommentStep;
        }
    }
}
