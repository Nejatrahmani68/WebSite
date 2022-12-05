using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class WebsiteAdminsControl : ControlPublishFields
    {
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("ناو و ناسناو")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("کورتەباس")]
        public string? ShortDescription { get; set; }
        [DisplayName("لەبارەی")]
        public string? FullDescription { get; set; }
        [DisplayName("ژمارە تەلەفوون")]
        [Phone]
        public string? TellphoneNmber { get; set; }
        [DisplayName("وێنە")]
        public string? PictureAddress { get; set; }
        
        //Constructors
        public WebsiteAdminsControl()
        {

        }
        public WebsiteAdminsControl(int id, bool active, bool timable, DateTime? startDate, DateTime? endDate, DateTime? startTime, DateTime? endTime, DateTime createDate, string? email,string? tagsName, string? title, string? shortDescription, string? fullDescription, string? tellphoneNmber, string? pictureAddress) : base(id, active, timable, startDate, endDate, createDate, email, tagsName)
        {
            Title = title;
            ShortDescription = shortDescription;
            FullDescription = fullDescription;
            Email = email;
            TellphoneNmber = tellphoneNmber;
            PictureAddress = pictureAddress;
            TagsName = tagsName;
        }
        /// <summary>
        /// Publish Activated and Not Timabled Automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="sectionSecondSteps"></param>
        public WebsiteAdminsControl(bool ActivatedNotTimabled, string? email,string? tagsName, string? title, string? shortDescription, string? fullDescription, string? tellphoneNmber, string? pictureAddress) : base(ActivatedNotTimabled,email,tagsName)
        {
            Title = title;
            ShortDescription = shortDescription;
            FullDescription = fullDescription;
            Email = email;
            TellphoneNmber = tellphoneNmber;
            PictureAddress = pictureAddress;
        }


    }
}
