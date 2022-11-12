using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;
using Microsoft.AspNetCore.Authorization;
using DataAccess.Services;

namespace WebsitePresentation.Areas.AdministratorArea.Controllers
{
    [Area("AdministratorArea")]
    [Authorize(Roles = "Administrator")]
    public class WebsiteThemControlsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WebsiteThemControlsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdministratorArea/WebsiteThemControls
        public async Task<IActionResult> Index()
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            return View(await _context.WebsiteThemControls.ToListAsync());
        }

        // GET: AdministratorArea/WebsiteThemControls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.WebsiteThemControls == null)
            {
                return NotFound();
            }

            var websiteThemControl = await _context.WebsiteThemControls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (websiteThemControl == null)
            {
                return NotFound();
            }

            return View(websiteThemControl);
        }

        // GET: AdministratorArea/WebsiteThemControls/Create
        public IActionResult Create()
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            return View();
        }

        // POST: AdministratorArea/WebsiteThemControls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SectionName,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] WebsiteThemControl websiteThemControl)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                _context.Add(websiteThemControl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(websiteThemControl);
        }

        // GET: AdministratorArea/WebsiteThemControls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.WebsiteThemControls == null)
            {
                return NotFound();
            }

            var websiteThemControl = await _context.WebsiteThemControls.FindAsync(id);
            if (websiteThemControl == null)
            {
                return NotFound();
            }
            return View(websiteThemControl);
        }

        // POST: AdministratorArea/WebsiteThemControls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SectionName,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] WebsiteThemControl websiteThemControl)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != websiteThemControl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(websiteThemControl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WebsiteThemControlExists(websiteThemControl.Id))
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
            return View(websiteThemControl);
        }

        // GET: AdministratorArea/WebsiteThemControls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.WebsiteThemControls == null)
            {
                return NotFound();
            }

            var websiteThemControl = await _context.WebsiteThemControls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (websiteThemControl == null)
            {
                return NotFound();
            }

            return View(websiteThemControl);
        }

        // POST: AdministratorArea/WebsiteThemControls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //Check Admin WorkTime
            ServiceAdminControl _serviceAdminControl = new ServiceAdminControl(_context);
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (_context.WebsiteThemControls == null)
            {
                return Problem("Entity set 'ApplicationDbContext.WebsiteThemControls'  is null.");
            }
            var websiteThemControl = await _context.WebsiteThemControls.FindAsync(id);
            if (websiteThemControl != null)
            {
                _context.WebsiteThemControls.Remove(websiteThemControl);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WebsiteThemControlExists(int id)
        {
          return _context.WebsiteThemControls.Any(e => e.Id == id);
        }
    }
}
