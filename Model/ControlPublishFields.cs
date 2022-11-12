using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ControlPublishFields
    {
        [Key]
        [DisplayName("ئایدی")]
        public int Id { get; set; }
        [DisplayName("كارابوون")]
        public bool Active { get; set; }
        [DisplayName("کات دار")]
        public bool Timable { get; set; }
        [DisplayName("بەرواری دەستپێکردن")]
        public DateTime? StartDate { get; set; }
        [DisplayName("بەرواری کۆتایی")]
        public DateTime? EndDate { get; set; }
        [DisplayName("کاتی دروستبون")]
        public DateTime CreateDate { get; set; } = System.DateTime.Now;
        [DisplayName("ئیمەێل")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("تەگ")]
        public string? TagsName { get; set; }

        //Constructors
        public ControlPublishFields()
        {

        }
        public ControlPublishFields(int id, bool active, bool timable, DateTime? startDate, DateTime? endDate, DateTime createDate, string? email, string? tagsName)
        {
            Id = id;
            Active = active;
            Timable = timable;
            StartDate = startDate;
            EndDate = endDate;
            CreateDate = createDate;
            Email = email;  
            TagsName = tagsName;
        }
        public ControlPublishFields(bool ActivatedNotTimabled,string? email, string? tagsName)
        {
            if (ActivatedNotTimabled)
            {
                Active = true;
                Timable = false;
                StartDate = null;
                EndDate = null;
                
            }
            else
            {
                Active = false;
                Timable = false;
                StartDate = null;
                EndDate = null;
            }
            CreateDate = System.DateTime.Now;
            Email = email;
            TagsName = tagsName;    
        }
    }
}
