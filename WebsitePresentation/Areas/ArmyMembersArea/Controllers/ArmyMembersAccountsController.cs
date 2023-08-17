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
    [Authorize(Roles = "Administrator,ArmyAdmin,ArmyAdminRegister")]
    public class ArmyMembersAccountsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;
        public ArmyMembersAccountsController(ApplicationDbContext context, ServiceAdminControl serviceAdminControl)
        {
            _context = context;
            _serviceAdminControl = serviceAdminControl;
        }

        // GET: ArmyMembersArea/ArmyMembersAccounts
        public async Task<IActionResult> Index(int? idTemp)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                var applicationDbContext = _context.ArmyMembersAccounts!.Where(m => m.Id_ArmyMembers == idTemp).OrderByDescending(m => m.CreateDate).Include(a => a.ArmyMembers).Include(a => a.ArmySocialsName);
                var ParentDetail = _context.ArmyMembers!.Find(idTemp);
                ViewBag.ParentDetail = ParentDetail!.Id + "-" + ParentDetail!.Name;
                return View(await applicationDbContext.ToListAsync());
            }
            return RedirectToAction("Index", "ArmyMembers");
        }

        // GET: ArmyMembersArea/ArmyMembersAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.ArmyMembersAccounts == null)
            {
                return NotFound();
            }

            var armyMembersAccount = await _context.ArmyMembersAccounts
                .Include(a => a.ArmyMembers)
                .Include(a => a.ArmySocialsName)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (armyMembersAccount == null)
            {
                return NotFound();
            }

            return View(armyMembersAccount);
        }

        // GET: ArmyMembersArea/ArmyMembersAccounts/Create
        public IActionResult Create(int? idTemp)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            ViewBag.idTemp = idTemp;
            if (idTemp != null)
            {
                ViewData["Id_ArmySocialsName"] = new SelectList(_context.ArmySocialsNames, "Id", "Title");
                ViewData["Id_ArmyMembers"] = new SelectList(_context.ArmyMembers!.Where(m => m.Id == idTemp), "Id", "Name");
                return View();
            }
            return RedirectToAction("Index", "ArmyMembers");
        }

        // POST: ArmyMembersArea/ArmyMembersAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_ArmySocialsName,SocialAddress,Id_ArmyMembers,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] ArmyMembersAccount armyMembersAccount)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                ArmySocialsName? SocialNameChecking = _context.ArmySocialsNames!.Find(armyMembersAccount.Id_ArmySocialsName);
                if (SocialNameChecking!=null && (SocialNameChecking.Title=="Telegram"|| SocialNameChecking.Title == "TELEGRAM"|| SocialNameChecking.Title == "telegram"))
                {
                    int socialCheck = 0;
                    if (!int.TryParse( armyMembersAccount.SocialAddress,out socialCheck))
                    {
                        ModelState.AddModelError("SocialAddress", "ئادرەسەکە تەنیا دەتونیت ژمارە بەکار بێنی");
                        ViewData["Id_ArmyMembers"] = new SelectList(_context.ArmyMembers, "Id", "Name", armyMembersAccount.Id_ArmyMembers);
                        ViewData["Id_ArmySocialsName"] = new SelectList(_context.ArmySocialsNames, "Id", "Title", armyMembersAccount.Id_ArmySocialsName);
                        ViewBag.idTemp = armyMembersAccount.Id_ArmyMembers;
                        return View(armyMembersAccount);
                    }
                }
                armyMembersAccount.Email = User.Identity!.Name;
                _context.Add(armyMembersAccount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { @idTemp = armyMembersAccount.Id_ArmyMembers });
            }
            ViewData["Id_ArmyMembers"] = new SelectList(_context.ArmyMembers, "Id", "Name", armyMembersAccount.Id_ArmyMembers);
            ViewData["Id_ArmySocialsName"] = new SelectList(_context.ArmySocialsNames, "Id", "Title", armyMembersAccount.Id_ArmySocialsName);
            ViewBag.idTemp = armyMembersAccount.Id_ArmyMembers;
            return View(armyMembersAccount);
        }

        // GET: ArmyMembersArea/ArmyMembersAccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.ArmyMembersAccounts == null)
            {
                return NotFound();
            }

            var armyMembersAccount = await _context.ArmyMembersAccounts.FindAsync(id);
            if (armyMembersAccount == null)
            {
                return NotFound();
            }
            ViewData["Id_ArmyMembers"] = new SelectList(_context.ArmyMembers, "Id", "Name", armyMembersAccount.Id_ArmyMembers);
            ViewData["Id_ArmySocialsName"] = new SelectList(_context.ArmySocialsNames, "Id", "Title", armyMembersAccount.Id_ArmySocialsName);
            return View(armyMembersAccount);
        }

        // POST: ArmyMembersArea/ArmyMembersAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_ArmySocialsName,SocialAddress,Id_ArmyMembers,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] ArmyMembersAccount armyMembersAccount)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != armyMembersAccount.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(armyMembersAccount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArmyMembersAccountExists(armyMembersAccount.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { @idTemp = armyMembersAccount.Id_ArmyMembers });
            }
            ViewData["Id_ArmyMembers"] = new SelectList(_context.ArmyMembers, "Id", "Name", armyMembersAccount.Id_ArmyMembers);
            ViewData["Id_ArmySocialsName"] = new SelectList(_context.ArmySocialsNames, "Id", "Title", armyMembersAccount.Id_ArmySocialsName);
            return View(armyMembersAccount);
        }

        // GET: ArmyMembersArea/ArmyMembersAccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime

            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.ArmyMembersAccounts == null)
            {
                return NotFound();
            }

            var armyMembersAccount = await _context.ArmyMembersAccounts
                .Include(a => a.ArmyMembers)
                .Include(a => a.ArmySocialsName)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (armyMembersAccount == null)
            {
                return NotFound();
            }

            return View(armyMembersAccount);
        }

        // POST: ArmyMembersArea/ArmyMembersAccounts/Delete/5
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
            if (_context.ArmyMembersAccounts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.armyMembersAccounts'  is null.");
            }
            var armyMembersAccount = await _context.ArmyMembersAccounts.FindAsync(id);

            if (armyMembersAccount != null)
            {
                _context.ArmyMembersAccounts.Remove(armyMembersAccount);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { @idTemp = armyMembersAccount!.Id_ArmyMembers });
        }

        private bool ArmyMembersAccountExists(int id)
        {
          return (_context.ArmyMembersAccounts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
