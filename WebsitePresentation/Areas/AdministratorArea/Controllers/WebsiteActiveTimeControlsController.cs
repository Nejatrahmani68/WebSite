using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;
using Microsoft.AspNetCore.Authorization;
using DataAccess.Services;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Administrator")]
    public class WebsiteActiveTimeControlsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;

        public WebsiteActiveTimeControlsController(ApplicationDbContext context, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: AdministratorArea/WebsiteActiveTimeControls
        public async Task<IActionResult> Index()
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            return View(await _context.WebsiteActiveTimeControls!.ToListAsync());
        }

        // GET: AdministratorArea/WebsiteActiveTimeControls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.WebsiteActiveTimeControls == null)
            {
                return NotFound();
            }

            var websiteActiveTimeControl = await _context.WebsiteActiveTimeControls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (websiteActiveTimeControl == null)
            {
                return NotFound();
            }

            return View(websiteActiveTimeControl);
        }

        // GET: AdministratorArea/WebsiteActiveTimeControls/Create
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

        // POST: AdministratorArea/WebsiteActiveTimeControls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WebsiteTitle,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] WebsiteActiveTimeControl websiteActiveTimeControl)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                _context.Add(websiteActiveTimeControl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(websiteActiveTimeControl);
        }

        // GET: AdministratorArea/WebsiteActiveTimeControls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.WebsiteActiveTimeControls == null)
            {
                return NotFound();
            }

            var websiteActiveTimeControl = await _context.WebsiteActiveTimeControls.FindAsync(id);
            if (websiteActiveTimeControl == null)
            {
                return NotFound();
            }
            return View(websiteActiveTimeControl);
        }

        // POST: AdministratorArea/WebsiteActiveTimeControls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WebsiteTitle,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] WebsiteActiveTimeControl websiteActiveTimeControl)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != websiteActiveTimeControl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(websiteActiveTimeControl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebsiteActiveTimeControlExists(websiteActiveTimeControl.Id))
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
            return View(websiteActiveTimeControl);
        }

        // GET: AdministratorArea/WebsiteActiveTimeControls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime
            
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.WebsiteActiveTimeControls == null)
            {
                return NotFound();
            }

            var websiteActiveTimeControl = await _context.WebsiteActiveTimeControls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (websiteActiveTimeControl == null)
            {
                return NotFound();
            }

            return View(websiteActiveTimeControl);
        }

        // POST: AdministratorArea/WebsiteActiveTimeControls/Delete/5
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
            if (_context.WebsiteActiveTimeControls == null)
            {
                return Problem("Entity set 'ApplicationDbContext.WebsiteActiveTimeControls'  is null.");
            }
            var websiteActiveTimeControl = await _context.WebsiteActiveTimeControls.FindAsync(id);
            if (websiteActiveTimeControl != null)
            {
                _context.WebsiteActiveTimeControls.Remove(websiteActiveTimeControl);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WebsiteActiveTimeControlExists(int id)
        {
          return _context.WebsiteActiveTimeControls!.Any(e => e.Id == id);
        }
    }
}
