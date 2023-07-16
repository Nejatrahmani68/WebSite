using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class ArmyMembersAccount : ControlPublishFields
    {

        [DisplayName("سۆشیاڵ")]
        [ForeignKey("ArmySocialsName")]
        public int? Id_ArmySocialsName { get; set; }
        public ArmySocialsName? ArmySocialsName { get; set; }
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("ئادرەس")]
        public string? SocialAddress { get; set; }
        [DisplayName("ئەندام")]
        [ForeignKey("ArmyMembers")]
        public int? Id_ArmyMembers { get; set; }
        public ArmyMembers? ArmyMembers { get; set; }  
    }
}
