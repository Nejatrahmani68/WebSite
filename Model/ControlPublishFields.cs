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
        [DisplayName("کاتی دەستپێکردن")]
        public DateTime? StartTime { get; set; }
        [DisplayName("کاتی کۆتایی")]
        public DateTime? EndTime { get; set; }
        [DisplayName("کاتی دروستبون")]
        public DateTime CreateDate { get; set; } = System.DateTime.Now;

        //Constructors
        public ControlPublishFields()
        {

        }
        public ControlPublishFields(int id, bool active, bool timable, DateTime? startDate, DateTime? endDate, DateTime? startTime, DateTime? endTime, DateTime createDate)
        {
            Id = id;
            Active = active;
            Timable = timable;
            StartDate = startDate;
            EndDate = endDate;
            StartTime = startTime;
            EndTime = endTime;
            CreateDate = createDate;
        }
        public ControlPublishFields(bool ActivatedNotTimabled)
        {
            if (ActivatedNotTimabled)
            {
                Active = true;
                Timable = false;
                StartDate = null;
                EndDate = null;
                StartTime = null;
                EndTime = null;
                CreateDate = System.DateTime.Now;
            }
            else
            {
                Active = false;
                Timable = false;
                StartDate = null;
                EndDate = null;
                StartTime = null;
                EndTime = null;
                CreateDate = System.DateTime.Now;
            }
        }
    }
}
