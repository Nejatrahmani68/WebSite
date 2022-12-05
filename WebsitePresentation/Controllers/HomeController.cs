using DataAccess.Data;
using DataAccess.Services;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Model;
using Model.ViewModels;
using System;
using System.Diagnostics;
using System.IO;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebsitePresentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly ViewModelHomePage _viewModelHomPage;
        private readonly ServicesHome _serviceHome;
        [Obsolete]
        private readonly IHostingEnvironment _env;

        [Obsolete]
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, ViewModelHomePage viewModelHomePage, ServicesHome serviceHome, IHostingEnvironment env)
        {
            _logger = logger;
            _db = context;
            _viewModelHomPage = viewModelHomePage;
            _serviceHome = serviceHome;
            _env = env;
        }
        public IActionResult Index()
        {
            _serviceHome.FillHomapageModel();
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
            _serviceHome.FillHomapageModelForPostView(idPost);
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
            _serviceHome.FillHomapageModelForThirStepView(idSecondStep);
            //Check Website Active Time
            if (!_viewModelHomPage.IsActive)
            {
                ViewData["ErrorReportMessage"] = "لە کۆنترۆڵی کاتی کارا بوونی وێبسایت دا کێشە هاتۆتە پێش";
                return View("ErrorReportView", _viewModelHomPage);
            }
            return View(_viewModelHomPage);
        }

        public IActionResult PostsCategoryView(int idThirdStep, int? page)
        {
            _serviceHome.FillHomapageModelForViewSubCategoryPosts(idThirdStep, page);
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
            _serviceHome.FillHomapageModel();
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
        public IActionResult PostInsertComment(string userName, string mailAddress, string commentText, int idPost)
        {
            if (userName != "" && mailAddress != "" && commentText != "")
            {
                SectionPostCommentStep NewComment = new SectionPostCommentStep(false, mailAddress, "", userName, commentText, idPost);
                _db.SectionPostCommentSteps!.Add(NewComment);
                _db.SaveChanges();
                return RedirectToAction("PostView", new { idPost });
            }
            else
            {
                ViewBag.Error = "نەبو";
                return View("PostView");
            }
        }
        [Obsolete]
        public IActionResult Download(int? idFile)
        {
            var FileForDownload = _db.SectionPostFiles!.Find(idFile);
            if (FileForDownload != null)
            {
                var filepath = Path.Combine(_env.WebRootPath, "Files", "PostFiles", FileForDownload.FileAddress!);
                return File(System.IO.File.ReadAllBytes(filepath), "Winrar/rar", FileForDownload.Title + Path.GetExtension(FileForDownload.FileAddress));
            }
            return NotFound();
        }
        public IActionResult ChangeLanguage(string language)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(language)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            //return Redirect(Request.Headers["Referer"].ToString());
            return RedirectToAction("Index");
        }
        public IActionResult ViewAllPostInfinitScroll(int? page)
        {
            _serviceHome.FillHomapageModelForViewAllPostInfinitScroll(page);
            //Check Website Active Time
            if (!_viewModelHomPage.IsActive)
            {
                ViewData["ErrorReportMessage"] = "لە کۆنترۆڵی کاتی کارا بوونی وێبسایت دا کێشە هاتۆتە پێش";
                return View("ErrorReportView", _viewModelHomPage);
            }

            return View(_viewModelHomPage);
        }

        public IActionResult ViewAllPostOrderByType(string postType, int? page)
        {
            _serviceHome.FillHomapageModelForViewAllPostOrderedByType(postType, page);
            //Check Website Active Time
            if (!_viewModelHomPage.IsActive)
            {
                ViewData["ErrorReportMessage"] = "لە کۆنترۆڵی کاتی کارا بوونی وێبسایت دا کێشە هاتۆتە پێش";
                return View("ErrorReportView", _viewModelHomPage);
            }

            return View("ViewAllPostInfinitScroll", _viewModelHomPage);
        }
        

    }
}