using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DataAccess.Data;
using DataAccess.Services;
using Model.ViewModels;

namespace WebsitePresentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly ViewModelHomePage _viewModelHomPage;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, ViewModelHomePage viewModelHomePage)
        {
            _logger = logger;
            _db = context;
            _viewModelHomPage = viewModelHomePage;
        }
        public IActionResult Index()
        {
            ServicesHome serviceHome = new ServicesHome(_db, _viewModelHomPage);
            serviceHome.FillHomapageModel();
            //Check Website Active Time
            if (!_viewModelHomPage.IsActive)
            {
                ViewData["ErrorReportMessage"] = "لە کۆنترۆڵی کاتی کارا بوونی وێبسایت دا کێشە هاتۆتە پێش";
                return View("ErrorReportView", _viewModelHomPage);
            }
            return View(_viewModelHomPage);
        }

        public IActionResult About()
        {
            ServicesHome serviceHome = new ServicesHome(_db, _viewModelHomPage);
            serviceHome.FillHomapageModel();
            if (!_viewModelHomPage.IsActive)
            {
                ViewData["ErrorReportMessage"] = "لە کۆنترۆڵی کاتی کارا بوونی وێبسایت دا کێشە هاتۆتە پێش";
                return View("ErrorReportView", _viewModelHomPage);
            }
            return View(_viewModelHomPage);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(String? messageError)
        {
            ViewData["MessageError"] = messageError;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}