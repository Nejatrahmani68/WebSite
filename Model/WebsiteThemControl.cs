using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class WebsiteThemControl : ControlPublishFields
    {

        [DisplayName("ناوی بەش")]
        public string? SectionName { get; set; }

        //Constructors
        public WebsiteThemControl()
        {

        }
        public WebsiteThemControl(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime startTime, DateTime endTime, DateTime createDate, string? sectionName) : base(id, active, timable, startDate, endDate, startTime, endTime, createDate)
        {
            SectionName = sectionName;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public WebsiteThemControl(bool ActivatedNotTimabled, string? sectionName) : base(ActivatedNotTimabled)
        {
            SectionName = sectionName;
        }
    }
}
