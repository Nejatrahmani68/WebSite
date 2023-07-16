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

namespace WebsitePresentation.Areas.ArmyMembersArea.Controllers
{
    [Area("ArmyMembersArea")]
    [Authorize(Roles = "ArmyAdmin")]
    public class ArmySocialsNamesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;
        public ArmySocialsNamesController(ApplicationDbContext context, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: ArmyMembersArea/ArmySocialsNames
        public async Task<IActionResult> Index()
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            return _context.armySocialsNames != null ? 
                          View(await _context.armySocialsNames.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.armySocialsNames'  is null.");
        }

        // GET: ArmyMembersArea/ArmySocialsNames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.armySocialsNames == null)
            {
                return NotFound();
            }

            var armySocialsName = await _context.armySocialsNames
                .FirstOrDefaultAsync(m => m.Id == id);
            if (armySocialsName == null)
            {
                return NotFound();
            }

            return View(armySocialsName);
        }

        // GET: ArmyMembersArea/ArmySocialsNames/Create
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

        // POST: ArmyMembersArea/ArmySocialsNames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Desciption,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] ArmySocialsName armySocialsName)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                _context.Add(armySocialsName);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(armySocialsName);
        }

        // GET: ArmyMembersArea/ArmySocialsNames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.armySocialsNames == null)
            {
                return NotFound();
            }

            var armySocialsName = await _context.armySocialsNames.FindAsync(id);
            if (armySocialsName == null)
            {
                return NotFound();
            }
            return View(armySocialsName);
        }

        // POST: ArmyMembersArea/ArmySocialsNames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,Desciption,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] ArmySocialsName armySocialsName)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != armySocialsName.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(armySocialsName);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArmySocialsNameExists(armySocialsName.Id))
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
            return View(armySocialsName);
        }

        // GET: ArmyMembersArea/ArmySocialsNames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.armySocialsNames == null)
            {
                return NotFound();
            }

            var armySocialsName = await _context.armySocialsNames
                .FirstOrDefaultAsync(m => m.Id == id);
            if (armySocialsName == null)
            {
                return NotFound();
            }

            return View(armySocialsName);
        }

        // POST: ArmyMembersArea/ArmySocialsNames/Delete/5
        [Authorize(Roles = "Delete,Administrator,FullWriter")]
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
            if (_context.armySocialsNames == null)
            {
                return Problem("Entity set 'ApplicationDbContext.armySocialsNames'  is null.");
            }
            var armySocialsName = await _context.armySocialsNames.FindAsync(id);
            if (armySocialsName != null)
            {
                _context.armySocialsNames.Remove(armySocialsName);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArmySocialsNameExists(int id)
        {
          return (_context.armySocialsNames?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
