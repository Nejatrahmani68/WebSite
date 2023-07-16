using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ArmySocialsName : ControlPublishFields
    {
        [Required(ErrorMessage = "پێویستە پڕ کرێتەوە")]
        [DisplayName("ناو")]
        public string? Title { get; set; }
        [DisplayName("لەبارەی")]
        public string? Desciption { get; set; }
        public ICollection<ArmyMembersAccounts>? ArmyMembersAccounts { get; set; }

       
    }
}
