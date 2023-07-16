using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class ArmyMembers : ControlPublishFields
    {
        [Required(ErrorMessage ="پێویستە پڕ کرێتەوە")]
        [DisplayName("ناو")]
        public string? Name { get; set; }
        [DisplayName("ئیمەیل")]
        [EmailAddress]
        public string? MemberEmail { get; set; }
        [DisplayName("ژمارەی پەیوەندی")]
        public string? TellNumber { get; set; }
        public ICollection<ArmyMembersAccount>? ArmyMembersAccounts { get; set; }

      
    }
}
