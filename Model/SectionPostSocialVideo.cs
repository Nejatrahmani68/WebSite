using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Model
{
    public class SectionPostSocialVideo:ControlPublishFields
    {
        [DisplayName("ناو")]
        public string? Title { get; set; }
        [DisplayName("ئادرەس")]
        public string? Address { get; set; }
        [DisplayName("كارابوون")]
        public ICollection<SectionPostVideo>? SectionPostVideos { get; set; }

        //Constructors
        public SectionPostSocialVideo()
        {

        }
        public SectionPostSocialVideo(int id, bool active, bool timable, DateTime startDate, DateTime endDate, DateTime createDate, string? email,string? tagsName, string? title, string? address) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Title = title;
            Address= address;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public SectionPostSocialVideo(bool ActivatedNotTimabled, string? email,string? tagsName, string? title, string? address) : base(ActivatedNotTimabled,email,tagsName)
        {
            Title = title;
            Address = address;
        }
    }
}
