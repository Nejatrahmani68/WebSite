using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DataAccess.Data;
using DataAccess.Services;
using Model.ViewModels;
using Model;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

        public IActionResult PostView(int idPost)
        {
            ServicesHome serviceHome = new ServicesHome(_db, _viewModelHomPage);
            serviceHome.FillHomapageModelForPostView(idPost);
            //Check Website Active Time
            if (!_viewModelHomPage.IsActive)
            {
                ViewData["ErrorReportMessage"] = "لە کۆنترۆڵی کاتی کارا بوونی وێبسایت دا کێشە هاتۆتە پێش";
                return View("ErrorReportView", _viewModelHomPage);
            }
            return View(_viewModelHomPage);
        }
        public IActionResult SectionThirdStepView(int idSecondStep)
        {
            ServicesHome serviceHome = new ServicesHome(_db, _viewModelHomPage);
            serviceHome.FillHomapageModelForThirStepView(idSecondStep);
            //Check Website Active Time
            if (!_viewModelHomPage.IsActive)
            {
                ViewData["ErrorReportMessage"] = "لە کۆنترۆڵی کاتی کارا بوونی وێبسایت دا کێشە هاتۆتە پێش";
                return View("ErrorReportView", _viewModelHomPage);
            }
            return View(_viewModelHomPage);
        }

        public IActionResult PostsCategoryView(int idThirdStep,int? page)
        {
            ServicesHome serviceHome = new ServicesHome(_db, _viewModelHomPage);
            serviceHome.FillHomapageModelForViewSubCategoryPosts(idThirdStep,page);
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
        [HttpPost]
        public IActionResult PostInsertComment(string userName, string mailAddress, string commentText,int idPost)
        {
            if (userName != "" && mailAddress != "" && commentText != "")
            {
                SectionPostCommentStep NewComment=new SectionPostCommentStep(false,mailAddress,"",userName,commentText,idPost);
                _db.SectionPostCommentSteps.Add(NewComment);
                _db.SaveChanges();
                return RedirectToAction("PostView", new {idPost});
            }
            else
            {
                ViewBag.Error  = "نەبو";
                return View("PostView"); 
            }
        }
        

    }
}