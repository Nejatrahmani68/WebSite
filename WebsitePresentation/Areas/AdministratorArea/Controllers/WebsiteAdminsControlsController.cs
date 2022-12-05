using DataAccess.Data;
using DataAccess.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    //IN Case Limited Admin Add Admin Detail,Empty is Equal to Admin Not Limited
    [Area("AdministratorArea")]
    [Authorize(Roles = "Administrator")]
    public class WebsiteAdminsControlsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;
        [ObsoleteAttribute("ناردنی فایل")]
        private readonly IHostingEnvironment _env;

        [ObsoleteAttribute("ناردنی فایل")]
        public WebsiteAdminsControlsController(ApplicationDbContext context, IHostingEnvironment env, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _env = env;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: AdministratorArea/WebsiteAdminsControls
        public async Task<IActionResult> Index()
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            return View(await _context.WebsiteAdminsControls!.ToListAsync());
        }

        // GET: AdministratorArea/WebsiteAdminsControls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.WebsiteAdminsControls == null)
            {
                return NotFound();
            }

            var websiteAdminsControl = await _context.WebsiteAdminsControls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (websiteAdminsControl == null)
            {
                return NotFound();
            }

            return View(websiteAdminsControl);
        }

        // GET: AdministratorArea/WebsiteAdminsControls/Create
        public IActionResult Create()
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            return View();
        }

        // POST: AdministratorArea/WebsiteAdminsControls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ObsoleteAttribute("ناردنی فایل")]
        public async Task<IActionResult> Create(IFormFile files, [Bind("Title,ShortDescription,FullDescription,TellphoneNmber,PictureAddress,Id,Active,Timable,StartDate,EndDate,Email,TagsName")] WebsiteAdminsControl websiteAdminsControl)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                if (files.Length > 0)
                {
                    // full path to file in temp location
                    string newFilename = websiteAdminsControl.TellphoneNmber + "-" + Guid.NewGuid().ToString() + Path.GetExtension(files.FileName);
                    string filePath = Path.Combine(_env.WebRootPath, "Images", "ImageAdmin", newFilename);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await files.CopyToAsync(stream);
                    }
                    websiteAdminsControl.PictureAddress = newFilename;
                    _context.Add(websiteAdminsControl);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                _context.Add(websiteAdminsControl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(websiteAdminsControl);
        }

        // GET: AdministratorArea/WebsiteAdminsControls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.WebsiteAdminsControls == null)
            {
                return NotFound();
            }

            var websiteAdminsControl = await _context.WebsiteAdminsControls.FindAsync(id);
            if (websiteAdminsControl == null)
            {
                return NotFound();
            }
            return View(websiteAdminsControl);
        }

        // POST: AdministratorArea/WebsiteAdminsControls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,ShortDescription,FullDescription,TellphoneNmber,PictureAddress,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] WebsiteAdminsControl websiteAdminsControl)
        {

            if (id != websiteAdminsControl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(websiteAdminsControl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebsiteAdminsControlExists(websiteAdminsControl.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(websiteAdminsControl);
        }

        // GET: AdministratorArea/WebsiteAdminsControls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.WebsiteAdminsControls == null)
            {
                return NotFound();
            }

            var websiteAdminsControl = await _context.WebsiteAdminsControls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (websiteAdminsControl == null)
            {
                return NotFound();
            }

            return View(websiteAdminsControl);
        }

        // POST: AdministratorArea/WebsiteAdminsControls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (_context.WebsiteAdminsControls == null)
            {
                return Problem("Entity set 'ApplicationDbContext.WebsiteAdminsControls'  is null.");
            }
            var websiteAdminsControl = await _context.WebsiteAdminsControls.FindAsync(id);
            if (websiteAdminsControl != null)
            {
                _context.WebsiteAdminsControls.Remove(websiteAdminsControl);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WebsiteAdminsControlExists(int id)
        {
            return _context.WebsiteAdminsControls!.Any(e => e.Id == id);
        }
    }
}
