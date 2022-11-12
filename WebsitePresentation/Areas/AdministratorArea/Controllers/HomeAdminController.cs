using DataAccess.Data;
using DataAccess.Services;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.ViewModels;
using System.Data;
using WebsitePresentation.Controllers;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Admin,Administrator")]
    public class HomeAdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeAdminController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _db = context;
        }
        public IActionResult Index()
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_db);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            return RedirectToAction("Index", "SectionFirstSteps");
        }
    }
}
