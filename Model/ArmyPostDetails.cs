using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class ArmyPostDetails : ControlPublishFields
    {
        [DisplayName("ناو")]
        public string? Name { get; set; }
        [DisplayName("تێبینی")]
        public string? Description { get; set; }
        [DisplayName("لینک")]
        public string? Link { get; set; }
        [DisplayName("لایک")]
        public bool Like { get; set; }
        [DisplayName("هاوبەش کردن بە پۆست")]
        public bool ShareAsPost { get; set; }
        [DisplayName("هاوبەش کردن بە ستۆری")]
        public bool ShareAsStory { get; set; }
        [DisplayName("تویتێر")]
        public bool Twit { get; set; }
        [DisplayName("سەیڤ")]
        public bool Save { get; set; }
        [DisplayName("کومینتی پۆزێتیڤ")]
        public bool CommentPssitive { get; set; }
        [DisplayName("کۆمێنتی نێگێتیڤ")]
        public bool CommentNegetive { get; set; }
        [DisplayName("بلاک")]
        public bool Block { get; set; }
        [DisplayName("ڕیپۆرت")]
        public bool Report { get; set; }
      


    }
}
