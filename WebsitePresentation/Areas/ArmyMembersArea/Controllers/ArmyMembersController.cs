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
using X.PagedList;
using System.Collections.Immutable;

namespace WebsitePresentation.Areas.ArmyMembersArea.Controllers
{
    [Area("ArmyMembersArea")]
    [Authorize(Roles = "ArmyAdmin")]
    public class ArmyMembersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;
        public ArmyMembersController(ApplicationDbContext context, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: ArmyMembersArea/ArmyMembers
        public async Task<IActionResult> Index(int? page)
        {
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int PageSize = 50;
           IEnumerable<ArmyMembers> armyMembers = await _context.ArmyMembers!.OrderByDescending(m=>m.CreateDate).ToListAsync();
            return _context.ArmyMembers != null ? 
                          View( armyMembers.ToPagedList(pageNumber, PageSize)) :
                          Problem("Entity set 'ApplicationDbContext.ArmyMembers'  is null.");
        }

        // GET: ArmyMembersArea/ArmyMembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.ArmyMembers == null)
            {
                return NotFound();
            }

            var armyMembers = await _context.ArmyMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (armyMembers == null)
            {
                return NotFound();
            }

            return View(armyMembers);
        }

        // GET: ArmyMembersArea/ArmyMembers/Create
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

        // POST: ArmyMembersArea/ArmyMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,MemberEmail,TellNumber,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] ArmyMembers armyMembers)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                armyMembers.Email = User.Identity!.Name;
                _context.Add(armyMembers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(armyMembers);
        }

        // GET: ArmyMembersArea/ArmyMembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.ArmyMembers == null)
            {
                return NotFound();
            }

            var armyMembers = await _context.ArmyMembers.FindAsync(id);
            if (armyMembers == null)
            {
                return NotFound();
            }
            return View(armyMembers);
        }

        // POST: ArmyMembersArea/ArmyMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,MemberEmail,TellNumber,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] ArmyMembers armyMembers)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != armyMembers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(armyMembers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArmyMembersExists(armyMembers.Id))
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
            return View(armyMembers);
        }

        // GET: ArmyMembersArea/ArmyMembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.ArmyMembers == null)
            {
                return NotFound();
            }

            var armyMembers = await _context.ArmyMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (armyMembers == null)
            {
                return NotFound();
            }

            return View(armyMembers);
        }

        // POST: ArmyMembersArea/ArmyMembers/Delete/5
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
            if (_context.ArmyMembers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ArmyMembers'  is null.");
            }
            var armyMembers = await _context.ArmyMembers.FindAsync(id);
            if (armyMembers != null)
            {
                _context.ArmyMembers.Remove(armyMembers);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArmyMembersExists(int id)
        {
          return (_context.ArmyMembers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
