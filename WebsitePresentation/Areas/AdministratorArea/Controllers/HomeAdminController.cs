using DataAccess.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using WebsitePresentation.Controllers;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Admin,Administrator")]
    public class HomeAdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ServiceAdminControl _serviceAdminControl;

        public HomeAdminController(ILogger<HomeController> logger, ServiceAdminControl serviceAdminControl)
        {
            _logger = logger;
            _serviceAdminControl = serviceAdminControl; 
        }
        public IActionResult Index()
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            ViewBag.WebsiteTitle = _serviceAdminControl.WebsiteTitle();
            _logger.LogInformation(CultureInfo.CurrentCulture.Name);
            return RedirectToAction("Index", "SectionFirstSteps");
        }
    }
}
