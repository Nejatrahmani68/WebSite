using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class UserRolesViewModel
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public IEnumerable<string>? Roles { get; set; }
    }
}
