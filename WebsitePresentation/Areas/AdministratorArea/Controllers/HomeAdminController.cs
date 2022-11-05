using DataAccess.Data;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModels;
using WebsitePresentation.Controllers;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    public class HomeAdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly ViewModelHomePage _viewModelHomPage;

        public HomeAdminController(ILogger<HomeController> logger, ApplicationDbContext context, ViewModelHomePage viewModelHomePage)
        {
            _logger = logger;
            _db = context;
            _viewModelHomPage = viewModelHomePage;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Index", "SectionFirstSteps");
        }
    }
}
