using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    //For Active or Deactive And Schedule Website Work Time
    public class WebsiteActiveTimeControl : ControlPublishFields
    {
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("سەردێڕ")]
        public string? WebsiteTitle { get; set; }
        //Constructors
        public WebsiteActiveTimeControl()
        {

        }
        public WebsiteActiveTimeControl(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, string websiteTitle) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            WebsiteTitle = websiteTitle;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public WebsiteActiveTimeControl(bool ActivatedNotTimabled, string? email,string? tagsName, string websiteTitle) : base(ActivatedNotTimabled,email,tagsName)
        {
            WebsiteTitle = websiteTitle;
        }
    }
}
