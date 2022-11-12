using DataAccess.Data;
using DataAccess.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Administrator")]
    public class RoleManagerController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        public RoleManagerController(RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(string roleName)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (roleName != null)
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(string Name)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (Name == null)
            {
                return NotFound();
            }
            var roles = await _roleManager.Roles.FirstOrDefaultAsync(m => m.Name == Name);
            return View(roles);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string Name)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (Name != null)
            {
                var roles =  _roleManager.Roles.FirstOrDefault(m => m.Name == Name);
                await _roleManager.DeleteAsync(roles!);
            }
            return RedirectToAction("Index");
        }
    }
}
