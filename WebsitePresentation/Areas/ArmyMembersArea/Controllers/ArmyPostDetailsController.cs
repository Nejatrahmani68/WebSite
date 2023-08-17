using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using Model;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;
using DataAccess.Services;
using Telegram.Bot;

namespace WebsitePresentation.Areas.ArmyMembersArea.Controllers
{
    [Area("ArmyMembersArea")]
    [Authorize(Roles = "Administrator,ArmyAdmin,ArmyAdminBotControl")]
    public class ArmyPostDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ServiceAdminControl _serviceAdminControl;
        private readonly ServiceTelegramBotControl  _botTelegramControl;
        public ArmyPostDetailsController(ApplicationDbContext context, ServiceAdminControl serviceAdminControl,ServiceTelegramBotControl telegramBotControl)
        {
            _context = context;
            _serviceAdminControl = serviceAdminControl;
            _botTelegramControl= telegramBotControl;
        }

        // GET: ArmyMembersArea/ArmyPostDetails
        public async Task<IActionResult> Index(int? page)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int PageSize = 50;
            IEnumerable<ArmyPostDetails> armyPostDetails = await _context.ArmyPostDetails!.OrderByDescending(m => m.CreateDate).ToListAsync();
            return _context.ArmyPostDetails != null ?
                          View(armyPostDetails.ToPagedList(pageNumber, PageSize)) :
                          Problem("Entity set 'ApplicationDbContext.ArmyMembers'  is null.");

        }

        // GET: ArmyMembersArea/ArmyPostDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.ArmyPostDetails == null)
            {
                return NotFound();
            }

            var armyPostDetails = await _context.ArmyPostDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (armyPostDetails == null)
            {
                return NotFound();
            }

            return View(armyPostDetails);
        }

        // GET: ArmyMembersArea/ArmyPostDetails/Create
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

        // POST: ArmyMembersArea/ArmyPostDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Add,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Link,Like,ShareAsPost,ShareAsStory,Twit,Save,CommentPssitive,CommentNegetive,Block,Report,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] ArmyPostDetails armyPostDetails)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (ModelState.IsValid)
            {
                armyPostDetails.Email = User.Identity!.Name;
                _context.Add(armyPostDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(armyPostDetails);
        }

        // GET: ArmyMembersArea/ArmyPostDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.ArmyPostDetails == null)
            {
                return NotFound();
            }

            var armyPostDetails = await _context.ArmyPostDetails.FindAsync(id);
            if (armyPostDetails == null)
            {
                return NotFound();
            }
            return View(armyPostDetails);
        }

        // POST: ArmyMembersArea/ArmyPostDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Edit,Administrator,FullWriter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Link,Like,ShareAsPost,ShareAsStory,Twit,Save,CommentPssitive,CommentNegetive,Block,Report,Id,Active,Timable,StartDate,EndDate,CreateDate,Email,TagsName")] ArmyPostDetails armyPostDetails)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id != armyPostDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(armyPostDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArmyPostDetailsExists(armyPostDetails.Id))
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
            return View(armyPostDetails);
        }

        // GET: ArmyMembersArea/ArmyPostDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (id == null || _context.ArmyPostDetails == null)
            {
                return NotFound();
            }

            var armyPostDetails = await _context.ArmyPostDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (armyPostDetails == null)
            {
                return NotFound();
            }

            return View(armyPostDetails);
        }

        // POST: ArmyMembersArea/ArmyPostDetails/Delete/5
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
            if (_context.ArmyPostDetails == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ArmyPostDetails'  is null.");
            }
            var armyPostDetails = await _context.ArmyPostDetails.FindAsync(id);
            if (armyPostDetails != null)
            {
                _context.ArmyPostDetails.Remove(armyPostDetails);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArmyPostDetailsExists(int id)
        {
            return (_context.ArmyPostDetails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        public IActionResult SendMessage(int armyPostId)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            _botTelegramControl.SendBotMessage(armyPostId);
            return RedirectToAction("DetailsForConfirm", new { @armyPostId = armyPostId});
        }

        public IActionResult SendMessageEmail(int armyPostId)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            _botTelegramControl.SendMail(armyPostId);
            return RedirectToAction("DetailsForConfirm", new { @armyPostId = armyPostId });
        }
        // GET: ArmyMembersArea/ArmyPostDetails/DetailsForConfirm/5
        public async Task<IActionResult> DetailsForConfirm(int? armyPostId)
        {
            //Check Admin WorkTime
            if (!_serviceAdminControl.CheckAdmin(User.Identity!.Name!))
            {
                ViewData["ErrorReportMessage"] = "بەکارهێنەری بەرێز ئاکانتەکەتان ڕاگیراوە یا کاتی بەسەر چووە تکایە پەیوەندی بە بەرپرسانەوە بگرە.";
                return View("ErrorReportView");
            }
            if (armyPostId == null || _context.ArmyPostDetails == null)
            {
                return NotFound();
            }

            var armyPostDetails = await _context.ArmyPostDetails
                .FirstOrDefaultAsync(m => m.Id == armyPostId);
            if (armyPostDetails == null)
            {
                return NotFound();
            }

            return View(armyPostDetails);
        }

    }
}
